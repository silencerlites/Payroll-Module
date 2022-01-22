namespace WindowsFormsApp1
{
    partial class add_prog_data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_prog_data));
            this.panelDrag = new System.Windows.Forms.Panel();
            this.lb_choice = new System.Windows.Forms.Label();
            this.lmcClose = new System.Windows.Forms.Label();
            this.lmcMini = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txb_Eno = new System.Windows.Forms.TextBox();
            this.lb_wday = new System.Windows.Forms.Label();
            this.lb_drate = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_dbirth = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.bt_Add_Prog = new System.Windows.Forms.Button();
            this.bt_Delete_Prog = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lb_cal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_wcount = new System.Windows.Forms.Label();
            this.panelDrag.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDrag
            // 
            this.panelDrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.panelDrag.Controls.Add(this.lb_choice);
            this.panelDrag.Controls.Add(this.lmcClose);
            this.panelDrag.Controls.Add(this.lmcMini);
            this.panelDrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDrag.Location = new System.Drawing.Point(0, 0);
            this.panelDrag.Name = "panelDrag";
            this.panelDrag.Size = new System.Drawing.Size(827, 41);
            this.panelDrag.TabIndex = 5;
            this.panelDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDrag_MouseDown);
            this.panelDrag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelDrag_MouseMove);
            // 
            // lb_choice
            // 
            this.lb_choice.AutoSize = true;
            this.lb_choice.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lb_choice.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_choice.ForeColor = System.Drawing.Color.White;
            this.lb_choice.Location = new System.Drawing.Point(8, 4);
            this.lb_choice.Name = "lb_choice";
            this.lb_choice.Size = new System.Drawing.Size(149, 26);
            this.lb_choice.TabIndex = 204;
            this.lb_choice.Text = "Employee Data";
            // 
            // lmcClose
            // 
            this.lmcClose.AutoSize = true;
            this.lmcClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lmcClose.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lmcClose.ForeColor = System.Drawing.Color.White;
            this.lmcClose.Location = new System.Drawing.Point(783, 5);
            this.lmcClose.Name = "lmcClose";
            this.lmcClose.Size = new System.Drawing.Size(29, 29);
            this.lmcClose.TabIndex = 56;
            this.lmcClose.Text = "X";
            this.lmcClose.Click += new System.EventHandler(this.lmcClose_Click);
            // 
            // lmcMini
            // 
            this.lmcMini.AutoSize = true;
            this.lmcMini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lmcMini.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lmcMini.ForeColor = System.Drawing.Color.White;
            this.lmcMini.Location = new System.Drawing.Point(740, 1);
            this.lmcMini.Name = "lmcMini";
            this.lmcMini.Size = new System.Drawing.Size(27, 33);
            this.lmcMini.TabIndex = 55;
            this.lmcMini.Text = "-";
            this.lmcMini.Click += new System.EventHandler(this.lmcMini_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 41);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 100, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 224);
            this.groupBox1.TabIndex = 201;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Details";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lb_wcount);
            this.groupBox3.Controls.Add(this.txb_Eno);
            this.groupBox3.Controls.Add(this.lb_wday);
            this.groupBox3.Controls.Add(this.lb_drate);
            this.groupBox3.Controls.Add(this.lb_name);
            this.groupBox3.Controls.Add(this.lb_dbirth);
            this.groupBox3.Location = new System.Drawing.Point(228, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(584, 177);
            this.groupBox3.TabIndex = 82;
            this.groupBox3.TabStop = false;
            // 
            // txb_Eno
            // 
            this.txb_Eno.BackColor = System.Drawing.Color.White;
            this.txb_Eno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_Eno.Enabled = false;
            this.txb_Eno.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Eno.ForeColor = System.Drawing.Color.Black;
            this.txb_Eno.Location = new System.Drawing.Point(11, 29);
            this.txb_Eno.Name = "txb_Eno";
            this.txb_Eno.Size = new System.Drawing.Size(570, 26);
            this.txb_Eno.TabIndex = 188;
            this.txb_Eno.Text = "Employee Number";
            // 
            // lb_wday
            // 
            this.lb_wday.AutoSize = true;
            this.lb_wday.ForeColor = System.Drawing.Color.Black;
            this.lb_wday.Location = new System.Drawing.Point(6, 133);
            this.lb_wday.Name = "lb_wday";
            this.lb_wday.Size = new System.Drawing.Size(138, 26);
            this.lb_wday.TabIndex = 80;
            this.lb_wday.Text = "Working Days";
            // 
            // lb_drate
            // 
            this.lb_drate.AutoSize = true;
            this.lb_drate.ForeColor = System.Drawing.Color.Black;
            this.lb_drate.Location = new System.Drawing.Point(6, 107);
            this.lb_drate.Name = "lb_drate";
            this.lb_drate.Size = new System.Drawing.Size(103, 26);
            this.lb_drate.TabIndex = 79;
            this.lb_drate.Text = "Daily Rate";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.ForeColor = System.Drawing.Color.Black;
            this.lb_name.Location = new System.Drawing.Point(6, 55);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(162, 26);
            this.lb_name.TabIndex = 77;
            this.lb_name.Text = "Employee Name";
            // 
            // lb_dbirth
            // 
            this.lb_dbirth.AutoSize = true;
            this.lb_dbirth.ForeColor = System.Drawing.Color.Black;
            this.lb_dbirth.Location = new System.Drawing.Point(6, 81);
            this.lb_dbirth.Name = "lb_dbirth";
            this.lb_dbirth.Size = new System.Drawing.Size(129, 26);
            this.lb_dbirth.TabIndex = 78;
            this.lb_dbirth.Text = "Date of Birth";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(6, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 177);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(6, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 26);
            this.label5.TabIndex = 80;
            this.label5.Text = "Working Days";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 26);
            this.label1.TabIndex = 76;
            this.label1.Text = "Employee Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(6, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 26);
            this.label4.TabIndex = 79;
            this.label4.Text = "Daily Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 26);
            this.label2.TabIndex = 77;
            this.label2.Text = "Employee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 26);
            this.label3.TabIndex = 78;
            this.label3.Text = "Date of Birth";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Open Sans", 1F, System.Drawing.FontStyle.Bold);
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(261, 164);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(10, 2);
            this.textBox3.TabIndex = 75;
            // 
            // bt_Add_Prog
            // 
            this.bt_Add_Prog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.bt_Add_Prog.FlatAppearance.BorderSize = 0;
            this.bt_Add_Prog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Add_Prog.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Add_Prog.ForeColor = System.Drawing.Color.White;
            this.bt_Add_Prog.Image = ((System.Drawing.Image)(resources.GetObject("bt_Add_Prog.Image")));
            this.bt_Add_Prog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Add_Prog.Location = new System.Drawing.Point(23, 437);
            this.bt_Add_Prog.Name = "bt_Add_Prog";
            this.bt_Add_Prog.Size = new System.Drawing.Size(161, 43);
            this.bt_Add_Prog.TabIndex = 202;
            this.bt_Add_Prog.Text = "Get Computed";
            this.bt_Add_Prog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Add_Prog.UseVisualStyleBackColor = false;
            this.bt_Add_Prog.Click += new System.EventHandler(this.bt_Add_Prog_Click_1);
            // 
            // bt_Delete_Prog
            // 
            this.bt_Delete_Prog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.bt_Delete_Prog.FlatAppearance.BorderSize = 0;
            this.bt_Delete_Prog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Delete_Prog.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Delete_Prog.ForeColor = System.Drawing.Color.White;
            this.bt_Delete_Prog.Image = ((System.Drawing.Image)(resources.GetObject("bt_Delete_Prog.Image")));
            this.bt_Delete_Prog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Delete_Prog.Location = new System.Drawing.Point(712, 437);
            this.bt_Delete_Prog.Name = "bt_Delete_Prog";
            this.bt_Delete_Prog.Size = new System.Drawing.Size(100, 43);
            this.bt_Delete_Prog.TabIndex = 203;
            this.bt_Delete_Prog.Text = "Cancel";
            this.bt_Delete_Prog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Delete_Prog.UseVisualStyleBackColor = false;
            this.bt_Delete_Prog.Click += new System.EventHandler(this.Bt_Delete_Prog_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Controls.Add(this.panel10);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 265);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(827, 73);
            this.groupBox4.TabIndex = 204;
            this.groupBox4.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtp_end);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(396, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 54);
            this.panel1.TabIndex = 207;
            // 
            // dtp_end
            // 
            this.dtp_end.CustomFormat = "MMMM, dd yyyy";
            this.dtp_end.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtp_end.Font = new System.Drawing.Font("Open Sans", 12F);
            this.dtp_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_end.Location = new System.Drawing.Point(0, 20);
            this.dtp_end.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(411, 29);
            this.dtp_end.TabIndex = 52;
            this.dtp_end.Value = new System.DateTime(2022, 1, 22, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "Ending Date";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.dtp_start);
            this.panel10.Controls.Add(this.label21);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(3, 16);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(393, 54);
            this.panel10.TabIndex = 206;
            // 
            // dtp_start
            // 
            this.dtp_start.CustomFormat = "MMMM, dd yyyy";
            this.dtp_start.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtp_start.Font = new System.Drawing.Font("Open Sans", 12F);
            this.dtp_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_start.Location = new System.Drawing.Point(0, 20);
            this.dtp_start.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(393, 29);
            this.dtp_start.TabIndex = 52;
            this.dtp_start.Value = new System.DateTime(2022, 1, 22, 0, 0, 0, 0);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Top;
            this.label21.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(0, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(105, 20);
            this.label21.TabIndex = 51;
            this.label21.Text = "Starting Date";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.groupBox5.Location = new System.Drawing.Point(0, 338);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 100, 3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(827, 90);
            this.groupBox5.TabIndex = 205;
            this.groupBox5.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lb_cal);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Location = new System.Drawing.Point(228, 23);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(584, 64);
            this.groupBox6.TabIndex = 82;
            this.groupBox6.TabStop = false;
            // 
            // lb_cal
            // 
            this.lb_cal.AutoSize = true;
            this.lb_cal.ForeColor = System.Drawing.Color.Black;
            this.lb_cal.Location = new System.Drawing.Point(60, 29);
            this.lb_cal.Name = "lb_cal";
            this.lb_cal.Size = new System.Drawing.Size(50, 26);
            this.lb_cal.TabIndex = 77;
            this.lb_cal.Text = "0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 26);
            this.label8.TabIndex = 76;
            this.label8.Text = "Php";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Location = new System.Drawing.Point(6, 23);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 64);
            this.groupBox7.TabIndex = 81;
            this.groupBox7.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(6, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(158, 26);
            this.label13.TabIndex = 76;
            this.label13.Text = "Take-home Pay:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Open Sans", 1F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(261, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(10, 2);
            this.textBox1.TabIndex = 75;
            // 
            // lb_wcount
            // 
            this.lb_wcount.AutoSize = true;
            this.lb_wcount.ForeColor = System.Drawing.Color.Black;
            this.lb_wcount.Location = new System.Drawing.Point(440, 139);
            this.lb_wcount.Name = "lb_wcount";
            this.lb_wcount.Size = new System.Drawing.Size(138, 26);
            this.lb_wcount.TabIndex = 189;
            this.lb_wcount.Text = "Working Days";
            // 
            // add_prog_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 492);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.bt_Add_Prog);
            this.Controls.Add(this.bt_Delete_Prog);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelDrag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "add_prog_data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_prog_data";
            this.Load += new System.EventHandler(this.add_prog_data_Load);
            this.panelDrag.ResumeLayout(false);
            this.panelDrag.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDrag;
        private System.Windows.Forms.Label lmcClose;
        private System.Windows.Forms.Label lmcMini;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button bt_Add_Prog;
        private System.Windows.Forms.Button bt_Delete_Prog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lb_wday;
        private System.Windows.Forms.Label lb_drate;
        private System.Windows.Forms.Label lb_dbirth;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lb_cal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox txb_Eno;
        public System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_choice;
        private System.Windows.Forms.Label lb_wcount;
    }
}