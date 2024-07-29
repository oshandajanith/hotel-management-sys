using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "admin" && txtpass.Text == "admin")
            {
                MessageBox.Show(" Login successful", "login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                main main=new main();
                main.Show();
            }
            else 
            {
                
                label4.Visible = true; label5.Visible=true;
                MessageBox.Show(" Login Fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {
            
            label4.Visible = false;
        }

        private void txtuser_Click(object sender, EventArgs e)
        {
            txtuser.SelectAll();
            
        }

        private void txtpass_Click(object sender, EventArgs e)
        {
            txtpass.SelectAll();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
