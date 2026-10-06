using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai5_2
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
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lstAvailableServices = new System.Windows.Forms.ListBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.lblSelected = new System.Windows.Forms.Label();
            this.lstSelectedServices = new System.Windows.Forms.ListBox();
            this.grpTinhTien = new System.Windows.Forms.GroupBox();
            this.lblTong = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.lblChietKhau = new System.Windows.Forms.Label();
            this.numChietKhau = new System.Windows.Forms.NumericUpDown();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblCoupon = new System.Windows.Forms.Label();
            this.txtCoupon = new System.Windows.Forms.TextBox();
            this.btnApDung = new System.Windows.Forms.Button();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numChietKhau)).BeginInit();
            this.grpTinhTien.SuspendLayout();
            this.SuspendLayout();
            //
            // lblCategory
            //
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(15, 18);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Text = "Loại dịch vụ:";
            //
            // cboCategory
            //
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Location = new System.Drawing.Point(110, 15);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(250, 23);
            this.cboCategory.TabIndex = 0;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            //
            // lblAvailable
            //
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Location = new System.Drawing.Point(15, 50);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Text = "Dịch vụ có sẵn:";
            //
            // lstAvailableServices
            //
            this.lstAvailableServices.FormattingEnabled = true;
            this.lstAvailableServices.ItemHeight = 15;
            this.lstAvailableServices.Location = new System.Drawing.Point(15, 70);
            this.lstAvailableServices.Name = "lstAvailableServices";
            this.lstAvailableServices.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstAvailableServices.Size = new System.Drawing.Size(300, 199);
            this.lstAvailableServices.TabIndex = 1;
            this.lstAvailableServices.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstAvailableServices_MouseDoubleClick);
            //
            // btnSelect
            //
            this.btnSelect.Location = new System.Drawing.Point(325, 100);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(60, 32);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = ">";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            //
            // btnRemove
            //
            this.btnRemove.Location = new System.Drawing.Point(325, 140);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(60, 32);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            //
            // btnClearAll
            //
            this.btnClearAll.Location = new System.Drawing.Point(325, 180);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(60, 32);
            this.btnClearAll.TabIndex = 4;
            this.btnClearAll.Text = "<<";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            //
            // lblSelected
            //
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(395, 50);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Text = "Dịch vụ đã chọn:";
            //
            // lstSelectedServices
            //
            this.lstSelectedServices.FormattingEnabled = true;
            this.lstSelectedServices.ItemHeight = 15;
            this.lstSelectedServices.Location = new System.Drawing.Point(395, 70);
            this.lstSelectedServices.Name = "lstSelectedServices";
            this.lstSelectedServices.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSelectedServices.Size = new System.Drawing.Size(350, 199);
            this.lstSelectedServices.TabIndex = 5;
            this.lstSelectedServices.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstSelectedServices_MouseDoubleClick);
            //
            // grpTinhTien
            //
            this.grpTinhTien.Controls.Add(this.lblTong);
            this.grpTinhTien.Controls.Add(this.txtTong);
            this.grpTinhTien.Controls.Add(this.lblChietKhau);
            this.grpTinhTien.Controls.Add(this.numChietKhau);
            this.grpTinhTien.Controls.Add(this.lblPercent);
            this.grpTinhTien.Controls.Add(this.lblCoupon);
            this.grpTinhTien.Controls.Add(this.txtCoupon);
            this.grpTinhTien.Controls.Add(this.btnApDung);
            this.grpTinhTien.Controls.Add(this.lblThanhTien);
            this.grpTinhTien.Controls.Add(this.txtThanhTien);
            this.grpTinhTien.Location = new System.Drawing.Point(15, 285);
            this.grpTinhTien.Name = "grpTinhTien";
            this.grpTinhTien.Size = new System.Drawing.Size(730, 140);
            this.grpTinhTien.TabIndex = 6;
            this.grpTinhTien.TabStop = false;
            this.grpTinhTien.Text = "Tính tiền";
            //
            // lblTong
            //
            this.lblTong.AutoSize = true;
            this.lblTong.Location = new System.Drawing.Point(15, 33);
            this.lblTong.Name = "lblTong";
            this.lblTong.Text = "Tổng tiền chưa giảm:";
            //
            // txtTong
            //
            this.txtTong.Location = new System.Drawing.Point(190, 30);
            this.txtTong.Name = "txtTong";
            this.txtTong.ReadOnly = true;
            this.txtTong.Size = new System.Drawing.Size(160, 23);
            this.txtTong.TabStop = false;
            this.txtTong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // lblChietKhau
            //
            this.lblChietKhau.AutoSize = true;
            this.lblChietKhau.Location = new System.Drawing.Point(15, 68);
            this.lblChietKhau.Name = "lblChietKhau";
            this.lblChietKhau.Text = "Tỷ lệ chiết khấu (%):";
            //
            // numChietKhau
            //
            this.numChietKhau.Location = new System.Drawing.Point(190, 65);
            this.numChietKhau.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numChietKhau.Name = "numChietKhau";
            this.numChietKhau.Size = new System.Drawing.Size(70, 23);
            this.numChietKhau.TabIndex = 0;
            this.numChietKhau.ValueChanged += new System.EventHandler(this.numChietKhau_ValueChanged);
            //
            // lblPercent
            //
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(266, 68);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Text = "%";
            //
            // lblCoupon
            //
            this.lblCoupon.AutoSize = true;
            this.lblCoupon.Location = new System.Drawing.Point(400, 33);
            this.lblCoupon.Name = "lblCoupon";
            this.lblCoupon.Text = "Mã giảm giá:";
            //
            // txtCoupon
            //
            this.txtCoupon.Location = new System.Drawing.Point(490, 30);
            this.txtCoupon.Name = "txtCoupon";
            this.txtCoupon.Size = new System.Drawing.Size(110, 23);
            this.txtCoupon.TabIndex = 1;
            //
            // btnApDung
            //
            this.btnApDung.Location = new System.Drawing.Point(610, 28);
            this.btnApDung.Name = "btnApDung";
            this.btnApDung.Size = new System.Drawing.Size(90, 27);
            this.btnApDung.TabIndex = 2;
            this.btnApDung.Text = "Áp dụng";
            this.btnApDung.UseVisualStyleBackColor = true;
            this.btnApDung.Click += new System.EventHandler(this.btnApDung_Click);
            //
            // lblThanhTien
            //
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblThanhTien.Location = new System.Drawing.Point(15, 103);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Text = "Thành tiền thanh toán:";
            //
            // txtThanhTien
            //
            this.txtThanhTien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtThanhTien.ForeColor = System.Drawing.Color.Firebrick;
            this.txtThanhTien.Location = new System.Drawing.Point(190, 99);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(160, 25);
            this.txtThanhTien.TabStop = false;
            this.txtThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 440);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.lstAvailableServices);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.lstSelectedServices);
            this.Controls.Add(this.grpTinhTien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính tiền dịch vụ và chiết khấu đơn hàng";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numChietKhau)).EndInit();
            this.grpTinhTien.ResumeLayout(false);
            this.grpTinhTien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.ListBox lstAvailableServices;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.ListBox lstSelectedServices;
        private System.Windows.Forms.GroupBox grpTinhTien;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Label lblChietKhau;
        private System.Windows.Forms.NumericUpDown numChietKhau;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblCoupon;
        private System.Windows.Forms.TextBox txtCoupon;
        private System.Windows.Forms.Button btnApDung;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.TextBox txtThanhTien;
    }
}
