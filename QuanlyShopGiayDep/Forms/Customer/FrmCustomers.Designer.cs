namespace QuanlyShopGiayDep
{
    partial class FrmCustomers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tk = new System.Windows.Forms.Label();
            this.NameKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataKH = new System.Windows.Forms.DataGridView();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numdiem = new System.Windows.Forms.NumericUpDown();
            this.cmbgioi = new System.Windows.Forms.ComboBox();
            this.gioitinh = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.tichdiem = new System.Windows.Forms.Label();
            this.sdt = new System.Windows.Forms.Label();
            this.txttim = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.Ten = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.luu = new FontAwesome.Sharp.IconButton();
            this.xoa = new FontAwesome.Sharp.IconButton();
            this.sua = new FontAwesome.Sharp.IconButton();
            this.them = new FontAwesome.Sharp.IconButton();
            this.MaKH = new System.Windows.Forms.Label();
            this.thongtin = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numdiem)).BeginInit();
            this.thongtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tk
            // 
            this.tk.AutoSize = true;
            this.tk.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tk.Location = new System.Drawing.Point(17, 314);
            this.tk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tk.Name = "tk";
            this.tk.Size = new System.Drawing.Size(221, 30);
            this.tk.TabIndex = 32;
            this.tk.Text = "Tìm kiếm khách hàng";
            // 
            // NameKH
            // 
            this.NameKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameKH.DataPropertyName = "Name";
            this.NameKH.HeaderText = "Name";
            this.NameKH.MinimumWidth = 6;
            this.NameKH.Name = "NameKH";
            this.NameKH.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // dataKH
            // 
            this.dataKH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataKH.BackgroundColor = System.Drawing.Color.White;
            this.dataKH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NameKH,
            this.Phone,
            this.Gender,
            this.Score});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataKH.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataKH.GridColor = System.Drawing.Color.White;
            this.dataKH.Location = new System.Drawing.Point(9, 353);
            this.dataKH.Name = "dataKH";
            this.dataKH.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataKH.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataKH.RowHeadersVisible = false;
            this.dataKH.RowHeadersWidth = 51;
            this.dataKH.RowTemplate.Height = 24;
            this.dataKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataKH.Size = new System.Drawing.Size(1105, 327);
            this.dataKH.TabIndex = 34;
            this.dataKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataKH_CellClick);
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Score
            // 
            this.Score.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Score.DataPropertyName = "Score";
            this.Score.HeaderText = "Score";
            this.Score.MinimumWidth = 6;
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            // 
            // numdiem
            // 
            this.numdiem.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numdiem.Location = new System.Drawing.Point(726, 103);
            this.numdiem.Margin = new System.Windows.Forms.Padding(4);
            this.numdiem.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numdiem.Name = "numdiem";
            this.numdiem.Size = new System.Drawing.Size(254, 32);
            this.numdiem.TabIndex = 67;
            // 
            // cmbgioi
            // 
            this.cmbgioi.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbgioi.FormattingEnabled = true;
            this.cmbgioi.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmbgioi.Location = new System.Drawing.Point(241, 148);
            this.cmbgioi.Margin = new System.Windows.Forms.Padding(4);
            this.cmbgioi.Name = "cmbgioi";
            this.cmbgioi.Size = new System.Drawing.Size(252, 38);
            this.cmbgioi.TabIndex = 66;
            // 
            // gioitinh
            // 
            this.gioitinh.AutoSize = true;
            this.gioitinh.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gioitinh.Location = new System.Drawing.Point(19, 156);
            this.gioitinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Size = new System.Drawing.Size(97, 30);
            this.gioitinh.TabIndex = 7;
            this.gioitinh.Text = "Giới Tính";
            // 
            // txtsdt
            // 
            this.txtsdt.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsdt.Location = new System.Drawing.Point(726, 43);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(4);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(254, 32);
            this.txtsdt.TabIndex = 5;
            // 
            // tichdiem
            // 
            this.tichdiem.AutoSize = true;
            this.tichdiem.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tichdiem.Location = new System.Drawing.Point(545, 103);
            this.tichdiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tichdiem.Name = "tichdiem";
            this.tichdiem.Size = new System.Drawing.Size(62, 30);
            this.tichdiem.TabIndex = 1;
            this.tichdiem.Text = "Điểm";
            // 
            // sdt
            // 
            this.sdt.AutoSize = true;
            this.sdt.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdt.Location = new System.Drawing.Point(545, 46);
            this.sdt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(147, 30);
            this.sdt.TabIndex = 4;
            this.sdt.Text = "Số Điện Thoại";
            // 
            // txttim
            // 
            this.txttim.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttim.Location = new System.Drawing.Point(263, 314);
            this.txttim.Margin = new System.Windows.Forms.Padding(4);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(440, 32);
            this.txttim.TabIndex = 33;
            this.txttim.TextChanged += new System.EventHandler(this.txttim_TextChanged);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(241, 91);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(252, 32);
            this.txtTenKH.TabIndex = 3;
            // 
            // Ten
            // 
            this.Ten.AutoSize = true;
            this.Ten.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ten.Location = new System.Drawing.Point(19, 100);
            this.Ten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ten.Name = "Ten";
            this.Ten.Size = new System.Drawing.Size(172, 30);
            this.Ten.TabIndex = 2;
            this.Ten.Text = "Tên Khách Hàng";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(241, 43);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(252, 32);
            this.txtMaKH.TabIndex = 1;
            // 
            // luu
            // 
            this.luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.luu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.luu.FlatAppearance.BorderSize = 0;
            this.luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.luu.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luu.ForeColor = System.Drawing.Color.White;
            this.luu.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.luu.IconColor = System.Drawing.Color.White;
            this.luu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.luu.IconSize = 32;
            this.luu.Location = new System.Drawing.Point(1002, 251);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(99, 42);
            this.luu.TabIndex = 38;
            this.luu.Text = "Lưu";
            this.luu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.luu.UseVisualStyleBackColor = false;
            this.luu.Click += new System.EventHandler(this.luu_Click);
            // 
            // xoa
            // 
            this.xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xoa.FlatAppearance.BorderSize = 0;
            this.xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xoa.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa.ForeColor = System.Drawing.Color.White;
            this.xoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.xoa.IconColor = System.Drawing.Color.White;
            this.xoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.xoa.IconSize = 32;
            this.xoa.Location = new System.Drawing.Point(396, 251);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(119, 42);
            this.xoa.TabIndex = 37;
            this.xoa.Text = "Xóa";
            this.xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.xoa.UseVisualStyleBackColor = false;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // sua
            // 
            this.sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(36)))));
            this.sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sua.FlatAppearance.BorderSize = 0;
            this.sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sua.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sua.ForeColor = System.Drawing.Color.White;
            this.sua.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.sua.IconColor = System.Drawing.Color.White;
            this.sua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sua.IconSize = 32;
            this.sua.Location = new System.Drawing.Point(214, 251);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(107, 42);
            this.sua.TabIndex = 36;
            this.sua.Text = "Sửa";
            this.sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sua.UseVisualStyleBackColor = false;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // them
            // 
            this.them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(149)))), ((int)(((byte)(238)))));
            this.them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.them.FlatAppearance.BorderSize = 0;
            this.them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.them.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them.ForeColor = System.Drawing.Color.White;
            this.them.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.them.IconColor = System.Drawing.Color.White;
            this.them.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.them.IconSize = 32;
            this.them.Location = new System.Drawing.Point(22, 251);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(130, 42);
            this.them.TabIndex = 35;
            this.them.Text = "Thêm";
            this.them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.them.UseVisualStyleBackColor = false;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // MaKH
            // 
            this.MaKH.AutoSize = true;
            this.MaKH.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaKH.Location = new System.Drawing.Point(19, 46);
            this.MaKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaKH.Name = "MaKH";
            this.MaKH.Size = new System.Drawing.Size(166, 30);
            this.MaKH.TabIndex = 0;
            this.MaKH.Text = "Mã Khách Hàng";
            // 
            // thongtin
            // 
            this.thongtin.Controls.Add(this.numdiem);
            this.thongtin.Controls.Add(this.cmbgioi);
            this.thongtin.Controls.Add(this.gioitinh);
            this.thongtin.Controls.Add(this.txtsdt);
            this.thongtin.Controls.Add(this.tichdiem);
            this.thongtin.Controls.Add(this.sdt);
            this.thongtin.Controls.Add(this.txtTenKH);
            this.thongtin.Controls.Add(this.Ten);
            this.thongtin.Controls.Add(this.txtMaKH);
            this.thongtin.Controls.Add(this.MaKH);
            this.thongtin.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongtin.Location = new System.Drawing.Point(22, 24);
            this.thongtin.Margin = new System.Windows.Forms.Padding(4);
            this.thongtin.Name = "thongtin";
            this.thongtin.Padding = new System.Windows.Forms.Padding(4);
            this.thongtin.Size = new System.Drawing.Size(1079, 215);
            this.thongtin.TabIndex = 31;
            this.thongtin.TabStop = false;
            this.thongtin.Text = "Thông tin khách hàng";
            // 
            // FrmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 705);
            this.Controls.Add(this.tk);
            this.Controls.Add(this.dataKH);
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.luu);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.them);
            this.Controls.Add(this.thongtin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCustomers";
            this.Load += new System.EventHandler(this.FrmCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numdiem)).EndInit();
            this.thongtin.ResumeLayout(false);
            this.thongtin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tk;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridView dataKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.NumericUpDown numdiem;
        private System.Windows.Forms.ComboBox cmbgioi;
        private System.Windows.Forms.Label gioitinh;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label tichdiem;
        private System.Windows.Forms.Label sdt;
        private System.Windows.Forms.TextBox txttim;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label Ten;
        private System.Windows.Forms.TextBox txtMaKH;
        private FontAwesome.Sharp.IconButton luu;
        private FontAwesome.Sharp.IconButton xoa;
        private FontAwesome.Sharp.IconButton sua;
        private FontAwesome.Sharp.IconButton them;
        private System.Windows.Forms.Label MaKH;
        private System.Windows.Forms.GroupBox thongtin;
    }
}