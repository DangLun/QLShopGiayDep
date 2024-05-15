namespace QuanlyShopGiayDep.Forms
{
    partial class FrmAccounts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.thongtin = new System.Windows.Forms.GroupBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.sdt = new System.Windows.Forms.Label();
            this.MaKH = new System.Windows.Forms.Label();
            this.gioitinh = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.Ten = new System.Windows.Forms.Label();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tk = new System.Windows.Forms.Label();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btndelete = new FontAwesome.Sharp.IconButton();
            this.btnupdate = new FontAwesome.Sharp.IconButton();
            this.btnIensert = new FontAwesome.Sharp.IconButton();
            this.btnCapTK = new FontAwesome.Sharp.IconButton();
            this.thongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // thongtin
            // 
            this.thongtin.Controls.Add(this.cmbRole);
            this.thongtin.Controls.Add(this.sdt);
            this.thongtin.Controls.Add(this.MaKH);
            this.thongtin.Controls.Add(this.gioitinh);
            this.thongtin.Controls.Add(this.txtID);
            this.thongtin.Controls.Add(this.txtMK);
            this.thongtin.Controls.Add(this.Ten);
            this.thongtin.Controls.Add(this.txtTenTK);
            this.thongtin.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongtin.ForeColor = System.Drawing.Color.Fuchsia;
            this.thongtin.Location = new System.Drawing.Point(13, 1);
            this.thongtin.Margin = new System.Windows.Forms.Padding(4);
            this.thongtin.Name = "thongtin";
            this.thongtin.Padding = new System.Windows.Forms.Padding(4);
            this.thongtin.Size = new System.Drawing.Size(1097, 162);
            this.thongtin.TabIndex = 23;
            this.thongtin.TabStop = false;
            this.thongtin.Text = "Thông tin tài khoản";
            // 
            // cmbRole
            // 
            this.cmbRole.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "Nhân viên"});
            this.cmbRole.Location = new System.Drawing.Point(728, 107);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(252, 38);
            this.cmbRole.TabIndex = 66;
            // 
            // sdt
            // 
            this.sdt.AutoSize = true;
            this.sdt.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdt.ForeColor = System.Drawing.Color.Blue;
            this.sdt.Location = new System.Drawing.Point(545, 56);
            this.sdt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(109, 30);
            this.sdt.TabIndex = 4;
            this.sdt.Text = "Mật khẩu:";
            // 
            // MaKH
            // 
            this.MaKH.AutoSize = true;
            this.MaKH.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaKH.ForeColor = System.Drawing.Color.Blue;
            this.MaKH.Location = new System.Drawing.Point(19, 56);
            this.MaKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaKH.Name = "MaKH";
            this.MaKH.Size = new System.Drawing.Size(38, 30);
            this.MaKH.TabIndex = 0;
            this.MaKH.Text = "ID:";
            // 
            // gioitinh
            // 
            this.gioitinh.AutoSize = true;
            this.gioitinh.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gioitinh.ForeColor = System.Drawing.Color.Blue;
            this.gioitinh.Location = new System.Drawing.Point(545, 115);
            this.gioitinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Size = new System.Drawing.Size(81, 30);
            this.gioitinh.TabIndex = 7;
            this.gioitinh.Text = "Quyền:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(241, 53);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(252, 32);
            this.txtID.TabIndex = 1;
            // 
            // txtMK
            // 
            this.txtMK.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Location = new System.Drawing.Point(726, 53);
            this.txtMK.Margin = new System.Windows.Forms.Padding(4);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(254, 32);
            this.txtMK.TabIndex = 5;
            // 
            // Ten
            // 
            this.Ten.AutoSize = true;
            this.Ten.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ten.ForeColor = System.Drawing.Color.Blue;
            this.Ten.Location = new System.Drawing.Point(19, 110);
            this.Ten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ten.Name = "Ten";
            this.Ten.Size = new System.Drawing.Size(151, 30);
            this.Ten.TabIndex = 2;
            this.Ten.Text = "Tên tài khoản:";
            // 
            // txtTenTK
            // 
            this.txtTenTK.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTK.Location = new System.Drawing.Point(241, 101);
            this.txtTenTK.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(252, 32);
            this.txtTenTK.TabIndex = 3;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(254, 177);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(440, 32);
            this.txttimkiem.TabIndex = 25;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TenTk,
            this.MatKhau,
            this.Quyen});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(13, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1097, 387);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // TenTk
            // 
            this.TenTk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenTk.DataPropertyName = "Username";
            this.TenTk.HeaderText = "Tên Tài Khoản";
            this.TenTk.MinimumWidth = 6;
            this.TenTk.Name = "TenTk";
            this.TenTk.ReadOnly = true;
            // 
            // MatKhau
            // 
            this.MatKhau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MatKhau.DataPropertyName = "Password";
            this.MatKhau.HeaderText = "Mật Khẩu";
            this.MatKhau.MinimumWidth = 6;
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.ReadOnly = true;
            // 
            // Quyen
            // 
            this.Quyen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quyen.DataPropertyName = "Name";
            this.Quyen.HeaderText = "Quyền";
            this.Quyen.MinimumWidth = 6;
            this.Quyen.Name = "Quyen";
            this.Quyen.ReadOnly = true;
            // 
            // tk
            // 
            this.tk.AutoSize = true;
            this.tk.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tk.Location = new System.Drawing.Point(8, 177);
            this.tk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tk.Name = "tk";
            this.tk.Size = new System.Drawing.Size(221, 30);
            this.tk.TabIndex = 24;
            this.tk.Text = "Tìm kiếm khách hàng";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnSave.IconColor = System.Drawing.Color.White;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 32;
            this.btnSave.Location = new System.Drawing.Point(1011, 641);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 42);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btndelete.IconColor = System.Drawing.Color.White;
            this.btndelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btndelete.IconSize = 32;
            this.btndelete.Location = new System.Drawing.Point(387, 641);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(119, 42);
            this.btndelete.TabIndex = 33;
            this.btndelete.Text = "Xóa";
            this.btndelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(36)))));
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btnupdate.IconColor = System.Drawing.Color.White;
            this.btnupdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnupdate.IconSize = 32;
            this.btnupdate.Location = new System.Drawing.Point(205, 641);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(107, 42);
            this.btnupdate.TabIndex = 32;
            this.btnupdate.Text = "Sửa";
            this.btnupdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnIensert
            // 
            this.btnIensert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(149)))), ((int)(((byte)(238)))));
            this.btnIensert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIensert.FlatAppearance.BorderSize = 0;
            this.btnIensert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIensert.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIensert.ForeColor = System.Drawing.Color.White;
            this.btnIensert.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnIensert.IconColor = System.Drawing.Color.White;
            this.btnIensert.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIensert.IconSize = 32;
            this.btnIensert.Location = new System.Drawing.Point(13, 641);
            this.btnIensert.Name = "btnIensert";
            this.btnIensert.Size = new System.Drawing.Size(130, 42);
            this.btnIensert.TabIndex = 31;
            this.btnIensert.Text = "Thêm";
            this.btnIensert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIensert.UseVisualStyleBackColor = false;
            this.btnIensert.Click += new System.EventHandler(this.btnIensert_Click);
            // 
            // btnCapTK
            // 
            this.btnCapTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCapTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapTK.FlatAppearance.BorderSize = 0;
            this.btnCapTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapTK.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapTK.ForeColor = System.Drawing.Color.White;
            this.btnCapTK.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            this.btnCapTK.IconColor = System.Drawing.Color.White;
            this.btnCapTK.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCapTK.IconSize = 32;
            this.btnCapTK.Location = new System.Drawing.Point(584, 641);
            this.btnCapTK.Name = "btnCapTK";
            this.btnCapTK.Size = new System.Drawing.Size(201, 42);
            this.btnCapTK.TabIndex = 35;
            this.btnCapTK.Text = "Cấp tài khoản";
            this.btnCapTK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCapTK.UseVisualStyleBackColor = false;
            this.btnCapTK.Click += new System.EventHandler(this.btnCapTK_Click);
            // 
            // FrmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 705);
            this.Controls.Add(this.btnCapTK);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnIensert);
            this.Controls.Add(this.thongtin);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAccounts";
            this.Load += new System.EventHandler(this.FrmAccounts_Load);
            this.thongtin.ResumeLayout(false);
            this.thongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox thongtin;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label gioitinh;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label sdt;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.Label Ten;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label MaKH;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label tk;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btndelete;
        private FontAwesome.Sharp.IconButton btnupdate;
        private FontAwesome.Sharp.IconButton btnIensert;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTk;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quyen;
        private FontAwesome.Sharp.IconButton btnCapTK;
    }
}