namespace Configurator {
    partial class MainForm {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.GlobalPage = new System.Windows.Forms.TabPage();
            this.GlobalGroupBox = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.UpdateServiceBox = new System.Windows.Forms.TextBox();
            this.AdditionalTimeBox = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.DebuggingBox = new System.Windows.Forms.CheckBox();
            this.TaskIntervalBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ZipCodeBox = new System.Windows.Forms.NumericUpDown();
            this.DBPage = new System.Windows.Forms.TabPage();
            this.DBGroupBox = new System.Windows.Forms.GroupBox();
            this.DBTestConnectionButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DBPasswordBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DBDatabaseBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DBUsernameBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DBDataSourceBox = new System.Windows.Forms.TextBox();
            this.ExternalFtpPage = new System.Windows.Forms.TabPage();
            this.ExternalGroupBox = new System.Windows.Forms.GroupBox();
            this.ExternalPortBox = new System.Windows.Forms.NumericUpDown();
            this.ExternalLoginBox = new System.Windows.Forms.TextBox();
            this.ExternalHostBox = new System.Windows.Forms.TextBox();
            this.ExternalTestConnectionButton = new System.Windows.Forms.Button();
            this.ExternalPortLabel = new System.Windows.Forms.Label();
            this.ExternalCwdLabel = new System.Windows.Forms.Label();
            this.ExternalCwdBox = new System.Windows.Forms.TextBox();
            this.ExternalPasswordLabel = new System.Windows.Forms.Label();
            this.ExternalPasswordBox = new System.Windows.Forms.TextBox();
            this.ExternalLoginLabel = new System.Windows.Forms.Label();
            this.ExternalHostLabel = new System.Windows.Forms.Label();
            this.MailPage = new System.Windows.Forms.TabPage();
            this.ExchangeGroupBox = new System.Windows.Forms.GroupBox();
            this.ExCertBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ExchangeTestButton = new System.Windows.Forms.Button();
            this.ExRecipientBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ExPasswordBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ExUsernameBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ExDomainBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.ExHostBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TasksPage = new System.Windows.Forms.TabPage();
            this.TasksBox = new System.Windows.Forms.GroupBox();
            this.DeleteTaskButton = new System.Windows.Forms.Button();
            this.EditTaskButton = new System.Windows.Forms.Button();
            this.AddTaskButton = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.TasksListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SaveButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.MainOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.LegendGoodBox = new System.Windows.Forms.Panel();
            this.LegendBadBox = new System.Windows.Forms.Panel();
            this.LegendGoodLabel = new System.Windows.Forms.Label();
            this.LegendBadLabel = new System.Windows.Forms.Label();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.InfoStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainTabControl.SuspendLayout();
            this.GlobalPage.SuspendLayout();
            this.GlobalGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdditionalTimeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskIntervalBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZipCodeBox)).BeginInit();
            this.DBPage.SuspendLayout();
            this.DBGroupBox.SuspendLayout();
            this.ExternalFtpPage.SuspendLayout();
            this.ExternalGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExternalPortBox)).BeginInit();
            this.MailPage.SuspendLayout();
            this.ExchangeGroupBox.SuspendLayout();
            this.TasksPage.SuspendLayout();
            this.TasksBox.SuspendLayout();
            this.MainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTabControl.Controls.Add(this.GlobalPage);
            this.MainTabControl.Controls.Add(this.DBPage);
            this.MainTabControl.Controls.Add(this.ExternalFtpPage);
            this.MainTabControl.Controls.Add(this.MailPage);
            this.MainTabControl.Controls.Add(this.TasksPage);
            this.MainTabControl.Location = new System.Drawing.Point(12, 12);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(560, 479);
            this.MainTabControl.TabIndex = 0;
            // 
            // GlobalPage
            // 
            this.GlobalPage.Controls.Add(this.GlobalGroupBox);
            this.GlobalPage.Location = new System.Drawing.Point(4, 25);
            this.GlobalPage.Name = "GlobalPage";
            this.GlobalPage.Padding = new System.Windows.Forms.Padding(3);
            this.GlobalPage.Size = new System.Drawing.Size(552, 450);
            this.GlobalPage.TabIndex = 0;
            this.GlobalPage.Text = "Основные параметры";
            this.GlobalPage.UseVisualStyleBackColor = true;
            // 
            // GlobalGroupBox
            // 
            this.GlobalGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GlobalGroupBox.Controls.Add(this.label11);
            this.GlobalGroupBox.Controls.Add(this.UpdateServiceBox);
            this.GlobalGroupBox.Controls.Add(this.AdditionalTimeBox);
            this.GlobalGroupBox.Controls.Add(this.label10);
            this.GlobalGroupBox.Controls.Add(this.DebuggingBox);
            this.GlobalGroupBox.Controls.Add(this.TaskIntervalBox);
            this.GlobalGroupBox.Controls.Add(this.label1);
            this.GlobalGroupBox.Controls.Add(this.label2);
            this.GlobalGroupBox.Controls.Add(this.ZipCodeBox);
            this.GlobalGroupBox.Location = new System.Drawing.Point(10, 10);
            this.GlobalGroupBox.Name = "GlobalGroupBox";
            this.GlobalGroupBox.Size = new System.Drawing.Size(530, 224);
            this.GlobalGroupBox.TabIndex = 0;
            this.GlobalGroupBox.TabStop = false;
            this.GlobalGroupBox.Text = "Основные";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Имя службы обновлений";
            // 
            // UpdateServiceBox
            // 
            this.UpdateServiceBox.BackColor = System.Drawing.Color.Salmon;
            this.UpdateServiceBox.Location = new System.Drawing.Point(15, 164);
            this.UpdateServiceBox.Name = "UpdateServiceBox";
            this.UpdateServiceBox.Size = new System.Drawing.Size(280, 23);
            this.UpdateServiceBox.TabIndex = 15;
            // 
            // AdditionalTimeBox
            // 
            this.AdditionalTimeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AdditionalTimeBox.BackColor = System.Drawing.Color.LightGreen;
            this.AdditionalTimeBox.Location = new System.Drawing.Point(300, 51);
            this.AdditionalTimeBox.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.AdditionalTimeBox.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.AdditionalTimeBox.Name = "AdditionalTimeBox";
            this.AdditionalTimeBox.Size = new System.Drawing.Size(128, 23);
            this.AdditionalTimeBox.TabIndex = 4;
            this.AdditionalTimeBox.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(297, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(230, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Время на остановку службы (сек)";
            // 
            // DebuggingBox
            // 
            this.DebuggingBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DebuggingBox.AutoSize = true;
            this.DebuggingBox.BackColor = System.Drawing.Color.Salmon;
            this.DebuggingBox.Location = new System.Drawing.Point(300, 109);
            this.DebuggingBox.Name = "DebuggingBox";
            this.DebuggingBox.Size = new System.Drawing.Size(128, 21);
            this.DebuggingBox.TabIndex = 3;
            this.DebuggingBox.Text = "Режим отладки";
            this.DebuggingBox.UseVisualStyleBackColor = false;
            // 
            // TaskIntervalBox
            // 
            this.TaskIntervalBox.BackColor = System.Drawing.Color.LightGreen;
            this.TaskIntervalBox.Location = new System.Drawing.Point(15, 107);
            this.TaskIntervalBox.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.TaskIntervalBox.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.TaskIntervalBox.Name = "TaskIntervalBox";
            this.TaskIntervalBox.Size = new System.Drawing.Size(128, 23);
            this.TaskIntervalBox.TabIndex = 1;
            this.TaskIntervalBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Индекс отделения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Периодичность обработки файлов (мин)";
            // 
            // ZipCodeBox
            // 
            this.ZipCodeBox.BackColor = System.Drawing.Color.LightGreen;
            this.ZipCodeBox.Location = new System.Drawing.Point(15, 51);
            this.ZipCodeBox.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.ZipCodeBox.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ZipCodeBox.Name = "ZipCodeBox";
            this.ZipCodeBox.Size = new System.Drawing.Size(128, 23);
            this.ZipCodeBox.TabIndex = 0;
            this.ZipCodeBox.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // DBPage
            // 
            this.DBPage.Controls.Add(this.DBGroupBox);
            this.DBPage.Location = new System.Drawing.Point(4, 22);
            this.DBPage.Name = "DBPage";
            this.DBPage.Padding = new System.Windows.Forms.Padding(3);
            this.DBPage.Size = new System.Drawing.Size(552, 453);
            this.DBPage.TabIndex = 1;
            this.DBPage.Text = "Подключение к БД";
            this.DBPage.UseVisualStyleBackColor = true;
            // 
            // DBGroupBox
            // 
            this.DBGroupBox.Controls.Add(this.DBTestConnectionButton);
            this.DBGroupBox.Controls.Add(this.label4);
            this.DBGroupBox.Controls.Add(this.DBPasswordBox);
            this.DBGroupBox.Controls.Add(this.label5);
            this.DBGroupBox.Controls.Add(this.DBDatabaseBox);
            this.DBGroupBox.Controls.Add(this.label7);
            this.DBGroupBox.Controls.Add(this.DBUsernameBox);
            this.DBGroupBox.Controls.Add(this.label8);
            this.DBGroupBox.Controls.Add(this.DBDataSourceBox);
            this.DBGroupBox.Location = new System.Drawing.Point(10, 10);
            this.DBGroupBox.Name = "DBGroupBox";
            this.DBGroupBox.Size = new System.Drawing.Size(530, 188);
            this.DBGroupBox.TabIndex = 0;
            this.DBGroupBox.TabStop = false;
            this.DBGroupBox.Text = "Параметры подключения к БД";
            // 
            // DBTestConnectionButton
            // 
            this.DBTestConnectionButton.Location = new System.Drawing.Point(10, 136);
            this.DBTestConnectionButton.Name = "DBTestConnectionButton";
            this.DBTestConnectionButton.Size = new System.Drawing.Size(164, 28);
            this.DBTestConnectionButton.TabIndex = 4;
            this.DBTestConnectionButton.Tag = "Internal";
            this.DBTestConnectionButton.Text = "Тест подключения";
            this.DBTestConnectionButton.UseVisualStyleBackColor = true;
            this.DBTestConnectionButton.Click += new System.EventHandler(this.DBTestConnectionButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Пароль";
            // 
            // DBPasswordBox
            // 
            this.DBPasswordBox.BackColor = System.Drawing.Color.LightGreen;
            this.DBPasswordBox.Location = new System.Drawing.Point(270, 90);
            this.DBPasswordBox.Name = "DBPasswordBox";
            this.DBPasswordBox.Size = new System.Drawing.Size(250, 23);
            this.DBPasswordBox.TabIndex = 3;
            this.DBPasswordBox.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Путь к файлу БД";
            // 
            // DBDatabaseBox
            // 
            this.DBDatabaseBox.BackColor = System.Drawing.Color.LightGreen;
            this.DBDatabaseBox.Location = new System.Drawing.Point(270, 46);
            this.DBDatabaseBox.Name = "DBDatabaseBox";
            this.DBDatabaseBox.Size = new System.Drawing.Size(250, 23);
            this.DBDatabaseBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Пользователь";
            // 
            // DBUsernameBox
            // 
            this.DBUsernameBox.BackColor = System.Drawing.Color.LightGreen;
            this.DBUsernameBox.Location = new System.Drawing.Point(10, 90);
            this.DBUsernameBox.Name = "DBUsernameBox";
            this.DBUsernameBox.Size = new System.Drawing.Size(250, 23);
            this.DBUsernameBox.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Имя сервера";
            // 
            // DBDataSourceBox
            // 
            this.DBDataSourceBox.BackColor = System.Drawing.Color.LightGreen;
            this.DBDataSourceBox.Location = new System.Drawing.Point(10, 46);
            this.DBDataSourceBox.Name = "DBDataSourceBox";
            this.DBDataSourceBox.Size = new System.Drawing.Size(250, 23);
            this.DBDataSourceBox.TabIndex = 0;
            // 
            // ExternalFtpPage
            // 
            this.ExternalFtpPage.Controls.Add(this.ExternalGroupBox);
            this.ExternalFtpPage.Location = new System.Drawing.Point(4, 22);
            this.ExternalFtpPage.Name = "ExternalFtpPage";
            this.ExternalFtpPage.Size = new System.Drawing.Size(552, 453);
            this.ExternalFtpPage.TabIndex = 2;
            this.ExternalFtpPage.Text = "Внешний FTP";
            this.ExternalFtpPage.UseVisualStyleBackColor = true;
            // 
            // ExternalGroupBox
            // 
            this.ExternalGroupBox.Controls.Add(this.ExternalPortBox);
            this.ExternalGroupBox.Controls.Add(this.ExternalLoginBox);
            this.ExternalGroupBox.Controls.Add(this.ExternalHostBox);
            this.ExternalGroupBox.Controls.Add(this.ExternalTestConnectionButton);
            this.ExternalGroupBox.Controls.Add(this.ExternalPortLabel);
            this.ExternalGroupBox.Controls.Add(this.ExternalCwdLabel);
            this.ExternalGroupBox.Controls.Add(this.ExternalCwdBox);
            this.ExternalGroupBox.Controls.Add(this.ExternalPasswordLabel);
            this.ExternalGroupBox.Controls.Add(this.ExternalPasswordBox);
            this.ExternalGroupBox.Controls.Add(this.ExternalLoginLabel);
            this.ExternalGroupBox.Controls.Add(this.ExternalHostLabel);
            this.ExternalGroupBox.Location = new System.Drawing.Point(10, 10);
            this.ExternalGroupBox.Name = "ExternalGroupBox";
            this.ExternalGroupBox.Size = new System.Drawing.Size(530, 228);
            this.ExternalGroupBox.TabIndex = 3;
            this.ExternalGroupBox.TabStop = false;
            this.ExternalGroupBox.Text = "Внешний FTP";
            // 
            // ExternalPortBox
            // 
            this.ExternalPortBox.BackColor = System.Drawing.Color.LightGreen;
            this.ExternalPortBox.Location = new System.Drawing.Point(10, 90);
            this.ExternalPortBox.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.ExternalPortBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ExternalPortBox.Name = "ExternalPortBox";
            this.ExternalPortBox.Size = new System.Drawing.Size(250, 23);
            this.ExternalPortBox.TabIndex = 2;
            this.ExternalPortBox.Value = new decimal(new int[] {
            21,
            0,
            0,
            0});
            // 
            // ExternalLoginBox
            // 
            this.ExternalLoginBox.BackColor = System.Drawing.Color.LightGreen;
            this.ExternalLoginBox.Location = new System.Drawing.Point(270, 46);
            this.ExternalLoginBox.Name = "ExternalLoginBox";
            this.ExternalLoginBox.Size = new System.Drawing.Size(250, 23);
            this.ExternalLoginBox.TabIndex = 1;
            // 
            // ExternalHostBox
            // 
            this.ExternalHostBox.BackColor = System.Drawing.Color.LightGreen;
            this.ExternalHostBox.Location = new System.Drawing.Point(10, 46);
            this.ExternalHostBox.Name = "ExternalHostBox";
            this.ExternalHostBox.Size = new System.Drawing.Size(250, 23);
            this.ExternalHostBox.TabIndex = 0;
            // 
            // ExternalTestConnectionButton
            // 
            this.ExternalTestConnectionButton.Location = new System.Drawing.Point(10, 190);
            this.ExternalTestConnectionButton.Name = "ExternalTestConnectionButton";
            this.ExternalTestConnectionButton.Size = new System.Drawing.Size(164, 28);
            this.ExternalTestConnectionButton.TabIndex = 5;
            this.ExternalTestConnectionButton.Tag = "External";
            this.ExternalTestConnectionButton.Text = "Тест подключения";
            this.ExternalTestConnectionButton.UseVisualStyleBackColor = true;
            this.ExternalTestConnectionButton.Click += new System.EventHandler(this.ExternalTestConnectionButton_Click);
            // 
            // ExternalPortLabel
            // 
            this.ExternalPortLabel.AutoSize = true;
            this.ExternalPortLabel.Location = new System.Drawing.Point(7, 71);
            this.ExternalPortLabel.Name = "ExternalPortLabel";
            this.ExternalPortLabel.Size = new System.Drawing.Size(41, 17);
            this.ExternalPortLabel.TabIndex = 10;
            this.ExternalPortLabel.Text = "Порт";
            // 
            // ExternalCwdLabel
            // 
            this.ExternalCwdLabel.AutoSize = true;
            this.ExternalCwdLabel.Location = new System.Drawing.Point(267, 115);
            this.ExternalCwdLabel.Name = "ExternalCwdLabel";
            this.ExternalCwdLabel.Size = new System.Drawing.Size(138, 17);
            this.ExternalCwdLabel.TabIndex = 8;
            this.ExternalCwdLabel.Text = "Удаленный каталог";
            // 
            // ExternalCwdBox
            // 
            this.ExternalCwdBox.BackColor = System.Drawing.Color.LightGreen;
            this.ExternalCwdBox.Location = new System.Drawing.Point(270, 134);
            this.ExternalCwdBox.Name = "ExternalCwdBox";
            this.ExternalCwdBox.Size = new System.Drawing.Size(250, 23);
            this.ExternalCwdBox.TabIndex = 4;
            // 
            // ExternalPasswordLabel
            // 
            this.ExternalPasswordLabel.AutoSize = true;
            this.ExternalPasswordLabel.Location = new System.Drawing.Point(267, 71);
            this.ExternalPasswordLabel.Name = "ExternalPasswordLabel";
            this.ExternalPasswordLabel.Size = new System.Drawing.Size(57, 17);
            this.ExternalPasswordLabel.TabIndex = 6;
            this.ExternalPasswordLabel.Text = "Пароль";
            // 
            // ExternalPasswordBox
            // 
            this.ExternalPasswordBox.BackColor = System.Drawing.Color.LightGreen;
            this.ExternalPasswordBox.Location = new System.Drawing.Point(270, 90);
            this.ExternalPasswordBox.Name = "ExternalPasswordBox";
            this.ExternalPasswordBox.Size = new System.Drawing.Size(250, 23);
            this.ExternalPasswordBox.TabIndex = 3;
            this.ExternalPasswordBox.UseSystemPasswordChar = true;
            // 
            // ExternalLoginLabel
            // 
            this.ExternalLoginLabel.AutoSize = true;
            this.ExternalLoginLabel.Location = new System.Drawing.Point(267, 26);
            this.ExternalLoginLabel.Name = "ExternalLoginLabel";
            this.ExternalLoginLabel.Size = new System.Drawing.Size(131, 17);
            this.ExternalLoginLabel.TabIndex = 4;
            this.ExternalLoginLabel.Text = "Имя пользователя";
            // 
            // ExternalHostLabel
            // 
            this.ExternalHostLabel.AutoSize = true;
            this.ExternalHostLabel.Location = new System.Drawing.Point(7, 27);
            this.ExternalHostLabel.Name = "ExternalHostLabel";
            this.ExternalHostLabel.Size = new System.Drawing.Size(39, 17);
            this.ExternalHostLabel.TabIndex = 2;
            this.ExternalHostLabel.Text = "Хост";
            // 
            // MailPage
            // 
            this.MailPage.Controls.Add(this.ExchangeGroupBox);
            this.MailPage.Location = new System.Drawing.Point(4, 22);
            this.MailPage.Name = "MailPage";
            this.MailPage.Size = new System.Drawing.Size(552, 453);
            this.MailPage.TabIndex = 3;
            this.MailPage.Text = "Электронная почта";
            this.MailPage.UseVisualStyleBackColor = true;
            // 
            // ExchangeGroupBox
            // 
            this.ExchangeGroupBox.Controls.Add(this.ExCertBox);
            this.ExchangeGroupBox.Controls.Add(this.label12);
            this.ExchangeGroupBox.Controls.Add(this.ExchangeTestButton);
            this.ExchangeGroupBox.Controls.Add(this.ExRecipientBox);
            this.ExchangeGroupBox.Controls.Add(this.label13);
            this.ExchangeGroupBox.Controls.Add(this.ExPasswordBox);
            this.ExchangeGroupBox.Controls.Add(this.label14);
            this.ExchangeGroupBox.Controls.Add(this.ExUsernameBox);
            this.ExchangeGroupBox.Controls.Add(this.label15);
            this.ExchangeGroupBox.Controls.Add(this.ExDomainBox);
            this.ExchangeGroupBox.Controls.Add(this.label16);
            this.ExchangeGroupBox.Controls.Add(this.ExHostBox);
            this.ExchangeGroupBox.Controls.Add(this.label17);
            this.ExchangeGroupBox.Location = new System.Drawing.Point(10, 10);
            this.ExchangeGroupBox.Name = "ExchangeGroupBox";
            this.ExchangeGroupBox.Size = new System.Drawing.Size(530, 228);
            this.ExchangeGroupBox.TabIndex = 3;
            this.ExchangeGroupBox.TabStop = false;
            this.ExchangeGroupBox.Text = "Параметры почтового сервера Exchange";
            // 
            // ExCertBox
            // 
            this.ExCertBox.BackColor = System.Drawing.Color.Salmon;
            this.ExCertBox.Location = new System.Drawing.Point(270, 134);
            this.ExCertBox.MaxLength = 40;
            this.ExCertBox.Name = "ExCertBox";
            this.ExCertBox.Size = new System.Drawing.Size(250, 23);
            this.ExCertBox.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(267, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 17);
            this.label12.TabIndex = 15;
            this.label12.Text = "Имя сертификата";
            // 
            // ExchangeTestButton
            // 
            this.ExchangeTestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ExchangeTestButton.Location = new System.Drawing.Point(10, 190);
            this.ExchangeTestButton.Name = "ExchangeTestButton";
            this.ExchangeTestButton.Size = new System.Drawing.Size(164, 28);
            this.ExchangeTestButton.TabIndex = 6;
            this.ExchangeTestButton.Text = "Тест подключения";
            this.ExchangeTestButton.UseVisualStyleBackColor = true;
            this.ExchangeTestButton.Click += new System.EventHandler(this.ExchangeTestButton_Click);
            // 
            // ExRecipientBox
            // 
            this.ExRecipientBox.BackColor = System.Drawing.Color.LightGreen;
            this.ExRecipientBox.Location = new System.Drawing.Point(10, 134);
            this.ExRecipientBox.MaxLength = 40;
            this.ExRecipientBox.Name = "ExRecipientBox";
            this.ExRecipientBox.Size = new System.Drawing.Size(250, 23);
            this.ExRecipientBox.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "Получатель";
            // 
            // ExPasswordBox
            // 
            this.ExPasswordBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExPasswordBox.BackColor = System.Drawing.Color.LightGreen;
            this.ExPasswordBox.Location = new System.Drawing.Point(270, 90);
            this.ExPasswordBox.MaxLength = 38;
            this.ExPasswordBox.Name = "ExPasswordBox";
            this.ExPasswordBox.Size = new System.Drawing.Size(250, 23);
            this.ExPasswordBox.TabIndex = 3;
            this.ExPasswordBox.UseSystemPasswordChar = true;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(267, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 17);
            this.label14.TabIndex = 10;
            this.label14.Text = "Пароль";
            // 
            // ExUsernameBox
            // 
            this.ExUsernameBox.BackColor = System.Drawing.Color.LightGreen;
            this.ExUsernameBox.Location = new System.Drawing.Point(10, 90);
            this.ExUsernameBox.MaxLength = 38;
            this.ExUsernameBox.Name = "ExUsernameBox";
            this.ExUsernameBox.Size = new System.Drawing.Size(250, 23);
            this.ExUsernameBox.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 17);
            this.label15.TabIndex = 8;
            this.label15.Text = "Пользователь";
            // 
            // ExDomainBox
            // 
            this.ExDomainBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExDomainBox.BackColor = System.Drawing.Color.LightGreen;
            this.ExDomainBox.Location = new System.Drawing.Point(270, 46);
            this.ExDomainBox.MaxLength = 256;
            this.ExDomainBox.Name = "ExDomainBox";
            this.ExDomainBox.Size = new System.Drawing.Size(250, 23);
            this.ExDomainBox.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(267, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 17);
            this.label16.TabIndex = 6;
            this.label16.Text = "Домен";
            // 
            // ExHostBox
            // 
            this.ExHostBox.BackColor = System.Drawing.Color.LightGreen;
            this.ExHostBox.Location = new System.Drawing.Point(10, 46);
            this.ExHostBox.MaxLength = 40;
            this.ExHostBox.Name = "ExHostBox";
            this.ExHostBox.Size = new System.Drawing.Size(250, 23);
            this.ExHostBox.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 17);
            this.label17.TabIndex = 4;
            this.label17.Text = "Имя сервера";
            // 
            // TasksPage
            // 
            this.TasksPage.Controls.Add(this.TasksBox);
            this.TasksPage.Location = new System.Drawing.Point(4, 22);
            this.TasksPage.Name = "TasksPage";
            this.TasksPage.Size = new System.Drawing.Size(552, 453);
            this.TasksPage.TabIndex = 4;
            this.TasksPage.Text = "Задачи";
            this.TasksPage.UseVisualStyleBackColor = true;
            // 
            // TasksBox
            // 
            this.TasksBox.Controls.Add(this.DeleteTaskButton);
            this.TasksBox.Controls.Add(this.EditTaskButton);
            this.TasksBox.Controls.Add(this.AddTaskButton);
            this.TasksBox.Controls.Add(this.label19);
            this.TasksBox.Controls.Add(this.TasksListView);
            this.TasksBox.Location = new System.Drawing.Point(10, 10);
            this.TasksBox.Name = "TasksBox";
            this.TasksBox.Size = new System.Drawing.Size(530, 429);
            this.TasksBox.TabIndex = 0;
            this.TasksBox.TabStop = false;
            this.TasksBox.Text = "Управление задачами";
            // 
            // DeleteTaskButton
            // 
            this.DeleteTaskButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteTaskButton.BackColor = System.Drawing.Color.LightGreen;
            this.DeleteTaskButton.Location = new System.Drawing.Point(410, 389);
            this.DeleteTaskButton.Name = "DeleteTaskButton";
            this.DeleteTaskButton.Size = new System.Drawing.Size(110, 28);
            this.DeleteTaskButton.TabIndex = 3;
            this.DeleteTaskButton.Text = "Удалить";
            this.DeleteTaskButton.UseVisualStyleBackColor = false;
            this.DeleteTaskButton.Click += new System.EventHandler(this.DeleteTaskButton_Click);
            // 
            // EditTaskButton
            // 
            this.EditTaskButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditTaskButton.BackColor = System.Drawing.Color.LightGreen;
            this.EditTaskButton.Location = new System.Drawing.Point(110, 389);
            this.EditTaskButton.Name = "EditTaskButton";
            this.EditTaskButton.Size = new System.Drawing.Size(95, 28);
            this.EditTaskButton.TabIndex = 2;
            this.EditTaskButton.Text = "Править";
            this.EditTaskButton.UseVisualStyleBackColor = false;
            this.EditTaskButton.Click += new System.EventHandler(this.EditTaskButton_Click);
            // 
            // AddTaskButton
            // 
            this.AddTaskButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddTaskButton.BackColor = System.Drawing.Color.LightGreen;
            this.AddTaskButton.Location = new System.Drawing.Point(10, 389);
            this.AddTaskButton.Name = "AddTaskButton";
            this.AddTaskButton.Size = new System.Drawing.Size(95, 28);
            this.AddTaskButton.TabIndex = 1;
            this.AddTaskButton.Text = "Добавить";
            this.AddTaskButton.UseVisualStyleBackColor = false;
            this.AddTaskButton.Click += new System.EventHandler(this.AddTaskButton_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(98, 17);
            this.label19.TabIndex = 1;
            this.label19.Text = "Список задач";
            // 
            // TasksListView
            // 
            this.TasksListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TasksListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.TasksListView.FullRowSelect = true;
            this.TasksListView.GridLines = true;
            this.TasksListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.TasksListView.HideSelection = false;
            this.TasksListView.Location = new System.Drawing.Point(10, 46);
            this.TasksListView.MultiSelect = false;
            this.TasksListView.Name = "TasksListView";
            this.TasksListView.Size = new System.Drawing.Size(510, 334);
            this.TasksListView.TabIndex = 0;
            this.TasksListView.UseCompatibleStateImageBehavior = false;
            this.TasksListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Имя";
            this.columnHeader1.Width = 190;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Путь";
            this.columnHeader2.Width = 290;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(437, 505);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(135, 27);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OpenButton.Location = new System.Drawing.Point(12, 505);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(135, 27);
            this.OpenButton.TabIndex = 1;
            this.OpenButton.Text = "Открыть";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // MainOpenFileDialog
            // 
            this.MainOpenFileDialog.FileName = "POFileManagerService.conf";
            this.MainOpenFileDialog.Filter = "Файл конфигурации|*.conf";
            this.MainOpenFileDialog.Title = "Выбор файла конфигурации (POFileManagerService.conf)";
            // 
            // LegendGoodBox
            // 
            this.LegendGoodBox.BackColor = System.Drawing.Color.LightGreen;
            this.LegendGoodBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LegendGoodBox.Location = new System.Drawing.Point(166, 497);
            this.LegendGoodBox.Name = "LegendGoodBox";
            this.LegendGoodBox.Size = new System.Drawing.Size(16, 16);
            this.LegendGoodBox.TabIndex = 3;
            // 
            // LegendBadBox
            // 
            this.LegendBadBox.BackColor = System.Drawing.Color.Salmon;
            this.LegendBadBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LegendBadBox.Location = new System.Drawing.Point(166, 516);
            this.LegendBadBox.Name = "LegendBadBox";
            this.LegendBadBox.Size = new System.Drawing.Size(16, 16);
            this.LegendBadBox.TabIndex = 4;
            // 
            // LegendGoodLabel
            // 
            this.LegendGoodLabel.AutoSize = true;
            this.LegendGoodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LegendGoodLabel.Location = new System.Drawing.Point(188, 499);
            this.LegendGoodLabel.Name = "LegendGoodLabel";
            this.LegendGoodLabel.Size = new System.Drawing.Size(222, 13);
            this.LegendGoodLabel.TabIndex = 5;
            this.LegendGoodLabel.Text = "Параметры рекомендуемые к изменению";
            // 
            // LegendBadLabel
            // 
            this.LegendBadLabel.AutoSize = true;
            this.LegendBadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LegendBadLabel.Location = new System.Drawing.Point(188, 518);
            this.LegendBadLabel.Name = "LegendBadLabel";
            this.LegendBadLabel.Size = new System.Drawing.Size(237, 13);
            this.LegendBadLabel.TabIndex = 6;
            this.LegendBadLabel.Text = "Параметры не рекомендуемые к изменению";
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InfoStatusLabel});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 540);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(584, 22);
            this.MainStatusStrip.SizingGrip = false;
            this.MainStatusStrip.TabIndex = 7;
            // 
            // InfoStatusLabel
            // 
            this.InfoStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.InfoStatusLabel.Name = "InfoStatusLabel";
            this.InfoStatusLabel.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.InfoStatusLabel.Size = new System.Drawing.Size(569, 17);
            this.InfoStatusLabel.Spring = true;
            this.InfoStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.LegendBadLabel);
            this.Controls.Add(this.LegendGoodLabel);
            this.Controls.Add(this.LegendBadBox);
            this.Controls.Add(this.LegendGoodBox);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.MainTabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конфигуратор POFileManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MainTabControl.ResumeLayout(false);
            this.GlobalPage.ResumeLayout(false);
            this.GlobalGroupBox.ResumeLayout(false);
            this.GlobalGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdditionalTimeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskIntervalBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZipCodeBox)).EndInit();
            this.DBPage.ResumeLayout(false);
            this.DBGroupBox.ResumeLayout(false);
            this.DBGroupBox.PerformLayout();
            this.ExternalFtpPage.ResumeLayout(false);
            this.ExternalGroupBox.ResumeLayout(false);
            this.ExternalGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExternalPortBox)).EndInit();
            this.MailPage.ResumeLayout(false);
            this.ExchangeGroupBox.ResumeLayout(false);
            this.ExchangeGroupBox.PerformLayout();
            this.TasksPage.ResumeLayout(false);
            this.TasksBox.ResumeLayout(false);
            this.TasksBox.PerformLayout();
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage GlobalPage;
        private System.Windows.Forms.TabPage DBPage;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ZipCodeBox;
        private System.Windows.Forms.NumericUpDown TaskIntervalBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage ExternalFtpPage;
        private System.Windows.Forms.TabPage MailPage;
        private System.Windows.Forms.TabPage TasksPage;
        private System.Windows.Forms.GroupBox ExchangeGroupBox;
        private System.Windows.Forms.TextBox ExCertBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button ExchangeTestButton;
        private System.Windows.Forms.TextBox ExRecipientBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ExPasswordBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ExUsernameBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox ExDomainBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox ExHostBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox ExternalGroupBox;
        private System.Windows.Forms.Button ExternalTestConnectionButton;
        private System.Windows.Forms.Label ExternalPortLabel;
        private System.Windows.Forms.NumericUpDown ExternalPortBox;
        private System.Windows.Forms.Label ExternalCwdLabel;
        private System.Windows.Forms.TextBox ExternalCwdBox;
        private System.Windows.Forms.Label ExternalPasswordLabel;
        private System.Windows.Forms.TextBox ExternalPasswordBox;
        private System.Windows.Forms.Label ExternalLoginLabel;
        private System.Windows.Forms.TextBox ExternalLoginBox;
        private System.Windows.Forms.Label ExternalHostLabel;
        private System.Windows.Forms.TextBox ExternalHostBox;
        private System.Windows.Forms.GroupBox DBGroupBox;
        private System.Windows.Forms.Button DBTestConnectionButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DBPasswordBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DBDatabaseBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DBUsernameBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DBDataSourceBox;
        private System.Windows.Forms.GroupBox GlobalGroupBox;
        private System.Windows.Forms.GroupBox TasksBox;
        private System.Windows.Forms.ListView TasksListView;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button DeleteTaskButton;
        private System.Windows.Forms.Button EditTaskButton;
        private System.Windows.Forms.Button AddTaskButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.OpenFileDialog MainOpenFileDialog;
        private System.Windows.Forms.CheckBox DebuggingBox;
        private System.Windows.Forms.NumericUpDown AdditionalTimeBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox UpdateServiceBox;
        private System.Windows.Forms.Panel LegendGoodBox;
        private System.Windows.Forms.Panel LegendBadBox;
        private System.Windows.Forms.Label LegendGoodLabel;
        private System.Windows.Forms.Label LegendBadLabel;
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel InfoStatusLabel;
    }
}

