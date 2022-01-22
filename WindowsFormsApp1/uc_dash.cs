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
    public partial class uc_dash : UserControl
    {
        DBConnection dbconn = new DBConnection();
        private static uc_dash _instance;
        public static uc_dash Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_dash();
                return _instance;
            }
        }
        public uc_dash()
        {
            InitializeComponent();
            numUser();
            timer1.Start();
        }

        void numUser()
        {
            string sql = "SELECT COUNT(EmpNo) FROM tbl_employees";

            try
            {
                dbconn.conn.Open();
                SqlCommand command = new SqlCommand(sql, dbconn.conn);
                Int32 rows_count = Convert.ToInt32(command.ExecuteScalar());
                command.Dispose();
                dbconn.conn.Close();
                lb_atten.Text = "" + rows_count.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (dbconn.conn.State == ConnectionState.Open)
                {
                    dbconn.conn.Close();
                }
            }
        }

    

        private void Timer1_Tick(object sender, EventArgs e)
        {
            numUser();
        }

    }
}
