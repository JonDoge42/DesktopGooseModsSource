using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GooseShared;

namespace ShaggysGooseMenu
{
    public partial class ModMenu : Form
    {
        public bool ChangesMade;
        public ModMenu()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            string filePath = @"config.ini";
            string newContent = "[Settings]\r\n";


            string currentContent = String.Empty;
            if (File.Exists(filePath) && File.ReadAllLines(filePath).First() != "[Settings]")
            {
                currentContent = File.ReadAllText(filePath);
                File.WriteAllText(filePath, newContent + currentContent);
            }
            GetConfigValues();
        }


        private void GetConfigValues()
        {
            var MyIni = new IniFile("config.ini");


            var Task_CanAttackMouse = MyIni.Read("Task_CanAttackMouse", "Settings");
            var AttackRandomly = MyIni.Read("AttackRandomly", "Settings");
            var SilenceSounds = MyIni.Read("SilenceSounds", "Settings");
            var UseCustomColors = MyIni.Read("UseCustomColors", "Settings");
            var GooseDefaultWhite = MyIni.Read("GooseDefaultWhite", "Settings");
            var GooseDefaultOrange = MyIni.Read("GooseDefaultOrange", "Settings");
            var GooseDefaultOutline = MyIni.Read("GooseDefaultOutline", "Settings");
            var MinWanderingTimeSeconds = MyIni.Read("MinWanderingTimeSeconds", "Settings");
            var MaxWanderingTimeSeconds = MyIni.Read("MaxWanderingTimeSeconds", "Settings");
            var FirstWanderTimeSeconds = MyIni.Read("FirstWanderTimeSeconds", "Settings");

            ConfigBools.Items.Add("Task Can Attack Mouse", Boolean.Parse(Task_CanAttackMouse));
            ConfigBools.Items.Add("Attack Randomly", Boolean.Parse(AttackRandomly));
            ConfigBools.Items.Add("Silence Sounds", Boolean.Parse(SilenceSounds));
            ConfigBools.Items.Add("Use Custom Colors", Boolean.Parse(UseCustomColors));

            GooseDefaultWhiteTxtBox.Text = GooseDefaultWhite;
            GooseDefaultOrangeTxtBox.Text = GooseDefaultOrange;
            GooseDefaultOutlineTxtBox.Text = GooseDefaultOutline;

            MinWanderingTimeSecondsNUD.Value = int.Parse(MinWanderingTimeSeconds);
            MaxWanderingTimeSecondsNUD.Value = int.Parse(MaxWanderingTimeSeconds);
            FirstWanderTimeSecondsNUD.Value = int.Parse(FirstWanderTimeSeconds);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExitBtn_MouseLeave(object sender, EventArgs e)
        {
            ExitBtn.BackColor = Color.FromArgb(255, 28, 28, 28);
        }

        private void ExitBtn_MouseEnter(object sender, EventArgs e)
        {
            ExitBtn.BackColor = Color.Crimson;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var MyIni = new IniFile("config.ini");

            MyIni.DeleteKey("SilenceSounds", "Settings");
            MyIni.DeleteKey("Task_CanAttackMouse", "Settings");
            MyIni.DeleteKey("AttackRandomly", "Settings");
            MyIni.DeleteKey("UseCustomColors", "Settings");
            MyIni.DeleteKey("GooseDefaultWhite", "Settings");
            MyIni.DeleteKey("GooseDefaultOrange", "Settings");
            MyIni.DeleteKey("GooseDefaultOutline", "Settings");
            MyIni.DeleteKey("MinWanderingTimeSeconds", "Settings");
            MyIni.DeleteKey("MaxWanderingTimeSeconds", "Settings");
            MyIni.DeleteKey("FirstWanderTimeSeconds", "Settings");

            MyIni.Write("SilenceSounds", ConfigBools.GetItemChecked(2).ToString(), "Settings");
            MyIni.Write("Task_CanAttackMouse", ConfigBools.GetItemChecked(0).ToString(), "Settings");
            MyIni.Write("AttackRandomly", ConfigBools.GetItemChecked(1).ToString(), "Settings");
            MyIni.Write("UseCustomColors", ConfigBools.GetItemChecked(3).ToString(), "Settings");
            MyIni.Write("GooseDefaultWhite", GooseDefaultWhiteTxtBox.Text, "Settings");
            MyIni.Write("GooseDefaultOrange", GooseDefaultOrangeTxtBox.Text, "Settings");
            MyIni.Write("GooseDefaultOutline", GooseDefaultOutlineTxtBox.Text, "Settings");
            MyIni.Write("MinWanderingTimeSeconds", MinWanderingTimeSecondsNUD.Value.ToString(), "Settings");
            MyIni.Write("MaxWanderingTimeSeconds", MaxWanderingTimeSecondsNUD.Value.ToString(), "Settings");
            MyIni.Write("FirstWanderTimeSeconds", FirstWanderTimeSecondsNUD.Value.ToString(), "Settings");

            if (ChangesMade == true)
            {
                MessageBox.Show("You have made changes to the configuration file, Goose will now restart.", "Changes to the config were made",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                Application.Restart();
            }
            else
            {
                this.Close();
            }
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightGreen;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(255, 15, 15, 15);
        }

        Point mouseDownPoint = Point.Empty;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDownPoint = Point.Empty;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDownPoint.IsEmpty)
                return;
            this.Location = new Point(this.Location.X + (e.X - mouseDownPoint.X), this.Location.Y + (e.Y - mouseDownPoint.Y));
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MinimizeBtn_MouseEnter(object sender, EventArgs e)
        {
            MinimizeBtn.BackColor = Color.LightBlue;
        }

        private void MinimizeBtn_MouseLeave(object sender, EventArgs e)
        {
            MinimizeBtn.BackColor = Color.FromArgb(255, 28, 28, 28);
        }



        private void GooseDefaultWhiteTxtBox_MouseClick(object sender, MouseEventArgs e)
        {
            ChangesMade = true;
        }

        private void MinWanderingTimeSecondsNUD_MouseClick(object sender, MouseEventArgs e)
        {
            ChangesMade = true;
        }

        private void ConfigBools_MouseClick(object sender, MouseEventArgs e)
        {
            ChangesMade = true;
        }

        private void GooseDefaultOutlineTxtBox_Click(object sender, EventArgs e)
        {
            ChangesMade = true;
        }

        private void MinWanderingTimeSecondsNUD_Click(object sender, EventArgs e)
        {
            ChangesMade = true;
        }

        private void ConfigBools_Click(object sender, EventArgs e)
        {
            ChangesMade = true;
        }
    }
}
