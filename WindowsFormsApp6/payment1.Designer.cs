namespace WindowsFormsApp6
{
    partial class payment1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtPid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdates = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textRtype = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.cusId = new System.Windows.Forms.ComboBox();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.BtnUodate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(325, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(867, 446);
            this.dataGridView1.TabIndex = 57;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtPid
            // 
            this.txtPid.Location = new System.Drawing.Point(117, 38);
            this.txtPid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPid.Name = "txtPid";
            this.txtPid.Size = new System.Drawing.Size(173, 22);
            this.txtPid.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 54;
            this.label3.Text = "Dates";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 53;
            this.label2.Text = "Customer ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "Payment ID";
            // 
            // txtdates
            // 
            this.txtdates.Location = new System.Drawing.Point(117, 164);
            this.txtdates.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdates.Name = "txtdates";
            this.txtdates.Size = new System.Drawing.Size(173, 22);
            this.txtdates.TabIndex = 62;
            this.txtdates.TextChanged += new System.EventHandler(this.txtdates_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 63;
            this.label4.Text = "Room type";
            // 
            // textRtype
            // 
            this.textRtype.Location = new System.Drawing.Point(117, 220);
            this.textRtype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textRtype.Name = "textRtype";
            this.textRtype.Size = new System.Drawing.Size(173, 22);
            this.textRtype.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 65;
            this.label5.Text = "Room Price";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(117, 279);
            this.txtprice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(173, 22);
            this.txtprice.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 67;
            this.label6.Text = "Total";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(115, 345);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(38, 16);
            this.lbltotal.TabIndex = 72;
            this.lbltotal.Text = "Total";
            // 
            // cusId
            // 
            this.cusId.FormattingEnabled = true;
            this.cusId.Location = new System.Drawing.Point(117, 98);
            this.cusId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cusId.Name = "cusId";
            this.cusId.Size = new System.Drawing.Size(173, 24);
            this.cusId.TabIndex = 73;
            this.cusId.SelectedIndexChanged += new System.EventHandler(this.cusId_SelectedIndexChanged);
            // 
            // btnprint
            // 
            this.btnprint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnprint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnprint.ForeColor = System.Drawing.Color.White;
            this.btnprint.Location = new System.Drawing.Point(865, 496);
            this.btnprint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(121, 48);
            this.btnprint.TabIndex = 74;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = false;
            // 
            // btnclear
            // 
            this.btnclear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(704, 496);
            this.btnclear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(121, 48);
            this.btnclear.TabIndex = 61;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(551, 496);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(121, 48);
            this.btnDel.TabIndex = 60;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // BtnUodate
            // 
            this.BtnUodate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnUodate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.BtnUodate.ForeColor = System.Drawing.Color.White;
            this.BtnUodate.Location = new System.Drawing.Point(408, 496);
            this.BtnUodate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnUodate.Name = "BtnUodate";
            this.BtnUodate.Size = new System.Drawing.Size(121, 48);
            this.BtnUodate.TabIndex = 59;
            this.BtnUodate.Text = "Update";
            this.BtnUodate.UseVisualStyleBackColor = false;
            this.BtnUodate.Click += new System.EventHandler(this.BtnUodate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(267, 496);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 48);
            this.btnAdd.TabIndex = 58;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // payment1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 571);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.cusId);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textRtype);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdates);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.BtnUodate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "payment1";
            this.Text = "payment1";
            this.Load += new System.EventHandler(this.payment1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtPid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdates;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textRtype;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.ComboBox cusId;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button BtnUodate;
        private System.Windows.Forms.Button btnAdd;
    }
}