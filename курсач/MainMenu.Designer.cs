
namespace курсач
{
    partial class Просмотр_мотоциклов
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.MenuButton7 = new Guna.UI2.WinForms.Guna2Button();
            this.MenuButton4 = new Guna.UI2.WinForms.Guna2Button();
            this.MenuButton3 = new Guna.UI2.WinForms.Guna2Button();
            this.MenuButton2 = new Guna.UI2.WinForms.Guna2Button();
            this.MenuButton1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.personal1 = new курсач.User_Controls.Personal();
            this.motoBase1 = new курсач.User_Controls.MotoBaseForClients();
            this.clients1 = new курсач.User_Controls.Clients();
            this.motoBaseForStaff1 = new курсач.User_Controls.MotoBaseForStaff();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.personal1);
            this.panel1.Controls.Add(this.motoBase1);
            this.panel1.Controls.Add(this.clients1);
            this.panel1.Controls.Add(this.motoBaseForStaff1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(160, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 450);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Controls.Add(this.MenuButton7);
            this.panel2.Controls.Add(this.MenuButton4);
            this.panel2.Controls.Add(this.MenuButton3);
            this.panel2.Controls.Add(this.MenuButton2);
            this.panel2.Controls.Add(this.MenuButton1);
            this.panel2.Controls.Add(this.guna2Button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 450);
            this.panel2.TabIndex = 11;
            // 
            // MenuButton7
            // 
            this.MenuButton7.Animated = true;
            this.MenuButton7.BorderColor = System.Drawing.Color.Gold;
            this.MenuButton7.BorderThickness = 1;
            this.MenuButton7.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.MenuButton7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MenuButton7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MenuButton7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MenuButton7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MenuButton7.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuButton7.FillColor = System.Drawing.Color.OrangeRed;
            this.MenuButton7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.MenuButton7.ForeColor = System.Drawing.Color.LightCyan;
            this.MenuButton7.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MenuButton7.ImageSize = new System.Drawing.Size(40, 40);
            this.MenuButton7.IndicateFocus = true;
            this.MenuButton7.Location = new System.Drawing.Point(0, 378);
            this.MenuButton7.Name = "MenuButton7";
            this.MenuButton7.Size = new System.Drawing.Size(160, 71);
            this.MenuButton7.TabIndex = 7;
            this.MenuButton7.Text = "Выход";
            this.MenuButton7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MenuButton7.Click += new System.EventHandler(this.MenuButton7_Click);
            // 
            // MenuButton4
            // 
            this.MenuButton4.Animated = true;
            this.MenuButton4.BorderColor = System.Drawing.Color.Gold;
            this.MenuButton4.BorderThickness = 1;
            this.MenuButton4.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.MenuButton4.Checked = true;
            this.MenuButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MenuButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MenuButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MenuButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MenuButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuButton4.FillColor = System.Drawing.Color.OrangeRed;
            this.MenuButton4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.MenuButton4.ForeColor = System.Drawing.Color.LightCyan;
            this.MenuButton4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MenuButton4.ImageSize = new System.Drawing.Size(40, 40);
            this.MenuButton4.IndicateFocus = true;
            this.MenuButton4.Location = new System.Drawing.Point(0, 307);
            this.MenuButton4.Name = "MenuButton4";
            this.MenuButton4.Size = new System.Drawing.Size(160, 71);
            this.MenuButton4.TabIndex = 4;
            this.MenuButton4.Text = "История";
            this.MenuButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MenuButton4.CheckedChanged += new System.EventHandler(this.MenuButton1_CheckedChanged);
            this.MenuButton4.Click += new System.EventHandler(this.MenuButton4_Click);
            // 
            // MenuButton3
            // 
            this.MenuButton3.Animated = true;
            this.MenuButton3.BorderColor = System.Drawing.Color.Gold;
            this.MenuButton3.BorderThickness = 1;
            this.MenuButton3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.MenuButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MenuButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MenuButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MenuButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MenuButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuButton3.FillColor = System.Drawing.Color.OrangeRed;
            this.MenuButton3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.MenuButton3.ForeColor = System.Drawing.Color.LightCyan;
            this.MenuButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MenuButton3.ImageOffset = new System.Drawing.Point(0, -2);
            this.MenuButton3.ImageSize = new System.Drawing.Size(50, 50);
            this.MenuButton3.IndicateFocus = true;
            this.MenuButton3.Location = new System.Drawing.Point(0, 236);
            this.MenuButton3.Name = "MenuButton3";
            this.MenuButton3.Size = new System.Drawing.Size(160, 71);
            this.MenuButton3.TabIndex = 3;
            this.MenuButton3.Text = "Персонал";
            this.MenuButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MenuButton3.CheckedChanged += new System.EventHandler(this.MenuButton1_CheckedChanged);
            this.MenuButton3.Click += new System.EventHandler(this.MenuButton3_Click);
            // 
            // MenuButton2
            // 
            this.MenuButton2.Animated = true;
            this.MenuButton2.BorderColor = System.Drawing.Color.Gold;
            this.MenuButton2.BorderThickness = 1;
            this.MenuButton2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.MenuButton2.Checked = true;
            this.MenuButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MenuButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MenuButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MenuButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MenuButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuButton2.FillColor = System.Drawing.Color.OrangeRed;
            this.MenuButton2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.MenuButton2.ForeColor = System.Drawing.Color.LightCyan;
            this.MenuButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MenuButton2.ImageOffset = new System.Drawing.Point(0, -3);
            this.MenuButton2.ImageSize = new System.Drawing.Size(50, 50);
            this.MenuButton2.IndicateFocus = true;
            this.MenuButton2.Location = new System.Drawing.Point(0, 165);
            this.MenuButton2.Name = "MenuButton2";
            this.MenuButton2.Size = new System.Drawing.Size(160, 71);
            this.MenuButton2.TabIndex = 2;
            this.MenuButton2.Text = "Клиенты";
            this.MenuButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MenuButton2.CheckedChanged += new System.EventHandler(this.MenuButton1_CheckedChanged);
            this.MenuButton2.Click += new System.EventHandler(this.MenuButton2_Click);
            // 
            // MenuButton1
            // 
            this.MenuButton1.Animated = true;
            this.MenuButton1.BorderColor = System.Drawing.Color.Gold;
            this.MenuButton1.BorderThickness = 1;
            this.MenuButton1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.MenuButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MenuButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MenuButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MenuButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MenuButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuButton1.FillColor = System.Drawing.Color.OrangeRed;
            this.MenuButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.MenuButton1.ForeColor = System.Drawing.Color.LightCyan;
            this.MenuButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MenuButton1.ImageSize = new System.Drawing.Size(50, 50);
            this.MenuButton1.IndicateFocus = true;
            this.MenuButton1.Location = new System.Drawing.Point(0, 94);
            this.MenuButton1.Name = "MenuButton1";
            this.MenuButton1.Size = new System.Drawing.Size(160, 71);
            this.MenuButton1.TabIndex = 0;
            this.MenuButton1.Text = "МотоБаза";
            this.MenuButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MenuButton1.CheckedChanged += new System.EventHandler(this.MenuButton1_CheckedChanged);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderColor = System.Drawing.Color.Gold;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button1.FillColor = System.Drawing.Color.Salmon;
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.LightCyan;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button1.IndicateFocus = true;
            this.guna2Button1.Location = new System.Drawing.Point(0, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(160, 94);
            this.guna2Button1.TabIndex = 8;
            this.guna2Button1.Text = "Профиль";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            
            // 
            // personal1
            // 
            this.personal1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personal1.Location = new System.Drawing.Point(0, 0);
            this.personal1.Name = "personal1";
            this.personal1.Size = new System.Drawing.Size(640, 450);
            this.personal1.TabIndex = 12;
            this.personal1.Load += new System.EventHandler(this.personal1_Load);
            // 
            // motoBase1
            // 
            this.motoBase1.AutoScroll = true;
            this.motoBase1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.motoBase1.Location = new System.Drawing.Point(0, 0);
            this.motoBase1.Margin = new System.Windows.Forms.Padding(0);
            this.motoBase1.Name = "motoBase1";
            this.motoBase1.Size = new System.Drawing.Size(640, 450);
            this.motoBase1.TabIndex = 0;
            this.motoBase1.Load += new System.EventHandler(this.motoBase1_Load);
            // 
            // clients1
            // 
            this.clients1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clients1.Location = new System.Drawing.Point(0, 0);
            this.clients1.Name = "clients1";
            this.clients1.Size = new System.Drawing.Size(640, 450);
            this.clients1.TabIndex = 2;
            // 
            // motoBaseForStaff1
            // 
            this.motoBaseForStaff1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.motoBaseForStaff1.Location = new System.Drawing.Point(0, 0);
            this.motoBaseForStaff1.Name = "motoBaseForStaff1";
            this.motoBaseForStaff1.Size = new System.Drawing.Size(640, 450);
            this.motoBaseForStaff1.TabIndex = 1;
            // 
            // Просмотр_мотоциклов
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Просмотр_мотоциклов";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр_мотоциклов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Просмотр_мотоциклов_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private User_Controls.MotoBaseForClients motoBase1;
        private Guna.UI2.WinForms.Guna2Button MenuButton1;
        private Guna.UI2.WinForms.Guna2Button MenuButton7;
        private Guna.UI2.WinForms.Guna2Button MenuButton4;
        private Guna.UI2.WinForms.Guna2Button MenuButton3;
        private Guna.UI2.WinForms.Guna2Button MenuButton2;
        private User_Controls.MotoBaseForStaff motoBaseForStaff1;
        private User_Controls.Clients clients1;
        private User_Controls.Personal personal1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}