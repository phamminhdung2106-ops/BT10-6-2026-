using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai5_3
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
            this.bsProducts = new System.Windows.Forms.BindingSource(this.components);
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.lblQty = new System.Windows.Forms.Label();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnTatCa = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.grpThongTin.SuspendLayout();
            this.grpChucNang.SuspendLayout();
            this.SuspendLayout();
            //
            // grpThongTin
            //
            this.grpThongTin.Controls.Add(this.lblId);
            this.grpThongTin.Controls.Add(this.txtId);
            this.grpThongTin.Controls.Add(this.lblName);
            this.grpThongTin.Controls.Add(this.txtName);
            this.grpThongTin.Controls.Add(this.lblPrice);
            this.grpThongTin.Controls.Add(this.numPrice);
            this.grpThongTin.Controls.Add(this.lblQty);
            this.grpThongTin.Controls.Add(this.numQty);
            this.grpThongTin.Controls.Add(this.lblCategory);
            this.grpThongTin.Controls.Add(this.cboCategory);
            this.grpThongTin.Location = new System.Drawing.Point(15, 12);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(790, 150);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin sản phẩm";
            //
            // lblId
            //
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(15, 33);
            this.lblId.Name = "lblId";
            this.lblId.Text = "Mã SP:";
            //
            // txtId
            //
            this.txtId.Location = new System.Drawing.Point(95, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(150, 23);
            this.txtId.TabIndex = 0;
            //
            // lblName
            //
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(290, 33);
            this.lblName.Name = "lblName";
            this.lblName.Text = "Tên SP:";
            //
            // txtName
            //
            this.txtName.Location = new System.Drawing.Point(360, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 23);
            this.txtName.TabIndex = 1;
            //
            // lblPrice
            //
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(15, 73);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Text = "Đơn giá:";
            //
            // numPrice
            //
            this.numPrice.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numPrice.Location = new System.Drawing.Point(95, 70);
            this.numPrice.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(150, 23);
            this.numPrice.TabIndex = 2;
            this.numPrice.ThousandsSeparator = true;
            //
            // lblQty
            //
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(290, 73);
            this.lblQty.Name = "lblQty";
            this.lblQty.Text = "Số lượng:";
            //
            // numQty
            //
            this.numQty.Location = new System.Drawing.Point(360, 70);
            this.numQty.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(100, 23);
            this.numQty.TabIndex = 3;
            //
            // lblCategory
            //
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(15, 113);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Text = "Danh mục:";
            //
            // cboCategory
            //
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Location = new System.Drawing.Point(95, 110);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(150, 23);
            this.cboCategory.TabIndex = 4;
            //
            // grpChucNang
            //
            this.grpChucNang.Controls.Add(this.btnThem);
            this.grpChucNang.Controls.Add(this.btnSua);
            this.grpChucNang.Controls.Add(this.btnXoa);
            this.grpChucNang.Controls.Add(this.lblSearch);
            this.grpChucNang.Controls.Add(this.txtSearch);
            this.grpChucNang.Controls.Add(this.btnTim);
            this.grpChucNang.Controls.Add(this.btnTatCa);
            this.grpChucNang.Location = new System.Drawing.Point(15, 170);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(790, 70);
            this.grpChucNang.TabIndex = 1;
            this.grpChucNang.TabStop = false;
            this.grpChucNang.Text = "Chức năng";
            //
            // btnThem
            //
            this.btnThem.Location = new System.Drawing.Point(15, 25);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 32);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            //
            // btnSua
            //
            this.btnSua.Location = new System.Drawing.Point(105, 25);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 32);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            //
            // btnXoa
            //
            this.btnXoa.Location = new System.Drawing.Point(195, 25);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 32);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            //
            // lblSearch
            //
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(320, 33);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Text = "Tìm theo Tên SP:";
            //
            // txtSearch
            //
            this.txtSearch.Location = new System.Drawing.Point(430, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(170, 23);
            this.txtSearch.TabIndex = 3;
            //
            // btnTim
            //
            this.btnTim.Location = new System.Drawing.Point(610, 25);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(80, 32);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            //
            // btnTatCa
            //
            this.btnTatCa.Location = new System.Drawing.Point(695, 25);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(80, 32);
            this.btnTatCa.TabIndex = 5;
            this.btnTatCa.Text = "Tất cả";
            this.btnTatCa.UseVisualStyleBackColor = true;
            this.btnTatCa.Click += new System.EventHandler(this.btnTatCa_Click);
            //
            // dgvProducts
            //
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.DataSource = this.bsProducts;
            this.dgvProducts.Location = new System.Drawing.Point(15, 250);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(790, 290);
            this.dgvProducts.TabIndex = 2;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 555);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.dgvProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý danh sách sản phẩm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpChucNang.ResumeLayout(false);
            this.grpChucNang.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.BindingSource bsProducts;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnTatCa;
        private System.Windows.Forms.DataGridView dgvProducts;
    }
}
