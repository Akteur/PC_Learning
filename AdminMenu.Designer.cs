namespace PC_Builder
{
    partial class AdminMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.Label();
            this.Win_name = new System.Windows.Forms.Label();
            this.User_DataGrid = new System.Windows.Forms.DataGridView();
            this.Load_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.File_comboBox = new System.Windows.Forms.ComboBox();
            this.label_Help = new System.Windows.Forms.Label();
            this.File_textBox = new System.Windows.Forms.TextBox();
            this.Theory_redact_button = new System.Windows.Forms.Button();
            this.User_redact_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.User_DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(18)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.Win_name);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 40);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Close.Location = new System.Drawing.Point(764, 10);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(25, 24);
            this.Close.TabIndex = 1;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Win_name
            // 
            this.Win_name.AutoSize = true;
            this.Win_name.BackColor = System.Drawing.Color.Transparent;
            this.Win_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Win_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Win_name.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Win_name.Location = new System.Drawing.Point(13, 10);
            this.Win_name.Name = "Win_name";
            this.Win_name.Size = new System.Drawing.Size(134, 24);
            this.Win_name.TabIndex = 0;
            this.Win_name.Text = "Меню админа";
            // 
            // User_DataGrid
            // 
            this.User_DataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.User_DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.User_DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.User_DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.User_DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.User_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.User_DataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.User_DataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.User_DataGrid.Location = new System.Drawing.Point(16, 45);
            this.User_DataGrid.Name = "User_DataGrid";
            this.User_DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.User_DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.User_DataGrid.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.User_DataGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.User_DataGrid.Size = new System.Drawing.Size(400, 349);
            this.User_DataGrid.TabIndex = 60;
            this.User_DataGrid.Visible = false;
            // 
            // Load_button
            // 
            this.Load_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.Load_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Load_button.FlatAppearance.BorderSize = 0;
            this.Load_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Load_button.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.Load_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Load_button.Location = new System.Drawing.Point(422, 400);
            this.Load_button.Name = "Load_button";
            this.Load_button.Size = new System.Drawing.Size(366, 38);
            this.Load_button.TabIndex = 61;
            this.Load_button.Text = "Загрузить";
            this.Load_button.UseVisualStyleBackColor = false;
            this.Load_button.Visible = false;
            this.Load_button.Click += new System.EventHandler(this.Load_button_Click);
            // 
            // Save_button
            // 
            this.Save_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.Save_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_button.FlatAppearance.BorderSize = 0;
            this.Save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_button.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.Save_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Save_button.Location = new System.Drawing.Point(16, 400);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(400, 38);
            this.Save_button.TabIndex = 62;
            this.Save_button.Text = "Сохранить изменения";
            this.Save_button.UseVisualStyleBackColor = false;
            this.Save_button.Visible = false;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // File_comboBox
            // 
            this.File_comboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.File_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.File_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.File_comboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.File_comboBox.FormattingEnabled = true;
            this.File_comboBox.Items.AddRange(new object[] {
            "Процессор",
            "Материнская плата",
            "Оперативная память",
            "Сокет",
            "Чипсет",
            "Слоты для ОЗУ",
            "Слоты PCI",
            "Слоты SATA",
            "Зона VRM",
            "8-pin питание для процессора",
            "24-pin для материнской платы"});
            this.File_comboBox.Location = new System.Drawing.Point(422, 165);
            this.File_comboBox.Name = "File_comboBox";
            this.File_comboBox.Size = new System.Drawing.Size(366, 28);
            this.File_comboBox.TabIndex = 67;
            this.File_comboBox.Visible = false;
            // 
            // label_Help
            // 
            this.label_Help.AutoSize = true;
            this.label_Help.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Help.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label_Help.Location = new System.Drawing.Point(418, 143);
            this.label_Help.Name = "label_Help";
            this.label_Help.Size = new System.Drawing.Size(337, 19);
            this.label_Help.TabIndex = 68;
            this.label_Help.Text = "Выберите раздел который хотите отредактировать";
            this.label_Help.Visible = false;
            // 
            // File_textBox
            // 
            this.File_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.File_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.File_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.File_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.File_textBox.Location = new System.Drawing.Point(16, 45);
            this.File_textBox.Multiline = true;
            this.File_textBox.Name = "File_textBox";
            this.File_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.File_textBox.Size = new System.Drawing.Size(400, 349);
            this.File_textBox.TabIndex = 69;
            this.File_textBox.Visible = false;
            // 
            // Theory_redact_button
            // 
            this.Theory_redact_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.Theory_redact_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Theory_redact_button.FlatAppearance.BorderSize = 0;
            this.Theory_redact_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Theory_redact_button.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.Theory_redact_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Theory_redact_button.Location = new System.Drawing.Point(422, 89);
            this.Theory_redact_button.Name = "Theory_redact_button";
            this.Theory_redact_button.Size = new System.Drawing.Size(366, 38);
            this.Theory_redact_button.TabIndex = 70;
            this.Theory_redact_button.Text = "Редактировать теорию";
            this.Theory_redact_button.UseVisualStyleBackColor = false;
            this.Theory_redact_button.Click += new System.EventHandler(this.Theory_redact_button_Click);
            // 
            // User_redact_button
            // 
            this.User_redact_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.User_redact_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.User_redact_button.FlatAppearance.BorderSize = 0;
            this.User_redact_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.User_redact_button.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.User_redact_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.User_redact_button.Location = new System.Drawing.Point(422, 45);
            this.User_redact_button.Name = "User_redact_button";
            this.User_redact_button.Size = new System.Drawing.Size(366, 38);
            this.User_redact_button.TabIndex = 71;
            this.User_redact_button.Text = "Редактировать пользователей";
            this.User_redact_button.UseVisualStyleBackColor = false;
            this.User_redact_button.Click += new System.EventHandler(this.User_redact_button_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.User_redact_button);
            this.Controls.Add(this.Theory_redact_button);
            this.Controls.Add(this.File_textBox);
            this.Controls.Add(this.label_Help);
            this.Controls.Add(this.File_comboBox);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Load_button);
            this.Controls.Add(this.User_DataGrid);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.User_DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.Label Win_name;
        private System.Windows.Forms.DataGridView User_DataGrid;
        private System.Windows.Forms.Button Load_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.ComboBox File_comboBox;
        private System.Windows.Forms.Label label_Help;
        private System.Windows.Forms.TextBox File_textBox;
        private System.Windows.Forms.Button Theory_redact_button;
        private System.Windows.Forms.Button User_redact_button;
    }
}