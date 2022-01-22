namespace WindowsFormsApp1
{
    partial class uc_setting
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_setting));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Employees = new System.Windows.Forms.TabPage();
            this.lv_tblemployees = new System.Windows.Forms.ListView();
            this.no = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.wDays = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_Edit_att = new System.Windows.Forms.Button();
            this.bt_Delete_att = new System.Windows.Forms.Button();
            this.bt_view = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel28 = new System.Windows.Forms.Panel();
            this.txb_Eno = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Employees.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Open Sans Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.groupBox2.Location = new System.Drawing.Point(16, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(871, 536);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Setting";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Employees);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(865, 462);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Click += new System.EventHandler(this.TabControl1_Click);
            // 
            // Employees
            // 
            this.Employees.Controls.Add(this.lv_tblemployees);
            this.Employees.Controls.Add(this.flowLayoutPanel4);
            this.Employees.Location = new System.Drawing.Point(4, 31);
            this.Employees.Name = "Employees";
            this.Employees.Padding = new System.Windows.Forms.Padding(3);
            this.Employees.Size = new System.Drawing.Size(857, 427);
            this.Employees.TabIndex = 1;
            this.Employees.Text = "Employees Table";
            this.Employees.UseVisualStyleBackColor = true;
            // 
            // lv_tblemployees
            // 
            this.lv_tblemployees.BackColor = System.Drawing.Color.DimGray;
            this.lv_tblemployees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_tblemployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.no,
            this.name,
            this.dBirth,
            this.dRate,
            this.wDays});
            this.lv_tblemployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_tblemployees.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_tblemployees.ForeColor = System.Drawing.Color.White;
            this.lv_tblemployees.FullRowSelect = true;
            this.lv_tblemployees.HideSelection = false;
            this.lv_tblemployees.HoverSelection = true;
            this.lv_tblemployees.Location = new System.Drawing.Point(3, 3);
            this.lv_tblemployees.Name = "lv_tblemployees";
            this.lv_tblemployees.Scrollable = false;
            this.lv_tblemployees.Size = new System.Drawing.Size(851, 371);
            this.lv_tblemployees.TabIndex = 204;
            this.lv_tblemployees.UseCompatibleStateImageBehavior = false;
            this.lv_tblemployees.View = System.Windows.Forms.View.Details;
            this.lv_tblemployees.Click += new System.EventHandler(this.Lv_tblattendees_Click);
            // 
            // no
            // 
            this.no.Text = "Employees Number";
            this.no.Width = 300;
            // 
            // name
            // 
            this.name.Text = "Employee Name";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name.Width = 300;
            // 
            // dBirth
            // 
            this.dBirth.Text = "Date of Birth";
            this.dBirth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dBirth.Width = 300;
            // 
            // dRate
            // 
            this.dRate.Text = "Daily Rate";
            this.dRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dRate.Width = 300;
            // 
            // wDays
            // 
            this.wDays.Text = "Working Days";
            this.wDays.Width = 300;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.bt_Edit_att);
            this.flowLayoutPanel4.Controls.Add(this.bt_Delete_att);
            this.flowLayoutPanel4.Controls.Add(this.bt_view);
            this.flowLayoutPanel4.Controls.Add(this.panel14);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 374);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(851, 50);
            this.flowLayoutPanel4.TabIndex = 182;
            // 
            // bt_Edit_att
            // 
            this.bt_Edit_att.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(197)))), ((int)(((byte)(49)))));
            this.bt_Edit_att.FlatAppearance.BorderSize = 0;
            this.bt_Edit_att.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Edit_att.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Edit_att.ForeColor = System.Drawing.Color.White;
            this.bt_Edit_att.Image = ((System.Drawing.Image)(resources.GetObject("bt_Edit_att.Image")));
            this.bt_Edit_att.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Edit_att.Location = new System.Drawing.Point(3, 3);
            this.bt_Edit_att.Name = "bt_Edit_att";
            this.bt_Edit_att.Size = new System.Drawing.Size(86, 43);
            this.bt_Edit_att.TabIndex = 181;
            this.bt_Edit_att.Text = "Edit";
            this.bt_Edit_att.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Edit_att.UseVisualStyleBackColor = false;
            // 
            // bt_Delete_att
            // 
            this.bt_Delete_att.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.bt_Delete_att.FlatAppearance.BorderSize = 0;
            this.bt_Delete_att.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Delete_att.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Delete_att.ForeColor = System.Drawing.Color.White;
            this.bt_Delete_att.Image = ((System.Drawing.Image)(resources.GetObject("bt_Delete_att.Image")));
            this.bt_Delete_att.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Delete_att.Location = new System.Drawing.Point(95, 3);
            this.bt_Delete_att.Name = "bt_Delete_att";
            this.bt_Delete_att.Size = new System.Drawing.Size(100, 43);
            this.bt_Delete_att.TabIndex = 179;
            this.bt_Delete_att.Text = "Delete";
            this.bt_Delete_att.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Delete_att.UseVisualStyleBackColor = false;
            this.bt_Delete_att.Click += new System.EventHandler(this.Bt_Delete_att_Click);
            // 
            // bt_view
            // 
            this.bt_view.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_view.FlatAppearance.BorderSize = 0;
            this.bt_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_view.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_view.ForeColor = System.Drawing.Color.White;
            this.bt_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_view.Location = new System.Drawing.Point(201, 3);
            this.bt_view.Name = "bt_view";
            this.bt_view.Size = new System.Drawing.Size(100, 43);
            this.bt_view.TabIndex = 198;
            this.bt_view.Text = "View";
            this.bt_view.UseVisualStyleBackColor = false;
            this.bt_view.Click += new System.EventHandler(this.bt_view_Click);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.panel28);
            this.panel14.Controls.Add(this.txb_Eno);
            this.panel14.Controls.Add(this.label11);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel14.Location = new System.Drawing.Point(307, 3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(185, 43);
            this.panel14.TabIndex = 199;
            // 
            // panel28
            // 
            this.panel28.BackColor = System.Drawing.Color.DarkGray;
            this.panel28.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel28.Location = new System.Drawing.Point(0, 42);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(185, 2);
            this.panel28.TabIndex = 188;
            // 
            // txb_Eno
            // 
            this.txb_Eno.BackColor = System.Drawing.Color.White;
            this.txb_Eno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_Eno.Dock = System.Windows.Forms.DockStyle.Top;
            this.txb_Eno.Enabled = false;
            this.txb_Eno.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Eno.ForeColor = System.Drawing.Color.Black;
            this.txb_Eno.Location = new System.Drawing.Point(0, 20);
            this.txb_Eno.Name = "txb_Eno";
            this.txb_Eno.Size = new System.Drawing.Size(185, 22);
            this.txb_Eno.TabIndex = 187;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 20);
            this.label11.TabIndex = 186;
            this.label11.Text = "Code";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 36);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(865, 35);
            this.panel5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(693, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Maintenance";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(16, 536);
            this.panel2.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(887, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 536);
            this.panel1.TabIndex = 27;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 553);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(903, 19);
            this.panel4.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(903, 17);
            this.panel3.TabIndex = 29;
            // 
            // uc_setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "uc_setting";
            this.Size = new System.Drawing.Size(903, 572);
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Employees.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Employees;
        private System.Windows.Forms.ListView lv_tblemployees;
        private System.Windows.Forms.ColumnHeader no;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader dBirth;
        private System.Windows.Forms.ColumnHeader dRate;
        private System.Windows.Forms.ColumnHeader wDays;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button bt_Edit_att;
        private System.Windows.Forms.Button bt_Delete_att;
        private System.Windows.Forms.Button bt_view;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel28;
        public System.Windows.Forms.TextBox txb_Eno;
        private System.Windows.Forms.Label label11;
    }
}
