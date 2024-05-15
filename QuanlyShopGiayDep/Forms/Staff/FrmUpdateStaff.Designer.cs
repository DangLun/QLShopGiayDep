namespace QuanlyShopGiayDep.Forms.Staff
{
    partial class FrmUpdateStaff
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
            this.btnRotate = new FontAwesome.Sharp.IconButton();
            this.lbID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnResetForm = new FontAwesome.Sharp.IconButton();
            this.btnExitFrm = new FontAwesome.Sharp.IconButton();
            this.btnUpdateAccep = new FontAwesome.Sharp.IconButton();
            this.grbGender = new System.Windows.Forms.GroupBox();
            this.rdbKhac = new System.Windows.Forms.RadioButton();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ErrorIcon = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.grbGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRotate
            // 
            this.btnRotate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(36)))));
            this.btnRotate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRotate.FlatAppearance.BorderSize = 0;
            this.btnRotate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRotate.ForeColor = System.Drawing.Color.White;
            this.btnRotate.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btnRotate.IconColor = System.Drawing.Color.White;
            this.btnRotate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRotate.IconSize = 32;
            this.btnRotate.Location = new System.Drawing.Point(144, 495);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(141, 48);
            this.btnRotate.TabIndex = 53;
            this.btnRotate.Text = "Phục hồi";
            this.btnRotate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRotate.UseVisualStyleBackColor = false;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(212, 119);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(33, 30);
            this.lbID.TabIndex = 52;
            this.lbID.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 30);
            this.label7.TabIndex = 51;
            this.label7.Text = "ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(149)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 100);
            this.panel1.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(133, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sửa Thông Tin Nhân Viên";
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
            this.btnResetForm.Location = new System.Drawing.Point(306, 495);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(152, 48);
            this.btnResetForm.TabIndex = 50;
            this.btnResetForm.Text = "Xóa Trắng";
            this.btnResetForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResetForm.UseVisualStyleBackColor = false;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // btnExitFrm
            // 
            this.btnExitFrm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExitFrm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitFrm.FlatAppearance.BorderSize = 0;
            this.btnExitFrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitFrm.ForeColor = System.Drawing.Color.White;
            this.btnExitFrm.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnExitFrm.IconColor = System.Drawing.Color.White;
            this.btnExitFrm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExitFrm.IconSize = 32;
            this.btnExitFrm.Location = new System.Drawing.Point(18, 495);
            this.btnExitFrm.Name = "btnExitFrm";
            this.btnExitFrm.Size = new System.Drawing.Size(110, 48);
            this.btnExitFrm.TabIndex = 49;
            this.btnExitFrm.Text = "Thoát";
            this.btnExitFrm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExitFrm.UseVisualStyleBackColor = false;
            this.btnExitFrm.Click += new System.EventHandler(this.btnExitFrm_Click);
            // 
            // btnUpdateAccep
            // 
            this.btnUpdateAccep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnUpdateAccep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateAccep.FlatAppearance.BorderSize = 0;
            this.btnUpdateAccep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAccep.ForeColor = System.Drawing.Color.White;
            this.btnUpdateAccep.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnUpdateAccep.IconColor = System.Drawing.Color.White;
            this.btnUpdateAccep.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateAccep.IconSize = 32;
            this.btnUpdateAccep.Location = new System.Drawing.Point(477, 495);
            this.btnUpdateAccep.Name = "btnUpdateAccep";
            this.btnUpdateAccep.Size = new System.Drawing.Size(104, 48);
            this.btnUpdateAccep.TabIndex = 48;
            this.btnUpdateAccep.Text = "Lưu";
            this.btnUpdateAccep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateAccep.UseVisualStyleBackColor = false;
            this.btnUpdateAccep.Click += new System.EventHandler(this.btnUpdateAccep_Click);
            // 
            // grbGender
            // 
            this.grbGender.Controls.Add(this.rdbKhac);
            this.grbGender.Controls.Add(this.rdbNu);
            this.grbGender.Controls.Add(this.rdbNam);
            this.grbGender.Location = new System.Drawing.Point(217, 337);
            this.grbGender.Name = "grbGender";
            this.grbGender.Size = new System.Drawing.Size(363, 66);
            this.grbGender.TabIndex = 63;
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
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(217, 430);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(363, 32);
            this.txtSalary.TabIndex = 62;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(217, 289);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(363, 32);
            this.dtpBirthDate.TabIndex = 61;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(217, 175);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(363, 32);
            this.txtName.TabIndex = 59;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(217, 230);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(363, 32);
            this.txtPhone.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 30);
            this.label2.TabIndex = 68;
            this.label2.Text = "Giới tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 30);
            this.label5.TabIndex = 67;
            this.label5.Text = "Lương:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 30);
            this.label4.TabIndex = 66;
            this.label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 30);
            this.label3.TabIndex = 65;
            this.label3.Text = "Số điện thoại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 30);
            this.label6.TabIndex = 64;
            this.label6.Text = "Tên nhân viên:";
            // 
            // ErrorIcon
            // 
            this.ErrorIcon.ContainerControl = this;
            // 
            // FrmUpdateStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 567);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grbGender);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.btnRotate);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnExitFrm);
            this.Controls.Add(this.btnUpdateAccep);
            this.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FrmUpdateStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUpdateStaff";
            this.Load += new System.EventHandler(this.FrmUpdateStaff_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbGender.ResumeLayout(false);
            this.grbGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnRotate;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnResetForm;
        private FontAwesome.Sharp.IconButton btnExitFrm;
        private FontAwesome.Sharp.IconButton btnUpdateAccep;
        private System.Windows.Forms.GroupBox grbGender;
        private System.Windows.Forms.RadioButton rdbKhac;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider ErrorIcon;
    }
}