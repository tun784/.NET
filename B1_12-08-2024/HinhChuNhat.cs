using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1_12_08
{
    class HinhChuNhat
    {
        int chieuDai, chieuRong;
        public int r
        {
            get { return chieuRong; }
            set { chieuRong = value; }
        }
        public int d
        {
            get { return chieuDai; }
            set { chieuDai = value; }
        }
        public HinhChuNhat()
        {
            d = r = 0;
        }
        public HinhChuNhat(int d, int r)
        {
            chieuDai = d;
            chieuRong = r;
        }
        public void Nhap()
        {
            Console.Write("Nhap chieu dai: ");
            try
            {
                d = int.Parse(Console.ReadLine());
                if (d <= 0)
                {
                    throw new Exception("Chieu dai phai la so nguyen duong.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            Console.Write("Nhap chieu rong: ");
            try { 
                r = int.Parse(Console.ReadLine());
                if (r <= 0)
                {
                    throw new Exception("Chieu rong phai la so nguyen duong.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }
        public void VeDac()
        {
            for (int i = 0; i < chieuRong; i++) // Lặp qua từng hàng
            {
                for (int j = 0; j < chieuDai; j++) // Lặp qua từng cột
                {
                    Console.Write("*");
                }
                Console.WriteLine(); // Xuống dòng sau mỗi hàng
            }
        }
        public void VeRong()
        {
            // Vẽ dòng trên cùng
            for (int i = 0; i < chieuDai; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            // Vẽ các dòng giữa
            for (int i = 0; i < chieuRong - 2; i++)
            {
                Console.Write("*");
                for (int j = 0; j < chieuDai - 2; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }

            // Vẽ dòng dưới cùng (nếu chiều rộng lớn hơn 1)
            if (chieuRong > 1)
            {
                for (int i = 0; i < chieuDai; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
