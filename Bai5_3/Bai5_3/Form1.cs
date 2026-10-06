using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Bai5_3
{
    public partial class Form1 : Form
    {
        // Nguồn dữ liệu chính trong bộ nhớ
        private readonly List<Product> dsSanPham = new List<Product>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboCategory.Items.AddRange(new object[] { "Điện tử", "Gia dụng", "Thời trang", "Thực phẩm", "Văn phòng phẩm" });
            cboCategory.SelectedIndex = 0;

            dsSanPham.Add(new Product("SP001", "Chuột không dây", 250000, 40, "Điện tử"));
            dsSanPham.Add(new Product("SP002", "Bàn phím cơ", 850000, 15, "Điện tử"));
            dsSanPham.Add(new Product("SP003", "Nồi cơm điện", 1200000, 8, "Gia dụng"));
            dsSanPham.Add(new Product("SP004", "Sổ tay A5", 35000, 200, "Văn phòng phẩm"));

            LamMoiLuoi();
        }

        // Đưa dữ liệu (đã lọc theo ô tìm kiếm) lên DataGridView
        private void LamMoiLuoi()
        {
            string tuKhoa = txtSearch.Text.Trim();
            List<Product> ketQua;

            if (string.IsNullOrEmpty(tuKhoa))
                ketQua = dsSanPham.ToList();
            else
                ketQua = dsSanPham
                    .Where(p => p.ProductName.IndexOf(tuKhoa, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();

            bsProducts.DataSource = ketQua;
            bsProducts.ResetBindings(false);
            CauHinhCot();
        }

        private void CauHinhCot()
        {
            SetHeader("ProductId", "Mã SP");
            SetHeader("ProductName", "Tên SP");
            SetHeader("UnitPrice", "Đơn giá");
            SetHeader("Quantity", "Số lượng");
            SetHeader("Category", "Danh mục");

            if (dgvProducts.Columns["UnitPrice"] != null)
                dgvProducts.Columns["UnitPrice"].DefaultCellStyle.Format = "N0";
        }

        private void SetHeader(string tenCot, string tieuDe)
        {
            if (dgvProducts.Columns[tenCot] != null)
                dgvProducts.Columns[tenCot].HeaderText = tieuDe;
        }

        private Product LayDangChon()
        {
            if (dgvProducts.CurrentRow == null) return null;
            return dgvProducts.CurrentRow.DataBoundItem as Product;
        }

        // Kiểm tra dữ liệu nhập; excludeProduct dùng khi Sửa (bỏ qua chính nó khi kiểm tra trùng mã)
        private bool KiemTraNhap(Product excludeProduct)
        {
            string id = txtId.Text.Trim();
            if (id == "")
            {
                MessageBox.Show("Mã SP không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtId.Focus();
                return false;
            }
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Tên SP không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }
            bool trung = dsSanPham.Any(p => p != excludeProduct &&
                string.Equals(p.ProductId, id, StringComparison.OrdinalIgnoreCase));
            if (trung)
            {
                MessageBox.Show("Mã SP đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtId.Focus();
                return false;
            }
            return true;
        }

        private void XoaONhap()
        {
            txtId.Clear();
            txtName.Clear();
            numPrice.Value = 0;
            numQty.Value = 0;
            cboCategory.SelectedIndex = 0;
            txtId.Focus();
        }

        // Nút Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhap(null)) return;

            Product sp = new Product(
                txtId.Text.Trim(),
                txtName.Text.Trim(),
                numPrice.Value,
                (int)numQty.Value,
                cboCategory.Text);

            dsSanPham.Add(sp);
            LamMoiLuoi();
            XoaONhap();
        }

        // Nút Sửa: cập nhật sản phẩm đang chọn trên lưới
        private void btnSua_Click(object sender, EventArgs e)
        {
            Product sp = LayDangChon();
            if (sp == null)
            {
                MessageBox.Show("Hãy chọn một dòng cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!KiemTraNhap(sp)) return;

            sp.ProductId = txtId.Text.Trim();
            sp.ProductName = txtName.Text.Trim();
            sp.UnitPrice = numPrice.Value;
            sp.Quantity = (int)numQty.Value;
            sp.Category = cboCategory.Text;

            LamMoiLuoi();
            XoaONhap();
        }

        // Nút Xóa: xác nhận bằng MessageBox
        private void btnXoa_Click(object sender, EventArgs e)
        {
            Product sp = LayDangChon();
            if (sp == null)
            {
                MessageBox.Show("Hãy chọn một dòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult kq = MessageBox.Show(
                "Bạn có chắc muốn xóa sản phẩm \"" + sp.ProductName + "\"?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                dsSanPham.Remove(sp);
                LamMoiLuoi();
                XoaONhap();
            }
        }

        // Nút Tìm kiếm theo Tên SP
        private void btnTim_Click(object sender, EventArgs e)
        {
            LamMoiLuoi();
        }

        // Hiện lại toàn bộ danh sách
        private void btnTatCa_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LamMoiLuoi();
        }

        // Click vào dòng -> đẩy dữ liệu lên các ô nhập
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Product sp = dgvProducts.Rows[e.RowIndex].DataBoundItem as Product;
            if (sp == null) return;

            txtId.Text = sp.ProductId;
            txtName.Text = sp.ProductName;
            numPrice.Value = sp.UnitPrice;
            numQty.Value = sp.Quantity;
            cboCategory.Text = sp.Category;
        }
    }
}
