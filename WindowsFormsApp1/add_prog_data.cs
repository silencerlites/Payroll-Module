using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class add_prog_data : Form
    {
        DBConnection dbConn = new DBConnection();
        
        public add_prog_data()
        {
            InitializeComponent();
            
        }

        void Clear()
        {

        }

        public Point mouseLocation;

        private void panelDrag_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void panelDrag_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }



        public string Message
        {
            get { return lb_choice.Text; }
            set { txb_Eno.Text = lb_choice.Text = value; }
        }

        private void lmcMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lmcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bt_Add_Prog_Click(object sender, EventArgs e)
        {

        }

        private void Bt_Delete_Prog_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void dataGetPatientInfo()
        {
            dbConn.conn.Open();
            SqlCommand cmd = dbConn.conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From [tbl_employees] where EmpNo = '" + txb_Eno.Text + "'";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lb_name.Text = (dr["Lname"].ToString() +", " + dr["Fname"].ToString() +" "+ dr["Mname"].ToString());
                lb_dbirth.Text = (dr["Dbirth"].ToString());
                lb_drate.Text = (dr["Drate"].ToString());
                lb_wday.Text = (dr["Wdays"].ToString());
                lb_wcount.Text = (dr["WdaysCount"].ToString());

            }
            dbConn.conn.Close();
        }

        private void add_prog_data_Load(object sender, EventArgs e)
        {
            dataGetPatientInfo();

        }

        private void bt_Add_Prog_Click_1(object sender, EventArgs e)
        {
            int NumberOfDays = (dtp_end.Value - dtp_start.Value).Days;
            int WorkingDaysSE = (NumberOfDays * Convert.ToInt32(lb_wcount.Text) / 7);
            Double TotalPay = (WorkingDaysSE * 2 * Convert.ToInt32(lb_drate.Text));
            DateTime Birthday = Convert.ToDateTime(lb_dbirth.Text);
            DateTime dt_lower = Convert.ToDateTime(dtp_start.Value);
            DateTime dt_upper = Convert.ToDateTime(dtp_end.Value);
            DateTime nLower = new DateTime(dt_lower.Year, Birthday.Month, Birthday.Day);
            DateTime nUpper = new DateTime(dt_upper.Year, Birthday.Month, Birthday.Day);
            if (Birthday.Year <= dt_upper.Year && ((nLower >= dt_lower && nLower <= dt_upper) || (nUpper >= dt_lower && nUpper <= dt_upper)))
            {
                Double TotalPayBdayGift = (TotalPay + Convert.ToDouble(lb_drate.Text));
                lb_cal.Text = Convert.ToString(TotalPayBdayGift);
                // it's your birthday
            }
            else { lb_cal.Text = Convert.ToString(TotalPay); }
        }
    }
}
