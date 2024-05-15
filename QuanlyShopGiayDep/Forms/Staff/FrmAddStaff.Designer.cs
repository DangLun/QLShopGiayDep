namespace QuanlyShopGiayDep.Forms.Staff
{
    partial class FrmAddStaff
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
            this.components = new System.ComponentModel.Container();
            this.label7 = new System.Windows.Forms.Label();
            this.btnResetForm = new FontAwesome.Sharp.IconButton();
            this.btnExitFrmAddStaff = new FontAwesome.Sharp.IconButton();
            this.btnAddAccep = new FontAwesome.Sharp.IconButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.grbGender = new System.Windows.Forms.GroupBox();
            this.rdbKhac = new System.Windows.Forms.RadioButton();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.ErrorIcon = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.grbGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 30);
            this.label7.TabIndex = 34;
            this.label7.Text = "Giới tính:";
            // 
            // btnResetForm
            // 
            this.btnResetForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(149)))), ((int)(((byte)(238)))));
            this.btnResetForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetForm.FlatAppearance.BorderSize = 0;
            this.btnResetForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetForm.ForeColor = System.Drawing.Color.White;
            this.btnResetForm.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnResetForm.IconColor = System.Drawing.Color.White;
            this.btnResetForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResetForm.IconSize = 32;
            this.btnResetForm.Location = new System.Drawing.Point(280, 457);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(160, 48);
            this.btnResetForm.TabIndex = 33;
            this.btnResetForm.Text = "Xóa Trắng";
            this.btnResetForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResetForm.UseVisualStyleBackColor = false;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // btnExitFrmAddStaff
            // 
            this.btnExitFrmAddStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExitFrmAddStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitFrmAddStaff.FlatAppearance.BorderSize = 0;
            this.btnExitFrmAddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitFrmAddStaff.ForeColor = System.Drawing.Color.White;
            this.btnExitFrmAddStaff.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnExitFrmAddStaff.IconColor = System.Drawing.Color.White;
            this.btnExitFrmAddStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExitFrmAddStaff.IconSize = 32;
            this.btnExitFrmAddStaff.Location = new System.Drawing.Point(23, 457);
            this.btnExitFrmAddStaff.Name = "btnExitFrmAddStaff";
            this.btnExitFrmAddStaff.Size = new System.Drawing.Size(122, 48);
            this.btnExitFrmAddStaff.TabIndex = 32;
            this.btnExitFrmAddStaff.Text = "Thoát";
            this.btnExitFrmAddStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExitFrmAddStaff.UseVisualStyleBackColor = false;
            this.btnExitFrmAddStaff.Click += new System.EventHandler(this.btnExitFrmAddStaff_Click);
            // 
            // btnAddAccep
            // 
            this.btnAddAccep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAddAccep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAccep.FlatAppearance.BorderSize = 0;
            this.btnAddAccep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAccep.ForeColor = System.Drawing.Color.White;
            this.btnAddAccep.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnAddAccep.IconColor = System.Drawing.Color.White;
            this.btnAddAccep.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddAccep.IconSize = 32;
            this.btnAddAccep.Location = new System.Drawing.Point(461, 457);
            this.btnAddAccep.Name = "btnAddAccep";
            this.btnAddAccep.Size = new System.Drawing.Size(104, 48);
            this.btnAddAccep.TabIndex = 31;
            this.btnAddAccep.Text = "Lưu";
            this.btnAddAccep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddAccep.UseVisualStyleBackColor = false;
            this.btnAddAccep.Click += new System.EventHandler(this.btnAddAccep_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(202, 136);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(363, 32);
            this.txtName.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 30);
            this.label5.TabIndex = 24;
            this.label5.Text = "Lương:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 30);
            this.label4.TabIndex = 23;
            this.label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 30);
            this.label3.TabIndex = 22;
            this.label3.Text = "Số điện thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 30);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên nhân viên:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(202, 191);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(363, 32);
            this.txtPhone.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(149)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 100);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(166, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm Nhân Viên";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(202, 250);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(363, 32);
            this.dtpBirthDate.TabIndex = 35;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(202, 391);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(363, 32);
            this.txtSalary.TabIndex = 38;
            // 
            // grbGender
            // 
            this.grbGender.Controls.Add(this.rdbKhac);
            this.grbGender.Controls.Add(this.rdbNu);
            this.grbGender.Controls.Add(this.rdbNam);
            this.grbGender.Location = new System.Drawing.Point(202, 298);
            this.grbGender.Name = "grbGender";
            this.grbGender.Size = new System.Drawing.Size(363, 66);
            this.grbGender.TabIndex = 39;
            this.grbGender.TabStop = false;
            // 
            // rdbKhac
            // 
            this.rdbKhac.AutoSize = true;
            this.rdbKhac.Location = new System.Drawing.Point(231, 20);
            this.rdbKhac.Name = "rdbKhac";
            this.rdbKhac.Size = new System.Drawing.Size(80, 34);
            this.rdbKhac.TabIndex = 40;
            this.rdbKhac.Text = "Khác";
            this.rdbKhac.UseVisualStyleBackColor = true;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(126, 20);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(61, 34);
            this.rdbNu.TabIndex = 39;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Checked = true;
            this.rdbNam.Location = new System.Drawing.Point(6, 20);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(79, 34);
            this.rdbNam.TabIndex = 38;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // ErrorIcon
            // 
            this.ErrorIcon.ContainerControl = this;
            // 
            // FrmAddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 530);
            this.Controls.Add(this.grbGender);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnExitFrmAddStaff);
            this.Controls.Add(this.btnAddAccep);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FrmAddStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddStaff";
            this.Load += new System.EventHandler(this.FrmAddStaff_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbGender.ResumeLayout(false);
            this.grbGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btnResetForm;
        private FontAwesome.Sharp.IconButton btnExitFrmAddStaff;
        private FontAwesome.Sharp.IconButton btnAddAccep;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.GroupBox grbGender;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.RadioButton rdbKhac;
        private System.Windows.Forms.ErrorProvider ErrorIcon;
    }
}