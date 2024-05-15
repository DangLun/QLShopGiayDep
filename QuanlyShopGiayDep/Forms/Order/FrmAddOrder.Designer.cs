namespace QuanlyShopGiayDep.Forms
{
    partial class FrmAddOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnMinisize = new FontAwesome.Sharp.IconButton();
            this.ipbTitle = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThanhToan = new FontAwesome.Sharp.IconButton();
            this.chbPrintInvoice = new System.Windows.Forms.CheckBox();
            this.cmbListProduct = new System.Windows.Forms.ComboBox();
            this.btnAddItemOrder = new FontAwesome.Sharp.IconButton();
            this.nbrQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtSumPrice = new System.Windows.Forms.TextBox();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbDayNow = new System.Windows.Forms.Label();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteInvoice = new FontAwesome.Sharp.IconButton();
            this.lbNamestaff = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(102)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnMinisize);
            this.panel1.Controls.Add(this.ipbTitle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1037, 69);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Quicksand", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 25;
            this.btnClose.Location = new System.Drawing.Point(979, 1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(57, 28);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinisize
            // 
            this.btnMinisize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(185)))), ((int)(((byte)(215)))));
            this.btnMinisize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinisize.FlatAppearance.BorderSize = 0;
            this.btnMinisize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinisize.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinisize.ForeColor = System.Drawing.Color.White;
            this.btnMinisize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinisize.IconColor = System.Drawing.Color.White;
            this.btnMinisize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinisize.IconSize = 25;
            this.btnMinisize.Location = new System.Drawing.Point(929, 1);
            this.btnMinisize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinisize.Name = "btnMinisize";
            this.btnMinisize.Size = new System.Drawing.Size(50, 28);
            this.btnMinisize.TabIndex = 4;
            this.btnMinisize.UseVisualStyleBackColor = false;
            this.btnMinisize.Click += new System.EventHandler(this.btnMinisize_Click);
            // 
            // ipbTitle
            // 
            this.ipbTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(102)))), ((int)(((byte)(245)))));
            this.ipbTitle.IconChar = FontAwesome.Sharp.IconChar.MoneyCheck;
            this.ipbTitle.IconColor = System.Drawing.Color.White;
            this.ipbTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbTitle.IconSize = 49;
            this.ipbTitle.Location = new System.Drawing.Point(12, 12);
            this.ipbTitle.Name = "ipbTitle";
            this.ipbTitle.Size = new System.Drawing.Size(55, 49);
            this.ipbTitle.TabIndex = 1;
            this.ipbTitle.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thanh Toán";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(149)))), ((int)(((byte)(238)))));
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThanhToan.IconColor = System.Drawing.Color.White;
            this.btnThanhToan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThanhToan.IconSize = 32;
            this.btnThanhToan.Location = new System.Drawing.Point(871, 573);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(154, 42);
            this.btnThanhToan.TabIndex = 1;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // chbPrintInvoice
            // 
            this.chbPrintInvoice.AutoSize = true;
            this.chbPrintInvoice.Checked = true;
            this.chbPrintInvoice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbPrintInvoice.Font = new System.Drawing.Font("Quicksand Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPrintInvoice.Location = new System.Drawing.Point(903, 538);
            this.chbPrintInvoice.Name = "chbPrintInvoice";
            this.chbPrintInvoice.Size = new System.Drawing.Size(122, 29);
            this.chbPrintInvoice.TabIndex = 2;
            this.chbPrintInvoice.Text = "In Hóa Đơn";
            this.chbPrintInvoice.UseVisualStyleBackColor = true;
            // 
            // cmbListProduct
            // 
            this.cmbListProduct.Font = new System.Drawing.Font("Quicksand Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbListProduct.FormattingEnabled = true;
            this.cmbListProduct.Location = new System.Drawing.Point(115, 148);
            this.cmbListProduct.Name = "cmbListProduct";
            this.cmbListProduct.Size = new System.Drawing.Size(272, 33);
            this.cmbListProduct.TabIndex = 4;
            this.cmbListProduct.SelectedIndexChanged += new System.EventHandler(this.cmbListProduct_SelectedIndexChanged);
            // 
            // btnAddItemOrder
            // 
            this.btnAddItemOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAddItemOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItemOrder.FlatAppearance.BorderSize = 0;
            this.btnAddItemOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItemOrder.Font = new System.Drawing.Font("Quicksand Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItemOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddItemOrder.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.btnAddItemOrder.IconColor = System.Drawing.Color.White;
            this.btnAddItemOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddItemOrder.IconSize = 32;
            this.btnAddItemOrder.Location = new System.Drawing.Point(802, 148);
            this.btnAddItemOrder.Name = "btnAddItemOrder";
            this.btnAddItemOrder.Size = new System.Drawing.Size(223, 42);
            this.btnAddItemOrder.TabIndex = 5;
            this.btnAddItemOrder.Text = "Thêm Vào Hóa Đơn";
            this.btnAddItemOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddItemOrder.UseVisualStyleBackColor = false;
            this.btnAddItemOrder.Click += new System.EventHandler(this.btnAddItemOrder_Click);
            // 
            // nbrQuantity
            // 
            this.nbrQuantity.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbrQuantity.Location = new System.Drawing.Point(716, 149);
            this.nbrQuantity.Margin = new System.Windows.Forms.Padding(0);
            this.nbrQuantity.Name = "nbrQuantity";
            this.nbrQuantity.Size = new System.Drawing.Size(73, 32);
            this.nbrQuantity.TabIndex = 6;
            this.nbrQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtSumPrice
            // 
            this.txtSumPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSumPrice.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtSumPrice.Enabled = false;
            this.txtSumPrice.Font = new System.Drawing.Font("Quicksand SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtSumPrice.Location = new System.Drawing.Point(696, 574);
            this.txtSumPrice.Name = "txtSumPrice";
            this.txtSumPrice.ReadOnly = true;
            this.txtSumPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSumPrice.Size = new System.Drawing.Size(159, 41);
            this.txtSumPrice.TabIndex = 7;
            this.txtSumPrice.Text = "0";
            // 
            // cmbSize
            // 
            this.cmbSize.Font = new System.Drawing.Font("Quicksand Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Location = new System.Drawing.Point(511, 148);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(59, 33);
            this.cmbSize.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sản phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(456, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Size:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(614, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Số lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(718, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 30);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ngày:";
            // 
            // lbDayNow
            // 
            this.lbDayNow.AutoSize = true;
            this.lbDayNow.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDayNow.Location = new System.Drawing.Point(795, 90);
            this.lbDayNow.Name = "lbDayNow";
            this.lbDayNow.Size = new System.Drawing.Size(102, 30);
            this.lbDayNow.TabIndex = 13;
            this.lbDayNow.Text = "Hôm Nay";
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInvoice.BackgroundColor = System.Drawing.Color.White;
            this.dgvInvoice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SizeProduct,
            this.STT,
            this.NameProduct,
            this.Quantity,
            this.Price,
            this.Discount,
            this.ThanhTien});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Quicksand", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoice.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInvoice.GridColor = System.Drawing.Color.White;
            this.dgvInvoice.Location = new System.Drawing.Point(17, 211);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvInvoice.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInvoice.RowHeadersVisible = false;
            this.dgvInvoice.RowHeadersWidth = 51;
            this.dgvInvoice.RowTemplate.Height = 24;
            this.dgvInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoice.Size = new System.Drawing.Size(1008, 321);
            this.dgvInvoice.TabIndex = 14;
            this.dgvInvoice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // SizeProduct
            // 
            this.SizeProduct.HeaderText = "Size";
            this.SizeProduct.MinimumWidth = 6;
            this.SizeProduct.Name = "SizeProduct";
            this.SizeProduct.ReadOnly = true;
            this.SizeProduct.Visible = false;
            this.SizeProduct.Width = 125;
            // 
            // STT
            // 
            this.STT.HeaderText = "TT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 125;
            // 
            // NameProduct
            // 
            this.NameProduct.HeaderText = "Tên Sản Phẩm";
            this.NameProduct.MinimumWidth = 6;
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.ReadOnly = true;
            this.NameProduct.Width = 305;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.HeaderText = "Số Lượng";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.HeaderText = "Đơn Giá";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Khuyến Mãi";
            this.Discount.MinimumWidth = 6;
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            this.Discount.Width = 125;
            // 
            // ThanhTien
            // 
            this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // btnDeleteInvoice
            // 
            this.btnDeleteInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteInvoice.FlatAppearance.BorderSize = 0;
            this.btnDeleteInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteInvoice.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteInvoice.ForeColor = System.Drawing.Color.White;
            this.btnDeleteInvoice.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDeleteInvoice.IconColor = System.Drawing.Color.White;
            this.btnDeleteInvoice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteInvoice.IconSize = 32;
            this.btnDeleteInvoice.Location = new System.Drawing.Point(579, 574);
            this.btnDeleteInvoice.Name = "btnDeleteInvoice";
            this.btnDeleteInvoice.Size = new System.Drawing.Size(101, 41);
            this.btnDeleteInvoice.TabIndex = 15;
            this.btnDeleteInvoice.Text = "Xóa";
            this.btnDeleteInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteInvoice.UseVisualStyleBackColor = false;
            this.btnDeleteInvoice.Click += new System.EventHandler(this.btnDeleteInvoice_Click);
            // 
            // lbNamestaff
            // 
            this.lbNamestaff.AutoSize = true;
            this.lbNamestaff.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNamestaff.Location = new System.Drawing.Point(134, 90);
            this.lbNamestaff.Name = "lbNamestaff";
            this.lbNamestaff.Size = new System.Drawing.Size(143, 30);
            this.lbNamestaff.TabIndex = 17;
            this.lbNamestaff.Text = "Tên nhân viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 30);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nhân viên:";
            // 
            // FrmAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 630);
            this.Controls.Add(this.lbNamestaff);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDeleteInvoice);
            this.Controls.Add(this.dgvInvoice);
            this.Controls.Add(this.lbDayNow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSize);
            this.Controls.Add(this.txtSumPrice);
            this.Controls.Add(this.nbrQuantity);
            this.Controls.Add(this.btnAddItemOrder);
            this.Controls.Add(this.cmbListProduct);
            this.Controls.Add(this.chbPrintInvoice);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddOrder";
            this.Load += new System.EventHandler(this.FrmAddOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnThanhToan;
        private FontAwesome.Sharp.IconPictureBox ipbTitle;
        private System.Windows.Forms.CheckBox chbPrintInvoice;
        private System.Windows.Forms.ComboBox cmbListProduct;
        private FontAwesome.Sharp.IconButton btnAddItemOrder;
        private System.Windows.Forms.NumericUpDown nbrQuantity;
        private System.Windows.Forms.TextBox txtSumPrice;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMinisize;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbDayNow;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private FontAwesome.Sharp.IconButton btnDeleteInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Label lbNamestaff;
        private System.Windows.Forms.Label label7;
    }
}