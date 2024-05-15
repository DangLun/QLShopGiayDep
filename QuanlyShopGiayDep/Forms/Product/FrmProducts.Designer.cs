namespace QuanlyShopGiayDep
{
    partial class FrmProducts
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
            this.btnDropProduct = new FontAwesome.Sharp.IconButton();
            this.btnEditProduct = new FontAwesome.Sharp.IconButton();
            this.btnExportExcelProducts = new FontAwesome.Sharp.IconButton();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.txtInputSearchProduct = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new FontAwesome.Sharp.IconButton();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnViewDetailProduct = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDropProduct
            // 
            this.btnDropProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDropProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDropProduct.FlatAppearance.BorderSize = 0;
            this.btnDropProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDropProduct.Font = new System.Drawing.Font("Quicksand Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDropProduct.ForeColor = System.Drawing.Color.White;
            this.btnDropProduct.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDropProduct.IconColor = System.Drawing.Color.White;
            this.btnDropProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDropProduct.IconSize = 32;
            this.btnDropProduct.Location = new System.Drawing.Point(434, 640);
            this.btnDropProduct.Margin = new System.Windows.Forms.Padding(0);
            this.btnDropProduct.Name = "btnDropProduct";
            this.btnDropProduct.Size = new System.Drawing.Size(199, 47);
            this.btnDropProduct.TabIndex = 15;
            this.btnDropProduct.Text = "Xóa Sản Phẩm";
            this.btnDropProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDropProduct.UseVisualStyleBackColor = false;
            this.btnDropProduct.Click += new System.EventHandler(this.btnDropProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(36)))));
            this.btnEditProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProduct.FlatAppearance.BorderSize = 0;
            this.btnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProduct.Font = new System.Drawing.Font("Quicksand Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProduct.ForeColor = System.Drawing.Color.White;
            this.btnEditProduct.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnEditProduct.IconColor = System.Drawing.Color.White;
            this.btnEditProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditProduct.IconSize = 32;
            this.btnEditProduct.Location = new System.Drawing.Point(224, 640);
            this.btnEditProduct.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(199, 47);
            this.btnEditProduct.TabIndex = 14;
            this.btnEditProduct.Text = "Sửa Sản Phẩm";
            this.btnEditProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnExportExcelProducts
            // 
            this.btnExportExcelProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnExportExcelProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportExcelProducts.FlatAppearance.BorderSize = 0;
            this.btnExportExcelProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcelProducts.Font = new System.Drawing.Font("Quicksand Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcelProducts.ForeColor = System.Drawing.Color.White;
            this.btnExportExcelProducts.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.btnExportExcelProducts.IconColor = System.Drawing.Color.White;
            this.btnExportExcelProducts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportExcelProducts.IconSize = 32;
            this.btnExportExcelProducts.Location = new System.Drawing.Point(909, 17);
            this.btnExportExcelProducts.Margin = new System.Windows.Forms.Padding(0);
            this.btnExportExcelProducts.Name = "btnExportExcelProducts";
            this.btnExportExcelProducts.Size = new System.Drawing.Size(199, 47);
            this.btnExportExcelProducts.TabIndex = 13;
            this.btnExportExcelProducts.Text = "Xuất File Excel";
            this.btnExportExcelProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportExcelProducts.UseVisualStyleBackColor = false;
            this.btnExportExcelProducts.Click += new System.EventHandler(this.btnExportExcelProducts_Click);
            // 
            // cmbProductType
            // 
            this.cmbProductType.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Location = new System.Drawing.Point(14, 21);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(207, 38);
            this.cmbProductType.TabIndex = 12;
            // 
            // txtInputSearchProduct
            // 
            this.txtInputSearchProduct.BackColor = System.Drawing.Color.White;
            this.txtInputSearchProduct.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputSearchProduct.ForeColor = System.Drawing.Color.Black;
            this.txtInputSearchProduct.Location = new System.Drawing.Point(224, 21);
            this.txtInputSearchProduct.Margin = new System.Windows.Forms.Padding(0);
            this.txtInputSearchProduct.Multiline = true;
            this.txtInputSearchProduct.Name = "txtInputSearchProduct";
            this.txtInputSearchProduct.Size = new System.Drawing.Size(674, 38);
            this.txtInputSearchProduct.TabIndex = 11;
            this.txtInputSearchProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInputSearchProduct.TextChanged += new System.EventHandler(this.txtInputSearchProduct_TextChanged);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(149)))), ((int)(((byte)(238)))));
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.btnAddProduct.Font = new System.Drawing.Font("Quicksand Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAddProduct.IconColor = System.Drawing.Color.White;
            this.btnAddProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddProduct.IconSize = 32;
            this.btnAddProduct.Location = new System.Drawing.Point(14, 640);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(199, 47);
            this.btnAddProduct.TabIndex = 10;
            this.btnAddProduct.Text = "Thêm Sản Phẩm";
            this.btnAddProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NameProduct,
            this.Price,
            this.Discount,
            this.Quantity,
            this.Type,
            this.BrandName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.GridColor = System.Drawing.Color.White;
            this.dgvProducts.Location = new System.Drawing.Point(14, 72);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1094, 550);
            this.dgvProducts.TabIndex = 9;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // NameProduct
            // 
            this.NameProduct.DataPropertyName = "Name";
            this.NameProduct.HeaderText = "Tên Sản Phẩm";
            this.NameProduct.MinimumWidth = 6;
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.ReadOnly = true;
            this.NameProduct.Width = 307;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Đơn Giá";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 156;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "Khuyến Mãi";
            this.Discount.MinimumWidth = 6;
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            this.Discount.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 125;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Loại";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 156;
            // 
            // BrandName
            // 
            this.BrandName.DataPropertyName = "BrandName";
            this.BrandName.HeaderText = "Thương Hiệu";
            this.BrandName.MinimumWidth = 6;
            this.BrandName.Name = "BrandName";
            this.BrandName.ReadOnly = true;
            this.BrandName.Width = 150;
            // 
            // btnViewDetailProduct
            // 
            this.btnViewDetailProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(149)))), ((int)(((byte)(238)))));
            this.btnViewDetailProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewDetailProduct.FlatAppearance.BorderSize = 0;
            this.btnViewDetailProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetailProduct.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.btnViewDetailProduct.Font = new System.Drawing.Font("Quicksand Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDetailProduct.ForeColor = System.Drawing.Color.White;
            this.btnViewDetailProduct.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.btnViewDetailProduct.IconColor = System.Drawing.Color.White;
            this.btnViewDetailProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnViewDetailProduct.IconSize = 32;
            this.btnViewDetailProduct.Location = new System.Drawing.Point(654, 640);
            this.btnViewDetailProduct.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewDetailProduct.Name = "btnViewDetailProduct";
            this.btnViewDetailProduct.Size = new System.Drawing.Size(199, 47);
            this.btnViewDetailProduct.TabIndex = 16;
            this.btnViewDetailProduct.Text = "Xem Chi Tiết";
            this.btnViewDetailProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewDetailProduct.UseVisualStyleBackColor = false;
            this.btnViewDetailProduct.Click += new System.EventHandler(this.btnViewDetailProduct_Click);
            // 
            // FrmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 705);
            this.Controls.Add(this.btnViewDetailProduct);
            this.Controls.Add(this.btnDropProduct);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.btnExportExcelProducts);
            this.Controls.Add(this.cmbProductType);
            this.Controls.Add(this.txtInputSearchProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.dgvProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProducts";
            this.Load += new System.EventHandler(this.FrmProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnDropProduct;
        private FontAwesome.Sharp.IconButton btnEditProduct;
        private FontAwesome.Sharp.IconButton btnExportExcelProducts;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.TextBox txtInputSearchProduct;
        private FontAwesome.Sharp.IconButton btnAddProduct;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandName;
        private FontAwesome.Sharp.IconButton btnViewDetailProduct;
    }
}