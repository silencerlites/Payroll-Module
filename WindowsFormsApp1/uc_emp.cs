using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class uc_emp : UserControl
    {
        private static uc_emp _instance;
        public static uc_emp Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_emp();
                return _instance;
            }
        }
        DBConnection dbConn = new DBConnection();
        int chkListCount = 0;


        public uc_emp()
        {
            InitializeComponent();

            lb_f.Visible = lb_l.Visible = lb_m.Visible = lb_s.Visible = false;
            txtb_eNo.Enabled = false;
            


        }

        void Clear()
        {
            txtb_eNo.Text = txtb_FirstN.Text = txtb_Middle.Text = txtb_dRate.Text = txt_LastN.Text = "";
            panel12.Visible = false;
        }

        private void txtb_FirstN_Enter(object sender, EventArgs e)
        {
            if (txtb_FirstN.Text == "First Name")
            {
                txtb_FirstN.Text = "";
                txtb_FirstN.ForeColor = Color.Black;
                lb_f.Visible = true;
            }
        }

        private void txtb_FirstN_Leave(object sender, EventArgs e)
        {
            if (txtb_FirstN.Text == "")
            {
                txtb_FirstN.Text = "First Name";
                txtb_FirstN.ForeColor = Color.Gray;
                lb_f.Visible = false;
            }
        }

        private void txtb_Middle_Enter(object sender, EventArgs e)
        {
            if (txtb_Middle.Text == "Middle Name")
            {
                txtb_Middle.Text = "";
                txtb_Middle.ForeColor = Color.Black;
                lb_m.Visible = true;
            }
        }

        private void txtb_Middle_Leave(object sender, EventArgs e)
        {
            if (txtb_Middle.Text == "")
            {
                txtb_Middle.Text = "Middle Name";
                txtb_Middle.ForeColor = Color.Gray;
                lb_m.Visible = false;
            }
        }

        private void txtb_LastN_Enter(object sender, EventArgs e)
        {
            if (txt_LastN.Text == "Last Name")
            {
                txt_LastN.Text = "";
                txt_LastN.ForeColor = Color.Black;
                lb_l.Visible = true;
            }
        }

        private void txtb_LastN_Leave(object sender, EventArgs e)
        {
            if (txt_LastN.Text == "")
            {
                txt_LastN.Text = "Last Name";
                txt_LastN.ForeColor = Color.Gray;
                lb_l.Visible = false;
            }
        }

        private void txtb_DRate_Enter(object sender, EventArgs e)
        {
            if (txtb_dRate.Text == "Daily Rate")
            {
                txtb_dRate.Text = "";
                txtb_dRate.ForeColor = Color.Black;
                lb_s.Visible = true;
            }

        }

        private void txtb_DRate_Leave(object sender, EventArgs e)
        {
            if (txtb_dRate.Text == "")
            {
                txtb_dRate.Text = "Section";
                txtb_dRate.ForeColor = Color.Gray;
                lb_s.Visible = false;
            }
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            if (txtb_FirstN.Text == "First Name" && txtb_Middle.Text == "Middle Name" && txt_LastN.Text == "Last Name" && txtb_dRate.Text == "Daily Rate")
            {
                MessageBox.Show("Error! Please Enter your Information");
            }
            else
            {
                dbConn.Series("proc_emp", txtb_eNo, dtp_dBirth.Value.Date, txtb_FirstN.Text);

                var selectedWdays = new List<string>();

                foreach (var lang in clb_wDays.CheckedItems)
                {
                    selectedWdays.Add(lang.ToString());
                }

                dbConn.conn.Open();
                SqlCommand cmd = dbConn.conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ENo", txtb_eNo.Text);
                cmd.Parameters.AddWithValue("@Fname", txtb_FirstN.Text);
                cmd.Parameters.AddWithValue("@Mname", txtb_Middle.Text);
                cmd.Parameters.AddWithValue("@Lname", txt_LastN.Text);
                cmd.Parameters.AddWithValue("@Dbirth", dtp_dBirth.Value.Date);
                cmd.Parameters.AddWithValue("@Drate", txtb_dRate.Text);
                cmd.Parameters.AddWithValue("@Wdays", string.Join(", ", selectedWdays));
                cmd.Parameters.AddWithValue("@WdaysCount", chkListCount);
                cmd.CommandText = "Insert into [tbl_employees] (EmpNo, Fname, Mname, Lname, Dbirth, Drate, Wdays, WdaysCount) values (@ENo, @Fname, @Mname, @Lname, @Dbirth, @Drate, @Wdays, @WdaysCount)";
                cmd.ExecuteNonQuery();
                dbConn.conn.Close();
                MessageBox.Show("Record Added");
                Clear();
            }
           
        }

        private void clb_wDays_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                chkListCount++;
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                chkListCount--;
            }

        }
    }
}
