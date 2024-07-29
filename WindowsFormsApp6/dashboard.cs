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
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp6
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            
            InitializeComponent();
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_Load(object sender, EventArgs e)
        {

            try
            {
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Acer\\Documents\\db.accdb");
                con.Open();
                OleDbCommand command = con.CreateCommand();
                string s = "Select * from reserv";
                command.CommandText = s;




                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string guest = reader.GetString(1);
                    lblguest.Text = guest;
                    chart1.Series["Guest"].Points.AddXY("Guest",guest);
                    string room = reader.GetString(3);
                    chart1.Series["Rooms"].Points.AddXY("Rooms", room);
                }






                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string j= ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Acer\\Documents\\db.accdb");
            string selectquery = "SELECT SUM(Total) FROM payment";
            using(OleDbConnection connection = new OleDbConnection(j)) 
                using(OleDbCommand command = new OleDbCommand(selectquery,connection))
            {
                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        decimal total = Convert.ToDecimal(result);
                        lblearn.Text = total.ToString()+"$";
                    }
                    else
                    {
                        lblearn.Text = "0$";
                    }
                
                }
                catch(Exception ex) 
                {
                    lblearn.Text="error"+ex.Message;

               
                }
            }
            //string c = "SELECT COUNT(*) AS Totalrooms,SUM(IIF(Status='Available',1,0)) AS Availablerooms FROM room";
            //using(OleDbConnection con = new OleDbConnection(j))
            //    using(OleDbCommand command = new OleDbCommand(c,con))
            //{
            //    try
            //    {
            //        con.Open();
            //        OleDbDataReader reader = command.ExecuteReader();

            //        if(reader.Read())
            //        {
            //            int totalroom = Convert.ToInt32(reader["Totalrooms"]);
            //            int availableroom = Convert.ToInt32(reader["Availablerooms"]);

            //            double precentage=(availableroom*100.0)/totalroom;

            //            circularProgressBar1.Value = (int)precentage;
            //        }
            //    }
            //    catch(Exception ex)
            //    {
            //        MessageBox.Show("error"+ex.Message);
            //    }
            //}

    }   

    } 
        

    
}
