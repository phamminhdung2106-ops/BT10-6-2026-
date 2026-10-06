using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai5_1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.epCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpCaNhan = new System.Windows.Forms.GroupBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.grpBoSung = new System.Windows.Forms.GroupBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.chkDieuKhoan = new System.Windows.Forms.CheckBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).BeginInit();
            this.grpCaNhan.SuspendLayout();
            this.grpBoSung.SuspendLayout();
            this.SuspendLayout();
            //
            // epCheck
            //
            this.epCheck.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epCheck.ContainerControl = this;
            //
            // grpCaNhan
            //
            this.grpCaNhan.Controls.Add(this.lblUsername);
            this.grpCaNhan.Controls.Add(this.txtUsername);
            this.grpCaNhan.Controls.Add(this.lblPassword);
            this.grpCaNhan.Controls.Add(this.txtPassword);
            this.grpCaNhan.Controls.Add(this.lblConfirm);
            this.grpCaNhan.Controls.Add(this.txtConfirm);
            this.grpCaNhan.Location = new System.Drawing.Point(15, 15);
            this.grpCaNhan.Name = "grpCaNhan";
            this.grpCaNhan.Size = new System.Drawing.Size(390, 150);
            this.grpCaNhan.TabIndex = 0;
            this.grpCaNhan.TabStop = false;
            this.grpCaNhan.Text = "Thông tin cá nhân";
            //
            // lblUsername
            //
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(15, 33);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Text = "Tên đăng nhập:";
            //
            // txtUsername
            //
            this.txtUsername.Location = new System.Drawing.Point(140, 30);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(210, 23);
            this.txtUsername.TabIndex = 0;
            //
            // lblPassword
            //
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(15, 73);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Text = "Mật khẩu:";
            //
            // txtPassword
            //
            this.txtPassword.Location = new System.Drawing.Point(140, 70);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(210, 23);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            //
            // lblConfirm
            //
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Location = new System.Drawing.Point(15, 113);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Text = "Xác nhận mật khẩu:";
            //
            // txtConfirm
            //
            this.txtConfirm.Location = new System.Drawing.Point(140, 110);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(210, 23);
            this.txtConfirm.TabIndex = 2;
            this.txtConfirm.UseSystemPasswordChar = true;
            //
            // grpBoSung
            //
            this.grpBoSung.Controls.Add(this.lblNgaySinh);
            this.grpBoSung.Controls.Add(this.dtpNgaySinh);
            this.grpBoSung.Controls.Add(this.lblGioiTinh);
            this.grpBoSung.Controls.Add(this.rdoNam);
            this.grpBoSung.Controls.Add(this.rdoNu);
            this.grpBoSung.Controls.Add(this.chkDieuKhoan);
            this.grpBoSung.Location = new System.Drawing.Point(15, 180);
            this.grpBoSung.Name = "grpBoSung";
            this.grpBoSung.Size = new System.Drawing.Size(390, 160);
            this.grpBoSung.TabIndex = 1;
            this.grpBoSung.TabStop = false;
            this.grpBoSung.Text = "Thông tin bổ sung";
            //
            // lblNgaySinh
            //
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(15, 33);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Text = "Ngày sinh:";
            //
            // dtpNgaySinh
            //
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(140, 29);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(150, 23);
            this.dtpNgaySinh.TabIndex = 0;
            //
            // lblGioiTinh
            //
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(15, 73);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Text = "Giới tính:";
            //
            // rdoNam
            //
            this.rdoNam.AutoSize = true;
            this.rdoNam.Checked = true;
            this.rdoNam.Location = new System.Drawing.Point(140, 71);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.TabIndex = 1;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            //
            // rdoNu
            //
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(220, 71);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.TabIndex = 2;
            this.rdoNu.Text = "Nữ";
            //
            // chkDieuKhoan
            //
            this.chkDieuKhoan.Location = new System.Drawing.Point(15, 112);
            this.chkDieuKhoan.Name = "chkDieuKhoan";
            this.chkDieuKhoan.Size = new System.Drawing.Size(300, 24);
            this.chkDieuKhoan.TabIndex = 3;
            this.chkDieuKhoan.Text = "Tôi đồng ý với điều khoản dịch vụ";
            //
            // btnDangKy
            //
            this.btnDangKy.Location = new System.Drawing.Point(80, 360);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(110, 35);
            this.btnDangKy.TabIndex = 2;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            //
            // btnLamMoi
            //
            this.btnLamMoi.Location = new System.Drawing.Point(230, 360);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(110, 35);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 415);
            this.Controls.Add(this.grpCaNhan);
            this.Controls.Add(this.grpBoSung);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.btnLamMoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký tài khoản";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).EndInit();
            this.grpCaNhan.ResumeLayout(false);
            this.grpCaNhan.PerformLayout();
            this.grpBoSung.ResumeLayout(false);
            this.grpBoSung.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ErrorProvider epCheck;
        private System.Windows.Forms.GroupBox grpCaNhan;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.GroupBox grpBoSung;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.CheckBox chkDieuKhoan;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnLamMoi;
    }
}
