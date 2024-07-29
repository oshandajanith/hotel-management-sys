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
using Org.BouncyCastle.Asn1.Ocsp;

namespace WindowsFormsApp6
{
    public partial class Room1 : Form
    {
        string g;
        public Room1()
        {
            InitializeComponent();
           
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Acer\\Documents\\db.accdb");

        void dataviewer()
        {
           // OleDbConnection ro = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Acer\\Documents\\hroom.accdb");
            con.Open();
            string s = "SELECT * FROM room";
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(s, con))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;


                dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
                con.Close();





            }
        }

        private void Room_Load(object sender, EventArgs e)
        {

            try
            {
                //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\Acer\\Desktop\\New folder\\WindowsFormsApp6\\WindowsFormsApp6\\types.accdb\"");
                con.Open();
                OleDbCommand command = con.CreateCommand();
                string s = "Select * from types";
                command.CommandText = s;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    RoomType.Items.Add(reader["Lable"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataviewer();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                g = "Free";
            }
            else
                g = "Busy";


            try
            {

               // OleDbConnection ro = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Acer\\Documents\\hroom.accdb");
                con.Open();
              

                string s = "insert into room(Room_ID,Room_Type,Room_Price,Phone_No,Status)" + "values(@roomid,@roomtype,@price,@phoneno,@status)";
                OleDbCommand cmd = new OleDbCommand(s, con);
                cmd.Parameters.AddWithValue("@roomid", txtRid.Text);
                cmd.Parameters.AddWithValue("@roomtype", RoomType.SelectedItem);
                cmd.Parameters.AddWithValue("@price",lblprice.Text);
                cmd.Parameters.AddWithValue("@phoneno", txtph.Text);
                cmd.Parameters.AddWithValue("@status", g);
                

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Room Added Successfuly", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnclear.PerformClick();
                dataviewer();





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "access connect", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void BtnUodate_Click(object sender, EventArgs e)
        {
            try
            {

                //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Acer\\Documents\\hroom.accdb");
                con.Open();
                string s = "Update room set Status='" + g + "'where Room_Type ='" + RoomType.SelectedItem + "'and Room_ID='" + txtRid.Text + "'";
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            RoomType.SelectedItem= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lblprice.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtph.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            g = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            try
            {

                //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Acer\\Documents\\hroom.accdb");
                con.Open();
                string s = "Delete * from room where Room_ID='" + txtRid.Text + "'";
                OleDbCommand cmd = new OleDbCommand(s, con);



                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(" Room Remove Successfuly", "Room Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnclear.PerformClick();
                dataviewer();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "access connect", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtRid.Text = "";
            RoomType.SelectedItem = "";
            txtph.Text = "";
            lblprice.Text = "";
            g = "";
        }

        private void RoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Acer\\Documents\\hroom.accdb");
                con.Open();
                OleDbCommand command = con.CreateCommand();
                string s = "Select * from types Where Lable ='" + RoomType.SelectedItem.ToString() + "'";
                command.CommandText = s;



                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    decimal price = reader.GetDecimal(2);
                    lblprice.Text = price.ToString();
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
    }
}
