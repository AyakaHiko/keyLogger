namespace keyLogger
{
    partial class keyLogApp
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(keyLogApp));
            this.mainTabs = new System.Windows.Forms.TabControl();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.mainSetupPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.banAppsCheck = new System.Windows.Forms.CheckBox();
            this.logKeysCheck = new System.Windows.Forms.CheckBox();
            this.logWordsCheck = new System.Windows.Forms.CheckBox();
            this.bannedAppPanel = new System.Windows.Forms.GroupBox();
            this.banAppBox = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addBanAppBtn = new System.Windows.Forms.Button();
            this.delBanAppBtn = new System.Windows.Forms.Button();
            this.logWordsPanel = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logWordTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.addWordBtn = new System.Windows.Forms.Button();
            this.updWordBtn = new System.Windows.Forms.Button();
            this.delWordBtn = new System.Windows.Forms.Button();
            this.logWordsBox = new System.Windows.Forms.ListBox();
            this.stopBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.stateLbl = new System.Windows.Forms.Label();
            this.reportTab = new System.Windows.Forms.TabPage();
            this.reportToFileCheck = new System.Windows.Forms.CheckBox();
            this.fileReportPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.manualReportBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.reportIntervalBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.reportPathBox = new System.Windows.Forms.TextBox();
            this.changeRepPath = new System.Windows.Forms.Button();
            this.openRepDirBtn = new System.Windows.Forms.Button();
            this.appMonitoringPanel = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bannedReportBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.processReportBox = new System.Windows.Forms.ListBox();
            this.mainReportBox = new System.Windows.Forms.ListBox();
            this.tip = new System.Windows.Forms.ToolTip(this.components);
            this.reportTimer = new System.Windows.Forms.Timer(this.components);
            this.wordReportBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mainTabs.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.mainSetupPanel.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.bannedAppPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.logWordsPanel.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.reportTab.SuspendLayout();
            this.fileReportPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.appMonitoringPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabs
            // 
            this.mainTabs.Controls.Add(this.settingsTab);
            this.mainTabs.Controls.Add(this.reportTab);
            this.mainTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabs.Location = new System.Drawing.Point(0, 0);
            this.mainTabs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(712, 567);
            this.mainTabs.TabIndex = 0;
            this.mainTabs.SelectedIndexChanged += new System.EventHandler(this.mainTabs_SelectedIndexChanged);
            // 
            // settingsTab
            // 
            this.settingsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.settingsTab.Controls.Add(this.mainSetupPanel);
            this.settingsTab.Controls.Add(this.stopBtn);
            this.settingsTab.Controls.Add(this.startBtn);
            this.settingsTab.Controls.Add(this.stateLbl);
            this.settingsTab.Location = new System.Drawing.Point(4, 25);
            this.settingsTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsTab.Size = new System.Drawing.Size(704, 538);
            this.settingsTab.TabIndex = 0;
            this.settingsTab.Text = "Setup";
            // 
            // mainSetupPanel
            // 
            this.mainSetupPanel.Controls.Add(this.flowLayoutPanel3);
            this.mainSetupPanel.Controls.Add(this.bannedAppPanel);
            this.mainSetupPanel.Controls.Add(this.logWordsPanel);
            this.mainSetupPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainSetupPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.mainSetupPanel.Location = new System.Drawing.Point(3, 2);
            this.mainSetupPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainSetupPanel.Name = "mainSetupPanel";
            this.mainSetupPanel.Size = new System.Drawing.Size(698, 462);
            this.mainSetupPanel.TabIndex = 6;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.banAppsCheck);
            this.flowLayoutPanel3.Controls.Add(this.logKeysCheck);
            this.flowLayoutPanel3.Controls.Add(this.logWordsCheck);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 2);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(276, 24);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // banAppsCheck
            // 
            this.banAppsCheck.AutoSize = true;
            this.banAppsCheck.Location = new System.Drawing.Point(3, 2);
            this.banAppsCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.banAppsCheck.Name = "banAppsCheck";
            this.banAppsCheck.Size = new System.Drawing.Size(85, 20);
            this.banAppsCheck.TabIndex = 4;
            this.banAppsCheck.Text = "Ban Apps";
            this.banAppsCheck.UseVisualStyleBackColor = true;
            this.banAppsCheck.CheckedChanged += new System.EventHandler(this.banAppsCheck_CheckedChanged);
            // 
            // logKeysCheck
            // 
            this.logKeysCheck.AutoSize = true;
            this.logKeysCheck.Location = new System.Drawing.Point(94, 2);
            this.logKeysCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logKeysCheck.Name = "logKeysCheck";
            this.logKeysCheck.Size = new System.Drawing.Size(81, 20);
            this.logKeysCheck.TabIndex = 0;
            this.logKeysCheck.Text = "Log keys";
            this.logKeysCheck.UseVisualStyleBackColor = true;
            this.logKeysCheck.CheckedChanged += new System.EventHandler(this.logKeysCheck_CheckedChanged);
            // 
            // logWordsCheck
            // 
            this.logWordsCheck.AutoSize = true;
            this.logWordsCheck.Enabled = false;
            this.logWordsCheck.Location = new System.Drawing.Point(181, 2);
            this.logWordsCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logWordsCheck.Name = "logWordsCheck";
            this.logWordsCheck.Size = new System.Drawing.Size(92, 20);
            this.logWordsCheck.TabIndex = 5;
            this.logWordsCheck.Text = "Log Words";
            this.logWordsCheck.UseVisualStyleBackColor = true;
            this.logWordsCheck.CheckedChanged += new System.EventHandler(this.logWordsCheck_CheckedChanged);
            // 
            // bannedAppPanel
            // 
            this.bannedAppPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bannedAppPanel.Controls.Add(this.banAppBox);
            this.bannedAppPanel.Controls.Add(this.flowLayoutPanel1);
            this.bannedAppPanel.ForeColor = System.Drawing.Color.AliceBlue;
            this.bannedAppPanel.Location = new System.Drawing.Point(3, 30);
            this.bannedAppPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bannedAppPanel.Name = "bannedAppPanel";
            this.bannedAppPanel.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bannedAppPanel.Size = new System.Drawing.Size(687, 166);
            this.bannedAppPanel.TabIndex = 3;
            this.bannedAppPanel.TabStop = false;
            this.bannedAppPanel.Text = "banned Apps";
            this.bannedAppPanel.Visible = false;
            // 
            // banAppBox
            // 
            this.banAppBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.banAppBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.banAppBox.ForeColor = System.Drawing.Color.White;
            this.banAppBox.FormattingEnabled = true;
            this.banAppBox.ItemHeight = 16;
            this.banAppBox.Location = new System.Drawing.Point(3, 17);
            this.banAppBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.banAppBox.Name = "banAppBox";
            this.banAppBox.Size = new System.Drawing.Size(681, 84);
            this.banAppBox.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel1.Controls.Add(this.addBanAppBtn);
            this.flowLayoutPanel1.Controls.Add(this.delBanAppBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 109);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(681, 55);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // addBanAppBtn
            // 
            this.addBanAppBtn.BackColor = System.Drawing.Color.DimGray;
            this.addBanAppBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBanAppBtn.Location = new System.Drawing.Point(3, 2);
            this.addBanAppBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBanAppBtn.Name = "addBanAppBtn";
            this.addBanAppBtn.Size = new System.Drawing.Size(95, 49);
            this.addBanAppBtn.TabIndex = 0;
            this.addBanAppBtn.Text = "Add";
            this.addBanAppBtn.UseVisualStyleBackColor = false;
            this.addBanAppBtn.Click += new System.EventHandler(this.addBanAppBtn_Click);
            // 
            // delBanAppBtn
            // 
            this.delBanAppBtn.BackColor = System.Drawing.Color.DimGray;
            this.delBanAppBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delBanAppBtn.Location = new System.Drawing.Point(104, 2);
            this.delBanAppBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delBanAppBtn.Name = "delBanAppBtn";
            this.delBanAppBtn.Size = new System.Drawing.Size(95, 49);
            this.delBanAppBtn.TabIndex = 1;
            this.delBanAppBtn.Text = "Del";
            this.delBanAppBtn.UseVisualStyleBackColor = false;
            this.delBanAppBtn.Click += new System.EventHandler(this.delBanAppBtn_Click);
            // 
            // logWordsPanel
            // 
            this.logWordsPanel.Controls.Add(this.label1);
            this.logWordsPanel.Controls.Add(this.logWordTextBox);
            this.logWordsPanel.Controls.Add(this.flowLayoutPanel2);
            this.logWordsPanel.Controls.Add(this.logWordsBox);
            this.logWordsPanel.ForeColor = System.Drawing.Color.AliceBlue;
            this.logWordsPanel.Location = new System.Drawing.Point(3, 200);
            this.logWordsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logWordsPanel.Name = "logWordsPanel";
            this.logWordsPanel.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logWordsPanel.Size = new System.Drawing.Size(687, 218);
            this.logWordsPanel.TabIndex = 4;
            this.logWordsPanel.TabStop = false;
            this.logWordsPanel.Text = "Logging Words";
            this.logWordsPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Word:";
            // 
            // logWordTextBox
            // 
            this.logWordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.logWordTextBox.ForeColor = System.Drawing.Color.White;
            this.logWordTextBox.Location = new System.Drawing.Point(3, 132);
            this.logWordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logWordTextBox.Name = "logWordTextBox";
            this.logWordTextBox.Size = new System.Drawing.Size(559, 22);
            this.logWordTextBox.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel2.Controls.Add(this.addWordBtn);
            this.flowLayoutPanel2.Controls.Add(this.updWordBtn);
            this.flowLayoutPanel2.Controls.Add(this.delWordBtn);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 161);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(681, 55);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // addWordBtn
            // 
            this.addWordBtn.BackColor = System.Drawing.Color.DimGray;
            this.addWordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addWordBtn.Location = new System.Drawing.Point(3, 2);
            this.addWordBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addWordBtn.Name = "addWordBtn";
            this.addWordBtn.Size = new System.Drawing.Size(95, 49);
            this.addWordBtn.TabIndex = 0;
            this.addWordBtn.Text = "Add";
            this.addWordBtn.UseVisualStyleBackColor = false;
            this.addWordBtn.Click += new System.EventHandler(this.addWordBtn_Click);
            // 
            // updWordBtn
            // 
            this.updWordBtn.BackColor = System.Drawing.Color.DimGray;
            this.updWordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updWordBtn.Location = new System.Drawing.Point(104, 2);
            this.updWordBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updWordBtn.Name = "updWordBtn";
            this.updWordBtn.Size = new System.Drawing.Size(95, 49);
            this.updWordBtn.TabIndex = 2;
            this.updWordBtn.Text = "Upd";
            this.updWordBtn.UseVisualStyleBackColor = false;
            this.updWordBtn.Click += new System.EventHandler(this.updWordBtn_Click);
            // 
            // delWordBtn
            // 
            this.delWordBtn.BackColor = System.Drawing.Color.DimGray;
            this.delWordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delWordBtn.Location = new System.Drawing.Point(205, 2);
            this.delWordBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delWordBtn.Name = "delWordBtn";
            this.delWordBtn.Size = new System.Drawing.Size(95, 49);
            this.delWordBtn.TabIndex = 1;
            this.delWordBtn.Text = "Del";
            this.delWordBtn.UseVisualStyleBackColor = false;
            this.delWordBtn.Click += new System.EventHandler(this.delWordBtn_Click);
            // 
            // logWordsBox
            // 
            this.logWordsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.logWordsBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.logWordsBox.ForeColor = System.Drawing.Color.White;
            this.logWordsBox.FormattingEnabled = true;
            this.logWordsBox.ItemHeight = 16;
            this.logWordsBox.Location = new System.Drawing.Point(3, 17);
            this.logWordsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logWordsBox.Name = "logWordsBox";
            this.logWordsBox.Size = new System.Drawing.Size(681, 68);
            this.logWordsBox.TabIndex = 1;
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.DimGray;
            this.stopBtn.Enabled = false;
            this.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopBtn.Location = new System.Drawing.Point(113, 468);
            this.stopBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(95, 50);
            this.stopBtn.TabIndex = 5;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.DimGray;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Location = new System.Drawing.Point(12, 468);
            this.startBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(95, 50);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stateLbl
            // 
            this.stateLbl.AutoSize = true;
            this.stateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateLbl.Location = new System.Drawing.Point(235, 479);
            this.stateLbl.Name = "stateLbl";
            this.stateLbl.Size = new System.Drawing.Size(0, 31);
            this.stateLbl.TabIndex = 5;
            // 
            // reportTab
            // 
            this.reportTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.reportTab.Controls.Add(this.label8);
            this.reportTab.Controls.Add(this.label7);
            this.reportTab.Controls.Add(this.wordReportBox);
            this.reportTab.Controls.Add(this.reportToFileCheck);
            this.reportTab.Controls.Add(this.fileReportPanel);
            this.reportTab.Controls.Add(this.appMonitoringPanel);
            this.reportTab.Controls.Add(this.mainReportBox);
            this.reportTab.Location = new System.Drawing.Point(4, 25);
            this.reportTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportTab.Name = "reportTab";
            this.reportTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportTab.Size = new System.Drawing.Size(704, 538);
            this.reportTab.TabIndex = 1;
            this.reportTab.Text = "Report";
            // 
            // reportToFileCheck
            // 
            this.reportToFileCheck.AutoSize = true;
            this.reportToFileCheck.Checked = true;
            this.reportToFileCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.reportToFileCheck.Location = new System.Drawing.Point(6, 5);
            this.reportToFileCheck.Name = "reportToFileCheck";
            this.reportToFileCheck.Size = new System.Drawing.Size(101, 20);
            this.reportToFileCheck.TabIndex = 10;
            this.reportToFileCheck.Text = "Report to file";
            this.reportToFileCheck.UseVisualStyleBackColor = true;
            this.reportToFileCheck.CheckedChanged += new System.EventHandler(this.reportToFileCheck_CheckedChanged);
            // 
            // fileReportPanel
            // 
            this.fileReportPanel.Controls.Add(this.label2);
            this.fileReportPanel.Controls.Add(this.panel1);
            this.fileReportPanel.Controls.Add(this.reportPathBox);
            this.fileReportPanel.Controls.Add(this.changeRepPath);
            this.fileReportPanel.Controls.Add(this.openRepDirBtn);
            this.fileReportPanel.Location = new System.Drawing.Point(6, 31);
            this.fileReportPanel.Name = "fileReportPanel";
            this.fileReportPanel.Size = new System.Drawing.Size(687, 100);
            this.fileReportPanel.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Report path";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.manualReportBtn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.reportIntervalBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(9, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 39);
            this.panel1.TabIndex = 9;
            // 
            // manualReportBtn
            // 
            this.manualReportBtn.AutoSize = true;
            this.manualReportBtn.BackColor = System.Drawing.Color.DimGray;
            this.manualReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manualReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manualReportBtn.Location = new System.Drawing.Point(341, 1);
            this.manualReportBtn.Margin = new System.Windows.Forms.Padding(0);
            this.manualReportBtn.Name = "manualReportBtn";
            this.manualReportBtn.Size = new System.Drawing.Size(83, 33);
            this.manualReportBtn.TabIndex = 10;
            this.manualReportBtn.Text = "Report";
            this.manualReportBtn.UseVisualStyleBackColor = false;
            this.manualReportBtn.Click += new System.EventHandler(this.manualReportBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "or by clicking";
            // 
            // reportIntervalBox
            // 
            this.reportIntervalBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.reportIntervalBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reportIntervalBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportIntervalBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.reportIntervalBox.FormattingEnabled = true;
            this.reportIntervalBox.Location = new System.Drawing.Point(101, 7);
            this.reportIntervalBox.Name = "reportIntervalBox";
            this.reportIntervalBox.Size = new System.Drawing.Size(121, 24);
            this.reportIntervalBox.TabIndex = 11;
            this.reportIntervalBox.SelectedIndexChanged += new System.EventHandler(this.reportIntervalBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Report every";
            // 
            // reportPathBox
            // 
            this.reportPathBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.reportPathBox.ForeColor = System.Drawing.Color.White;
            this.reportPathBox.Location = new System.Drawing.Point(90, 8);
            this.reportPathBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportPathBox.Name = "reportPathBox";
            this.reportPathBox.Size = new System.Drawing.Size(384, 22);
            this.reportPathBox.TabIndex = 4;
            // 
            // changeRepPath
            // 
            this.changeRepPath.AutoSize = true;
            this.changeRepPath.BackColor = System.Drawing.Color.DimGray;
            this.changeRepPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeRepPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeRepPath.Location = new System.Drawing.Point(492, 2);
            this.changeRepPath.Margin = new System.Windows.Forms.Padding(0);
            this.changeRepPath.Name = "changeRepPath";
            this.changeRepPath.Size = new System.Drawing.Size(83, 33);
            this.changeRepPath.TabIndex = 6;
            this.changeRepPath.Text = "Change";
            this.changeRepPath.UseVisualStyleBackColor = false;
            this.changeRepPath.Click += new System.EventHandler(this.changeRepPath_Click);
            // 
            // openRepDirBtn
            // 
            this.openRepDirBtn.AutoSize = true;
            this.openRepDirBtn.BackColor = System.Drawing.Color.DimGray;
            this.openRepDirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openRepDirBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openRepDirBtn.Location = new System.Drawing.Point(586, 2);
            this.openRepDirBtn.Margin = new System.Windows.Forms.Padding(0);
            this.openRepDirBtn.Name = "openRepDirBtn";
            this.openRepDirBtn.Size = new System.Drawing.Size(91, 33);
            this.openRepDirBtn.TabIndex = 7;
            this.openRepDirBtn.Text = "Open Dir";
            this.openRepDirBtn.UseVisualStyleBackColor = false;
            this.openRepDirBtn.Click += new System.EventHandler(this.openRepDirBtn_Click);
            // 
            // appMonitoringPanel
            // 
            this.appMonitoringPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.appMonitoringPanel.Controls.Add(this.label4);
            this.appMonitoringPanel.Controls.Add(this.bannedReportBox);
            this.appMonitoringPanel.Controls.Add(this.label3);
            this.appMonitoringPanel.Controls.Add(this.processReportBox);
            this.appMonitoringPanel.ForeColor = System.Drawing.Color.AliceBlue;
            this.appMonitoringPanel.Location = new System.Drawing.Point(6, 136);
            this.appMonitoringPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appMonitoringPanel.Name = "appMonitoringPanel";
            this.appMonitoringPanel.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appMonitoringPanel.Size = new System.Drawing.Size(687, 158);
            this.appMonitoringPanel.TabIndex = 8;
            this.appMonitoringPanel.TabStop = false;
            this.appMonitoringPanel.Text = "App Monitoring";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Banned processes:";
            // 
            // bannedReportBox
            // 
            this.bannedReportBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.bannedReportBox.ForeColor = System.Drawing.Color.White;
            this.bannedReportBox.FormattingEnabled = true;
            this.bannedReportBox.ItemHeight = 16;
            this.bannedReportBox.Location = new System.Drawing.Point(244, 62);
            this.bannedReportBox.Name = "bannedReportBox";
            this.bannedReportBox.Size = new System.Drawing.Size(329, 84);
            this.bannedReportBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "New Processes:";
            // 
            // processReportBox
            // 
            this.processReportBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.processReportBox.ForeColor = System.Drawing.Color.White;
            this.processReportBox.FormattingEnabled = true;
            this.processReportBox.ItemHeight = 16;
            this.processReportBox.Location = new System.Drawing.Point(9, 62);
            this.processReportBox.Name = "processReportBox";
            this.processReportBox.Size = new System.Drawing.Size(182, 84);
            this.processReportBox.TabIndex = 0;
            // 
            // mainReportBox
            // 
            this.mainReportBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.mainReportBox.ForeColor = System.Drawing.Color.White;
            this.mainReportBox.FormattingEnabled = true;
            this.mainReportBox.ItemHeight = 16;
            this.mainReportBox.Location = new System.Drawing.Point(3, 372);
            this.mainReportBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainReportBox.Name = "mainReportBox";
            this.mainReportBox.Size = new System.Drawing.Size(336, 164);
            this.mainReportBox.TabIndex = 1;
            // 
            // reportTimer
            // 
            this.reportTimer.Interval = 300000;
            this.reportTimer.Tick += new System.EventHandler(this.reportTimer_Tick);
            // 
            // wordReportBox
            // 
            this.wordReportBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.wordReportBox.ForeColor = System.Drawing.Color.White;
            this.wordReportBox.FormattingEnabled = true;
            this.wordReportBox.ItemHeight = 16;
            this.wordReportBox.Location = new System.Drawing.Point(356, 372);
            this.wordReportBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wordReportBox.Name = "wordReportBox";
            this.wordReportBox.Size = new System.Drawing.Size(336, 164);
            this.wordReportBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Keys:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(353, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Words:";
            // 
            // keyLogApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(712, 567);
            this.Controls.Add(this.mainTabs);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(728, 606);
            this.MinimumSize = new System.Drawing.Size(728, 606);
            this.Name = "keyLogApp";
            this.Text = "Key Log";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.keyLogApp_FormClosing);
            this.Load += new System.EventHandler(this.keyLogApp_Load);
            this.mainTabs.ResumeLayout(false);
            this.settingsTab.ResumeLayout(false);
            this.settingsTab.PerformLayout();
            this.mainSetupPanel.ResumeLayout(false);
            this.mainSetupPanel.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.bannedAppPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.logWordsPanel.ResumeLayout(false);
            this.logWordsPanel.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.reportTab.ResumeLayout(false);
            this.reportTab.PerformLayout();
            this.fileReportPanel.ResumeLayout(false);
            this.fileReportPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.appMonitoringPanel.ResumeLayout(false);
            this.appMonitoringPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabs;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.TabPage reportTab;
        private System.Windows.Forms.GroupBox bannedAppPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button addBanAppBtn;
        private System.Windows.Forms.Button delBanAppBtn;
        private System.Windows.Forms.ListBox banAppBox;
        private System.Windows.Forms.CheckBox logKeysCheck;
        private System.Windows.Forms.CheckBox banAppsCheck;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.CheckBox logWordsCheck;
        private System.Windows.Forms.GroupBox logWordsPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button addWordBtn;
        private System.Windows.Forms.Button updWordBtn;
        private System.Windows.Forms.Button delWordBtn;
        private System.Windows.Forms.ListBox logWordsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox logWordTextBox;
        private System.Windows.Forms.ToolTip tip;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.ListBox mainReportBox;
        private System.Windows.Forms.Button changeRepPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox reportPathBox;
        private System.Windows.Forms.Button openRepDirBtn;
        private System.Windows.Forms.FlowLayoutPanel mainSetupPanel;
        private System.Windows.Forms.GroupBox appMonitoringPanel;
        private System.Windows.Forms.Label stateLbl;
        private System.Windows.Forms.ListBox processReportBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox bannedReportBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox reportIntervalBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button manualReportBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox reportToFileCheck;
        private System.Windows.Forms.Panel fileReportPanel;
        private System.Windows.Forms.Timer reportTimer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox wordReportBox;
    }
}

