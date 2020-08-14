namespace ShaggysGooseMenu
{
    partial class ModMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ConfigPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MaxWanderingTimeSecondsNUD = new System.Windows.Forms.NumericUpDown();
            this.FirstWanderTimeSecondsNUD = new System.Windows.Forms.NumericUpDown();
            this.MinWanderingTimeSecondsNUD = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.GooseDefaultOutlineTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GooseDefaultOrangeTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GooseDefaultWhiteTxtBox = new System.Windows.Forms.TextBox();
            this.ConfigBools = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.ConfigPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxWanderingTimeSecondsNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstWanderTimeSecondsNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinWanderingTimeSecondsNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.MinimizeBtn);
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 32);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Goose User Interface";
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.ForeColor = System.Drawing.Color.White;
            this.MinimizeBtn.Location = new System.Drawing.Point(291, 0);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(59, 32);
            this.MinimizeBtn.TabIndex = 1;
            this.MinimizeBtn.Text = "Minimize";
            this.MinimizeBtn.UseVisualStyleBackColor = true;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            this.MinimizeBtn.MouseEnter += new System.EventHandler(this.MinimizeBtn_MouseEnter);
            this.MinimizeBtn.MouseLeave += new System.EventHandler(this.MinimizeBtn_MouseLeave);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(350, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(54, 32);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.Text = "Close";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            this.ExitBtn.MouseEnter += new System.EventHandler(this.ExitBtn_MouseEnter);
            this.ExitBtn.MouseLeave += new System.EventHandler(this.ExitBtn_MouseLeave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(404, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Start Goose";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // ConfigPanel
            // 
            this.ConfigPanel.Controls.Add(this.label8);
            this.ConfigPanel.Controls.Add(this.label7);
            this.ConfigPanel.Controls.Add(this.label6);
            this.ConfigPanel.Controls.Add(this.label4);
            this.ConfigPanel.Controls.Add(this.MaxWanderingTimeSecondsNUD);
            this.ConfigPanel.Controls.Add(this.FirstWanderTimeSecondsNUD);
            this.ConfigPanel.Controls.Add(this.MinWanderingTimeSecondsNUD);
            this.ConfigPanel.Controls.Add(this.label5);
            this.ConfigPanel.Controls.Add(this.GooseDefaultOutlineTxtBox);
            this.ConfigPanel.Controls.Add(this.label3);
            this.ConfigPanel.Controls.Add(this.GooseDefaultOrangeTxtBox);
            this.ConfigPanel.Controls.Add(this.label2);
            this.ConfigPanel.Controls.Add(this.GooseDefaultWhiteTxtBox);
            this.ConfigPanel.Controls.Add(this.ConfigBools);
            this.ConfigPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfigPanel.Location = new System.Drawing.Point(0, 32);
            this.ConfigPanel.Name = "ConfigPanel";
            this.ConfigPanel.Size = new System.Drawing.Size(404, 278);
            this.ConfigPanel.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(4, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Max Wandering Time Seconds";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "First Wander Time Seconds\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Min Wandering Time Seconds";
            // 
            // MaxWanderingTimeSecondsNUD
            // 
            this.MaxWanderingTimeSecondsNUD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaxWanderingTimeSecondsNUD.Location = new System.Drawing.Point(4, 213);
            this.MaxWanderingTimeSecondsNUD.Name = "MaxWanderingTimeSecondsNUD";
            this.MaxWanderingTimeSecondsNUD.Size = new System.Drawing.Size(106, 20);
            this.MaxWanderingTimeSecondsNUD.TabIndex = 8;
            this.MaxWanderingTimeSecondsNUD.Click += new System.EventHandler(this.MinWanderingTimeSecondsNUD_Click);
            this.MaxWanderingTimeSecondsNUD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MinWanderingTimeSecondsNUD_MouseClick);
            // 
            // FirstWanderTimeSecondsNUD
            // 
            this.FirstWanderTimeSecondsNUD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstWanderTimeSecondsNUD.Location = new System.Drawing.Point(4, 252);
            this.FirstWanderTimeSecondsNUD.Name = "FirstWanderTimeSecondsNUD";
            this.FirstWanderTimeSecondsNUD.Size = new System.Drawing.Size(106, 20);
            this.FirstWanderTimeSecondsNUD.TabIndex = 8;
            this.FirstWanderTimeSecondsNUD.Click += new System.EventHandler(this.MinWanderingTimeSecondsNUD_Click);
            this.FirstWanderTimeSecondsNUD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MinWanderingTimeSecondsNUD_MouseClick);
            // 
            // MinWanderingTimeSecondsNUD
            // 
            this.MinWanderingTimeSecondsNUD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MinWanderingTimeSecondsNUD.Location = new System.Drawing.Point(4, 174);
            this.MinWanderingTimeSecondsNUD.Name = "MinWanderingTimeSecondsNUD";
            this.MinWanderingTimeSecondsNUD.Size = new System.Drawing.Size(106, 20);
            this.MinWanderingTimeSecondsNUD.TabIndex = 7;
            this.MinWanderingTimeSecondsNUD.Click += new System.EventHandler(this.MinWanderingTimeSecondsNUD_Click);
            this.MinWanderingTimeSecondsNUD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MinWanderingTimeSecondsNUD_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(4, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Goose Default Outline";
            // 
            // GooseDefaultOutlineTxtBox
            // 
            this.GooseDefaultOutlineTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GooseDefaultOutlineTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GooseDefaultOutlineTxtBox.Location = new System.Drawing.Point(4, 119);
            this.GooseDefaultOutlineTxtBox.Name = "GooseDefaultOutlineTxtBox";
            this.GooseDefaultOutlineTxtBox.Size = new System.Drawing.Size(106, 21);
            this.GooseDefaultOutlineTxtBox.TabIndex = 5;
            this.GooseDefaultOutlineTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GooseDefaultOutlineTxtBox.Click += new System.EventHandler(this.GooseDefaultOutlineTxtBox_Click);
            this.GooseDefaultOutlineTxtBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GooseDefaultWhiteTxtBox_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Goose Default Orange";
            // 
            // GooseDefaultOrangeTxtBox
            // 
            this.GooseDefaultOrangeTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GooseDefaultOrangeTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GooseDefaultOrangeTxtBox.Location = new System.Drawing.Point(4, 76);
            this.GooseDefaultOrangeTxtBox.Name = "GooseDefaultOrangeTxtBox";
            this.GooseDefaultOrangeTxtBox.Size = new System.Drawing.Size(106, 21);
            this.GooseDefaultOrangeTxtBox.TabIndex = 3;
            this.GooseDefaultOrangeTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GooseDefaultOrangeTxtBox.Click += new System.EventHandler(this.GooseDefaultOutlineTxtBox_Click);
            this.GooseDefaultOrangeTxtBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GooseDefaultWhiteTxtBox_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Goose Default White";
            // 
            // GooseDefaultWhiteTxtBox
            // 
            this.GooseDefaultWhiteTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GooseDefaultWhiteTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GooseDefaultWhiteTxtBox.Location = new System.Drawing.Point(4, 33);
            this.GooseDefaultWhiteTxtBox.Name = "GooseDefaultWhiteTxtBox";
            this.GooseDefaultWhiteTxtBox.Size = new System.Drawing.Size(106, 21);
            this.GooseDefaultWhiteTxtBox.TabIndex = 1;
            this.GooseDefaultWhiteTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GooseDefaultWhiteTxtBox.Click += new System.EventHandler(this.GooseDefaultOutlineTxtBox_Click);
            this.GooseDefaultWhiteTxtBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GooseDefaultWhiteTxtBox_MouseClick);
            // 
            // ConfigBools
            // 
            this.ConfigBools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ConfigBools.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConfigBools.CheckOnClick = true;
            this.ConfigBools.ForeColor = System.Drawing.Color.White;
            this.ConfigBools.FormattingEnabled = true;
            this.ConfigBools.Location = new System.Drawing.Point(237, 0);
            this.ConfigBools.Name = "ConfigBools";
            this.ConfigBools.Size = new System.Drawing.Size(167, 135);
            this.ConfigBools.TabIndex = 0;
            this.ConfigBools.Click += new System.EventHandler(this.ConfigBools_Click);
            this.ConfigBools.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ConfigBools_MouseClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(268, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "GUI Mod Made by Shaggy\r\n";
            // 
            // ModMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(404, 342);
            this.Controls.Add(this.ConfigPanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ModMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GooseUserInterface";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ConfigPanel.ResumeLayout(false);
            this.ConfigPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxWanderingTimeSecondsNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstWanderTimeSecondsNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinWanderingTimeSecondsNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ConfigPanel;
        private System.Windows.Forms.CheckedListBox ConfigBools;
        private System.Windows.Forms.TextBox GooseDefaultWhiteTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox GooseDefaultOutlineTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GooseDefaultOrangeTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown MinWanderingTimeSecondsNUD;
        private System.Windows.Forms.NumericUpDown MaxWanderingTimeSecondsNUD;
        private System.Windows.Forms.NumericUpDown FirstWanderTimeSecondsNUD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
    }
}