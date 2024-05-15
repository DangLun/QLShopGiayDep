namespace QuanlyShopGiayDep
{
    partial class FrmStaffs
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
            this.btnDropStaff = new FontAwesome.Sharp.IconButton();
            this.btnEditStaff = new FontAwesome.Sharp.IconButton();
            this.btnExportExcelStaffs = new FontAwesome.Sharp.IconButton();
            this.cmbStaffType = new System.Windows.Forms.ComboBox();
            this.txtInputSearchStaff = new System.Windows.Forms.TextBox();
            this.btnAddStaff = new FontAwesome.Sharp.IconButton();
            this.dgvStaffs = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDropStaff
            // 
            this.btnDropStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDropStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDropStaff.FlatAppearance.BorderSize = 0;
            this.btnDropStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDropStaff.Font = new System.Drawing.Font("Quicksand Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDropStaff.ForeColor = System.Drawing.Color.White;
            this.btnDropStaff.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDropStaff.IconColor = System.Drawing.Color.White;
            this.btnDropStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDropStaff.IconSize = 32;
            this.btnDropStaff.Location = new System.Drawing.Point(434, 640);
            this.btnDropStaff.Margin = new System.Windows.Forms.Padding(0);
            this.btnDropStaff.Name = "btnDropStaff";
            this.btnDropStaff.Size = new System.Drawing.Size(199, 47);
            this.btnDropStaff.TabIndex = 22;
            this.btnDropStaff.Text = "Xóa Nhân Viên";
            this.btnDropStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDropStaff.UseVisualStyleBackColor = false;
            this.btnDropStaff.Click += new System.EventHandler(this.btnDropStaff_Click);
            // 
            // btnEditStaff
            // 
            this.btnEditStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(36)))));
            this.btnEditStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditStaff.FlatAppearance.BorderSize = 0;
            this.btnEditStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditStaff.Font = new System.Drawing.Font("Quicksand Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditStaff.ForeColor = System.Drawing.Color.White;
            this.btnEditStaff.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnEditStaff.IconColor = System.Drawing.Color.White;
            this.btnEditStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditStaff.IconSize = 32;
            this.btnEditStaff.Location = new System.Drawing.Point(224, 640);
            this.btnEditStaff.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditStaff.Name = "btnEditStaff";
            this.btnEditStaff.Size = new System.Drawing.Size(199, 47);
            this.btnEditStaff.TabIndex = 21;
            this.btnEditStaff.Text = "Sửa Nhân Viên";
            this.btnEditStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditStaff.UseVisualStyleBackColor = false;
            this.btnEditStaff.Click += new System.EventHandler(this.btnEditStaff_Click);
            // 
            // btnExportExcelStaffs
            // 
            this.btnExportExcelStaffs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnExportExcelStaffs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportExcelStaffs.FlatAppearance.BorderSize = 0;
            this.btnExportExcelStaffs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcelStaffs.Font = new System.Drawing.Font("Quicksand Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcelStaffs.ForeColor = System.Drawing.Color.White;
            this.btnExportExcelStaffs.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.btnExportExcelStaffs.IconColor = System.Drawing.Color.White;
            this.btnExportExcelStaffs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportExcelStaffs.IconSize = 32;
            this.btnExportExcelStaffs.Location = new System.Drawing.Point(909, 17);
            this.btnExportExcelStaffs.Margin = new System.Windows.Forms.Padding(0);
            this.btnExportExcelStaffs.Name = "btnExportExcelStaffs";
            this.btnExportExcelStaffs.Size = new System.Drawing.Size(199, 47);
            this.btnExportExcelStaffs.TabIndex = 20;
            this.btnExportExcelStaffs.Text = "Xuất File Excel";
            this.btnExportExcelStaffs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportExcelStaffs.UseVisualStyleBackColor = false;
            this.btnExportExcelStaffs.Click += new System.EventHandler(this.btnExportExcelStaffs_Click);
            // 
            // cmbStaffType
            // 
            this.cmbStaffType.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStaffType.FormattingEnabled = true;
            this.cmbStaffType.Location = new System.Drawing.Point(14, 21);
            this.cmbStaffType.Name = "cmbStaffType";
            this.cmbStaffType.Size = new System.Drawing.Size(207, 38);
            this.cmbStaffType.TabIndex = 19;
            // 
            // txtInputSearchStaff
            // 
            this.txtInputSearchStaff.BackColor = System.Drawing.Color.White;
            this.txtInputSearchStaff.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputSearchStaff.ForeColor = System.Drawing.Color.Black;
            this.txtInputSearchStaff.Location = new System.Drawing.Point(224, 21);
            this.txtInputSearchStaff.Margin = new System.Windows.Forms.Padding(0);
            this.txtInputSearchStaff.Multiline = true;
            this.txtInputSearchStaff.Name = "txtInputSearchStaff";
            this.txtInputSearchStaff.Size = new System.Drawing.Size(674, 38);
            this.txtInputSearchStaff.TabIndex = 18;
            this.txtInputSearchStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInputSearchStaff.TextChanged += new System.EventHandler(this.txtInputSearchStaff_TextChanged);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(149)))), ((int)(((byte)(238)))));
            this.btnAddStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStaff.FlatAppearance.BorderSize = 0;
            this.btnAddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStaff.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.btnAddStaff.Font = new System.Drawing.Font("Quicksand Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStaff.ForeColor = System.Drawing.Color.White;
            this.btnAddStaff.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAddStaff.IconColor = System.Drawing.Color.White;
            this.btnAddStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddStaff.IconSize = 32;
            this.btnAddStaff.Location = new System.Drawing.Point(14, 640);
            this.btnAddStaff.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(199, 47);
            this.btnAddStaff.TabIndex = 17;
            this.btnAddStaff.Text = "Thêm Nhân Viên";
            this.btnAddStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddStaff.UseVisualStyleBackColor = false;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // dgvStaffs
            // 
            this.dgvStaffs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStaffs.BackgroundColor = System.Drawing.Color.White;
            this.dgvStaffs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaffs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStaffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NameStaff,
            this.Phone,
            this.BirthDate,
            this.Gender,
            this.Salary});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStaffs.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStaffs.GridColor = System.Drawing.Color.White;
            this.dgvStaffs.Location = new System.Drawing.Point(14, 72);
            this.dgvStaffs.Name = "dgvStaffs";
            this.dgvStaffs.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvStaffs.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStaffs.RowHeadersVisible = false;
            this.dgvStaffs.RowHeadersWidth = 51;
            this.dgvStaffs.RowTemplate.Height = 24;
            this.dgvStaffs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaffs.Size = new System.Drawing.Size(1094, 550);
            this.dgvStaffs.TabIndex = 16;
            this.dgvStaffs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaffs_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 82;
            // 
            // NameStaff
            // 
            this.NameStaff.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameStaff.DataPropertyName = "Name";
            this.NameStaff.HeaderText = "Tên Nhân Viên";
            this.NameStaff.MinimumWidth = 6;
            this.NameStaff.Name = "NameStaff";
            this.NameStaff.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Số điện thoại";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // BirthDate
            // 
            this.BirthDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BirthDate.DataPropertyName = "BirthDate";
            this.BirthDate.HeaderText = "Ngày Sinh";
            this.BirthDate.MinimumWidth = 6;
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Giới tính";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "Lương";
            this.Salary.MinimumWidth = 6;
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // FrmStaffs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 705);
            this.Controls.Add(this.txtInputSearchStaff);
            this.Controls.Add(this.btnDropStaff);
            this.Controls.Add(this.btnEditStaff);
            this.Controls.Add(this.btnExportExcelStaffs);
            this.Controls.Add(this.cmbStaffType);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.dgvStaffs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStaffs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStaffs";
            this.Load += new System.EventHandler(this.FrmStaffs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnDropStaff;
        private FontAwesome.Sharp.IconButton btnEditStaff;
        private FontAwesome.Sharp.IconButton btnExportExcelStaffs;
        private System.Windows.Forms.ComboBox cmbStaffType;
        private System.Windows.Forms.TextBox txtInputSearchStaff;
        private FontAwesome.Sharp.IconButton btnAddStaff;
        private System.Windows.Forms.DataGridView dgvStaffs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
    }
}