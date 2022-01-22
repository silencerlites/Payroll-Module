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
    public partial class uc_setting : UserControl
    {
        private static uc_setting _instance;

        public static uc_setting Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_setting();
                return _instance;
            }
        }
        public DBConnection dbConn = new DBConnection();
        public uc_setting()
        {
            InitializeComponent();
            dbConn.listLoadDataAttend(lv_tblemployees, "Select * from [tbl_employees]");
            Disable(false, false);
        }

        void Clear()
        {
            txb_Eno.Text = "";
        }

        void Disable(bool bt, bool bt1)
        {
          
            bt_Edit_att.Enabled = bt_view.Enabled = bt_Delete_att.Enabled = bt;
           
        }


        private void Bt_Delete_att_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to continue!", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (dialogResult == DialogResult.Yes)
            {
                dbConn.data_deletion("Delete from [tbl_employees] where EmpNo = '" + txb_Eno.Text + "'");
                Clear();
                Disable(false, false);
                dbConn.listLoadDataAttend(lv_tblemployees, "Select * from [tbl_employees]");
  
                MessageBox.Show("Record Delete");
            }

            else
            {
                MessageBox.Show("Record Deleted Fail");
                Clear();
                Disable(false, false);
                dbConn.listLoadDataAttend(lv_tblemployees, "Select * from [tbl_employees]");
               
            }
        }

        private void Lv_tblattendees_Click(object sender, EventArgs e)
        {
            Disable(true, false);
           
            if (lv_tblemployees.SelectedItems.Count > 0)
            {
                txb_Eno.Text = lv_tblemployees.SelectedItems[0].Text;
            }
        }

 


        private void TabControl1_Click(object sender, EventArgs e)
        {
            dbConn.listLoadDataAttend(lv_tblemployees, "Select * from [tbl_employees]");
        }

        private void bt_view_Click(object sender, EventArgs e)
        {
            _ = DataMB.ShowMessageP(txb_Eno.Text, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
           
     
        }

        private void lv_tblemployees_Leave(object sender, EventArgs e)
        {
            Disable(false, false);
        }
    }
}
