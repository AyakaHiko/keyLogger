using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using reporter;

namespace keyLogger
{
    public class AppControl
    {
        private List<string> _bannedApps { get; }
        public ReadOnlyCollection<string> BannedApps;
        public void AddBannedApp(string newApp)
        {
            if (!string.IsNullOrEmpty(newApp) && !_bannedApps.Contains(newApp))
                _bannedApps.Add(newApp);
        }

        public void RemoveBannedApp(string app)
        {
            _bannedApps.Remove(app);
        }

        private Process[] _processes;

        private bool _isRun = false;
        public void Start()
        {
            _isRun = true;
            Task.Factory.StartNew(_log);
        }



        public event Action<List<Process>> NewProcesses;
        public event Action<Process> ProcessBanned;
        private void _log()
        {
            while (_isRun)
            {
                Thread.Sleep(1000);
                _monitorProcess();
            }
        }

        class ProcessComparer : IEqualityComparer<Process>
        {
            public bool Equals(Process x, Process y)
            {
                if (ReferenceEquals(x, y)) return true;
                if (ReferenceEquals(x, null)) return false;
                if (ReferenceEquals(y, null)) return false;
                if (x.GetType() != y.GetType()) return false;
                return x.Id == y.Id && x.ProcessName == y.ProcessName;
            }

            public int GetHashCode(Process obj)
            {
                unchecked
                {
                    return (obj.Id * 397) ^ obj.ProcessName.GetHashCode();
                }
            }
        }
        private IEnumerable<Process> _monitorProcess()
        {
            var current = Process.GetProcesses();
            IEnumerable<Process> newProcesses = null;
            try
            {
                newProcesses = current.Except(_processes, new ProcessComparer());
                if (newProcesses.Any())
                    NewProcesses?.Invoke(newProcesses.ToList());
            }
            catch (Exception)
            {
                //ignored
            }
            finally
            {
                _processes = current;
            }
            return newProcesses;
        }
        private void _lockApps(IEnumerable<Process> source)
        {
            var ban = source.Join(_bannedApps,
                process =>
                {
                    try
                    {
                        return process.ProcessName;
                    }
                    catch (Exception)
                    {
                        return "";
                    }
                },
                Path.GetFileNameWithoutExtension, (process, s) => process);
            foreach (var process in ban)
            {
                process.Kill();
                ProcessBanned?.Invoke(process);
            }
        }

        public void Stop()
        {
            _isRun = false;
        }
        private AppControl()
        {
            _processes = new Process[1];
            _bannedApps = new List<string>();
            BannedApps = new ReadOnlyCollection<string>(_bannedApps);
            NewProcesses += _lockApps;
            ProcessBanned+=(process)=>
                _bannedReport.Report($"Process {process.ProcessName} was killed at {DateTime.Now.ToShortTimeString()}");
        }
        private ListReporter _bannedReport = new ListReporter();
        public ReadOnlyCollection<string> Reports => _bannedReport.Reports;
        public void Report(IReport reporter)
        {
            foreach (var report in _bannedReport.Reports)
            {
                reporter.Report(report);
            }

            _bannedReport = new ListReporter();
        }
        private static AppControl _instance;

        public static AppControl Instance => _instance ??= new AppControl();

    }
}
