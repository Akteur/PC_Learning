namespace PC_Builder
{
    partial class Authorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.Label();
            this.Win_name = new System.Windows.Forms.Label();
            this.Login_label = new System.Windows.Forms.Label();
            this.Pass_label = new System.Windows.Forms.Label();
            this.Login_textbox = new System.Windows.Forms.TextBox();
            this.Pass_textbox = new System.Windows.Forms.TextBox();
            this.Login_button = new System.Windows.Forms.Button();
            this.Create_Acc_button = new System.Windows.Forms.Button();
            this.Log_return_label = new System.Windows.Forms.Label();
            this.Reg_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(18)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.Win_name);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 40);
            this.panel1.TabIndex = 0;
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
            this.Close.Location = new System.Drawing.Point(405, 10);
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
            this.Win_name.Size = new System.Drawing.Size(129, 24);
            this.Win_name.TabIndex = 0;
            this.Win_name.Text = "Авторизация";
            // 
            // Login_label
            // 
            this.Login_label.AutoSize = true;
            this.Login_label.BackColor = System.Drawing.Color.Transparent;
            this.Login_label.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Login_label.Location = new System.Drawing.Point(81, 132);
            this.Login_label.Name = "Login_label";
            this.Login_label.Size = new System.Drawing.Size(48, 19);
            this.Login_label.TabIndex = 1;
            this.Login_label.Text = "Логин";
            // 
            // Pass_label
            // 
            this.Pass_label.AutoSize = true;
            this.Pass_label.BackColor = System.Drawing.Color.Transparent;
            this.Pass_label.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Pass_label.Location = new System.Drawing.Point(81, 179);
            this.Pass_label.Name = "Pass_label";
            this.Pass_label.Size = new System.Drawing.Size(57, 19);
            this.Pass_label.TabIndex = 2;
            this.Pass_label.Text = "Пароль";
            // 
            // Login_textbox
            // 
            this.Login_textbox.BackColor = System.Drawing.SystemColors.Window;
            this.Login_textbox.Location = new System.Drawing.Point(154, 133);
            this.Login_textbox.MaxLength = 8;
            this.Login_textbox.Name = "Login_textbox";
            this.Login_textbox.Size = new System.Drawing.Size(199, 20);
            this.Login_textbox.TabIndex = 3;
            this.Login_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_textbox_KeyDown);
            // 
            // Pass_textbox
            // 
            this.Pass_textbox.Location = new System.Drawing.Point(154, 180);
            this.Pass_textbox.Name = "Pass_textbox";
            this.Pass_textbox.PasswordChar = '*';
            this.Pass_textbox.Size = new System.Drawing.Size(199, 20);
            this.Pass_textbox.TabIndex = 4;
            this.Pass_textbox.UseSystemPasswordChar = true;
            this.Pass_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pass_textbox_KeyDown);
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.Login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_button.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.Login_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Login_button.Location = new System.Drawing.Point(84, 232);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(125, 23);
            this.Login_button.TabIndex = 5;
            this.Login_button.Text = "Вход";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // Create_Acc_button
            // 
            this.Create_Acc_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.Create_Acc_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Create_Acc_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Create_Acc_button.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.Create_Acc_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Create_Acc_button.Location = new System.Drawing.Point(230, 232);
            this.Create_Acc_button.Name = "Create_Acc_button";
            this.Create_Acc_button.Size = new System.Drawing.Size(125, 23);
            this.Create_Acc_button.TabIndex = 6;
            this.Create_Acc_button.Text = "Создать аккаунт";
            this.Create_Acc_button.UseVisualStyleBackColor = false;
            this.Create_Acc_button.Click += new System.EventHandler(this.Reg_Click);
            // 
            // Log_return_label
            // 
            this.Log_return_label.AutoSize = true;
            this.Log_return_label.BackColor = System.Drawing.Color.Transparent;
            this.Log_return_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Log_return_label.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Log_return_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Log_return_label.Location = new System.Drawing.Point(167, 335);
            this.Log_return_label.Name = "Log_return_label";
            this.Log_return_label.Size = new System.Drawing.Size(115, 19);
            this.Log_return_label.TabIndex = 7;
            this.Log_return_label.Text = "Войти в систему";
            this.Log_return_label.Visible = false;
            this.Log_return_label.Click += new System.EventHandler(this.Log_return_label_Click);
            // 
            // Reg_button
            // 
            this.Reg_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.Reg_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reg_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reg_button.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.Reg_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Reg_button.Location = new System.Drawing.Point(84, 232);
            this.Reg_button.Name = "Reg_button";
            this.Reg_button.Size = new System.Drawing.Size(271, 23);
            this.Reg_button.TabIndex = 8;
            this.Reg_button.Text = "Регистрация";
            this.Reg_button.UseVisualStyleBackColor = false;
            this.Reg_button.Visible = false;
            this.Reg_button.Click += new System.EventHandler(this.Reg_button_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(440, 394);
            this.Controls.Add(this.Reg_button);
            this.Controls.Add(this.Log_return_label);
            this.Controls.Add(this.Create_Acc_button);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.Pass_textbox);
            this.Controls.Add(this.Login_textbox);
            this.Controls.Add(this.Pass_label);
            this.Controls.Add(this.Login_label);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PC Builder";
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Win_name;
        private System.Windows.Forms.Label Login_label;
        private System.Windows.Forms.Label Pass_label;
        private System.Windows.Forms.TextBox Login_textbox;
        private System.Windows.Forms.TextBox Pass_textbox;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Button Create_Acc_button;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.Label Log_return_label;
        private System.Windows.Forms.Button Reg_button;
    }
}

