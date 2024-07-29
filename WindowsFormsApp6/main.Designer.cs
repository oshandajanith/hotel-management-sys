namespace WindowsFormsApp6
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.panellogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.paneltitle = new System.Windows.Forms.Panel();
            this.lbltitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnPay = new Guna.UI2.WinForms.Guna2Button();
            this.btnRoom = new Guna.UI2.WinForms.Guna2Button();
            this.btnRecipt = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuest = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panellogo.SuspendLayout();
            this.paneltitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelMain.Controls.Add(this.pnlNav);
            this.panelMain.Controls.Add(this.btnExit);
            this.panelMain.Controls.Add(this.btnPay);
            this.panelMain.Controls.Add(this.btnRoom);
            this.panelMain.Controls.Add(this.btnRecipt);
            this.panelMain.Controls.Add(this.btnGuest);
            this.panelMain.Controls.Add(this.btnDashboard);
            this.panelMain.Controls.Add(this.panellogo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(200, 686);
            this.panelMain.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.Black;
            this.pnlNav.Location = new System.Drawing.Point(3, 190);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(4, 100);
            this.pnlNav.TabIndex = 1;
            // 
            // panellogo
            // 
            this.panellogo.Controls.Add(this.label1);
            this.panellogo.Controls.Add(this.pictureBox1);
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(200, 138);
            this.panellogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(35, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome Back";
            // 
            // paneltitle
            // 
            this.paneltitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(10)))), ((int)(((byte)(12)))));
            this.paneltitle.Controls.Add(this.label2);
            this.paneltitle.Controls.Add(this.lbltitle);
            this.paneltitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitle.Location = new System.Drawing.Point(200, 0);
            this.paneltitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paneltitle.Name = "paneltitle";
            this.paneltitle.Size = new System.Drawing.Size(1013, 50);
            this.paneltitle.TabIndex = 1;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(465, 14);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(117, 25);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Dashboard";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 50);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1013, 636);
            this.panelDesktop.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::WindowsFormsApp6.Properties.Resources.logout;
            this.btnExit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnExit.Location = new System.Drawing.Point(0, 640);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 46);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.Leave += new System.EventHandler(this.btnExit_Leave);
            // 
            // btnPay
            // 
            this.btnPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPay.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Image = global::WindowsFormsApp6.Properties.Resources.wallet;
            this.btnPay.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPay.Location = new System.Drawing.Point(0, 322);
            this.btnPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(200, 46);
            this.btnPay.TabIndex = 5;
            this.btnPay.Text = "Payment";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            this.btnPay.Leave += new System.EventHandler(this.btnPay_Leave);
            // 
            // btnRoom
            // 
            this.btnRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRoom.ForeColor = System.Drawing.Color.White;
            this.btnRoom.Image = global::WindowsFormsApp6.Properties.Resources.hotel__1_;
            this.btnRoom.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRoom.Location = new System.Drawing.Point(0, 276);
            this.btnRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(200, 46);
            this.btnRoom.TabIndex = 4;
            this.btnRoom.Text = "Room";
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            this.btnRoom.Leave += new System.EventHandler(this.btnRoom_Leave);
            // 
            // btnRecipt
            // 
            this.btnRecipt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRecipt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRecipt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRecipt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRecipt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecipt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRecipt.ForeColor = System.Drawing.Color.White;
            this.btnRecipt.Image = global::WindowsFormsApp6.Properties.Resources._2384180_2001;
            this.btnRecipt.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRecipt.Location = new System.Drawing.Point(0, 230);
            this.btnRecipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRecipt.Name = "btnRecipt";
            this.btnRecipt.Size = new System.Drawing.Size(200, 46);
            this.btnRecipt.TabIndex = 3;
            this.btnRecipt.Text = "Reciption";
            this.btnRecipt.Click += new System.EventHandler(this.btnRecipt_Click);
            this.btnRecipt.Leave += new System.EventHandler(this.btnRecipt_Leave);
            // 
            // btnGuest
            // 
            this.btnGuest.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuest.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuest.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuest.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGuest.ForeColor = System.Drawing.Color.White;
            this.btnGuest.Image = global::WindowsFormsApp6.Properties.Resources.guest;
            this.btnGuest.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGuest.Location = new System.Drawing.Point(0, 184);
            this.btnGuest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Size = new System.Drawing.Size(200, 46);
            this.btnGuest.TabIndex = 2;
            this.btnGuest.Text = "Guest";
            this.btnGuest.Click += new System.EventHandler(this.btnGuest_Click);
            this.btnGuest.Leave += new System.EventHandler(this.btnGuest_Leave);
            // 
            // btnDashboard
            // 
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::WindowsFormsApp6.Properties.Resources.data_analysis;
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.Location = new System.Drawing.Point(0, 138);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(200, 46);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnDashboard.Leave += new System.EventHandler(this.btnDashboard_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp6.Properties.Resources.promo_lk_promo_d088a979d2224c3294f38a32243e59ae;
            this.pictureBox1.Location = new System.Drawing.Point(45, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(964, -6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "x";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 686);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.paneltitle);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            this.panelMain.ResumeLayout(false);
            this.panellogo.ResumeLayout(false);
            this.panellogo.PerformLayout();
            this.paneltitle.ResumeLayout(false);
            this.paneltitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panellogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnPay;
        private Guna.UI2.WinForms.Guna2Button btnRoom;
        private Guna.UI2.WinForms.Guna2Button btnRecipt;
        private Guna.UI2.WinForms.Guna2Button btnGuest;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel paneltitle;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label label2;
    }
}