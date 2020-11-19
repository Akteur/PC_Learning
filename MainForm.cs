using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_Builder
{
    public partial class MainForm : Form
    {
        private SQLiteConnection DB;
        static MainForm()
        {
            for (int i = 0; i < bStatus.Length; i++)
                bStatus[i] = false;
        }

        int width = 0, x = 0, y = 0,
            ElementCount = 0, checkTT = 0,
            bttnchk = 0, picchk = 0,
            r = 30, g = 30, b = 41, 
            TimeCheck = 0, bad = 0, good = 0;
        static bool[] bStatus = new bool[8];
        static bool[] bPressed = new bool[8];
        bool chkPan = true, settCheck = false, rescheck = false, colorPressed = false;
        Panel[] MenuChoosePanel = new Panel[2];
        Button[] prac_button = new Button[8];

        public MainForm()
        {
            InitializeComponent();

            timer1.Interval = 1;
            timer1.Start();
            timer2.Interval = 700;
            button_CPU.FlatAppearance.BorderSize = 0;            
            button_MB.FlatAppearance.BorderSize = 0;
            button_RAM.FlatAppearance.BorderSize = 0;
            Socket_PR.FlatAppearance.BorderSize = 0;
            PCI_PR.FlatAppearance.BorderSize = 0;
            RAM_PR.FlatAppearance.BorderSize = 0;
            SATA_PR.FlatAppearance.BorderSize = 0;
            pin24.FlatAppearance.BorderSize = 0;
            pin8.FlatAppearance.BorderSize = 0;
            NB_PR.FlatAppearance.BorderSize = 0;
            Result.FlatAppearance.BorderSize = 0;
            VRM.FlatAppearance.BorderSize = 0;
            this.Opacity = 0.99f;
            prac_button[0] = Socket_PR;
            prac_button[1] = PCI_PR;
            prac_button[2] = RAM_PR;
            prac_button[3] = SATA_PR;
            prac_button[4] = pin24;
            prac_button[5] = pin8;
            prac_button[6] = NB_PR;
            prac_button[7] = VRM;
        }
        public void PanelCreate(int a, int R, int G, int B)
        {
            MenuChoosePanel[a] = new Panel();
            MenuChoosePanel[a].Name = "MenuChoosePanel" + a;
            MenuChoosePanel[a].Size = new Size(width, 4);
            MenuChoosePanel[a].Location = new Point(x, y);
            MenuChoosePanel[a].BackColor = Color.FromArgb(255, R, G, B);
            this.Controls.Add(MenuChoosePanel[a]);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            label_Pract.Location = new Point(label_Theory.Location.X + label_Theory.Size.Width + 10, label_Theory.Location.Y);
            Rate_label.Location = new Point(label_Pract.Location.X + label_Pract.Size.Width + 10, label_Pract.Location.Y);
            panel_Bad.Width = 0;
            panel_Good.Width = 0;
        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter )
            {
                timer1.Stop();
                timer2.Stop();
                label1.ForeColor = Color.FromArgb(255, 255, 255, 255);
                this.Controls.Remove(label2);
                label_About.Visible = true;
                Win_name.Visible = true;
                label_Theory.Visible = true;
                label_Pract.Visible = true;
                label_Login.Visible = true;
                Settings.Visible = true;
                
                r = 243; g = 18; b = 78;
            }
        }        
        private void TitlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            TitlePanel.Capture = false;
            Message m = Message.Create(this.Handle, 161, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        //-------------------------------Practice-------------------------------
        public void Practice_Visibility()
        {
            this.Controls.Remove(label1);
            chkPan = false;
            Theory_Text.Visible = false;
            Theory_pic.Visible = false;
            button_CPU.Visible = false;
            button_MB.Visible = false;
            button_RAM.Visible = false;
           
        }
        void ButtonPrac_Visibility(bool chk)
        {
            if (chk)
            {
                for(int i = 0; i < prac_button.Length; i++)
                {
                    prac_button[i].Visible = true;
                }
            }
            else
            {
                for (int i = 0; i < prac_button.Length; i++)
                {
                    prac_button[i].Visible = false;
                }
            }
        }
        void TrueFalseColor(int red, int green, int blue)
        {
            switch (bttnchk)
            {
                case 1:
                    {
                        Socket_PR.ForeColor = Color.FromArgb(red, green, blue);
                        break;
                    }
                case 2:
                    {
                        PCI_PR.ForeColor = Color.FromArgb(red, green, blue);
                        break;
                    }
                case 3:
                    {
                        RAM_PR.ForeColor = Color.FromArgb(red, green, blue);
                        break;
                    }
                case 4:
                    {
                        SATA_PR.ForeColor = Color.FromArgb(red, green, blue);
                        break;
                    }
                case 5:
                    {
                        pin24.ForeColor = Color.FromArgb(red, green, blue);
                        break;
                    }
                case 6:
                    {
                        pin8.ForeColor = Color.FromArgb(red, green, blue);
                        break;
                    }
                case 7:
                    {
                        NB_PR.ForeColor = Color.FromArgb(red, green, blue);
                        break;
                    }
                case 8:
                    {
                        VRM.ForeColor = Color.FromArgb(red, green, blue);
                        break;
                    }
            }
        }
        void AnswerSum()
        {
            for (int i = 0; i < bStatus.Length; i++)
            {
                if(bStatus[i] == true)
                {
                    good++;
                }
                else
                {
                    bad++;
                }
            }
        }
        void Answer_Check()
        {
            if(bttnchk != 0)
            {
                if (bttnchk == picchk && bPressed[bttnchk - 1] == false)
                {
                    bPressed[bttnchk - 1] = true;
                    bStatus[bttnchk - 1] = true;
                    TrueFalseColor(40, 190, 40);
                }
                else if(bPressed[bttnchk - 1] == false)
                {
                    bPressed[bttnchk - 1] = true;
                    bStatus[bttnchk - 1] = false;
                    TrueFalseColor(190, 40, 40);
                }
            }

        }
        void TryAgain()
        {
            good = 0;
            bad = 0;
            for (int i = 0; i < bStatus.Length; i++)
            {
                bStatus[i] = false;
            }
            Result.Text = "Узнать результат";
            label_Score.Text = "Ваш балл:";
            Socket_PR.ForeColor = Color.FromArgb(255, 224, 224, 224);
            PCI_PR.ForeColor = Color.FromArgb(255, 224, 224, 224);
            RAM_PR.ForeColor = Color.FromArgb(255, 224, 224, 224);
            SATA_PR.ForeColor = Color.FromArgb(255, 224, 224, 224);
            NB_PR.ForeColor = Color.FromArgb(255, 224, 224, 224);
            pin24.ForeColor = Color.FromArgb(255, 224, 224, 224);
            pin8.ForeColor = Color.FromArgb(255, 224, 224, 224);
            VRM.ForeColor = Color.FromArgb(255, 224, 224, 224);
            panel_Bad.Width = 0;
            panel_Good.Width = 0;
            rescheck = false;
        }
        private void Result_Click(object sender, EventArgs e)
        {
            if (!rescheck)
            {
                for(int i = 0; i < 8; i++)
                {
                    bPressed[i] = false;
                }
                Result.Text = "Пройти заново";                
                label_Score.Text = "Ваш балл: ";
                AnswerSum();
                double score = good * (100.0 / 8);
                score = Math.Round(score, 1);
                label_Score.Text += score.ToString();
                timer3.Start();
                timer4.Start();

                DB = new SQLiteConnection("Data source=DB\\Users.db");
                DB.Open();
                SQLiteCommand command = DB.CreateCommand();
                command.CommandText = "update Users set Score = @score where Login = @login";
                command.Parameters.Add("@login", DbType.String).Value = label_Login.Text;
                command.Parameters.Add("@score", DbType.Int32).Value = score;
                command.ExecuteNonQuery();
                DB.Close();
                rescheck = true;
            }
            else
            {
                TryAgain();
            }

        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (panel_Bad.Width < bad * 38)
            {
                panel_Bad.Width += 2;
            }
            else
            {
                timer3.Stop();
            }
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            if (panel_Good.Width < good * 38)
            {
                panel_Good.Width += 2;
            }
            else
            {
                timer4.Stop();
            }
        }
        private void label_Practice_Click(object sender, EventArgs e)
        {
            Update_button.Visible = false;
            Rate_label.Visible = true;
            Mail_label.Visible = false;
            Mail_text.Visible = false;
            Send_Mail.Visible = false;
            Nick_label.Visible = false;
            Score_label.Visible = false;
            Rate_DataGrid.Visible = false;
            bttnchk = 0; picchk = 0;
            checkTT = 2;
            if (ElementCount >= 2)
            {
                ElementCount = 0;
            }
            width = label_Pract.Size.Width;
            x = label_Pract.Location.X;
            y = label_Pract.Location.Y + 27;

            //создание панели
            PanelCreate(ElementCount, r, g, b);
            ElementCount++;

            if (!chkPan)
            {
                if (ElementCount > 1)
                {
                    this.Controls.Remove(MenuChoosePanel[ElementCount - 2]);
                }
                else
                {
                    this.Controls.Remove(MenuChoosePanel[ElementCount]);
                }

            }
            Practice_Visibility();
            Theory_pic.Visible = true;
            panel_Bad.Visible = true;
            panel_Good.Visible = true;
            label_True.Visible = true;
            label_False.Visible = true;
            label_Score.Visible = true;
            Result.Visible = true;
            Rules_text.Visible = true;
            PicMBComponents(true);
            ButtonPrac_Visibility(true);
            Rules_text.Location = new Point(12, 92);
            Rules_text.Text = File.ReadAllText("Text\\Rules.txt");
            Theory_pic.Image = null;
            Theory_pic.InitialImage = null;
            Theory_pic.Image = Image.FromFile("Image\\Motherboard.png");           
            button_CPU.ForeColor = Color.FromArgb(255, 224, 224, 224);
            button_MB.ForeColor = Color.FromArgb(255, 224, 224, 224);
            button_RAM.ForeColor = Color.FromArgb(255, 224, 224, 224);
        }
        private void label_Practice_MouseMove(object sender, MouseEventArgs e)
        {
            label_Pract.BackColor = Color.FromArgb(255, 60, 60, 61);
        }
        private void label_Practice_MouseLeave(object sender, EventArgs e)
        {
            label_Pract.BackColor = Color.FromArgb(255, 30, 30, 41);
        }
        private void Socket_PR_Click(object sender, EventArgs e)
        {
            bttnchk = 1;
            Socket_PR.BackColor = Color.FromArgb(255, 60, 60, 71);
            NB_PR.BackColor = Color.FromArgb(255, 40, 40, 51);
            pin8.BackColor = Color.FromArgb(255, 40, 40, 51);
            pin24.BackColor = Color.FromArgb(255, 40, 40, 51);
            SATA_PR.BackColor = Color.FromArgb(255, 40, 40, 51);
            RAM_PR.BackColor = Color.FromArgb(255, 40, 40, 51);
            PCI_PR.BackColor = Color.FromArgb(255, 40, 40, 51);
            VRM.BackColor = Color.FromArgb(255, 40, 40, 51);
        }
        private void PCI_PR_Click(object sender, EventArgs e)
        {
            bttnchk = 2;
            PCI_PR.BackColor = Color.FromArgb(255, 60, 60, 71);
            NB_PR.BackColor = Color.FromArgb(255, 40, 40, 51);
            pin8.BackColor = Color.FromArgb(255, 40, 40, 51);
            pin24.BackColor = Color.FromArgb(255, 40, 40, 51);
            SATA_PR.BackColor = Color.FromArgb(255, 40, 40, 51);
            RAM_PR.BackColor = Color.FromArgb(255, 40, 40, 51);
            Socket_PR.BackColor = Color.FromArgb(255, 40, 40, 51);
            VRM.BackColor = Color.FromArgb(255, 40, 40, 51);
        }
        private void RAM_PR_Click(object sender, EventArgs e)
        {
            bttnchk = 3;

            RAM_PR.BackColor = Color.FromArgb(255, 60, 60, 71);
            NB_PR.BackColor = Color.FromArgb(255, 40, 40, 51);
            pin8.BackColor = Color.FromArgb(255, 40, 40, 51);
            pin24.BackColor = Color.FromArgb(255, 40, 40, 51);
            SATA_PR.BackColor = Color.FromArgb(255, 40, 40, 51);
            PCI_PR.BackColor = Color.FromArgb(255, 40, 40, 51);
            Socket_PR.BackColor = Color.FromArgb(255, 40, 40, 51);
            VRM.BackColor = Color.FromArgb(255, 40, 40, 51);
        }
        private void SATA_PR_Click(object sender, EventArgs e)
        {
            bttnchk = 4;
            SATA_PR.BackColor = Color.FromArgb(255, 60, 60, 71);
            NB_PR.BackColor = Color.FromArgb(255, 40, 40, 51);
            pin8.BackColor = Color.FromArgb(255, 40, 40, 51);
            pin24.BackColor = Color.FromArgb(255, 40, 40, 51);
            RAM_PR.BackColor = Color.FromArgb(255, 40, 40, 51);
            PCI_PR.BackColor = Color.FromArgb(255, 40, 40, 51);
            Socket_PR.BackColor = Color.FromArgb(255, 40, 40, 51);
            VRM.BackColor = Color.FromArgb(255, 40, 40, 51);
        }
        private void pin24_Click(object sender, EventArgs e)
        {
            bttnchk = 5;
            pin24.BackColor = Color.FromArgb(255, 60, 60, 71);
            NB_PR.BackColor = Color.FromArgb(255, 40, 40, 51);
            pin8.BackColor = Color.FromArgb(255, 40, 40, 51);
            SATA_PR.BackColor = Color.FromArgb(255, 40, 40, 51);
            RAM_PR.BackColor = Color.FromArgb(255, 40, 40, 51);
            PCI_PR.BackColor = Color.FromArgb(255, 40, 40, 51);
            Socket_PR.BackColor = Color.FromArgb(255, 40, 40, 51);
            VRM.BackColor = Color.FromArgb(255, 40, 40, 51);
        }
        private void pin8_Click(object sender, EventArgs e)
        {
            bttnchk = 6;
            pin8.BackColor = Color.FromArgb(255, 60, 60, 71);
            NB_PR.BackColor = Color.FromArgb(255, 40, 40, 51);
            pin24.BackColor = Color.FromArgb(255, 40, 40, 51);
            SATA_PR.BackColor = Color.FromArgb(255, 40, 40, 51);
            RAM_PR.BackColor = Color.FromArgb(255, 40, 40, 51);
            PCI_PR.BackColor = Color.FromArgb(255, 40, 40, 51);
            Socket_PR.BackColor = Color.FromArgb(255, 40, 40, 51);
            VRM.BackColor = Color.FromArgb(255, 40, 40, 51);
        }
        private void NB_PR_Click(object sender, EventArgs e)
        {
            bttnchk = 7;
            NB_PR.BackColor = Color.FromArgb(255, 60, 60, 71);
            pin8.BackColor = Color.FromArgb(255, 40, 40, 51);
            pin24.BackColor = Color.FromArgb(255, 40, 40, 51);
            SATA_PR.BackColor = Color.FromArgb(255, 40, 40, 51);
            RAM_PR.BackColor = Color.FromArgb(255, 40, 40, 51);
            PCI_PR.BackColor = Color.FromArgb(255, 40, 40, 51);
            Socket_PR.BackColor = Color.FromArgb(255, 40, 40, 51);
            VRM.BackColor = Color.FromArgb(255, 40, 40, 51);
        }
        private void VRM_Click(object sender, EventArgs e)
        {
            bttnchk = 8;
            VRM.BackColor = Color.FromArgb(255, 60, 60, 71);
            NB_PR.BackColor = Color.FromArgb(255, 40, 40, 51);
            pin8.BackColor = Color.FromArgb(255, 40, 40, 51);
            pin24.BackColor = Color.FromArgb(255, 40, 40, 51);
            SATA_PR.BackColor = Color.FromArgb(255, 40, 40, 51);
            RAM_PR.BackColor = Color.FromArgb(255, 40, 40, 51);
            PCI_PR.BackColor = Color.FromArgb(255, 40, 40, 51);
            Socket_PR.BackColor = Color.FromArgb(255, 40, 40, 51);
        }

        //-------------------------------Theory-------------------------------
        public void Theory_Visibility()
        {
            this.Controls.Remove(label1);
            Theory_pic.Visible = false;
            Theory_Text.Visible = false;
            Rules_text.Visible = false;
            chkPan = false;
            ButtonPrac_Visibility(false);
            label_True.Visible = false;
            label_False.Visible = false;
            Result.Visible = false;
            panel_Good.Visible = false;
            panel_Bad.Visible = false;
            label_Score.Visible = false;
            PicMBComponents(false);            
        }
        private void label_Theory_Click(object sender, EventArgs e)
        {
            Mail_text.Text = "";
            Update_button.Visible = false;
            Mail_label.Visible = false;
            Mail_text.Visible = false;
            Send_Mail.Visible = false;
            Rate_label.Visible = false;
            Nick_label.Visible = false;
            Score_label.Visible = false;
            Rate_DataGrid.Visible = false;
            TryAgain();
            Theory_Visibility();
            button_CPU.ForeColor = Color.FromArgb(255, 224, 224, 224);
            button_MB.ForeColor = Color.FromArgb(255, 224, 224, 224);
            button_RAM.ForeColor = Color.FromArgb(255, 224, 224, 224);
            checkTT = 1;
            if(ElementCount >= 2)
            {
                ElementCount = 0;
            }
            width = label_Theory.Size.Width;
            x = label_Theory.Location.X;
            y = label_Theory.Location.Y + 27;

            //создание панели
            PanelCreate(ElementCount, r, g, b);
            ElementCount++;
            button_CPU.Visible = true;
            button_MB.Visible = true;
            button_RAM.Visible = true;
            if (!chkPan)
            {
                if (ElementCount > 1)
                {
                    this.Controls.Remove(MenuChoosePanel[ElementCount - 2]);
                }
                else
                {
                    this.Controls.Remove(MenuChoosePanel[ElementCount]);
                }
                
            }                                     
        }
        private void label_Theory_MouseMove(object sender, MouseEventArgs e)
        {
            label_Theory.BackColor = Color.FromArgb(255, 60, 60, 61);
        }
        private void label_Theory_MouseLeave(object sender, EventArgs e)
        {
            label_Theory.BackColor = Color.FromArgb(255, 30, 30, 41);
        }
        private void Send_Mail_Click(object sender, EventArgs e)
        {
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("pclearning35@gmail.com", "PC Learning");
            // кому отправляем
            MailAddress to = new MailAddress(Mail_text.Text);
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = "Теория";
            // текст письма
            m.Body = Theory_Text.Text;
            // письмо представляет код html
            m.IsBodyHtml = false;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            // логин и пароль
            smtp.Credentials = new NetworkCredential(from.Address, "PC20010611Learning");
            smtp.EnableSsl = true;
            smtp.Send(m);
        }

        //-------------------------------CPU-------------------------------
        private void button_CPU_Click(object sender, EventArgs e)
        {
            Mail_label.Visible = true;
            Mail_text.Visible = true;
            Send_Mail.Visible = true;
            Rules_text.Visible = false;
            PicMBComponents(false);
            bttnchk = 1;
            Theory_pic.Image = null;
            Theory_pic.InitialImage = null;
            Theory_pic.Image = Image.FromFile("Image\\CPU.png");
            Theory_pic.Visible = true;
            Theory_Text.Visible = true;
            Theory_Text.Text = File.ReadAllText("Text\\CPU.txt");
            button_CPU.ForeColor = Color.FromArgb(255, r, g, b);
            button_MB.ForeColor = Color.FromArgb(255, 224, 224, 224);
            button_RAM.ForeColor = Color.FromArgb(255, 224, 224, 224);            

        }
        private void button_CPU_MouseMove(object sender, MouseEventArgs e)
        {
            button_CPU.BackColor = Color.FromArgb(255, 60, 60, 71);
        }
        private void button_CPU_MouseLeave(object sender, EventArgs e)
        {
            button_CPU.BackColor = Color.FromArgb(255, 40, 40, 51);
        }

        //-------------------------------Mother Board-------------------------------
        void PicMBComponents(bool chk)
        {
            if (chk)
            {
                pic_Socket.Visible = true;
                pic_Socket.BringToFront();
                pic_Socket.Visible = true;
                pic_Ram.Visible = true;
                pic_Ram.BringToFront();
                pic_MBPower.Visible = true;
                pic_MBPower.BringToFront();
                pic_PCIE.Visible = true;
                pic_PCIE.BringToFront();
                pic_PCIE2.Visible = true;
                pic_PCIE2.BringToFront();
                pic_NB.Visible = true;
                pic_NB.BringToFront();
                pic_CPUPower.Visible = true;
                pic_CPUPower.BringToFront();
                pic_SATA.Visible = true;
                pic_SATA.BringToFront();
                pic_VRM1.Visible = true;
                pic_VRM1.BringToFront();
            }
            else
            {
                pic_Socket.Visible = false;
                pic_Socket.Visible = false;
                pic_MBPower.Visible = false;
                pic_PCIE.Visible = false;
                pic_PCIE2.Visible = false;
                pic_NB.Visible = false;
                pic_CPUPower.Visible = false;
                pic_SATA.Visible = false;
                pic_Ram.Visible = false;
                pic_VRM1.Visible = false;
            }
        }
        private void button_MB_Click(object sender, EventArgs e)
        {
            if(checkTT == 1)
            {
                Mail_label.Visible = true;
                Mail_text.Visible = true;
                Send_Mail.Visible = true;
                Rules_text.Visible = true;
                Rules_text.Location = new Point(12, 333);
                Rules_text.Text = "Для получения информации об элементах материнскй платы кликните по ним";
                Theory_pic.Image = null;
                Theory_pic.InitialImage = null;
                Theory_pic.Image = Image.FromFile("Image\\Motherboard.png");
                Theory_pic.Visible = true;
                Theory_Text.Visible = true;
                Theory_Text.Text = File.ReadAllText("Text\\Motherboard.txt");
                
                button_MB.ForeColor = Color.FromArgb(255, r, g, b);
                button_CPU.ForeColor = Color.FromArgb(255, 224, 224, 224);
                button_RAM.ForeColor = Color.FromArgb(255, 224, 224, 224);
                PicMBComponents(true);
            }
            else if(checkTT == 2)
            {
                button_MB.ForeColor = Color.FromArgb(255, r, g, b);
                button_CPU.ForeColor = Color.FromArgb(255, 224, 224, 224);
                button_RAM.ForeColor = Color.FromArgb(255, 224, 224, 224);
            }
        }
        private void button_MB_MouseMove(object sender, MouseEventArgs e)
        {
            button_MB.BackColor = Color.FromArgb(255, 60, 60, 71);
        }
        private void button_MB_MouseLeave(object sender, EventArgs e)
        {
            button_MB.BackColor = Color.FromArgb(255, 40, 40, 51);
        }
        private void pic_Socket_Click(object sender, EventArgs e)
        {
            picchk = 1;
            if(checkTT == 1)
            {
                Theory_Text.Text = File.ReadAllText("Text\\Socket.txt");
            }
            else
            {
                Answer_Check();
            }
        }
        private void pic_PCIE_Click(object sender, EventArgs e)
        {
            picchk = 2;
            if (checkTT == 1)
            {
                Theory_Text.Text = File.ReadAllText("Text\\PCI_Slots.txt");
            }
            else
            {
                Answer_Check();
            }
        }
        private void pic_PCIE2_Click(object sender, EventArgs e)
        {
            picchk = 2;
            if (checkTT == 1)
            {
                Theory_Text.Text = File.ReadAllText("Text\\PCI_Slots.txt");
            }
            else
            {
                Answer_Check();
            }
        }
        private void pic_Ram_Click(object sender, EventArgs e)
        {
            picchk = 3;
            if (checkTT == 1)
            {
                Theory_Text.Text = File.ReadAllText("Text\\RAM_Slots.txt");
            }
            else
            {
                Answer_Check();
            }
        }
        private void pic_SATA_Click(object sender, EventArgs e)
        {
            picchk = 4;
            if (checkTT == 1)
            {
                Theory_Text.Text = File.ReadAllText("Text\\SATA_Slots.txt");
            }
            else
            {
                Answer_Check();
            }
        }
        private void pic_MBPower_Click(object sender, EventArgs e)
        {
            picchk = 5;
            if (checkTT == 1)
            {
                Theory_Text.Text = File.ReadAllText("Text\\MBPower.txt");
            }
            else
            {
                Answer_Check();
            }
        }
        private void pic_CPUPower_Click(object sender, EventArgs e)
        {
            picchk = 6;
            if (checkTT == 1)
            {
                Theory_Text.Text = File.ReadAllText("Text\\CPUPower.txt");
            }
            else
            {
                Answer_Check();
            }
        }
        private void pic_NB_Click(object sender, EventArgs e)
        {
            picchk = 7;   
            if (checkTT == 1)
            {
                Theory_Text.Text = File.ReadAllText("Text\\NS_Bridge.txt");
            }
            else
            {
                Answer_Check();
            }
        }
        private void pic_VRM1_Click(object sender, EventArgs e)
        {
            picchk = 8;
            if (checkTT == 1)
            {
                Theory_Text.Text = File.ReadAllText("Text\\VRM.txt");
            }
            else
            {
                Answer_Check();
            }
        }

        //-------------------------------RAM-------------------------------
        private void button_RAM_Click(object sender, EventArgs e)
        {
            Rules_text.Visible = false;
            bttnchk = 3;
            if (checkTT == 1)
            {
                Mail_label.Visible = true;
                Mail_text.Visible = true;
                Send_Mail.Visible = true;
                PicMBComponents(false);
                Theory_pic.Image = null;
                Theory_pic.InitialImage = null;
                Theory_pic.Image = Image.FromFile("Image\\Crusial.png");
                Theory_pic.Visible = true;
                Theory_Text.Visible = true;
                Theory_Text.Text = File.ReadAllText("Text\\RAM.txt");
                button_RAM.ForeColor = Color.FromArgb(255, r, g, b);
                button_CPU.ForeColor = Color.FromArgb(255, 224, 224, 224);
                button_MB.ForeColor = Color.FromArgb(255, 224, 224, 224);
            }
            else if(checkTT == 2)
            {
                pic_Socket.Visible = false;
                pic_Ram.Visible = false;
                pic_MBPower.Visible = false;
                pic_PCIE2.Visible = false;
                pic_NB.Visible = false;
                pic_PCIE2.Visible = false;
                button_RAM.ForeColor = Color.FromArgb(255, r, g, b);
                button_CPU.ForeColor = Color.FromArgb(255, 224, 224, 224);
                button_MB.ForeColor = Color.FromArgb(255, 224, 224, 224);
            }            
        }
        private void button_RAM_MouseMove(object sender, MouseEventArgs e)
        {
            button_RAM.BackColor = Color.FromArgb(255, 60, 60, 71);
        }
        private void button_RAM_MouseLeave(object sender, EventArgs e)
        {
            button_RAM.BackColor = Color.FromArgb(255, 40, 40, 51);
        }

        //-------------------------------Settings-------------------------------
        private void Settings_Click(object sender, EventArgs e)
        {
            if (!settCheck)
            {
                panel_Color.Visible = true;
                label_Color.Visible = true;
                Settings.BackColor = Color.FromArgb(255, 60, 60, 71);
                settCheck = true;
            }
            else
            {
                panel_Color.Visible = false;
                label_Color.Visible = false;
                panel_Color2.Visible = false;
                panel_Color1.Visible = false;
                Settings.BackColor = Color.FromArgb(255, 30, 30, 41);
                settCheck = false;
            }
            
        }
        private void Settings_MouseMove(object sender, MouseEventArgs e)
        {
            if (!settCheck)
            {
                Settings.BackColor = Color.FromArgb(255, 60, 60, 71);
            }            
        }
        private void Settings_MouseLeave(object sender, EventArgs e)
        {
            if (!settCheck)
            {
                Settings.BackColor = Color.FromArgb(255, 30, 30, 41);
            }            
        }

        //-------------------------------Rate-------------------------------
        private void Rate_label_Click(object sender, EventArgs e)
        {
            if (ElementCount >= 2)
            {
                ElementCount = 0;
            }
            width = Rate_label.Size.Width;
            x = Rate_label.Location.X;
            y = Rate_label.Location.Y + 27;

            //создание панели
            PanelCreate(ElementCount, r, g, b);
            ElementCount++;

            if (!chkPan)
            {
                if (ElementCount > 1)
                {
                    //this.Controls.Remove(MenuChoosePanel[ElementCount - 1]);
                    this.Controls.Remove(MenuChoosePanel[ElementCount - 2]);
                }
                else
                {
                    this.Controls.Remove(MenuChoosePanel[ElementCount]);
                }

            }
            this.Controls.Remove(label1);
            Rules_text.Visible = false;
            Update_button.Visible = true;
            SQLiteConnection cnn = new SQLiteConnection("Data source=DB\\Users.db");
            SQLiteCommand cmd = new SQLiteCommand("select Login, Score from Users order by Score desc", cnn);
            cnn.Open();
            SQLiteDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            DataTable dt = new DataTable();
            dt.Load(dr);
            Rate_DataGrid.DataSource = dt;
            cnn.Close();
            Rate_DataGrid.Visible = true;
            Nick_label.Visible = true;
            Score_label.Visible = true;
        }
        private void Update_button_Click(object sender, EventArgs e)
        {
            SQLiteConnection cnn = new SQLiteConnection("Data source=DB\\Users.db");
            SQLiteCommand cmd = new SQLiteCommand("select Login, Score from Users order by Score desc", cnn);
            cnn.Open();
            SQLiteDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            DataTable dt = new DataTable();
            dt.Load(dr);
            Rate_DataGrid.DataSource = dt;
            cnn.Close();
        }

        //-------------------------------About-------------------------------
        private void label_About_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        //-------------------------------Color------------------------------
        private void panel_Color_Click(object sender, EventArgs e)
        {
            if (!colorPressed)
            {
                panel_Color2.Visible = true;
                panel_Color1.Visible = true;
                colorPressed = true;
            }
            else
            {
                panel_Color2.Visible = false;
                panel_Color1.Visible = false;
                colorPressed = false;
            }
        }        
        private void label_Color_Click(object sender, EventArgs e)
        {
            if (!colorPressed)
            {
                panel_Color2.Visible = true;
                panel_Color1.Visible = true;
                colorPressed = true;
            }
            else
            {
                panel_Color2.Visible = false;
                panel_Color1.Visible = false;
                colorPressed = false;
            }
        }
        private void label_Color_MouseMove(object sender, MouseEventArgs e)
        {
            panel_Color.BackColor = Color.FromArgb(255, 60, 60, 71);
        }
        private void label_Color_MouseLeave(object sender, EventArgs e)
        {
            panel_Color.BackColor = Color.FromArgb(255, 30, 30, 41);
        }
        private void panel_Color_MouseMove(object sender, MouseEventArgs e)
        {
            panel_Color.BackColor = Color.FromArgb(255, 60, 60, 71);
        }
        private void panel_Color1_Click(object sender, EventArgs e)
        {
            r = 243; g = 18; b = 78;
            TitlePanel.BackColor = Color.FromArgb(255, r, g, b);
            switch (bttnchk)
            {
                case 1:
                    {
                        button_CPU.ForeColor = Color.FromArgb(255, r, g, b);
                        break;
                    }
                case 2:
                    {
                        button_MB.ForeColor = Color.FromArgb(255, r, g, b);
                        break;
                    }
                case 3:
                    {
                        button_RAM.ForeColor = Color.FromArgb(255, r, g, b);
                        break;
                    }
            }
            for(int i = 0; i < ElementCount; i++)
            {
                MenuChoosePanel[i].BackColor = Color.FromArgb(255, r, g, b);
            }
        }     
        private void panel_Color2_Click(object sender, EventArgs e)
        {
            r = 80; g = 58; b = 160;
            TitlePanel.BackColor = Color.FromArgb(255, r, g, b);
            switch (bttnchk)
            {
                case 1:
                    {
                        button_CPU.ForeColor = Color.FromArgb(255, r, g, b);
                        break;
                    }
                case 2:
                    {
                        button_MB.ForeColor = Color.FromArgb(255, r, g, b);
                        break;
                    }
                case 3:
                    {
                        button_RAM.ForeColor = Color.FromArgb(255, r, g, b);
                        break;
                    }
            }
            for (int i = 0; i < ElementCount; i++)
            {
                MenuChoosePanel[i].BackColor = Color.FromArgb(255, r, g, b);
            }
        }
        private void panel_Color_MouseLeave(object sender, EventArgs e)
        {
            panel_Color.BackColor = Color.FromArgb(255, 30, 30, 41);
        }

        //-------------------------------Login-------------------------------
        private void label_Login_Click(object sender, EventArgs e)
        {
            Authorization auth = new Authorization(this);
            this.Hide();
            auth.ShowDialog();
            this.Show();
        }
        private void label_Login_MouseMove(object sender, MouseEventArgs e)
        {
            label_Login.BackColor = Color.FromArgb(255, 60, 60, 71);
        }
        private void label_Login_MouseLeave(object sender, EventArgs e)
        {
            label_Login.BackColor = Color.FromArgb(255, 30, 30, 41);
        }

        //-------------------------------Timer-------------------------------
        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Visible = !label2.Visible;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeCheck++;//переменная которая каждый тик увеличивается на 1
            if (TimeCheck > 30)//жду 30 проходов таймера то есть 30 тиков и начинается этот эффект
            {
                TimeCheck++;//тут я опять использую эту переменную уже чтобы в определенный момент замедлить "анимацию"
                if (TimeCheck > 90)//она замедляется когда переменнаая больше 90
                {
                    timer1.Interval = 1;
                }
                label1.ForeColor = Color.FromArgb(255, r, g, b);//тут собственно меняю цвет
                r++;//увеличиваю значения переменной для красного
                g++;//увеличиваю значения переменной для зеленого
                b++;// и синего
                if (r > 250 || g > 250 || b > 250)
                {
                    timer2.Start();
                    timer1.Stop();
                }
            }
        }

        //-------------------------------Close App-------------------------------
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}