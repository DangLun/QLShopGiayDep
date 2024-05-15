namespace QuanlyShopGiayDep.Forms.Account
{
    partial class FrmCapTK
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
            this.lableqltk = new System.Windows.Forms.Label();
            this.btnCap = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbInfoAccount = new System.Windows.Forms.ComboBox();
            this.labletentk = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbInfoNhanVien = new System.Windows.Forms.ComboBox();
            this.tenNV = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.lableqltk);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 102);
            this.panel1.TabIndex = 2;
            // 
            // lableqltk
            // 
            this.lableqltk.Font = new System.Drawing.Font("Quicksand", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableqltk.ForeColor = System.Drawing.Color.White;
            this.lableqltk.Location = new System.Drawing.Point(59, 24);
            this.lableqltk.Name = "lableqltk";
            this.lableqltk.Size = new System.Drawing.Size(475, 52);
            this.lableqltk.TabIndex = 1;
            this.lableqltk.Text = "CẤP TÀI KHOẢN NHÂN VIÊN";
            // 
            // btnCap
            // 
            this.btnCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCap.FlatAppearance.BorderSize = 0;
            this.btnCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCap.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCap.ForeColor = System.Drawing.Color.White;
            this.btnCap.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnCap.IconColor = System.Drawing.Color.White;
            this.btnCap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCap.IconSize = 32;
            this.btnCap.Location = new System.Drawing.Point(462, 307);
            this.btnCap.Name = "btnCap";
            this.btnCap.Size = new System.Drawing.Size(99, 42);
            this.btnCap.TabIndex = 38;
            this.btnCap.Text = "Cấp";
            this.btnCap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCap.UseVisualStyleBackColor = false;
            this.btnCap.Click += new System.EventHandler(this.btnCap_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel3.Controls.Add(this.cmbInfoAccount);
            this.panel3.Controls.Add(this.labletentk);
            this.panel3.Location = new System.Drawing.Point(36, 207);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(525, 62);
            this.panel3.TabIndex = 37;
            // 
            // cmbInfoAccount
            // 
            this.cmbInfoAccount.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInfoAccount.FormattingEnabled = true;
            this.cmbInfoAccount.Items.AddRange(new object[] {
            "trantranLucky@gmail.com",
            "DangkhungLucky@gmail.com",
            "KhuongLucky@gmail.com"});
            this.cmbInfoAccount.Location = new System.Drawing.Point(206, 11);
            this.cmbInfoAccount.Name = "cmbInfoAccount";
            this.cmbInfoAccount.Size = new System.Drawing.Size(272, 38);
            this.cmbInfoAccount.TabIndex = 3;
            // 
            // labletentk
            // 
            this.labletentk.AutoSize = true;
            this.labletentk.BackColor = System.Drawing.Color.Transparent;
            this.labletentk.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labletentk.ForeColor = System.Drawing.Color.White;
            this.labletentk.Location = new System.Drawing.Point(14, 14);
            this.labletentk.Name = "labletentk";
            this.labletentk.Size = new System.Drawing.Size(113, 30);
            this.labletentk.TabIndex = 0;
            this.labletentk.Text = "Tài khoản:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.cmbInfoNhanVien);
            this.panel2.Controls.Add(this.tenNV);
            this.panel2.Location = new System.Drawing.Point(36, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 62);
            this.panel2.TabIndex = 36;
            // 
            // cmbInfoNhanVien
            // 
            this.cmbInfoNhanVien.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInfoNhanVien.FormattingEnabled = true;
            this.cmbInfoNhanVien.Items.AddRange(new object[] {
            "trantranLucky@gmail.com",
            "DangkhungLucky@gmail.com",
            "KhuongLucky@gmail.com"});
            this.cmbInfoNhanVien.Location = new System.Drawing.Point(206, 11);
            this.cmbInfoNhanVien.Name = "cmbInfoNhanVien";
            this.cmbInfoNhanVien.Size = new System.Drawing.Size(272, 38);
            this.cmbInfoNhanVien.TabIndex = 4;
            // 
            // tenNV
            // 
            this.tenNV.AutoSize = true;
            this.tenNV.BackColor = System.Drawing.Color.Transparent;
            this.tenNV.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenNV.ForeColor = System.Drawing.Color.White;
            this.tenNV.Location = new System.Drawing.Point(14, 14);
            this.tenNV.Name = "tenNV";
            this.tenNV.Size = new System.Drawing.Size(116, 30);
            this.tenNV.TabIndex = 0;
            this.tenNV.Text = "Nhân viên:";
            // 
            // FrmCapTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(599, 371);
            this.Controls.Add(this.btnCap);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCapTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCapTK";
            this.Load += new System.EventHandler(this.FrmCapTK_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lableqltk;
        private FontAwesome.Sharp.IconButton btnCap;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbInfoAccount;
        private System.Windows.Forms.Label labletentk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbInfoNhanVien;
        private System.Windows.Forms.Label tenNV;
    }
}