namespace PC_Builder
{
    partial class MyMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyMessage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Msg_name = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Label();
            this.Msg_label = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(18)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.Msg_name);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 40);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // Msg_name
            // 
            this.Msg_name.AutoSize = true;
            this.Msg_name.BackColor = System.Drawing.Color.Transparent;
            this.Msg_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Msg_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Msg_name.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Msg_name.Location = new System.Drawing.Point(15, 13);
            this.Msg_name.Name = "Msg_name";
            this.Msg_name.Size = new System.Drawing.Size(100, 24);
            this.Msg_name.TabIndex = 2;
            this.Msg_name.Text = "Внимание";
            // 
            // Close
            // 
            this.Close.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Close.Location = new System.Drawing.Point(216, 11);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(25, 24);
            this.Close.TabIndex = 2;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Msg_label
            // 
            this.Msg_label.AutoSize = true;
            this.Msg_label.BackColor = System.Drawing.Color.Transparent;
            this.Msg_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Msg_label.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Msg_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Msg_label.Location = new System.Drawing.Point(47, 63);
            this.Msg_label.Margin = new System.Windows.Forms.Padding(3, 0, 50, 0);
            this.Msg_label.Name = "Msg_label";
            this.Msg_label.Size = new System.Drawing.Size(164, 25);
            this.Msg_label.TabIndex = 1;
            this.Msg_label.Text = "Аккаунт создан!";
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.buttonOK.FlatAppearance.BorderSize = 0;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.buttonOK.Location = new System.Drawing.Point(85, 115);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // MyMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(250, 160);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.Msg_label);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Msg_name;
        private System.Windows.Forms.Label Close;
        public System.Windows.Forms.Label Msg_label;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button buttonOK;
    }
}