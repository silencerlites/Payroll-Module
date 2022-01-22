namespace WindowsFormsApp1
{
    partial class Main_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lmcClose = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dateTime = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Date_Time = new System.Windows.Forms.Timer(this.components);
            this.uc_panel = new System.Windows.Forms.Panel();
            this.btAdmin_Logout = new System.Windows.Forms.Button();
            this.pb_Nav = new System.Windows.Forms.PictureBox();
            this.bt_setting = new System.Windows.Forms.Button();
            this.bt_emp = new System.Windows.Forms.Button();
            this.bt_dashboard = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Nav)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(256, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 51);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ptitleBar_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptitleBar_MouseMove);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lmcClose);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(858, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(45, 51);
            this.panel5.TabIndex = 2;
            // 
            // lmcClose
            // 
            this.lmcClose.AutoSize = true;
            this.lmcClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lmcClose.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lmcClose.ForeColor = System.Drawing.Color.Red;
            this.lmcClose.Location = new System.Drawing.Point(6, 7);
            this.lmcClose.Name = "lmcClose";
            this.lmcClose.Size = new System.Drawing.Size(35, 35);
            this.lmcClose.TabIndex = 17;
            this.lmcClose.Text = "X";
            this.lmcClose.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lmcClose.Click += new System.EventHandler(this.LmcClose_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(903, 51);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Open Sans Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(903, 51);
            this.label2.TabIndex = 7;
            this.label2.Text = "PAYROLL SYSTEM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.pb_Nav);
            this.panel2.Controls.Add(this.bt_setting);
            this.panel2.Controls.Add(this.bt_emp);
            this.panel2.Controls.Add(this.SidePanel);
            this.panel2.Controls.Add(this.bt_dashboard);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 623);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btAdmin_Logout);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 557);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(256, 66);
            this.panel4.TabIndex = 2;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.SidePanel.Location = new System.Drawing.Point(1, 148);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(12, 52);
            this.SidePanel.TabIndex = 18;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel6.Location = new System.Drawing.Point(256, 51);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(903, 3);
            this.panel6.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.panel7.Controls.Add(this.dateTime);
            this.panel7.Controls.Add(this.panel13);
            this.panel7.Controls.Add(this.panel12);
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.panel11);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(256, 54);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(903, 63);
            this.panel7.TabIndex = 27;
            // 
            // dateTime
            // 
            this.dateTime.AutoSize = true;
            this.dateTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.dateTime.Font = new System.Drawing.Font("Open Sans Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.ForeColor = System.Drawing.Color.White;
            this.dateTime.Location = new System.Drawing.Point(794, 21);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(99, 23);
            this.dateTime.TabIndex = 31;
            this.dateTime.Text = "Date, Time";
            // 
            // panel13
            // 
            this.panel13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel13.Location = new System.Drawing.Point(16, 42);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(877, 10);
            this.panel13.TabIndex = 29;
            // 
            // panel12
            // 
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(16, 11);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(877, 10);
            this.panel12.TabIndex = 28;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(16, 52);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(877, 11);
            this.panel10.TabIndex = 26;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(16, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(877, 11);
            this.panel9.TabIndex = 25;
            // 
            // panel11
            // 
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(16, 63);
            this.panel11.TabIndex = 24;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(893, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 63);
            this.panel8.TabIndex = 21;
            // 
            // Date_Time
            // 
            this.Date_Time.Tick += new System.EventHandler(this.Date_Time_Tick);
            // 
            // uc_panel
            // 
            this.uc_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_panel.Location = new System.Drawing.Point(256, 117);
            this.uc_panel.Name = "uc_panel";
            this.uc_panel.Size = new System.Drawing.Size(903, 506);
            this.uc_panel.TabIndex = 28;
            // 
            // btAdmin_Logout
            // 
            this.btAdmin_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.btAdmin_Logout.FlatAppearance.BorderSize = 0;
            this.btAdmin_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdmin_Logout.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdmin_Logout.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btAdmin_Logout.Image = ((System.Drawing.Image)(resources.GetObject("btAdmin_Logout.Image")));
            this.btAdmin_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAdmin_Logout.Location = new System.Drawing.Point(17, 5);
            this.btAdmin_Logout.Name = "btAdmin_Logout";
            this.btAdmin_Logout.Size = new System.Drawing.Size(134, 47);
            this.btAdmin_Logout.TabIndex = 15;
            this.btAdmin_Logout.Text = "Logout";
            this.btAdmin_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAdmin_Logout.UseVisualStyleBackColor = false;
            // 
            // pb_Nav
            // 
            this.pb_Nav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Nav.Image = ((System.Drawing.Image)(resources.GetObject("pb_Nav.Image")));
            this.pb_Nav.Location = new System.Drawing.Point(18, 12);
            this.pb_Nav.Name = "pb_Nav";
            this.pb_Nav.Size = new System.Drawing.Size(39, 39);
            this.pb_Nav.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Nav.TabIndex = 18;
            this.pb_Nav.TabStop = false;
            this.pb_Nav.Click += new System.EventHandler(this.Pb_Nav_Click);
            // 
            // bt_setting
            // 
            this.bt_setting.FlatAppearance.BorderSize = 0;
            this.bt_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_setting.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_setting.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt_setting.Image = ((System.Drawing.Image)(resources.GetObject("bt_setting.Image")));
            this.bt_setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_setting.Location = new System.Drawing.Point(6, 264);
            this.bt_setting.Name = "bt_setting";
            this.bt_setting.Size = new System.Drawing.Size(244, 52);
            this.bt_setting.TabIndex = 21;
            this.bt_setting.Text = "Tables";
            this.bt_setting.UseVisualStyleBackColor = true;
            this.bt_setting.Click += new System.EventHandler(this.Bt_setting_Click);
            // 
            // bt_emp
            // 
            this.bt_emp.FlatAppearance.BorderSize = 0;
            this.bt_emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_emp.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_emp.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt_emp.Image = ((System.Drawing.Image)(resources.GetObject("bt_emp.Image")));
            this.bt_emp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_emp.Location = new System.Drawing.Point(12, 206);
            this.bt_emp.Name = "bt_emp";
            this.bt_emp.Size = new System.Drawing.Size(244, 52);
            this.bt_emp.TabIndex = 19;
            this.bt_emp.Text = "Employees Add";
            this.bt_emp.UseVisualStyleBackColor = true;
            this.bt_emp.Click += new System.EventHandler(this.Bt_attendance_Click);
            // 
            // bt_dashboard
            // 
            this.bt_dashboard.FlatAppearance.BorderSize = 0;
            this.bt_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_dashboard.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dashboard.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt_dashboard.Image = ((System.Drawing.Image)(resources.GetObject("bt_dashboard.Image")));
            this.bt_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_dashboard.Location = new System.Drawing.Point(12, 148);
            this.bt_dashboard.Name = "bt_dashboard";
            this.bt_dashboard.Size = new System.Drawing.Size(244, 52);
            this.bt_dashboard.TabIndex = 5;
            this.bt_dashboard.Text = "Dashboard";
            this.bt_dashboard.UseVisualStyleBackColor = true;
            this.bt_dashboard.Click += new System.EventHandler(this.Bt_dashboard_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1159, 623);
            this.ControlBox = false;
            this.Controls.Add(this.uc_panel);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main_Form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Nav)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_dashboard;
        private System.Windows.Forms.PictureBox pb_Nav;
        private System.Windows.Forms.Button btAdmin_Logout;
        private System.Windows.Forms.Button bt_setting;
        private System.Windows.Forms.Button bt_emp;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lmcClose;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label dateTime;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Timer Date_Time;
        private System.Windows.Forms.Panel uc_panel;
    }
}

