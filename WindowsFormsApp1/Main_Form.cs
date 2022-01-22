using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            Date_Time.Start();

            if (!uc_panel.Controls.Contains(uc_dash.Instance))
            {
                uc_panel.Controls.Clear();
                uc_panel.Controls.Add(uc_dash.Instance);
                uc_dash.Instance.Dock = DockStyle.Fill;
                uc_dash.Instance.BringToFront();
            }
            else
                uc_dash.Instance.BringToFront();
        }

        void sidePanel(int sp1, int sp2)
        {
            SidePanel.Height = sp1;
            SidePanel.Top = sp2;
        }

        public Point mouseLocation;

        private void ptitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void ptitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }


        private void Pb_Nav_Click(object sender, EventArgs e)
        {
            if(panel2.Width == 256)
            {
                panel2.Width = 77;
            }
            else
            {
                panel2.Width = 256;
            }
        }

        private void Date_Time_Tick(object sender, EventArgs e)
        {
            DateTime datetimeObject = DateTime.Now;
            dateTime.Text = datetimeObject.ToString("dddd, MMMM dd, yyyy | hh:mm:ss tt");
        }

        private void Bt_dashboard_Click(object sender, EventArgs e)
        {
            sidePanel(bt_dashboard.Height, bt_dashboard.Top);
            if (!uc_panel.Controls.Contains(uc_dash.Instance))
            {
                uc_panel.Controls.Clear();
                uc_panel.Controls.Add(uc_dash.Instance);
                uc_dash.Instance.Dock = DockStyle.Fill;
                uc_dash.Instance.BringToFront();
            }
            else
                uc_dash.Instance.BringToFront();
        }

        private void Bt_attendance_Click(object sender, EventArgs e)
        {
            sidePanel(bt_emp.Height, bt_emp.Top);
            if (!uc_panel.Controls.Contains(uc_emp.Instance))
            {
                uc_panel.Controls.Clear();
                uc_panel.Controls.Add(uc_emp.Instance);
                uc_emp.Instance.Dock = DockStyle.Fill;
                uc_emp.Instance.BringToFront();
            }
            else
                uc_emp.Instance.BringToFront();
                
        }


        private void Bt_setting_Click(object sender, EventArgs e)
        {
            
                sidePanel(bt_setting.Height, bt_setting.Top);

                if (!uc_panel.Controls.Contains(uc_setting.Instance))
                {
                    uc_panel.Controls.Add(uc_setting.Instance);
                    uc_setting.Instance.Dock = DockStyle.Fill;
                    uc_setting.Instance.BringToFront();
                }
                else
                    uc_setting.Instance.BringToFront();


        }
        private void LmcClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
