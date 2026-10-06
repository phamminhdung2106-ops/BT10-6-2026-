using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace Bai5_4
{
    public partial class Form1 : Form
    {
        // Chỉ số icon trong ImageList
        private const int ICON_CONGTY = 0;
        private const int ICON_PHONG = 1;
        private const int ICON_NHOM = 2;
        private const int ICON_NHANVIEN = 3;

        private readonly List<NhanVien> dsNhanVien = new List<NhanVien>();

        public Form1()
        {
            InitializeComponent();
            TaoIcon(imgSmall, 16);
            TaoIcon(imgLarge, 32);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NapDuLieuMau();
            XayDungCay();
            cboView.SelectedIndex = 0;                 // Details
            tvDepartments.SelectedNode = tvDepartments.Nodes[0];
        }

        // ---------- Dữ liệu mẫu ----------
        private void NapDuLieuMau()
        {
            dsNhanVien.Add(new NhanVien("NV001", "Nguyễn Văn An", "Trưởng nhóm", new DateTime(2019, 3, 15), "Kỹ thuật", "Backend"));
            dsNhanVien.Add(new NhanVien("NV002", "Trần Thị Bình", "Lập trình viên", new DateTime(2021, 7, 1), "Kỹ thuật", "Backend"));
            dsNhanVien.Add(new NhanVien("NV003", "Lê Minh Cường", "Lập trình viên", new DateTime(2022, 1, 10), "Kỹ thuật", "Frontend"));
            dsNhanVien.Add(new NhanVien("NV004", "Phạm Thu Hà", "Trưởng nhóm", new DateTime(2020, 5, 20), "Kỹ thuật", "Frontend"));
            dsNhanVien.Add(new NhanVien("NV005", "Hoàng Quốc Dũng", "Trưởng phòng", new DateTime(2018, 9, 1), "Kinh doanh", "Miền Bắc"));
            dsNhanVien.Add(new NhanVien("NV006", "Vũ Thị Lan", "NV kinh doanh", new DateTime(2022, 11, 12), "Kinh doanh", "Miền Bắc"));
            dsNhanVien.Add(new NhanVien("NV007", "Đặng Văn Khoa", "NV kinh doanh", new DateTime(2023, 2, 6), "Kinh doanh", "Miền Nam"));
            dsNhanVien.Add(new NhanVien("NV008", "Bùi Thanh Mai", "Trưởng phòng", new DateTime(2017, 4, 18), "Nhân sự", "Tuyển dụng"));
            dsNhanVien.Add(new NhanVien("NV009", "Ngô Đức Long", "Chuyên viên", new DateTime(2021, 10, 25), "Nhân sự", "Tuyển dụng"));
        }

        // ---------- Xây dựng cây Công ty -> Phòng ban -> Nhóm ----------
        private void XayDungCay()
        {
            tvDepartments.Nodes.Clear();

            TreeNode congTy = new TreeNode("Công ty ABC", ICON_CONGTY, ICON_CONGTY);
            tvDepartments.Nodes.Add(congTy);

            ThemPhong(congTy, "Kỹ thuật", "Backend", "Frontend");
            ThemPhong(congTy, "Kinh doanh", "Miền Bắc", "Miền Nam");
            ThemPhong(congTy, "Nhân sự", "Tuyển dụng");

            congTy.ExpandAll();
        }

        // Tag của node = tên phòng / tên nhóm dùng để lọc
        private void ThemPhong(TreeNode congTy, string tenPhong, params string[] cacNhom)
        {
            TreeNode nodePhong = new TreeNode("Phòng " + tenPhong, ICON_PHONG, ICON_PHONG);
            nodePhong.Tag = tenPhong;
            congTy.Nodes.Add(nodePhong);

            foreach (string nhom in cacNhom)
            {
                TreeNode nodeNhom = new TreeNode("Nhóm " + nhom, ICON_NHOM, ICON_NHOM);
                nodeNhom.Tag = nhom;
                nodePhong.Nodes.Add(nodeNhom);
            }
        }

        // ---------- Chọn node -> lọc nhân viên ----------
        private void tvDepartments_AfterSelect(object sender, TreeViewEventArgs e)
        {
            IEnumerable<NhanVien> ketQua;

            switch (e.Node.Level)
            {
                case 0:  // Công ty: tất cả
                    ketQua = dsNhanVien;
                    break;
                case 1:  // Phòng ban
                    ketQua = dsNhanVien.Where(nv => nv.Phong == (string)e.Node.Tag);
                    break;
                default: // Nhóm
                    ketQua = dsNhanVien.Where(nv => nv.Nhom == (string)e.Node.Tag);
                    break;
            }

            NapListView(ketQua);
        }

        private void NapListView(IEnumerable<NhanVien> ds)
        {
            lsvEmployees.BeginUpdate();
            lsvEmployees.Items.Clear();

            foreach (NhanVien nv in ds)
            {
                ListViewItem item = new ListViewItem(nv.Ma, ICON_NHANVIEN);
                item.SubItems.Add(nv.HoTen);
                item.SubItems.Add(nv.ChucVu);
                item.SubItems.Add(nv.NgayVao.ToString("dd/MM/yyyy"));
                lsvEmployees.Items.Add(item);
            }

            lsvEmployees.EndUpdate();
        }

        // ---------- Đổi chế độ xem ----------
        private void cboView_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsvEmployees.View = (View)Enum.Parse(typeof(View), cboView.Text);
        }

        // ---------- Tự vẽ icon để không cần file ảnh ----------
        private void TaoIcon(ImageList il, int s)
        {
            Color[] mau = { Color.SteelBlue, Color.DarkOrange, Color.SeaGreen, Color.SlateGray };
            int m = s / 8;

            for (int i = 0; i < mau.Length; i++)
            {
                Bitmap bmp = new Bitmap(s, s);
                using (Graphics g = Graphics.FromImage(bmp))
                using (Brush b = new SolidBrush(mau[i]))
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.Clear(Color.Transparent);

                    switch (i)
                    {
                        case ICON_CONGTY:      // tòa nhà
                            g.FillRectangle(b, m * 2, m, s - 4 * m, s - 2 * m);
                            break;
                        case ICON_PHONG:       // thư mục
                            g.FillRectangle(b, m, m * 2, s / 2, s / 4);
                            g.FillRectangle(b, m, s / 3, s - 2 * m, s / 2);
                            break;
                        case ICON_NHOM:        // hình tròn
                            g.FillEllipse(b, m, m, s - 2 * m, s - 2 * m);
                            break;
                        case ICON_NHANVIEN:    // người
                            g.FillEllipse(b, s / 3, m, s / 3, s / 3);
                            g.FillEllipse(b, m * 2, s / 2, s - 4 * m, s / 2 - m);
                            break;
                    }
                }
                il.Images.Add(bmp);
            }
        }
    }
}
