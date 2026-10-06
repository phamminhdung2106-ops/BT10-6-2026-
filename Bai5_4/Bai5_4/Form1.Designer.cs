using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai5_4
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
            this.imgSmall = new System.Windows.Forms.ImageList(this.components);
            this.imgLarge = new System.Windows.Forms.ImageList(this.components);
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.tvDepartments = new System.Windows.Forms.TreeView();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblView = new System.Windows.Forms.Label();
            this.cboView = new System.Windows.Forms.ComboBox();
            this.lsvEmployees = new System.Windows.Forms.ListView();
            this.colMa = new System.Windows.Forms.ColumnHeader();
            this.colHoTen = new System.Windows.Forms.ColumnHeader();
            this.colChucVu = new System.Windows.Forms.ColumnHeader();
            this.colNgayVao = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            //
            // imgSmall
            //
            this.imgSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgSmall.ImageSize = new System.Drawing.Size(16, 16);
            this.imgSmall.TransparentColor = System.Drawing.Color.Transparent;
            //
            // imgLarge
            //
            this.imgLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.imgLarge.TransparentColor = System.Drawing.Color.Transparent;
            //
            // splitMain
            //
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Name = "splitMain";
            this.splitMain.Panel1.Controls.Add(this.tvDepartments);
            this.splitMain.Panel2.Controls.Add(this.lsvEmployees);
            this.splitMain.Panel2.Controls.Add(this.pnlTop);
            this.splitMain.Size = new System.Drawing.Size(900, 520);
            this.splitMain.SplitterDistance = 260;
            this.splitMain.TabIndex = 0;
            //
            // tvDepartments
            //
            this.tvDepartments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvDepartments.HideSelection = false;
            this.tvDepartments.ImageList = this.imgSmall;
            this.tvDepartments.Location = new System.Drawing.Point(0, 0);
            this.tvDepartments.Name = "tvDepartments";
            this.tvDepartments.TabIndex = 0;
            this.tvDepartments.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDepartments_AfterSelect);
            //
            // pnlTop
            //
            this.pnlTop.Controls.Add(this.lblView);
            this.pnlTop.Controls.Add(this.cboView);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(636, 40);
            this.pnlTop.TabIndex = 0;
            //
            // lblView
            //
            this.lblView.AutoSize = true;
            this.lblView.Location = new System.Drawing.Point(10, 13);
            this.lblView.Name = "lblView";
            this.lblView.Text = "Chế độ xem:";
            //
            // cboView
            //
            this.cboView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboView.Items.AddRange(new object[] { "Details", "SmallIcon", "LargeIcon", "Tile", "List" });
            this.cboView.Location = new System.Drawing.Point(95, 9);
            this.cboView.Name = "cboView";
            this.cboView.Size = new System.Drawing.Size(150, 23);
            this.cboView.TabIndex = 0;
            this.cboView.SelectedIndexChanged += new System.EventHandler(this.cboView_SelectedIndexChanged);
            //
            // lsvEmployees
            //
            this.lsvEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colMa, this.colHoTen, this.colChucVu, this.colNgayVao });
            this.lsvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvEmployees.FullRowSelect = true;
            this.lsvEmployees.GridLines = true;
            this.lsvEmployees.LargeImageList = this.imgLarge;
            this.lsvEmployees.Location = new System.Drawing.Point(0, 40);
            this.lsvEmployees.Name = "lsvEmployees";
            this.lsvEmployees.SmallImageList = this.imgSmall;
            this.lsvEmployees.TabIndex = 1;
            this.lsvEmployees.TileSize = new System.Drawing.Size(230, 48);
            this.lsvEmployees.UseCompatibleStateImageBehavior = false;
            this.lsvEmployees.View = System.Windows.Forms.View.Details;
            //
            // colMa
            //
            this.colMa.Text = "Mã NV";
            this.colMa.Width = 80;
            //
            // colHoTen
            //
            this.colHoTen.Text = "Họ Tên";
            this.colHoTen.Width = 180;
            //
            // colChucVu
            //
            this.colChucVu.Text = "Chức vụ";
            this.colChucVu.Width = 160;
            //
            // colNgayVao
            //
            this.colNgayVao.Text = "Ngày vào làm";
            this.colNgayVao.Width = 120;
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 520);
            this.Controls.Add(this.splitMain);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân sự (TreeView & ListView)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ImageList imgSmall;
        private System.Windows.Forms.ImageList imgLarge;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.TreeView tvDepartments;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.ComboBox cboView;
        private System.Windows.Forms.ListView lsvEmployees;
        private System.Windows.Forms.ColumnHeader colMa;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colChucVu;
        private System.Windows.Forms.ColumnHeader colNgayVao;
    }
}
