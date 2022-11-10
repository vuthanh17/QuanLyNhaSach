using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach
{
    class Lib
    {
    }
    public class NhaXuatBan
    {
        public int id { get; set; }
        public string tenNXB { get; set; }
    }
    public class TheLoai
    {
        public int id { get; set; }
        public string tentheloai { get; set; }
    }
    public class Sach
    {
        public int id { get; set; }
        public string tensach { get; set; }
        public string tacgia { get; set; }
        public string theloai { get; set; }
        public string nhaxuatban { get; set; }
        public int soluongton { get; set; }
        public int giaban { get; set; }
    }
    public class NhanVien
    {
        public int id { get; set; }
        public string hoten { get; set; }
        public string gioitinh { get; set; }
        public int namsinh { get; set; }
        public int luong { get; set; }
        public string sdt { get; set; }
    }
    public class DoDungHocTap
    {
        public int id { get; set; }
        public string tensanpham { get; set; }
        public int soluongton { get; set; }
        public int giaban { get; set; }
    }
    public class Ban
    {
        public int id { get; set; }
        public string tensanpham { get; set; }
        public DateTime ngaylap { get; set; }
        public int soluong { get; set; }
        public int dongia { get; set; }
    }
    public class Nhap
    {
        public int id { get; set; }
        public string tensanpham { get; set; }
        public DateTime ngaylap { get; set; }
        public int soluong { get; set; }
        public int dongia { get; set; }
    }
}
