using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace WindowsFormsApp6
{
    public partial class reservation : Form
    {
        
        public reservation()
        {
            InitializeComponent();

        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Acer\\Documents\\db.accdb");

        void dataviewer()
        {
            //OleDbConnection ro = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Acer\\Documents\\reser.accdb");
            con.Open();
            string s = "SELECT * FROM reserv";
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(s, con))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;


                dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
                con.Close();
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateout = dateTimePicker2.Value;
            DateTime datein = dateTimePicker1.Value;

            TimeSpan difference = dateout - datein;
            Dates.Text = difference.Days + " ";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void reservation_Load(object sender, EventArgs e)
        {
            try
            {
                // OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Acer\\Documents\\hroom.accdb");
                con.Open();
                OleDbCommand command = con.CreateCommand();
                string s = "Select * from room";
                command.CommandText = s;



                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string rtype = reader.GetString(1);
                    RoomType.Items.Add(rtype);
                    //string price = reader.GetString(2);
                    //txtprice.Text = price;
                }



                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataviewer();
            lblstatus.Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Acer\\Documents\\reser.accdb");
                con.Open();
                string s = "insert into reserv (Reservation_ID,Customer_Id,Room_Type,Room_No,Date_In,Date_Out,Price,Numof_Dates)" + "values(@reservid,@customerid,@roomtype,@roomno,@datein,@dateout,@price,@dates)";
                OleDbCommand cmd = new OleDbCommand(s, con);
                cmd.Parameters.AddWithValue("@reservid", txtRid.Text);
                cmd.Parameters.AddWithValue("@customerid", txtCid.Text);
                cmd.Parameters.AddWithValue("@roomtype", RoomType.SelectedItem);
                cmd.Parameters.AddWithValue("@roomno", txtroomno.Text);
                cmd.Parameters.AddWithValue("@datein", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@dateout", dateTimePicker2.Text);
                cmd.Parameters.AddWithValue("@price", txtprice.Text);
                cmd.Parameters.AddWithValue("@dates", Dates.Text);


                cmd.ExecuteNonQuery();
                con.Close();

                btnclear.PerformClick();
                dataviewer();
                





                if (lblst.Text == "Busy")
                {
                    MessageBox.Show(" Room is not available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(" Save Successfuly", "Details Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "access connect", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }





        }

        private void setreservroom()
        {
            throw new NotImplementedException();
        }

        private void RoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Acer\\Documents\\hroom.accdb");
                con.Open();
                OleDbCommand command = con.CreateCommand();
                string s = "Select * from room Where Room_Type='" + RoomType.SelectedItem.ToString() + "'";
                command.CommandText = s;



                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string roomno = reader.GetString(0);
                    txtroomno.Text = roomno;
                    string status = reader.GetString(4);
                    lblst.Text = status;
                   string price=reader.GetString(2);
                    txtprice.Text = price;

                }
                try
                {
                    if (RoomType.SelectedItem != null)
                    {
                        lblstatus.Visible = true;
                    }

                    if (lblst.Text == "Busy")
                        MessageBox.Show(" Room is not available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            con.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtRid.Text = "";
            txtCid.Text = "";
            txtroomno.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            lblst.Text = "";
            RoomType.Text = "";
            txtprice.Text = "";
            Dates.Text = "";
            lblst.Visible = false;

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {

                //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Acer\\Documents\\reser.accdb");
                con.Open();
                string s = "Delete * from reserv where Reservation_ID='" + txtRid.Text + "'";
                OleDbCommand cmd = new OleDbCommand(s, con);



                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(" Remove Successfuly", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnclear.PerformClick();
                dataviewer();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "access connect", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtCid.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            RoomType.SelectedItem = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtroomno.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtprice.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            //dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            //dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            Dates.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void BtnUodate_Click(object sender, EventArgs e)
        {
            try
            {

               // OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Acer\\Documents\\reser.accdb");
                con.Open();
                string s = "Update reserv set Reservation_ID ='" + txtRid.Text + "'where Customer_Id ='" + txtCid.Text + "'and Room_NO='" + txtroomno.Text + "'";
                OleDbCommand cmd = new OleDbCommand(s, con);



                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Recod updated successfully", "update success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnclear.PerformClick();
                dataviewer();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "access connect", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        //public bool setreservroom(string rno, string sts)
        //{
        //    OleDbConnection ro = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Acer\\Documents\\hroom.accdb");
        //    ro.Open();
        //    string j = "Update roomdb set Status =@status WHERE RoomTD=@roomno";
        //    OleDbCommand com = new OleDbCommand(j, ro);
        //    com.Parameters.Add("@status", OleDbType.VarChar).Value = rno;
        //    com.Parameters.Add("@roomno", OleDbType.VarChar).Value = sts;
        //    ro.Open();
        //    if (com.ExecuteNonQuery() == 1)
        //    {
        //        ro.Close();
        //        return true;
        //    }
        //    else
        //    {
        //        ro.Close();
        //        return false;
        //    }
        //}
    }
}
