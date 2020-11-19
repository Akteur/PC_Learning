namespace PC_Builder
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Win_name = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label_Theory = new System.Windows.Forms.Label();
            this.label_Pract = new System.Windows.Forms.Label();
            this.label_Login = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Theory_Text = new System.Windows.Forms.RichTextBox();
            this.Settings = new System.Windows.Forms.PictureBox();
            this.panel_Color = new System.Windows.Forms.Panel();
            this.label_Color = new System.Windows.Forms.Label();
            this.Theory_pic = new System.Windows.Forms.PictureBox();
            this.button_CPU = new System.Windows.Forms.Button();
            this.button_MB = new System.Windows.Forms.Button();
            this.button_RAM = new System.Windows.Forms.Button();
            this.Socket_PR = new System.Windows.Forms.Button();
            this.PCI_PR = new System.Windows.Forms.Button();
            this.RAM_PR = new System.Windows.Forms.Button();
            this.pin24 = new System.Windows.Forms.Button();
            this.pin8 = new System.Windows.Forms.Button();
            this.SATA_PR = new System.Windows.Forms.Button();
            this.pic_Socket = new System.Windows.Forms.PictureBox();
            this.pic_Ram = new System.Windows.Forms.PictureBox();
            this.pic_PCIE = new System.Windows.Forms.PictureBox();
            this.pic_PCIE2 = new System.Windows.Forms.PictureBox();
            this.pic_NB = new System.Windows.Forms.PictureBox();
            this.pic_MBPower = new System.Windows.Forms.PictureBox();
            this.NB_PR = new System.Windows.Forms.Button();
            this.pic_SATA = new System.Windows.Forms.PictureBox();
            this.pic_CPUPower = new System.Windows.Forms.PictureBox();
            this.panel_Good = new System.Windows.Forms.Panel();
            this.panel_Bad = new System.Windows.Forms.Panel();
            this.label_True = new System.Windows.Forms.Label();
            this.label_False = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label_Score = new System.Windows.Forms.Label();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.pic_VRM1 = new System.Windows.Forms.PictureBox();
            this.VRM = new System.Windows.Forms.Button();
            this.Rules_text = new System.Windows.Forms.RichTextBox();
            this.label_About = new System.Windows.Forms.Label();
            this.Rate_label = new System.Windows.Forms.Label();
            this.Rate_DataGrid = new System.Windows.Forms.DataGridView();
            this.Nick_label = new System.Windows.Forms.Label();
            this.Score_label = new System.Windows.Forms.Label();
            this.panel_Color2 = new System.Windows.Forms.Panel();
            this.panel_Color1 = new System.Windows.Forms.Panel();
            this.Update_button = new System.Windows.Forms.Button();
            this.Send_Mail = new System.Windows.Forms.Button();
            this.Mail_text = new System.Windows.Forms.TextBox();
            this.Mail_label = new System.Windows.Forms.Label();
            this.TitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).BeginInit();
            this.panel_Color.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Theory_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Socket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PCIE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PCIE2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_NB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MBPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SATA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CPUPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_VRM1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rate_DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TitlePanel
            // 
            this.TitlePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(18)))), ((int)(((byte)(78)))));
            this.TitlePanel.Controls.Add(this.label3);
            this.TitlePanel.Controls.Add(this.Win_name);
            this.TitlePanel.Controls.Add(this.Close);
            this.TitlePanel.Location = new System.Drawing.Point(-1, -1);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(1282, 40);
            this.TitlePanel.TabIndex = 0;
            this.TitlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseDown);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(1219, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "_";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Win_name
            // 
            this.Win_name.AutoSize = true;
            this.Win_name.BackColor = System.Drawing.Color.Transparent;
            this.Win_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Win_name.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Win_name.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Win_name.Location = new System.Drawing.Point(13, 10);
            this.Win_name.Name = "Win_name";
            this.Win_name.Size = new System.Drawing.Size(123, 25);
            this.Win_name.TabIndex = 1;
            this.Win_name.Text = "PC Learning";
            this.Win_name.Visible = false;
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.AutoSize = true;
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Close.Location = new System.Drawing.Point(1244, 10);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(25, 24);
            this.Close.TabIndex = 2;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 63.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.label1.Location = new System.Drawing.Point(407, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 111);
            this.label1.TabIndex = 3;
            this.label1.Text = "PC Learning";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(477, 599);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Для продолжения нажмите Enter";
            this.label2.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label_Theory
            // 
            this.label_Theory.AutoSize = true;
            this.label_Theory.BackColor = System.Drawing.Color.Transparent;
            this.label_Theory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Theory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Theory.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Theory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_Theory.Location = new System.Drawing.Point(12, 42);
            this.label_Theory.Name = "label_Theory";
            this.label_Theory.Size = new System.Drawing.Size(80, 25);
            this.label_Theory.TabIndex = 5;
            this.label_Theory.Text = "Теория";
            this.label_Theory.Visible = false;
            this.label_Theory.Click += new System.EventHandler(this.label_Theory_Click);
            this.label_Theory.MouseLeave += new System.EventHandler(this.label_Theory_MouseLeave);
            this.label_Theory.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_Theory_MouseMove);
            // 
            // label_Pract
            // 
            this.label_Pract.AutoSize = true;
            this.label_Pract.BackColor = System.Drawing.Color.Transparent;
            this.label_Pract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Pract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Pract.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Pract.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_Pract.Location = new System.Drawing.Point(96, 42);
            this.label_Pract.Name = "label_Pract";
            this.label_Pract.Size = new System.Drawing.Size(102, 25);
            this.label_Pract.TabIndex = 6;
            this.label_Pract.Text = "Практика";
            this.label_Pract.Visible = false;
            this.label_Pract.Click += new System.EventHandler(this.label_Practice_Click);
            this.label_Pract.MouseLeave += new System.EventHandler(this.label_Practice_MouseLeave);
            this.label_Pract.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_Practice_MouseMove);
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.BackColor = System.Drawing.Color.Transparent;
            this.label_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Login.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_Login.Location = new System.Drawing.Point(1172, 42);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(69, 25);
            this.label_Login.TabIndex = 8;
            this.label_Login.Text = "Войти";
            this.label_Login.Visible = false;
            this.label_Login.Click += new System.EventHandler(this.label_Login_Click);
            this.label_Login.MouseLeave += new System.EventHandler(this.label_Login_MouseLeave);
            this.label_Login.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_Login_MouseMove);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(1122, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Вы:";
            this.label7.Visible = false;
            // 
            // Theory_Text
            // 
            this.Theory_Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.Theory_Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Theory_Text.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Theory_Text.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Theory_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Theory_Text.Location = new System.Drawing.Point(664, 86);
            this.Theory_Text.Name = "Theory_Text";
            this.Theory_Text.ReadOnly = true;
            this.Theory_Text.Size = new System.Drawing.Size(448, 456);
            this.Theory_Text.TabIndex = 13;
            this.Theory_Text.Text = "";
            this.Theory_Text.Visible = false;
            // 
            // Settings
            // 
            this.Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings.Image = ((System.Drawing.Image)(resources.GetObject("Settings.Image")));
            this.Settings.Location = new System.Drawing.Point(0, 660);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(60, 60);
            this.Settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Settings.TabIndex = 15;
            this.Settings.TabStop = false;
            this.Settings.Visible = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            this.Settings.MouseLeave += new System.EventHandler(this.Settings_MouseLeave);
            this.Settings.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Settings_MouseMove);
            // 
            // panel_Color
            // 
            this.panel_Color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.panel_Color.Controls.Add(this.label_Color);
            this.panel_Color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_Color.Location = new System.Drawing.Point(61, 660);
            this.panel_Color.Name = "panel_Color";
            this.panel_Color.Size = new System.Drawing.Size(91, 60);
            this.panel_Color.TabIndex = 14;
            this.panel_Color.Visible = false;
            this.panel_Color.Click += new System.EventHandler(this.panel_Color_Click);
            this.panel_Color.MouseLeave += new System.EventHandler(this.panel_Color_MouseLeave);
            this.panel_Color.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Color_MouseMove);
            // 
            // label_Color
            // 
            this.label_Color.AutoSize = true;
            this.label_Color.BackColor = System.Drawing.Color.Transparent;
            this.label_Color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Color.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Color.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_Color.Location = new System.Drawing.Point(18, 19);
            this.label_Color.Name = "label_Color";
            this.label_Color.Size = new System.Drawing.Size(60, 25);
            this.label_Color.TabIndex = 13;
            this.label_Color.Text = "Тема";
            this.label_Color.Visible = false;
            this.label_Color.Click += new System.EventHandler(this.label_Color_Click);
            this.label_Color.MouseLeave += new System.EventHandler(this.label_Color_MouseLeave);
            this.label_Color.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_Color_MouseMove);
            // 
            // Theory_pic
            // 
            this.Theory_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Theory_pic.Image = ((System.Drawing.Image)(resources.GetObject("Theory_pic.Image")));
            this.Theory_pic.Location = new System.Drawing.Point(234, 92);
            this.Theory_pic.Name = "Theory_pic";
            this.Theory_pic.Size = new System.Drawing.Size(416, 500);
            this.Theory_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Theory_pic.TabIndex = 16;
            this.Theory_pic.TabStop = false;
            this.Theory_pic.Visible = false;
            // 
            // button_CPU
            // 
            this.button_CPU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.button_CPU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CPU.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.button_CPU.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_CPU.Location = new System.Drawing.Point(12, 169);
            this.button_CPU.Name = "button_CPU";
            this.button_CPU.Size = new System.Drawing.Size(200, 70);
            this.button_CPU.TabIndex = 17;
            this.button_CPU.Text = "Процессор";
            this.button_CPU.UseVisualStyleBackColor = false;
            this.button_CPU.Visible = false;
            this.button_CPU.Click += new System.EventHandler(this.button_CPU_Click);
            this.button_CPU.MouseLeave += new System.EventHandler(this.button_CPU_MouseLeave);
            this.button_CPU.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_CPU_MouseMove);
            // 
            // button_MB
            // 
            this.button_MB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.button_MB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_MB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MB.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.button_MB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_MB.Location = new System.Drawing.Point(12, 92);
            this.button_MB.Name = "button_MB";
            this.button_MB.Size = new System.Drawing.Size(200, 70);
            this.button_MB.TabIndex = 18;
            this.button_MB.Text = "Материнская плата";
            this.button_MB.UseVisualStyleBackColor = false;
            this.button_MB.Visible = false;
            this.button_MB.Click += new System.EventHandler(this.button_MB_Click);
            this.button_MB.MouseLeave += new System.EventHandler(this.button_MB_MouseLeave);
            this.button_MB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MB_MouseMove);
            // 
            // button_RAM
            // 
            this.button_RAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.button_RAM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_RAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_RAM.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.button_RAM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_RAM.Location = new System.Drawing.Point(12, 245);
            this.button_RAM.Name = "button_RAM";
            this.button_RAM.Size = new System.Drawing.Size(200, 70);
            this.button_RAM.TabIndex = 19;
            this.button_RAM.Text = "Оперативная память";
            this.button_RAM.UseVisualStyleBackColor = false;
            this.button_RAM.Visible = false;
            this.button_RAM.Click += new System.EventHandler(this.button_RAM_Click);
            this.button_RAM.MouseLeave += new System.EventHandler(this.button_RAM_MouseLeave);
            this.button_RAM.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_RAM_MouseMove);
            // 
            // Socket_PR
            // 
            this.Socket_PR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.Socket_PR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Socket_PR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Socket_PR.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.Socket_PR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Socket_PR.Location = new System.Drawing.Point(664, 92);
            this.Socket_PR.Name = "Socket_PR";
            this.Socket_PR.Size = new System.Drawing.Size(200, 70);
            this.Socket_PR.TabIndex = 30;
            this.Socket_PR.Text = "Сокет";
            this.Socket_PR.UseVisualStyleBackColor = false;
            this.Socket_PR.Visible = false;
            this.Socket_PR.Click += new System.EventHandler(this.Socket_PR_Click);
            // 
            // PCI_PR
            // 
            this.PCI_PR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.PCI_PR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PCI_PR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PCI_PR.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.PCI_PR.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PCI_PR.Location = new System.Drawing.Point(870, 92);
            this.PCI_PR.Name = "PCI_PR";
            this.PCI_PR.Size = new System.Drawing.Size(200, 70);
            this.PCI_PR.TabIndex = 31;
            this.PCI_PR.Text = "PCI-E";
            this.PCI_PR.UseVisualStyleBackColor = false;
            this.PCI_PR.Visible = false;
            this.PCI_PR.Click += new System.EventHandler(this.PCI_PR_Click);
            // 
            // RAM_PR
            // 
            this.RAM_PR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.RAM_PR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RAM_PR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RAM_PR.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.RAM_PR.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RAM_PR.Location = new System.Drawing.Point(664, 169);
            this.RAM_PR.Name = "RAM_PR";
            this.RAM_PR.Size = new System.Drawing.Size(200, 70);
            this.RAM_PR.TabIndex = 32;
            this.RAM_PR.Text = "Слоты ОЗУ";
            this.RAM_PR.UseVisualStyleBackColor = false;
            this.RAM_PR.Visible = false;
            this.RAM_PR.Click += new System.EventHandler(this.RAM_PR_Click);
            // 
            // pin24
            // 
            this.pin24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.pin24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pin24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pin24.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.pin24.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pin24.Location = new System.Drawing.Point(664, 246);
            this.pin24.Name = "pin24";
            this.pin24.Size = new System.Drawing.Size(200, 70);
            this.pin24.TabIndex = 35;
            this.pin24.Text = "24-pin";
            this.pin24.UseVisualStyleBackColor = false;
            this.pin24.Visible = false;
            this.pin24.Click += new System.EventHandler(this.pin24_Click);
            // 
            // pin8
            // 
            this.pin8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.pin8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pin8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pin8.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.pin8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pin8.Location = new System.Drawing.Point(664, 322);
            this.pin8.Name = "pin8";
            this.pin8.Size = new System.Drawing.Size(200, 70);
            this.pin8.TabIndex = 37;
            this.pin8.Text = "8-pin";
            this.pin8.UseVisualStyleBackColor = false;
            this.pin8.Visible = false;
            this.pin8.Click += new System.EventHandler(this.pin8_Click);
            // 
            // SATA_PR
            // 
            this.SATA_PR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.SATA_PR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SATA_PR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SATA_PR.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.SATA_PR.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SATA_PR.Location = new System.Drawing.Point(870, 169);
            this.SATA_PR.Name = "SATA_PR";
            this.SATA_PR.Size = new System.Drawing.Size(200, 70);
            this.SATA_PR.TabIndex = 39;
            this.SATA_PR.Text = "SATA";
            this.SATA_PR.UseVisualStyleBackColor = false;
            this.SATA_PR.Visible = false;
            this.SATA_PR.Click += new System.EventHandler(this.SATA_PR_Click);
            // 
            // pic_Socket
            // 
            this.pic_Socket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(58)))), ((int)(((byte)(160)))));
            this.pic_Socket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Socket.Image = ((System.Drawing.Image)(resources.GetObject("pic_Socket.Image")));
            this.pic_Socket.Location = new System.Drawing.Point(429, 227);
            this.pic_Socket.Name = "pic_Socket";
            this.pic_Socket.Size = new System.Drawing.Size(86, 75);
            this.pic_Socket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Socket.TabIndex = 40;
            this.pic_Socket.TabStop = false;
            this.pic_Socket.Visible = false;
            this.pic_Socket.Click += new System.EventHandler(this.pic_Socket_Click);
            // 
            // pic_Ram
            // 
            this.pic_Ram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(58)))), ((int)(((byte)(160)))));
            this.pic_Ram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Ram.Image = ((System.Drawing.Image)(resources.GetObject("pic_Ram.Image")));
            this.pic_Ram.Location = new System.Drawing.Point(544, 147);
            this.pic_Ram.Name = "pic_Ram";
            this.pic_Ram.Size = new System.Drawing.Size(57, 226);
            this.pic_Ram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Ram.TabIndex = 42;
            this.pic_Ram.TabStop = false;
            this.pic_Ram.Visible = false;
            this.pic_Ram.Click += new System.EventHandler(this.pic_Ram_Click);
            // 
            // pic_PCIE
            // 
            this.pic_PCIE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(58)))), ((int)(((byte)(160)))));
            this.pic_PCIE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_PCIE.Image = ((System.Drawing.Image)(resources.GetObject("pic_PCIE.Image")));
            this.pic_PCIE.Location = new System.Drawing.Point(320, 384);
            this.pic_PCIE.Name = "pic_PCIE";
            this.pic_PCIE.Size = new System.Drawing.Size(165, 25);
            this.pic_PCIE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_PCIE.TabIndex = 43;
            this.pic_PCIE.TabStop = false;
            this.pic_PCIE.Visible = false;
            this.pic_PCIE.Click += new System.EventHandler(this.pic_PCIE_Click);
            // 
            // pic_PCIE2
            // 
            this.pic_PCIE2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(58)))), ((int)(((byte)(160)))));
            this.pic_PCIE2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_PCIE2.Image = ((System.Drawing.Image)(resources.GetObject("pic_PCIE2.Image")));
            this.pic_PCIE2.Location = new System.Drawing.Point(320, 480);
            this.pic_PCIE2.Name = "pic_PCIE2";
            this.pic_PCIE2.Size = new System.Drawing.Size(165, 25);
            this.pic_PCIE2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_PCIE2.TabIndex = 44;
            this.pic_PCIE2.TabStop = false;
            this.pic_PCIE2.Visible = false;
            this.pic_PCIE2.Click += new System.EventHandler(this.pic_PCIE2_Click);
            // 
            // pic_NB
            // 
            this.pic_NB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(58)))), ((int)(((byte)(160)))));
            this.pic_NB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_NB.Image = ((System.Drawing.Image)(resources.GetObject("pic_NB.Image")));
            this.pic_NB.Location = new System.Drawing.Point(489, 399);
            this.pic_NB.Name = "pic_NB";
            this.pic_NB.Size = new System.Drawing.Size(104, 99);
            this.pic_NB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_NB.TabIndex = 45;
            this.pic_NB.TabStop = false;
            this.pic_NB.Visible = false;
            this.pic_NB.Click += new System.EventHandler(this.pic_NB_Click);
            // 
            // pic_MBPower
            // 
            this.pic_MBPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(58)))), ((int)(((byte)(160)))));
            this.pic_MBPower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_MBPower.Image = ((System.Drawing.Image)(resources.GetObject("pic_MBPower.Image")));
            this.pic_MBPower.Location = new System.Drawing.Point(612, 232);
            this.pic_MBPower.Name = "pic_MBPower";
            this.pic_MBPower.Size = new System.Drawing.Size(19, 84);
            this.pic_MBPower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_MBPower.TabIndex = 46;
            this.pic_MBPower.TabStop = false;
            this.pic_MBPower.Visible = false;
            this.pic_MBPower.Click += new System.EventHandler(this.pic_MBPower_Click);
            // 
            // NB_PR
            // 
            this.NB_PR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.NB_PR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NB_PR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NB_PR.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.NB_PR.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NB_PR.Location = new System.Drawing.Point(870, 245);
            this.NB_PR.Name = "NB_PR";
            this.NB_PR.Size = new System.Drawing.Size(200, 70);
            this.NB_PR.TabIndex = 47;
            this.NB_PR.Text = "Чипсет";
            this.NB_PR.UseVisualStyleBackColor = false;
            this.NB_PR.Visible = false;
            this.NB_PR.Click += new System.EventHandler(this.NB_PR_Click);
            // 
            // pic_SATA
            // 
            this.pic_SATA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(58)))), ((int)(((byte)(160)))));
            this.pic_SATA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_SATA.Image = ((System.Drawing.Image)(resources.GetObject("pic_SATA.Image")));
            this.pic_SATA.Location = new System.Drawing.Point(606, 379);
            this.pic_SATA.Name = "pic_SATA";
            this.pic_SATA.Size = new System.Drawing.Size(27, 79);
            this.pic_SATA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_SATA.TabIndex = 48;
            this.pic_SATA.TabStop = false;
            this.pic_SATA.Visible = false;
            this.pic_SATA.Click += new System.EventHandler(this.pic_SATA_Click);
            // 
            // pic_CPUPower
            // 
            this.pic_CPUPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(58)))), ((int)(((byte)(160)))));
            this.pic_CPUPower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_CPUPower.Image = ((System.Drawing.Image)(resources.GetObject("pic_CPUPower.Image")));
            this.pic_CPUPower.Location = new System.Drawing.Point(322, 117);
            this.pic_CPUPower.Name = "pic_CPUPower";
            this.pic_CPUPower.Size = new System.Drawing.Size(30, 19);
            this.pic_CPUPower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_CPUPower.TabIndex = 49;
            this.pic_CPUPower.TabStop = false;
            this.pic_CPUPower.Visible = false;
            this.pic_CPUPower.Click += new System.EventHandler(this.pic_CPUPower_Click);
            // 
            // panel_Good
            // 
            this.panel_Good.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(58)))), ((int)(((byte)(160)))));
            this.panel_Good.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_Good.Location = new System.Drawing.Point(766, 414);
            this.panel_Good.Name = "panel_Good";
            this.panel_Good.Size = new System.Drawing.Size(304, 25);
            this.panel_Good.TabIndex = 32;
            this.panel_Good.Visible = false;
            // 
            // panel_Bad
            // 
            this.panel_Bad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(18)))), ((int)(((byte)(78)))));
            this.panel_Bad.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_Bad.Location = new System.Drawing.Point(766, 445);
            this.panel_Bad.Name = "panel_Bad";
            this.panel_Bad.Size = new System.Drawing.Size(304, 25);
            this.panel_Bad.TabIndex = 31;
            this.panel_Bad.Visible = false;
            // 
            // label_True
            // 
            this.label_True.AutoSize = true;
            this.label_True.BackColor = System.Drawing.Color.Transparent;
            this.label_True.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_True.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_True.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_True.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_True.Location = new System.Drawing.Point(665, 414);
            this.label_True.Name = "label_True";
            this.label_True.Size = new System.Drawing.Size(71, 25);
            this.label_True.TabIndex = 50;
            this.label_True.Text = "Верно";
            this.label_True.Visible = false;
            // 
            // label_False
            // 
            this.label_False.AutoSize = true;
            this.label_False.BackColor = System.Drawing.Color.Transparent;
            this.label_False.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_False.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_False.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_False.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_False.Location = new System.Drawing.Point(665, 445);
            this.label_False.Name = "label_False";
            this.label_False.Size = new System.Drawing.Size(96, 25);
            this.label_False.TabIndex = 51;
            this.label_False.Text = "Неверно";
            this.label_False.Visible = false;
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.Result.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Result.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.Result.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Result.Location = new System.Drawing.Point(664, 532);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(406, 41);
            this.Result.TabIndex = 52;
            this.Result.Text = "Узнать результат";
            this.Result.UseVisualStyleBackColor = false;
            this.Result.Visible = false;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // timer3
            // 
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label_Score
            // 
            this.label_Score.AutoSize = true;
            this.label_Score.BackColor = System.Drawing.Color.Transparent;
            this.label_Score.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label_Score.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Score.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_Score.Location = new System.Drawing.Point(785, 489);
            this.label_Score.Name = "label_Score";
            this.label_Score.Size = new System.Drawing.Size(108, 25);
            this.label_Score.TabIndex = 53;
            this.label_Score.Text = "Ваш балл:";
            this.label_Score.Visible = false;
            // 
            // timer4
            // 
            this.timer4.Interval = 1;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // pic_VRM1
            // 
            this.pic_VRM1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(58)))), ((int)(((byte)(160)))));
            this.pic_VRM1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_VRM1.Image = ((System.Drawing.Image)(resources.GetObject("pic_VRM1.Image")));
            this.pic_VRM1.Location = new System.Drawing.Point(277, 139);
            this.pic_VRM1.Name = "pic_VRM1";
            this.pic_VRM1.Size = new System.Drawing.Size(132, 167);
            this.pic_VRM1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_VRM1.TabIndex = 54;
            this.pic_VRM1.TabStop = false;
            this.pic_VRM1.Visible = false;
            this.pic_VRM1.Click += new System.EventHandler(this.pic_VRM1_Click);
            // 
            // VRM
            // 
            this.VRM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.VRM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VRM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VRM.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.VRM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.VRM.Location = new System.Drawing.Point(870, 321);
            this.VRM.Name = "VRM";
            this.VRM.Size = new System.Drawing.Size(200, 70);
            this.VRM.TabIndex = 55;
            this.VRM.Text = "VRM";
            this.VRM.UseVisualStyleBackColor = false;
            this.VRM.Visible = false;
            this.VRM.Click += new System.EventHandler(this.VRM_Click);
            // 
            // Rules_text
            // 
            this.Rules_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.Rules_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rules_text.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Rules_text.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rules_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Rules_text.Location = new System.Drawing.Point(12, 333);
            this.Rules_text.Name = "Rules_text";
            this.Rules_text.ReadOnly = true;
            this.Rules_text.Size = new System.Drawing.Size(200, 253);
            this.Rules_text.TabIndex = 56;
            this.Rules_text.Text = "";
            this.Rules_text.Visible = false;
            // 
            // label_About
            // 
            this.label_About.AutoSize = true;
            this.label_About.BackColor = System.Drawing.Color.Transparent;
            this.label_About.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_About.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_About.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_About.Location = new System.Drawing.Point(1246, 683);
            this.label_About.Name = "label_About";
            this.label_About.Size = new System.Drawing.Size(22, 28);
            this.label_About.TabIndex = 57;
            this.label_About.Text = "?";
            this.label_About.Visible = false;
            this.label_About.Click += new System.EventHandler(this.label_About_Click);
            // 
            // Rate_label
            // 
            this.Rate_label.AutoSize = true;
            this.Rate_label.BackColor = System.Drawing.Color.Transparent;
            this.Rate_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rate_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rate_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rate_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Rate_label.Location = new System.Drawing.Point(204, 42);
            this.Rate_label.Name = "Rate_label";
            this.Rate_label.Size = new System.Drawing.Size(88, 25);
            this.Rate_label.TabIndex = 58;
            this.Rate_label.Text = "Рейтинг";
            this.Rate_label.Visible = false;
            this.Rate_label.Click += new System.EventHandler(this.Rate_label_Click);
            // 
            // Rate_DataGrid
            // 
            this.Rate_DataGrid.AllowUserToResizeColumns = false;
            this.Rate_DataGrid.AllowUserToResizeRows = false;
            this.Rate_DataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.Rate_DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rate_DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Rate_DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Rate_DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Rate_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Rate_DataGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Rate_DataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.Rate_DataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.Rate_DataGrid.Location = new System.Drawing.Point(12, 122);
            this.Rate_DataGrid.Name = "Rate_DataGrid";
            this.Rate_DataGrid.ReadOnly = true;
            this.Rate_DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Rate_DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Rate_DataGrid.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Rate_DataGrid.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.Rate_DataGrid.Size = new System.Drawing.Size(200, 420);
            this.Rate_DataGrid.TabIndex = 59;
            this.Rate_DataGrid.Visible = false;
            // 
            // Nick_label
            // 
            this.Nick_label.AutoSize = true;
            this.Nick_label.BackColor = System.Drawing.Color.Transparent;
            this.Nick_label.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Nick_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nick_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nick_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Nick_label.Location = new System.Drawing.Point(12, 92);
            this.Nick_label.Name = "Nick_label";
            this.Nick_label.Size = new System.Drawing.Size(99, 25);
            this.Nick_label.TabIndex = 60;
            this.Nick_label.Text = "Никнейм";
            this.Nick_label.Visible = false;
            // 
            // Score_label
            // 
            this.Score_label.AutoSize = true;
            this.Score_label.BackColor = System.Drawing.Color.Transparent;
            this.Score_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.Score_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Score_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Score_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Score_label.Location = new System.Drawing.Point(116, 92);
            this.Score_label.Name = "Score_label";
            this.Score_label.Size = new System.Drawing.Size(61, 25);
            this.Score_label.TabIndex = 61;
            this.Score_label.Text = "Очки";
            this.Score_label.Visible = false;
            // 
            // panel_Color2
            // 
            this.panel_Color2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(58)))), ((int)(((byte)(160)))));
            this.panel_Color2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_Color2.Location = new System.Drawing.Point(158, 695);
            this.panel_Color2.Name = "panel_Color2";
            this.panel_Color2.Size = new System.Drawing.Size(134, 25);
            this.panel_Color2.TabIndex = 33;
            this.panel_Color2.Visible = false;
            this.panel_Color2.Click += new System.EventHandler(this.panel_Color2_Click);
            // 
            // panel_Color1
            // 
            this.panel_Color1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(18)))), ((int)(((byte)(78)))));
            this.panel_Color1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_Color1.Location = new System.Drawing.Point(158, 660);
            this.panel_Color1.Name = "panel_Color1";
            this.panel_Color1.Size = new System.Drawing.Size(134, 25);
            this.panel_Color1.TabIndex = 32;
            this.panel_Color1.Visible = false;
            this.panel_Color1.Click += new System.EventHandler(this.panel_Color1_Click);
            // 
            // Update_button
            // 
            this.Update_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.Update_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Update_button.FlatAppearance.BorderSize = 0;
            this.Update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_button.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.Update_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Update_button.Location = new System.Drawing.Point(12, 548);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(200, 38);
            this.Update_button.TabIndex = 77;
            this.Update_button.Text = "Обновить";
            this.Update_button.UseVisualStyleBackColor = false;
            this.Update_button.Visible = false;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // Send_Mail
            // 
            this.Send_Mail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.Send_Mail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Send_Mail.FlatAppearance.BorderSize = 0;
            this.Send_Mail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Send_Mail.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.Send_Mail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Send_Mail.Location = new System.Drawing.Point(664, 545);
            this.Send_Mail.Name = "Send_Mail";
            this.Send_Mail.Size = new System.Drawing.Size(448, 41);
            this.Send_Mail.TabIndex = 78;
            this.Send_Mail.Text = "Отправить на почту";
            this.Send_Mail.UseVisualStyleBackColor = false;
            this.Send_Mail.Visible = false;
            this.Send_Mail.Click += new System.EventHandler(this.Send_Mail_Click);
            // 
            // Mail_text
            // 
            this.Mail_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.Mail_text.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mail_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Mail_text.Location = new System.Drawing.Point(822, 592);
            this.Mail_text.Name = "Mail_text";
            this.Mail_text.Size = new System.Drawing.Size(290, 29);
            this.Mail_text.TabIndex = 84;
            this.Mail_text.Visible = false;
            // 
            // Mail_label
            // 
            this.Mail_label.AutoSize = true;
            this.Mail_label.BackColor = System.Drawing.Color.Transparent;
            this.Mail_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Mail_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mail_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mail_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Mail_label.Location = new System.Drawing.Point(665, 592);
            this.Mail_label.Name = "Mail_label";
            this.Mail_label.Size = new System.Drawing.Size(150, 25);
            this.Mail_label.TabIndex = 83;
            this.Mail_label.Text = "Введите почту";
            this.Mail_label.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.Mail_text);
            this.Controls.Add(this.Mail_label);
            this.Controls.Add(this.Send_Mail);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.panel_Color1);
            this.Controls.Add(this.panel_Color2);
            this.Controls.Add(this.Score_label);
            this.Controls.Add(this.Nick_label);
            this.Controls.Add(this.Rate_DataGrid);
            this.Controls.Add(this.Rate_label);
            this.Controls.Add(this.label_About);
            this.Controls.Add(this.Rules_text);
            this.Controls.Add(this.VRM);
            this.Controls.Add(this.pic_VRM1);
            this.Controls.Add(this.label_Score);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label_False);
            this.Controls.Add(this.label_True);
            this.Controls.Add(this.panel_Good);
            this.Controls.Add(this.pic_CPUPower);
            this.Controls.Add(this.panel_Bad);
            this.Controls.Add(this.pic_SATA);
            this.Controls.Add(this.NB_PR);
            this.Controls.Add(this.pic_MBPower);
            this.Controls.Add(this.pic_NB);
            this.Controls.Add(this.pic_PCIE2);
            this.Controls.Add(this.pic_PCIE);
            this.Controls.Add(this.pic_Ram);
            this.Controls.Add(this.pic_Socket);
            this.Controls.Add(this.SATA_PR);
            this.Controls.Add(this.pin8);
            this.Controls.Add(this.pin24);
            this.Controls.Add(this.RAM_PR);
            this.Controls.Add(this.PCI_PR);
            this.Controls.Add(this.Socket_PR);
            this.Controls.Add(this.button_RAM);
            this.Controls.Add(this.button_MB);
            this.Controls.Add(this.button_CPU);
            this.Controls.Add(this.Theory_pic);
            this.Controls.Add(this.panel_Color);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Theory_Text);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.label_Pract);
            this.Controls.Add(this.label_Theory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitlePanel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).EndInit();
            this.panel_Color.ResumeLayout(false);
            this.panel_Color.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Theory_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Socket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PCIE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PCIE2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_NB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MBPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SATA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CPUPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_VRM1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rate_DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.Label Win_name;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label_Theory;
        private System.Windows.Forms.Label label_Pract;
        public System.Windows.Forms.Label label_Login;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox Theory_Text;
        private System.Windows.Forms.PictureBox Settings;
        private System.Windows.Forms.Panel panel_Color;
        private System.Windows.Forms.Label label_Color;
        private System.Windows.Forms.PictureBox Theory_pic;
        private System.Windows.Forms.Button button_CPU;
        private System.Windows.Forms.Button button_MB;
        private System.Windows.Forms.Button button_RAM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Socket_PR;
        private System.Windows.Forms.Button PCI_PR;
        private System.Windows.Forms.Button RAM_PR;
        private System.Windows.Forms.Button pin24;
        private System.Windows.Forms.Button pin8;
        private System.Windows.Forms.Button SATA_PR;
        private System.Windows.Forms.PictureBox pic_Socket;
        private System.Windows.Forms.PictureBox pic_Ram;
        private System.Windows.Forms.PictureBox pic_PCIE;
        private System.Windows.Forms.PictureBox pic_PCIE2;
        private System.Windows.Forms.PictureBox pic_NB;
        private System.Windows.Forms.PictureBox pic_MBPower;
        private System.Windows.Forms.Button NB_PR;
        private System.Windows.Forms.PictureBox pic_SATA;
        private System.Windows.Forms.PictureBox pic_CPUPower;
        private System.Windows.Forms.Panel panel_Good;
        private System.Windows.Forms.Panel panel_Bad;
        public System.Windows.Forms.Label label_True;
        public System.Windows.Forms.Label label_False;
        private System.Windows.Forms.Button Result;
        private System.Windows.Forms.Timer timer3;
        public System.Windows.Forms.Label label_Score;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.PictureBox pic_VRM1;
        private System.Windows.Forms.Button VRM;
        private System.Windows.Forms.RichTextBox Rules_text;
        private System.Windows.Forms.Label label_About;
        private System.Windows.Forms.Label Rate_label;
        private System.Windows.Forms.DataGridView Rate_DataGrid;
        private System.Windows.Forms.Label Nick_label;
        private System.Windows.Forms.Label Score_label;
        private System.Windows.Forms.Panel panel_Color2;
        private System.Windows.Forms.Panel panel_Color1;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Send_Mail;
        private System.Windows.Forms.TextBox Mail_text;
        private System.Windows.Forms.Label Mail_label;
    }
}