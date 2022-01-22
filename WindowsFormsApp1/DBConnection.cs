using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;


namespace WindowsFormsApp1
{
    public class DBConnection
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lites\Desktop\WindowsFormsApp1\WindowsFormsApp1\dbPS.mdf;Integrated Security=True");

        public void data_manipulate(String dm)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = dm;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void dataGetEmployeeInfo(String dm, Label lb2, Label lb3, Label lb4, Label lb5, Label lb6 )
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = dm;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lb2.Text = (dr["Lname"].ToString() + dr["Fname"].ToString() + dr["Mname"].ToString());
                lb3.Text = (dr["Dbirth"].ToString());
                lb4.Text = (dr["Drate"].ToString());
                lb5.Text = (dr["Wdays"].ToString());
                lb6.Text = (dr["Birthdate"].ToString());
             
            }
            conn.Close();
        }



        public void Series(string proc, TextBox txt, DateTime date, string txt2)
        {
            SqlDataAdapter sda = new SqlDataAdapter(proc, conn);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("@DBirth", SqlDbType.Char).Value = date;
            sda.SelectCommand.Parameters.Add("@NamePrefix", SqlDbType.VarChar).Value = txt2;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txt.Text = dt.Rows[0][0].ToString();
        }

        public void Data_manipulate(string dm)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = dm;
            cmd.ExecuteNonQuery();
            conn.Close();
        }



        public void listLoadDataProg(ListView lv, string com)
        {
            lv.Items.Clear();
            try
            {
                lv.View = View.Details;
                SqlDataReader dr;
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = com;
                conn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        // change based on database
                        ListViewItem item = new ListViewItem(dr[0].ToString());
                        item.SubItems.Add(dr[1].ToString());
                        lv.Items.Add(item);
                    }
                    dr.Close();
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        public void listLoadDataCrs(ListView lv, string com)
        {
            lv.Items.Clear();
            try
            {
                lv.View = View.Details;
                SqlDataReader dr;
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = com;
                conn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        // change based on database
                        ListViewItem item = new ListViewItem(dr[0].ToString());
                        item.SubItems.Add(dr[1].ToString());
                        item.SubItems.Add(dr[2].ToString());
                        lv.Items.Add(item);
                    }
                    dr.Close();
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        public void listLoadDataMjr(ListView lv, string com)
        {
            lv.Items.Clear();
            try
            {
                lv.View = View.Details;
                SqlDataReader dr;
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = com;
                conn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        // change based on database
                        ListViewItem item = new ListViewItem(dr[0].ToString());
                        item.SubItems.Add(dr[1].ToString());
                        item.SubItems.Add(dr[2].ToString());
                        lv.Items.Add(item);
                    }
                    dr.Close();
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        public void listLoadDataAttend(ListView lv, string com)
        {
            lv.Items.Clear();
            try
            {
                lv.View = View.Details;
                SqlDataReader dr;
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = com;
                conn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        // change based on database
                        ListViewItem item = new ListViewItem(dr[0].ToString());
                        item.SubItems.Add(dr[3].ToString() + ", " + dr[1].ToString() + " " + dr[2].ToString());
                        item.SubItems.Add(dr[4].ToString());
                        item.SubItems.Add(dr[5].ToString());
                        item.SubItems.Add(dr[6].ToString());
                        lv.Items.Add(item);
                    }
                    dr.Close();
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        public void listLoadDataCert(ListView lv, string com)
        {
            lv.Items.Clear();
            try
            {
                lv.View = View.Details;
                SqlDataReader dr;
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = com;
                conn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        // change based on database
                        ListViewItem item = new ListViewItem(dr[0].ToString());
                        item.SubItems.Add(dr[1].ToString() + " " + dr[2].ToString() + " " + dr[3].ToString());
                        item.SubItems.Add(dr[4].ToString());
                        item.SubItems.Add(dr[5].ToString());
                        item.SubItems.Add(dr[6].ToString());
                        lv.Items.Add(item);
                    }
                    dr.Close();
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        public void data_deletion(string delete)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = delete;
                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show("ERROR! Please delete a existing Transaction", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();

        }

        public void data_deletion2(string delete, string deletes)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = delete;
                cmd.ExecuteNonQuery();
                cmd.CommandText = deletes;
                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show("ERROR! Please delete a existing Transaction", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();

        }

        public void CategoryList(ComboBox cb)
        {
            SqlCommand cmd = new SqlCommand("Select * from [tbl_program]", conn);
            SqlDataReader myRead;
            try
            {
                conn.Open();
                myRead = cmd.ExecuteReader();
                while (myRead.Read())
                {
                    string Description = myRead.GetString(1);
                    cb.Items.Add(Description);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void FillCombo(ComboBox combo, string query, string displayMember, string valueMember)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            sda.Fill(tb);
            combo.DataSource = tb;
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
        }
       
    }
}
