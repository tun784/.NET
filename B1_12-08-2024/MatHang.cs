using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1_12_08
{
    class MatHang
    {
        private int soluong;
        public int Soluong
        {
          get { return soluong; }
          set { soluong = value; }
        }
        private double dongia;
        public double Dongia
        {
          get { return dongia; }
          set { dongia = value; }
        }
        public MatHang(){
            soluong = 0;
            dongia = 0.0;
        }
        public MatHang(int sl, double dg){
            soluong = sl;
            dongia = dg;
        }
        public double ThanhTien()
        {
            return dongia * soluong;
        }
        public double GiamGia()
        {
            var tt = ThanhTien();
            return (tt > 100) ? 0.03 * tt : 0;
        }
        public double TongTien()
        {
            return ThanhTien() - GiamGia();
        }
        public void Nhap()
        {
            Console.Write("Vui long nhap so luong san pham: ");
            try
            {
                Soluong = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Write("So ban da nhap phai la so nguyen.");
                return;
            }
            Console.Write("Vui long nhap don gia san pham: ");
            try
            {
                Dongia = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Write("So ban da nhap phai la so thuc.");
                return;
            }
        }
        public void Xuat()
        {
            Console.WriteLine("So luong san pham: {0} san pham", Soluong);
            Console.WriteLine("Don gia san pham: {0} 000 dong", Dongia);
            Console.WriteLine("Thanh tien: {0} 000 dong", ThanhTien());
            Console.WriteLine("Giam gia: {0} 000 dong", GiamGia());
            Console.WriteLine("Tong tien phai tra: {0} 000 dong", TongTien());
        }
    }
}
