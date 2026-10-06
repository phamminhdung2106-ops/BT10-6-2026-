using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Bai5_2
{
    public partial class Form1 : Form
    {
        // Dữ liệu mẫu: loại dịch vụ -> danh sách dịch vụ
        private readonly Dictionary<string, List<DichVu>> dsDichVu =
            new Dictionary<string, List<DichVu>>
            {
                { "Khám bệnh", new List<DichVu> {
                    new DichVu("Khám nội tổng quát", 150000),
                    new DichVu("Khám tai mũi họng", 180000),
                    new DichVu("Khám răng hàm mặt", 200000),
                    new DichVu("Khám mắt", 170000) } },
                { "Xét nghiệm", new List<DichVu> {
                    new DichVu("Xét nghiệm máu tổng quát", 250000),
                    new DichVu("Xét nghiệm đường huyết", 80000),
                    new DichVu("Xét nghiệm mỡ máu", 120000),
                    new DichVu("Xét nghiệm nước tiểu", 90000) } },
                { "Chụp X-Quang", new List<DichVu> {
                    new DichVu("X-Quang phổi", 220000),
                    new DichVu("X-Quang xương khớp", 260000),
                    new DichVu("X-Quang răng toàn cảnh", 300000) } },
                { "Vắc-xin", new List<DichVu> {
                    new DichVu("Vắc-xin cúm mùa", 350000),
                    new DichVu("Vắc-xin viêm gan B", 280000),
                    new DichVu("Vắc-xin uốn ván", 150000),
                    new DichVu("Vắc-xin HPV", 1800000) } }
            };

        // Mã giảm giá mẫu -> % chiết khấu
        private readonly Dictionary<string, int> dsMaGiamGia =
            new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
            {
                { "GIAM10", 10 },
                { "GIAM20", 20 },
                { "VIP50", 50 }
            };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboCategory.Items.AddRange(dsDichVu.Keys.ToArray());
            cboCategory.SelectedIndex = 0;   // kích hoạt SelectedIndexChanged
            TinhTien();
        }

        // 1. Đổi loại dịch vụ -> nạp danh sách tương ứng
        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstAvailableServices.Items.Clear();
            string loai = cboCategory.SelectedItem as string;
            if (loai == null) return;

            foreach (DichVu dv in dsDichVu[loai])
                lstAvailableServices.Items.Add(dv);
        }

        // 2. Chuyển dịch vụ sang danh sách đã chọn
        private void btnSelect_Click(object sender, EventArgs e)
        {
            foreach (object item in lstAvailableServices.SelectedItems.Cast<object>().ToList())
                lstSelectedServices.Items.Add(item);
            TinhTien();
        }

        private void lstAvailableServices_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lstAvailableServices.IndexFromPoint(e.Location);
            if (index == ListBox.NoMatches) return;

            lstSelectedServices.Items.Add(lstAvailableServices.Items[index]);
            TinhTien();
        }

        // Bỏ các dịch vụ đang chọn
        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (object item in lstSelectedServices.SelectedItems.Cast<object>().ToList())
                lstSelectedServices.Items.Remove(item);
            TinhTien();
        }

        private void lstSelectedServices_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lstSelectedServices.IndexFromPoint(e.Location);
            if (index == ListBox.NoMatches) return;

            lstSelectedServices.Items.RemoveAt(index);
            TinhTien();
        }

        // Xóa toàn bộ
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lstSelectedServices.Items.Clear();
            TinhTien();
        }

        private void numChietKhau_ValueChanged(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void btnApDung_Click(object sender, EventArgs e)
        {
            string ma = txtCoupon.Text.Trim();
            int phanTram;
            if (dsMaGiamGia.TryGetValue(ma, out phanTram))
            {
                numChietKhau.Value = phanTram;   // tự gọi TinhTien qua ValueChanged
                MessageBox.Show("Áp dụng mã thành công: giảm " + phanTram + "%",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Mã giảm giá không hợp lệ!\n(Thử: GIAM10, GIAM20, VIP50)",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 3. Tính lại tổng tiền mỗi khi danh sách / chiết khấu thay đổi
        private void TinhTien()
        {
            decimal tong = lstSelectedServices.Items.Cast<DichVu>().Sum(dv => dv.Gia);
            decimal thanhTien = tong * (100 - numChietKhau.Value) / 100;

            txtTong.Text = tong.ToString("N0") + " đ";
            txtThanhTien.Text = thanhTien.ToString("N0") + " đ";
        }
    }
}
