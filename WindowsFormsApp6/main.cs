using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApp6
{
    public partial class main : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        

        private static extern IntPtr CreateRoundRectRgn
     (
          int nLeftRect,
          int nTopRect,
          int nRightRect,
          int nBottomRect,
          int nWidthEllipse,
         int nHeightEllipse

      );
        public main()
        {
            InitializeComponent();
            random = new Random();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            lbltitle.Text = "Dashboard";
            this.panelDesktop.Controls.Clear();
            dashboard FrmDashboard_Vrb = new dashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelDesktop.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMain.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(0, 30, 54);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void openchildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            //ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbltitle.Text = childForm.Text;
        }
        private void Reset()
        {
            DisableButton();
            lbltitle.Text = "HOME";
            paneltitle.BackColor = Color.FromArgb(106, 10, 12);
            panellogo.BackColor = Color.FromArgb(26, 26, 26);
            currentButton = null;
            
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            lbltitle.Text = "Dashboard";
            this.panelDesktop.Controls.Clear();
            dashboard FrmDashboard_Vrb = new dashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelDesktop.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();

        }

        private void btnGuest_Click(object sender, EventArgs e)
        {

            pnlNav.Height = btnGuest.Height;
            pnlNav.Top = btnGuest.Top;
            pnlNav.Left = btnGuest.Left;
            btnGuest.BackColor = Color.FromArgb(46, 51, 73);

            lbltitle.Text = "Guest";
            this.panelDesktop.Controls.Clear();
            guest FrmDashboard_Vrb = new guest() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelDesktop.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void btnRecipt_Click(object sender, EventArgs e)
        {

            pnlNav.Height = btnRecipt.Height;
            pnlNav.Top = btnRecipt.Top;
            pnlNav.Left = btnRecipt.Left;
            btnRecipt.BackColor = Color.FromArgb(46, 51, 73);

            lbltitle.Text = "Reciption";
            this.panelDesktop.Controls.Clear();
            reservation FrmDashboard_Vrb = new reservation() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelDesktop.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {

            pnlNav.Height = btnRoom.Height;
            pnlNav.Top = btnRoom.Top;
            pnlNav.Left = btnRoom.Left;
            btnRoom.BackColor = Color.FromArgb(46, 51, 73);

            lbltitle.Text = "Room";
            this.panelDesktop.Controls.Clear();
            Room1 FrmDashboard_Vrb = new Room1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelDesktop.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnPay.Height;
            pnlNav.Top = btnPay.Top;
            pnlNav.Left = btnPay.Left;
            btnPay.BackColor = Color.FromArgb(46, 51, 73);

            lbltitle.Text = "Payment";
            this.panelDesktop.Controls.Clear();
            payment1 FrmDashboard_Vrb = new payment1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelDesktop.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnExit.Height;
            pnlNav.Top = btnExit.Top;
            pnlNav.Left = btnExit.Left;
            btnExit.BackColor = Color.FromArgb(46, 51, 73);
            //Application.Exit();
            login login= new login();
            this.Hide();
            login.Show();
            
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnGuest_Leave(object sender, EventArgs e)
        {
           btnGuest.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnRecipt_Leave(object sender, EventArgs e)
        {
            btnRecipt.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnRoom_Leave(object sender, EventArgs e)
        {
            btnRoom.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnPay_Leave(object sender, EventArgs e)
        {
            btnPay.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnExit_Leave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
