using System;
using System.Windows.Forms;

namespace Bai5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpNgaySinh.MaxDate = DateTime.Today;   // không cho chọn ngày tương lai
            AcceptButton = btnDangKy;               // Enter = Đăng Ký
        }

        // Tính tuổi chính xác từ ngày sinh
        private int TinhTuoi(DateTime ngaySinh)
        {
            DateTime today = DateTime.Today;
            int tuoi = today.Year - ngaySinh.Year;
            if (ngaySinh.Date > today.AddYears(-tuoi))
                tuoi--;
            return tuoi;
        }

        // Kiểm tra dữ liệu, trả về true nếu hợp lệ
        private bool KiemTraHopLe()
        {
            bool hopLe = true;
            epCheck.Clear();

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                epCheck.SetError(txtUsername, "Tên đăng nhập không được để trống!");
                hopLe = false;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                epCheck.SetError(txtPassword, "Mật khẩu không được để trống!");
                hopLe = false;
            }

            if (txtConfirm.Text != txtPassword.Text)
            {
                epCheck.SetError(txtConfirm, "Mật khẩu nhập lại không khớp!");
                hopLe = false;
            }

            if (TinhTuoi(dtpNgaySinh.Value) < 18)
            {
                epCheck.SetError(dtpNgaySinh, "Bạn phải từ 18 tuổi trở lên!");
                hopLe = false;
            }

            if (!chkDieuKhoan.Checked)
            {
                epCheck.SetError(chkDieuKhoan, "Bạn phải đồng ý điều khoản dịch vụ!");
                hopLe = false;
            }

            return hopLe;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe()) return;

            string gioiTinh = rdoNam.Checked ? "Nam" : "Nữ";
            MessageBox.Show(
                "Đăng ký thành công!\n\n" +
                "Tên đăng nhập: " + txtUsername.Text + "\n" +
                "Ngày sinh: " + dtpNgaySinh.Value.ToString("dd/MM/yyyy") + "\n" +
                "Giới tính: " + gioiTinh,
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirm.Clear();
            dtpNgaySinh.Value = DateTime.Today;
            rdoNam.Checked = true;
            chkDieuKhoan.Checked = false;
            epCheck.Clear();
            txtUsername.Focus();
        }
    }
}
