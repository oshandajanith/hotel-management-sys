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

namespace WindowsFormsApp6
{
    public partial class guest : Form
    {
        public guest()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Acer\\Documents\\db.accdb");

        void dataviewer()
        {
            //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Acer\\Documents\\db.accdb");
            con.Open();
            string s = "SELECT * FROM Guest";
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(s, con))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;


                dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
                con.Close();    





            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ( txtFname.Text == "" || txtLname.Text == "" || Txtph.Text == "")
            {
                MessageBox.Show("Requierd field-id no,First name and phone no:", "Requerd Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {

                    //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Acer\\Documents\\romm1.accdb");
                    con.Open();
                    string s = "insert into Guest(Guest_ID,First_Name,Last_Name,Address,Phone,Email)" + "values(@id,@firstname,@lastname,@address,@phone,@email)";
                    OleDbCommand cmd = new OleDbCommand(s, con);
                    cmd.Parameters.AddWithValue("@id", txtId.Text);
                    cmd.Parameters.AddWithValue("@firstname", txtFname.Text);
                    cmd.Parameters.AddWithValue("@lastname", txtLname.Text);
                    cmd.Parameters.AddWithValue("@address", txtAdd.Text);
                    cmd.Parameters.AddWithValue("@phone", Txtph.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);


                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("New Guest Save Successfuly", "Guset Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnclear.PerformClick();
                    dataviewer();





                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "access connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }

        }

        private void guest_Load(object sender, EventArgs e)
        {
            dataviewer();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //txtFname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //txtLname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //txtAdd.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //Txtph.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            //txtEmail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtFname.Text = "";
            txtLname.Text = "";
            Txtph.Text = "";
            txtId.Text = "";
            txtEmail.Text = "";
            txtAdd.Text = "";
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {

                //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Acer\\Documents\\romm1.accdb");
                con.Open();
                string s = "Delete * from Guest where Guest_ID='"+txtId.Text+"'";
                OleDbCommand cmd = new OleDbCommand(s, con);



                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(" Guest Remove Successfuly", "Guset Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnclear.PerformClick();
                dataviewer();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "access connect", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void btnup_Click(object sender, EventArgs e)
        {
            try
            {

                //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Acer\\Documents\\romm1.accdb");
                con.Open();
                string s = "Update Guest set Guest_ID='"+txtId.Text+"'where First_Name='"+txtFname.Text+"'and Last_Name='"+txtLname.Text+"'";
                OleDbCommand cmd = new OleDbCommand(s, con);
                


                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Recod updated successfully","update success",MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnclear.PerformClick();
                dataviewer();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"access connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtFname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtLname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtAdd.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Txtph.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
    }
    
}
