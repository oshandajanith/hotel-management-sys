namespace WindowsFormsApp6
{
    partial class reservation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRid = new System.Windows.Forms.TextBox();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.RoomType = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.BtnUodate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.txtroomno = new System.Windows.Forms.TextBox();
            this.lblstatus = new System.Windows.Forms.Label();
            this.lblst = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtdates = new System.Windows.Forms.Label();
            this.Dates = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reserv ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Room Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Room No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date In";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date Out";
            // 
            // txtRid
            // 
            this.txtRid.Location = new System.Drawing.Point(137, 31);
            this.txtRid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRid.Name = "txtRid";
            this.txtRid.Size = new System.Drawing.Size(173, 22);
            this.txtRid.TabIndex = 6;
            // 
            // txtCid
            // 
            this.txtCid.Location = new System.Drawing.Point(137, 94);
            this.txtCid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(173, 22);
            this.txtCid.TabIndex = 7;
            // 
            // RoomType
            // 
            this.RoomType.FormattingEnabled = true;
            this.RoomType.Location = new System.Drawing.Point(137, 158);
            this.RoomType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RoomType.Name = "RoomType";
            this.RoomType.Size = new System.Drawing.Size(173, 24);
            this.RoomType.TabIndex = 8;
            this.RoomType.SelectedIndexChanged += new System.EventHandler(this.RoomType_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 346);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(173, 22);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(137, 418);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(173, 22);
            this.dateTimePicker2.TabIndex = 11;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(345, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(845, 409);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(204, 510);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 44);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnUodate
            // 
            this.BtnUodate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnUodate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.BtnUodate.ForeColor = System.Drawing.Color.White;
            this.BtnUodate.Location = new System.Drawing.Point(412, 510);
            this.BtnUodate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnUodate.Name = "BtnUodate";
            this.BtnUodate.Size = new System.Drawing.Size(140, 44);
            this.BtnUodate.TabIndex = 14;
            this.BtnUodate.Text = "Update";
            this.BtnUodate.UseVisualStyleBackColor = false;
            this.BtnUodate.Click += new System.EventHandler(this.BtnUodate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(609, 510);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(140, 44);
            this.btnDel.TabIndex = 15;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnclear
            // 
            this.btnclear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(817, 510);
            this.btnclear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(140, 44);
            this.btnclear.TabIndex = 16;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // txtroomno
            // 
            this.txtroomno.Location = new System.Drawing.Point(137, 222);
            this.txtroomno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtroomno.Name = "txtroomno";
            this.txtroomno.Size = new System.Drawing.Size(173, 22);
            this.txtroomno.TabIndex = 17;
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(29, 258);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(89, 16);
            this.lblstatus.TabIndex = 18;
            this.lblstatus.Text = "This Room is:";
            // 
            // lblst
            // 
            this.lblst.AutoSize = true;
            this.lblst.Location = new System.Drawing.Point(125, 258);
            this.lblst.Name = "lblst";
            this.lblst.Size = new System.Drawing.Size(0, 16);
            this.lblst.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Price";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(137, 290);
            this.txtprice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(173, 22);
            this.txtprice.TabIndex = 21;
            // 
            // txtdates
            // 
            this.txtdates.AutoSize = true;
            this.txtdates.Location = new System.Drawing.Point(29, 473);
            this.txtdates.Name = "txtdates";
            this.txtdates.Size = new System.Drawing.Size(90, 16);
            this.txtdates.TabIndex = 22;
            this.txtdates.Text = "Num Of Dates";
            // 
            // Dates
            // 
            this.Dates.AutoSize = true;
            this.Dates.Location = new System.Drawing.Point(133, 473);
            this.Dates.Name = "Dates";
            this.Dates.Size = new System.Drawing.Size(14, 16);
            this.Dates.TabIndex = 23;
            this.Dates.Text = "0";
            // 
            // reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 588);
            this.Controls.Add(this.Dates);
            this.Controls.Add(this.txtdates);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblst);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.txtroomno);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.BtnUodate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.RoomType);
            this.Controls.Add(this.txtCid);
            this.Controls.Add(this.txtRid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "reservation";
            this.Text = "Recervation";
            this.Load += new System.EventHandler(this.reservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRid;
        private System.Windows.Forms.TextBox txtCid;
        private System.Windows.Forms.ComboBox RoomType;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button BtnUodate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.TextBox txtroomno;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label lblst;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label txtdates;
        private System.Windows.Forms.Label Dates;
    }
}