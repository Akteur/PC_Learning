namespace PC_Builder
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.Label();
            this.Win_name = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Version = new System.Windows.Forms.Label();
            this.label_Company = new System.Windows.Forms.Label();
            this.label_Dev = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Reg_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(18)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.Win_name);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 40);
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
            this.Close.Location = new System.Drawing.Point(417, 10);
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
            this.Win_name.Size = new System.Drawing.Size(130, 24);
            this.Win_name.TabIndex = 0;
            this.Win_name.Text = "О программе";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.BackColor = System.Drawing.Color.Transparent;
            this.label_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Name.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_Name.Location = new System.Drawing.Point(12, 60);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(102, 24);
            this.label_Name.TabIndex = 2;
            this.label_Name.Text = "Название:";
            // 
            // label_Version
            // 
            this.label_Version.AutoSize = true;
            this.label_Version.BackColor = System.Drawing.Color.Transparent;
            this.label_Version.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Version.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_Version.Location = new System.Drawing.Point(12, 104);
            this.label_Version.Name = "label_Version";
            this.label_Version.Size = new System.Drawing.Size(80, 24);
            this.label_Version.TabIndex = 3;
            this.label_Version.Text = "Версия:";
            // 
            // label_Company
            // 
            this.label_Company.AutoSize = true;
            this.label_Company.BackColor = System.Drawing.Color.Transparent;
            this.label_Company.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Company.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_Company.Location = new System.Drawing.Point(12, 150);
            this.label_Company.Name = "label_Company";
            this.label_Company.Size = new System.Drawing.Size(104, 24);
            this.label_Company.TabIndex = 4;
            this.label_Company.Text = "Компания:";
            // 
            // label_Dev
            // 
            this.label_Dev.AutoSize = true;
            this.label_Dev.BackColor = System.Drawing.Color.Transparent;
            this.label_Dev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Dev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Dev.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_Dev.Location = new System.Drawing.Point(12, 197);
            this.label_Dev.Name = "label_Dev";
            this.label_Dev.Size = new System.Drawing.Size(130, 24);
            this.label_Dev.TabIndex = 5;
            this.label_Dev.Text = "Разработчик:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(180, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "PC Learning";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(180, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "1.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(180, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "УО \"МГК Электроники\" 2020";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(180, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Витковский А.В.";
            // 
            // Reg_button
            // 
            this.Reg_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.Reg_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reg_button.FlatAppearance.BorderSize = 0;
            this.Reg_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reg_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reg_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Reg_button.Location = new System.Drawing.Point(90, 260);
            this.Reg_button.Name = "Reg_button";
            this.Reg_button.Size = new System.Drawing.Size(270, 30);
            this.Reg_button.TabIndex = 10;
            this.Reg_button.Text = "ОК";
            this.Reg_button.UseVisualStyleBackColor = false;
            this.Reg_button.Click += new System.EventHandler(this.Reg_button_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(450, 317);
            this.Controls.Add(this.Reg_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Dev);
            this.Controls.Add(this.label_Company);
            this.Controls.Add(this.label_Version);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.Text = "About";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.Label Win_name;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Version;
        private System.Windows.Forms.Label label_Company;
        private System.Windows.Forms.Label label_Dev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Reg_button;
    }
}