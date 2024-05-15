namespace QuanlyShopGiayDep
{
    partial class FrmOrders
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
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreaDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddOrder = new FontAwesome.Sharp.IconButton();
            this.txtInputSearchOrder = new System.Windows.Forms.TextBox();
            this.cmbOrderType = new System.Windows.Forms.ComboBox();
            this.btnExportExcelOrders = new FontAwesome.Sharp.IconButton();
            this.btnDropOrder = new FontAwesome.Sharp.IconButton();
            this.btnViewDetail = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrders
            // 
            this.dgvOrders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CreaDate,
            this.BuyQuantity,
            this.NameCustomer,
            this.Phone,
            this.Gender,
            this.Score});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrders.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOrders.GridColor = System.Drawing.Color.White;
            this.dgvOrders.Location = new System.Drawing.Point(17, 81);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvOrders.RowHeadersVisible = false;
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(1094, 550);
            this.dgvOrders.TabIndex = 0;
            this.dgvOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // CreaDate
            // 
            this.CreaDate.DataPropertyName = "CreaDate";
            this.CreaDate.HeaderText = "Ngày Lập";
            this.CreaDate.MinimumWidth = 6;
            this.CreaDate.Name = "CreaDate";
            this.CreaDate.ReadOnly = true;
            this.CreaDate.Width = 200;
            // 
            // BuyQuantity
            // 
            this.BuyQuantity.DataPropertyName = "BuyQuantity";
            this.BuyQuantity.HeaderText = "Sản phẩm";
            this.BuyQuantity.MinimumWidth = 6;
            this.BuyQuantity.Name = "BuyQuantity";
            this.BuyQuantity.ReadOnly = true;
            this.BuyQuantity.Width = 156;
            // 
            // NameCustomer
            // 
            this.NameCustomer.DataPropertyName = "NameCustomer";
            this.NameCustomer.HeaderText = "Tên Khách Hàng";
            this.NameCustomer.MinimumWidth = 6;
            this.NameCustomer.Name = "NameCustomer";
            this.NameCustomer.ReadOnly = true;
            this.NameCustomer.Width = 284;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Điện Thoại";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 156;
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Giới Tính";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Score
            // 
            this.Score.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Score.DataPropertyName = "Score";
            this.Score.HeaderText = "Điểm";
            this.Score.MinimumWidth = 6;
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(149)))), ((int)(((byte)(238)))));
            this.btnAddOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddOrder.FlatAppearance.BorderSize = 0;
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrder.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.btnAddOrder.Font = new System.Drawing.Font("Quicksand Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddOrder.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAddOrder.IconColor = System.Drawing.Color.White;
            this.btnAddOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddOrder.IconSize = 32;
            this.btnAddOrder.Location = new System.Drawing.Point(17, 649);
            this.btnAddOrder.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(199, 47);
            this.btnAddOrder.TabIndex = 1;
            this.btnAddOrder.Text = "Thêm Đơn Hàng";
            this.btnAddOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // txtInputSearchOrder
            // 
            this.txtInputSearchOrder.BackColor = System.Drawing.Color.White;
            this.txtInputSearchOrder.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputSearchOrder.ForeColor = System.Drawing.Color.Black;
            this.txtInputSearchOrder.Location = new System.Drawing.Point(227, 30);
            this.txtInputSearchOrder.Margin = new System.Windows.Forms.Padding(0);
            this.txtInputSearchOrder.Multiline = true;
            this.txtInputSearchOrder.Name = "txtInputSearchOrder";
            this.txtInputSearchOrder.Size = new System.Drawing.Size(674, 38);
            this.txtInputSearchOrder.TabIndex = 2;
            this.txtInputSearchOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInputSearchOrder.TextChanged += new System.EventHandler(this.txtInputSearchOrder_TextChanged);
            // 
            // cmbOrderType
            // 
            this.cmbOrderType.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrderType.FormattingEnabled = true;
            this.cmbOrderType.Location = new System.Drawing.Point(17, 30);
            this.cmbOrderType.Name = "cmbOrderType";
            this.cmbOrderType.Size = new System.Drawing.Size(207, 38);
            this.cmbOrderType.TabIndex = 3;
            // 
            // btnExportExcelOrders
            // 
            this.btnExportExcelOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnExportExcelOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportExcelOrders.FlatAppearance.BorderSize = 0;
            this.btnExportExcelOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcelOrders.Font = new System.Drawing.Font("Quicksand Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcelOrders.ForeColor = System.Drawing.Color.White;
            this.btnExportExcelOrders.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.btnExportExcelOrders.IconColor = System.Drawing.Color.White;
            this.btnExportExcelOrders.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportExcelOrders.IconSize = 32;
            this.btnExportExcelOrders.Location = new System.Drawing.Point(912, 26);
            this.btnExportExcelOrders.Margin = new System.Windows.Forms.Padding(0);
            this.btnExportExcelOrders.Name = "btnExportExcelOrders";
            this.btnExportExcelOrders.Size = new System.Drawing.Size(199, 47);
            this.btnExportExcelOrders.TabIndex = 5;
            this.btnExportExcelOrders.Text = "Xuất File Excel";
            this.btnExportExcelOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportExcelOrders.UseVisualStyleBackColor = false;
            this.btnExportExcelOrders.Click += new System.EventHandler(this.btnExportExcelOrders_Click);
            // 
            // btnDropOrder
            // 
            this.btnDropOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDropOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDropOrder.FlatAppearance.BorderSize = 0;
            this.btnDropOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDropOrder.Font = new System.Drawing.Font("Quicksand Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDropOrder.ForeColor = System.Drawing.Color.White;
            this.btnDropOrder.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDropOrder.IconColor = System.Drawing.Color.White;
            this.btnDropOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDropOrder.IconSize = 32;
            this.btnDropOrder.Location = new System.Drawing.Point(236, 649);
            this.btnDropOrder.Margin = new System.Windows.Forms.Padding(0);
            this.btnDropOrder.Name = "btnDropOrder";
            this.btnDropOrder.Size = new System.Drawing.Size(199, 47);
            this.btnDropOrder.TabIndex = 7;
            this.btnDropOrder.Text = "Xóa Đơn Hàng";
            this.btnDropOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDropOrder.UseVisualStyleBackColor = false;
            this.btnDropOrder.Click += new System.EventHandler(this.btnDropOrder_Click);
            // 
            // btnViewDetail
            // 
            this.btnViewDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(149)))), ((int)(((byte)(238)))));
            this.btnViewDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewDetail.FlatAppearance.BorderSize = 0;
            this.btnViewDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetail.Font = new System.Drawing.Font("Quicksand Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDetail.ForeColor = System.Drawing.Color.White;
            this.btnViewDetail.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.btnViewDetail.IconColor = System.Drawing.Color.White;
            this.btnViewDetail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnViewDetail.IconSize = 32;
            this.btnViewDetail.Location = new System.Drawing.Point(456, 649);
            this.btnViewDetail.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.Size = new System.Drawing.Size(199, 47);
            this.btnViewDetail.TabIndex = 8;
            this.btnViewDetail.Text = "Xem Chi Tiết";
            this.btnViewDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewDetail.UseVisualStyleBackColor = false;
            this.btnViewDetail.Click += new System.EventHandler(this.btnViewDetail_Click);
            // 
            // FrmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 705);
            this.Controls.Add(this.btnViewDetail);
            this.Controls.Add(this.btnDropOrder);
            this.Controls.Add(this.btnExportExcelOrders);
            this.Controls.Add(this.cmbOrderType);
            this.Controls.Add(this.txtInputSearchOrder);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.dgvOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOrders";
            this.Load += new System.EventHandler(this.FrmOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrders;
        private FontAwesome.Sharp.IconButton btnAddOrder;
        private System.Windows.Forms.TextBox txtInputSearchOrder;
        private System.Windows.Forms.ComboBox cmbOrderType;
        private FontAwesome.Sharp.IconButton btnExportExcelOrders;
        private FontAwesome.Sharp.IconButton btnDropOrder;
        private FontAwesome.Sharp.IconButton btnViewDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreaDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
    }
}