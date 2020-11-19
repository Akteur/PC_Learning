using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_Builder
{
    public partial class AdminMenu : Form
    {
        private SQLiteConnection DB;
        MainForm mf;
        string[] login;
        string[] id;
        string[] loginChanged;
        string[] pass;
        string[] score;
        bool TheoryOrUsers;
        string PathLoad = "Text\\";
        string PathSave = "Text\\";
        public AdminMenu(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
            Close.Focus();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            panel1.Capture = false;
            Message m = Message.Create(this.Handle, 161, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            mf.WindowState = FormWindowState.Normal;
            this.Close();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {            
            User_redact_button.Size = new Size(200, 80);
            Theory_redact_button.Size = new Size(200, 80);
            User_redact_button.Location = new Point(this.Size.Width / 2 - User_redact_button.Size.Width, this.Size.Height / 2 - User_redact_button.Size.Height / 2);
            Theory_redact_button.Location = new Point(this.Size.Width / 2 + 10, this.Size.Height / 2 - Theory_redact_button.Size.Height / 2);
        }

        private void Load_button_Click(object sender, EventArgs e)
        {
            if (TheoryOrUsers == false)
            {
                SQLiteConnection cnn = new SQLiteConnection("Data source=DB\\Users.db");
                SQLiteCommand cmd = new SQLiteCommand("select * from Users order by id", cnn);
                cnn.Open();
                SQLiteDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Load(dr);
                User_DataGrid.DataSource = dt;
                User_DataGrid.Visible = true;

                login = new string[User_DataGrid.RowCount];
                for (int i = 0; i < User_DataGrid.RowCount - 1; i++)
                {
                    login[i] = User_DataGrid[1, i].Value.ToString();
                }
            }
            else
            {
                switch (File_comboBox.SelectedIndex)
                {
                    case 0:
                        {
                            PathLoad += "CPU.txt";
                            PathSave += "CPU.txt";
                            break;
                        }
                    case 1:
                        {
                            PathLoad += "Motherboard.txt";
                            PathSave += "Motherboard.txt";
                            break;
                        }
                    case 2:
                        {
                            PathLoad += "RAM.txt";
                            PathSave += "RAM.txt";
                            break;
                        }
                    case 3:
                        {
                            PathLoad += "Socket.txt";
                            PathSave += "Socket.txt";
                            break;
                        }
                    case 4:
                        {
                            PathLoad += "Chipset.txt";
                            PathSave += "Chipset.txt";
                            break;
                        }
                    case 5:
                        {
                            PathLoad += "RAM_Slots.txt";
                            PathSave += "RAM_Slots.txt";
                            break;
                        }
                    case 6:
                        {
                            PathLoad += "PCI_Slots.txt";
                            PathSave += "PCI_Slots.txt";
                            break;
                        }
                    case 7:
                        {
                            PathLoad += "SATA_Slots.txt";
                            PathSave += "SATA_Slots.txt";
                            break;
                        }
                    case 8:
                        {
                            PathLoad += "VRM.txt";
                            PathSave += "VRM.txt";
                            break;
                        }
                    case 9:
                        {
                            PathLoad += "CPUPower.txt";
                            PathSave += "CPUPower.txt";
                            break;
                        }
                    case 10:
                        {
                            PathLoad += "MBPower.txt";
                            PathSave += "MBPower.txt";
                            break;
                        }
                }                                                                       
                File_textBox.Text = File.ReadAllText(PathLoad);
                PathLoad = "Text\\";
            }
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            if(TheoryOrUsers == false)
            {
                DB = new SQLiteConnection("Data source=DB\\Users.db");
                DB.Open();
                SQLiteCommand command = DB.CreateCommand();
                id = new string[User_DataGrid.RowCount];
                loginChanged = new string[User_DataGrid.RowCount];
                pass = new string[User_DataGrid.RowCount];
                score = new string[User_DataGrid.RowCount];
                for (int i = 0; i < User_DataGrid.RowCount-1; i++)
                {
                    id[i] = User_DataGrid[0, i].Value.ToString();
                    loginChanged[i] = User_DataGrid[1, i].Value.ToString();
                    pass[i] = User_DataGrid[2, i].Value.ToString();
                    score[i] = User_DataGrid[3, i].Value.ToString();                
                }
                for (int i = 0; i < User_DataGrid.RowCount - 1; i++)
                {
                    command.CommandText = "update Users set id = @id, Login = @loginChanged, Score = @score, Password = @pass where Login = @login";
                    command.Parameters.Add("@login", DbType.String).Value = login[i];
                    command.Parameters.Add("@id", DbType.Int32).Value = Int32.Parse(id[i]);
                    command.Parameters.Add("@loginChanged", DbType.String).Value = loginChanged[i];
                    command.Parameters.Add("@pass", DbType.String).Value = pass[i];
                    command.Parameters.Add("@score", DbType.Int32).Value = Int32.Parse(score[i]);
                    command.ExecuteNonQuery();
                }
                DB.Close();
            }
            else
            {
                if(PathSave != "Text\\")
                {
                    File.WriteAllText(PathSave, File_textBox.Text);
                    PathSave = "Text\\";
                }
                else
                {
                    MyMessage msg = new MyMessage();
                    msg.AutoSize = true;
                    msg.Msg_label.Text = "Вы не выбрали файл";
                }
            }
        }

        private void User_redact_button_Click(object sender, EventArgs e)
        {
            User_redact_button.Size = new Size(366, 38);
            User_redact_button.Location = new Point(422, 45);
            Theory_redact_button.Size = new Size(366, 38);
            Theory_redact_button.Location = new Point(422, 89);
            TheoryOrUsers = false;
            User_DataGrid.Visible = true;
            Load_button.Visible = true;
            Save_button.Visible = true;
            label_Help.Visible = false;
            File_comboBox.Visible = false;
            File_textBox.Visible = false;
        }

        private void Theory_redact_button_Click(object sender, EventArgs e)
        {
            User_redact_button.Size = new Size(366, 38);
            User_redact_button.Location = new Point(422, 45);
            Theory_redact_button.Size = new Size(366, 38);
            Theory_redact_button.Location = new Point(422, 89);
            TheoryOrUsers = true;
            User_DataGrid.Visible = false;
            label_Help.Visible = true;
            File_comboBox.Visible = true;
            File_textBox.Visible = true;
            Load_button.Visible = true;
            Save_button.Visible = true;
        }
    }
}
