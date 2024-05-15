namespace QuanlyShopGiayDep.Forms.Order
{
    partial class FrmThanhToan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTichDiem = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFinishInvoice = new FontAwesome.Sharp.IconButton();
            this.lbSumPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTienThua = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nbrTienNhan = new System.Windows.Forms.NumericUpDown();
            this.lbNameCustomer = new System.Windows.Forms.Label();
            this.lbSDTCustomer = new System.Windows.Forms.Label();
            this.btnDoiDiem = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbrTienNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(149)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 98);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(106, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xác Nhận Hóa Đơn";
            // 
            // btnTichDiem
            // 
            this.btnTichDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(36)))));
            this.btnTichDiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTichDiem.FlatAppearance.BorderSize = 0;
            this.btnTichDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTichDiem.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTichDiem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTichDiem.IconChar = FontAwesome.Sharp.IconChar.Medal;
            this.btnTichDiem.IconColor = System.Drawing.Color.White;
            this.btnTichDiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTichDiem.IconSize = 32;
            this.btnTichDiem.Location = new System.Drawing.Point(277, 105);
            this.btnTichDiem.Name = "btnTichDiem";
            this.btnTichDiem.Size = new System.Drawing.Size(153, 41);
            this.btnTichDiem.TabIndex = 17;
            this.btnTichDiem.Text = "Tích điểm";
            this.btnTichDiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTichDiem.UseVisualStyleBackColor = false;
            this.btnTichDiem.Click += new System.EventHandler(this.btnTichDiem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 30);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tổng tiền:";
            // 
            // btnFinishInvoice
            // 
            this.btnFinishInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(149)))), ((int)(((byte)(238)))));
            this.btnFinishInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinishInvoice.FlatAppearance.BorderSize = 0;
            this.btnFinishInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinishInvoice.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishInvoice.ForeColor = System.Drawing.Color.White;
            this.btnFinishInvoice.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnFinishInvoice.IconColor = System.Drawing.Color.White;
            this.btnFinishInvoice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFinishInvoice.IconSize = 32;
            this.btnFinishInvoice.Location = new System.Drawing.Point(17, 397);
            this.btnFinishInvoice.Name = "btnFinishInvoice";
            this.btnFinishInvoice.Size = new System.Drawing.Size(407, 42);
            this.btnFinishInvoice.TabIndex = 20;
            this.btnFinishInvoice.Text = "Hoàn tất đơn hàng";
            this.btnFinishInvoice.UseVisualStyleBackColor = false;
            this.btnFinishInvoice.Click += new System.EventHandler(this.btnFinishInvoice_Click);
            // 
            // lbSumPrice
            // 
            this.lbSumPrice.AutoSize = true;
            this.lbSumPrice.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSumPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbSumPrice.Location = new System.Drawing.Point(250, 231);
            this.lbSumPrice.Name = "lbSumPrice";
            this.lbSumPrice.Size = new System.Drawing.Size(126, 30);
            this.lbSumPrice.TabIndex = 21;
            this.lbSumPrice.Text = "120.000.000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 30);
            this.label4.TabIndex = 22;
            this.label4.Text = "VNĐ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 30);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tiền Nhận:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 30);
            this.label6.TabIndex = 25;
            this.label6.Text = "Tiền Thừa:";
            // 
            // lbTienThua
            // 
            this.lbTienThua.AutoSize = true;
            this.lbTienThua.BackColor = System.Drawing.SystemColors.Control;
            this.lbTienThua.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienThua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(36)))));
            this.lbTienThua.Location = new System.Drawing.Point(250, 333);
            this.lbTienThua.Name = "lbTienThua";
            this.lbTienThua.Size = new System.Drawing.Size(25, 30);
            this.lbTienThua.TabIndex = 26;
            this.lbTienThua.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(375, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 30);
            this.label8.TabIndex = 27;
            this.label8.Text = "VNĐ";
            // 
            // nbrTienNhan
            // 
            this.nbrTienNhan.Location = new System.Drawing.Point(254, 280);
            this.nbrTienNhan.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nbrTienNhan.Name = "nbrTienNhan";
            this.nbrTienNhan.Size = new System.Drawing.Size(170, 32);
            this.nbrTienNhan.TabIndex = 28;
            this.nbrTienNhan.ValueChanged += new System.EventHandler(this.nbrTienNhan_ValueChanged);
            // 
            // lbNameCustomer
            // 
            this.lbNameCustomer.AutoSize = true;
            this.lbNameCustomer.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameCustomer.ForeColor = System.Drawing.Color.Black;
            this.lbNameCustomer.Location = new System.Drawing.Point(12, 105);
            this.lbNameCustomer.Name = "lbNameCustomer";
            this.lbNameCustomer.Size = new System.Drawing.Size(161, 30);
            this.lbNameCustomer.TabIndex = 29;
            this.lbNameCustomer.Text = "Trần Duy Đăng";
            // 
            // lbSDTCustomer
            // 
            this.lbSDTCustomer.AutoSize = true;
            this.lbSDTCustomer.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDTCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbSDTCustomer.Location = new System.Drawing.Point(12, 135);
            this.lbSDTCustomer.Name = "lbSDTCustomer";
            this.lbSDTCustomer.Size = new System.Drawing.Size(123, 30);
            this.lbSDTCustomer.TabIndex = 30;
            this.lbSDTCustomer.Text = "0868337747";
            // 
            // btnDoiDiem
            // 
            this.btnDoiDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDoiDiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoiDiem.FlatAppearance.BorderSize = 0;
            this.btnDoiDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiDiem.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiDiem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDoiDiem.IconChar = FontAwesome.Sharp.IconChar.Exchange;
            this.btnDoiDiem.IconColor = System.Drawing.Color.White;
            this.btnDoiDiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDoiDiem.IconSize = 32;
            this.btnDoiDiem.Location = new System.Drawing.Point(277, 159);
            this.btnDoiDiem.Name = "btnDoiDiem";
            this.btnDoiDiem.Size = new System.Drawing.Size(153, 41);
            this.btnDoiDiem.TabIndex = 31;
            this.btnDoiDiem.Text = "Đổi điểm";
            this.btnDoiDiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoiDiem.UseVisualStyleBackColor = false;
            this.btnDoiDiem.Click += new System.EventHandler(this.btnDoiDiem_Click);
            // 
            // FrmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 458);
            this.Controls.Add(this.btnDoiDiem);
            this.Controls.Add(this.lbSDTCustomer);
            this.Controls.Add(this.lbNameCustomer);
            this.Controls.Add(this.nbrTienNhan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbTienThua);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbSumPrice);
            this.Controls.Add(this.btnFinishInvoice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTichDiem);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FrmThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmThanhToan";
            this.Load += new System.EventHandler(this.FrmThanhToan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbrTienNhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnTichDiem;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnFinishInvoice;
        private System.Windows.Forms.Label lbSumPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTienThua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nbrTienNhan;
        private System.Windows.Forms.Label lbNameCustomer;
        private System.Windows.Forms.Label lbSDTCustomer;
        private FontAwesome.Sharp.IconButton btnDoiDiem;
    }
}