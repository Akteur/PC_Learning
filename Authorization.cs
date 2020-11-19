using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace PC_Builder
{
    public partial class Authorization : Form
    {
        private SQLiteConnection DB;
        MainForm mf;
        public Authorization(MainForm mf)
        { 
            InitializeComponent();
            this.mf = mf;
        }
        private void auth_reg(bool check)
        {
            if (check)
            {
                
                Win_name.Text = "Авторизация";
                Login_button.Visible = true;
                Create_Acc_button.Visible = true;
                Reg_button.Visible = false;
                Log_return_label.Visible = false;
            }
            else
            {
                Win_name.Text = "Регистрация";
                Login_button.Visible = false;
                Create_Acc_button.Visible = false;
                Reg_button.Visible = true;
                Log_return_label.Visible = true;
            }
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
        private void Reg_Click(object sender, EventArgs e)
        {
            auth_reg(false);
        }
        private void Log_return_label_Click(object sender, EventArgs e)
        {
            auth_reg(true);
        }
        private void Reg_button_Click(object sender, EventArgs e)
        {
            MyMessage msg = new MyMessage();
            DB = new SQLiteConnection("Data source=DB\\Users.db");
            DB.Open();
            if (chkUser()) return;
            if (Login_textbox.Text == "" && Pass_textbox.Text == "")
            {
                msg.AutoSize = true;
                msg.Msg_label.Font = new Font("Microsoft YaHei", 10);
                msg.Msg_label.Text = "Поля \"Логин\" и \"Пароль\" не могут быть пустыми";
            }
            else
            {
                SQLiteCommand cmd = DB.CreateCommand();
                cmd.CommandText = "select * from Users where Login = @log";
                cmd.Parameters.Add("@log", DbType.String).Value = Login_textbox.Text;
                SQLiteDataReader SQL = cmd.ExecuteReader();
                if (SQL.HasRows)
                {
                    msg.AutoSize = true;
                    msg.Msg_label.Text = "Аккаунт с таким именем уже существует!";
                    Login_textbox.Text = "";
                    Pass_textbox.Text = "";
                }
                else
                {
                    SQLiteCommand command = DB.CreateCommand();
                    command.CommandText = "INSERT INTO Users(Login, Password, Score) VALUES(@login, @pass, 0)";
                    command.Parameters.Add("@login", System.Data.DbType.String).Value = Login_textbox.Text;
                    command.Parameters.Add("@pass", System.Data.DbType.String).Value = Pass_textbox.Text;
                    command.ExecuteNonQuery();
                    msg.buttonOK.Size = new Size(75, 23);
                    msg.panel1.Size = new Size(257, 44);
                    msg.Msg_label.Size = new Size(164, 25);
                    msg.Size = new Size(250, 160);
                    msg.Msg_label.Text = "Аккаунт создан!";
                    Login_textbox.Text = "";
                    Pass_textbox.Text = "";

                }
            }
            DB.Close();

            msg.Owner = this;
            msg.ShowDialog();
            auth_reg(true);
        }
        public Boolean chkUser()
        {
            MyMessage msg = new MyMessage();
            SQLiteCommand command = DB.CreateCommand();
            command.CommandText = "select * from Users where Login like @login";
            command.Parameters.Add("@login", DbType.String).Value = Login_textbox.Text;
            SQLiteDataReader SQL = command.ExecuteReader();
            if (SQL.HasRows)
            {
                msg.AutoSize = true;
                msg.Msg_label.Text = "Пользователь с таким именем уже существует!";
                msg.ShowDialog();
                return true;
            }
            else
            {
                return false;
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            panel1.Capture = false;
            Message m = Message.Create(this.Handle, 161, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
        private void Login_button_Click(object sender, EventArgs e)
        {
            MyMessage msg = new MyMessage();
            msg.AutoSize = true;
            DB = new SQLiteConnection("Data source=DB\\Users.db");
            DB.Open();
            SQLiteCommand command = DB.CreateCommand();
            command.CommandText = "select id from Users where Login like @login and Password like @pass";
            command.Parameters.Add("@login", DbType.String).Value = Login_textbox.Text;
            command.Parameters.Add("@pass", DbType.String).Value = Pass_textbox.Text;
            SQLiteDataReader SQL = command.ExecuteReader();
            if(Login_textbox.Text == "admin" && Pass_textbox.Text == "admin")
            {
                AdminMenu admin = new AdminMenu(mf);
                mf.WindowState = FormWindowState.Minimized;
                admin.Show();
                this.Close();                
            }
            else if (SQL.HasRows)
            {
                msg.Msg_label.Text = "Вход проведен успешно!";
                mf.label_Login.Text = Login_textbox.Text;
                mf.label7.Visible = true;
                msg.ShowDialog();
                this.Close();
            }
            else
            {
                msg.Msg_label.Text = "Введены неверные данные!";
                msg.ShowDialog();
            }
            DB.Close();            
        }
        private void Authorization_Load(object sender, EventArgs e)
        {
            Login_button.FlatAppearance.BorderSize = 0;
            Reg_button.FlatAppearance.BorderSize = 0;
            Create_Acc_button.FlatAppearance.BorderSize = 0;
        }
        private void Login_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Login_textbox.Focused && e.KeyCode == Keys.Down)
            {
                Pass_textbox.Focus();
            }
            else if (Pass_textbox.Focused && e.KeyCode == Keys.Down)
            {
                Login_textbox.Focus();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                Login_button_Click(Login_button, EventArgs.Empty);
            }
        }
        private void Pass_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Login_textbox.Focused && e.KeyCode == Keys.Down)
            {
                Pass_textbox.Focus();
            }
            else if (Pass_textbox.Focused && e.KeyCode == Keys.Up)
            {
                Login_textbox.Focus();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                Login_button_Click(Login_button, EventArgs.Empty);
            }
        }
    }
}
