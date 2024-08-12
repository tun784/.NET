using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1_12_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int o;
            Console.Write("Chon bai: ");
            o = int.Parse(Console.ReadLine());
            switch (o)
            {
                case 1:
                    {
                        MatHang mh = new MatHang();
                        mh.Nhap();
                        mh.Xuat();
                    }break;
                case 2:
                    {
                        TienDien td = new TienDien();
                        td.Nhap();
                        td.Xuat();
                    }break;
                case 3:
                    {
                        BangCuuChuong b = new BangCuuChuong();
                        Console.WriteLine("Viet chuong trinh in bang cuu chuong tu 1 den 9 theo hang doc.");
                        b.HangDoc();
                    }break;
                case 4:
                    {
                        BangCuuChuong b = new BangCuuChuong();
                        Console.WriteLine("Viet chuong trinh in bang cuu chuong tu 1 den 9 theo hang ngang.");
                        b.HangNgang();
                    }break;
                case 5:
                    {
                        HinhChuNhat hcn = new HinhChuNhat();
                        hcn.Nhap();
                        hcn.VeRong();
                    }break;
                case 6:
                    {
                         HinhChuNhat hcn = new HinhChuNhat();
                        hcn.Nhap();
                        hcn.VeDac();
                    }break;
                default: Environment.Exit(0); break;
            }
            Console.ReadLine();
        }
    }
}
