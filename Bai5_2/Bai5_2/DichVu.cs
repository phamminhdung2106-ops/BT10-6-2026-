namespace Bai5_2
{
    public class DichVu
    {
        public string Ten { get; set; }
        public decimal Gia { get; set; }

        public DichVu(string ten, decimal gia)
        {
            Ten = ten;
            Gia = gia;
        }

        // ListBox hiển thị kết quả của ToString()
        public override string ToString()
        {
            return Ten + " - " + Gia.ToString("N0") + " đ";
        }
    }
}
