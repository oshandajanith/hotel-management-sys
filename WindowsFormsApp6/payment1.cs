using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp6
{
    public partial class payment1 : Form
    {
        
        public payment1()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Acer\\Documents\\db.accdb");
        public void dataviewer()
        {
           // OleDbConnection ro = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Acer\\Documents\\payment1.accdb");
            con.Open();
            string s = "SELECT * FROM payment";
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(s, con))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;


                dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
                con.Close();





            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                //OleDbConnection ro = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Acer\\Documents\\payment1.accdb");
                con.Open();


                string s = "insert into payment(Payment_ID,Customer_Id,Dates,Type,Room_price,Total)" + "values(@paymentid,@guestid,@paydate,@types,@price,@total)";
                OleDbCommand cmd = new OleDbCommand(s, con);
                cmd.Parameters.AddWithValue("@paymentid", txtPid.Text);
                cmd.Parameters.AddWithValue("@guestid", cusId.SelectedItem);
                cmd.Parameters.AddWithValue("@paydate", txtdates.Text);
                cmd.Parameters.AddWithValue("@types", textRtype.Text);
                cmd.Parameters.AddWithValue("@price", txtprice.Text);
                cmd.Parameters.AddWithValue("@total", lbltotal.Text);



                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Added Successfuly", "Add payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnclear.PerformClick();
                dataviewer();


                //if (decimal.TryParse(txtprice.Text, out decimal val1) && decimal.TryParse(txtdates.Text, out decimal val2))
                //{
                //    decimal result = val1 * val2;
                //    lbltotal.Text = result.ToString();
                //}


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "access connect", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        
        }
    

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtPid.Text = "";
            //txtCid.Text = "";
            //dateTimePicker1.Text = "";
            txtPid.Text = "";
            txtprice.Text = "";
            txtdates.Text = "";
            textRtype.Text = "";
        }

        private void BtnUodate_Click(object sender, EventArgs e)
        {

            try
            {

                //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Acer\\Documents\\payment1.accdb");
                con.Open();
                string s = "Update payment set Payment_ID='" + txtPid.Text + "'where Customer_Id ='" + cusId.SelectedItem + "'";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cusId.SelectedItem= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtdates.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textRtype.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtprice.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            lbltotal.Text= dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void payment1_Load(object sender, EventArgs e)
        {

            try
            {
                //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\Acer\\Desktop\\New folder\\WindowsFormsApp6\\WindowsFormsApp6\\types.accdb\"");
                con.Open();
                OleDbCommand command = con.CreateCommand();
                string s = "Select * from reserv";
                command.CommandText = s;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cusId.Items.Add(reader["Customer_Id"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataviewer();
            
           
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {

                //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Acer\\Documents\\payment1.accdb");
                con.Open();
                string s = "Delete * from payment where payment_ID='" + txtPid.Text + "'";
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

        private void txtCid_TextChanged(object sender, EventArgs e)
        {
        }

        private void cusId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Acer\\Documents\\hroom.accdb");
                con.Open();
                OleDbCommand command = con.CreateCommand();
                string s = "Select * from reserv Where Customer_Id='" + cusId.SelectedItem.ToString() + "'";
                command.CommandText = s;



                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                   
                    
                    string types=reader.GetString(2);
                    textRtype.Text = types; 
                    string price=reader.GetString(4);
                    txtprice.Text = price;
                    string dates=reader.GetString(7);
                    txtdates.Text = dates;
                }
                if (decimal.TryParse(txtprice.Text, out decimal val1) && decimal.TryParse(txtdates.Text, out decimal val2))
                {
                    decimal result = val1 * val2;
                    lbltotal.Text = result.ToString()+"$";
                }


            }
            catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            con.Close();
            //try
            //{
            //    con.Open();
            //    OleDbCommand command = con.CreateCommand();
            //    string s = "Select * from types Where Price='" + txtprice.Text + "'";
            //    command.CommandText = s;
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            con.Close();

            }

        private void txtdates_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }  

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {
            
            
        }
    }
    
    }
    

