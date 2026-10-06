using System;

namespace Bai5_4
{
    public class NhanVien
    {
        public string Ma { get; set; }
        public string HoTen { get; set; }
        public string ChucVu { get; set; }
        public DateTime NgayVao { get; set; }
        public string Phong { get; set; }
        public string Nhom { get; set; }

        public NhanVien(string ma, string hoTen, string chucVu, DateTime ngayVao, string phong, string nhom)
        {
            Ma = ma; HoTen = hoTen; ChucVu = chucVu; NgayVao = ngayVao; Phong = phong; Nhom = nhom;
        }
    }
}
