using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace B2_19_08_2024
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bai 1. Mang mot chieu");
            Console.WriteLine("Cho mang 1 chieu chua cac so nguyen. Viet phuong thuc thuc hien:");
            Console.WriteLine("Nhap mang a gom n phan tu. Xuat mang a.");
            Console.WriteLine("Liet ke cac phan tu le o vi tri chan.");
            Console.WriteLine("Liet ke cac so nguyen to trong mang.");
            Console.WriteLine("Tim phan tu am dau tien trong mang.");
            Console.WriteLine("Tim max, min cua day.");
            Console.WriteLine("Tinh tong cac phan tu trong mang.\n");            
            Console.WriteLine("Bai 2. Mang hai chieu");
            Console.WriteLine("Cho mot ma tran nguyen kich thuoc m*n. Viet phuong thuc thuc hien:");
            Console.WriteLine("Nhap cac gia tri cho mang 2 chieu, sau do xuat mang vua nhap.");
            Console.WriteLine("Tong tat ca cac phan tu duong cua ma tran.");
            Console.WriteLine("Tong cac phan tu tren duong cheo chinh.");
            Console.WriteLine("Tong cac phan tu trong tam giac tren.");
            Console.WriteLine("Tong tat ca cac phan tu chan cua ma tran.");
            Console.WriteLine("Tinh tong cac phan tu o dong thu i.\n");
            Console.WriteLine("Bai 3. Nhap chuoi s (la ho ten). Viet phuong thuc thuc hien cac yeu cau sau:");
            Console.WriteLine("S co phai la chuoi doi xung khong?");
            Console.WriteLine("Doi ky tu dau tu thanh chu hoa");
            Console.WriteLine("Doi ky tu thuong thanh chuoi hoa va nguoc lai");
            Console.WriteLine("Co bao nhieu nguyen am, phu am, khoang trang trong chuoi s.\n");
            
            Console.Write("Hay chon mot bai: ");
            int o = int.Parse(Console.ReadLine());
            switch (o)
            {
                case 1:
                    Mang1Chieu();
                    break;
                default:
                    break;
            }

            Console.ReadLine();
        }
        static int[] NhapMang(int[] A, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Moi nhap phan tu A[{0}]= ", i);
                A[i] = int.Parse(Console.ReadLine());
            }
            return A;
        }
        static int[] NhapFile(int[] A,string path)
        {
            int i = 0;
            XmlDocument read = new XmlDocument();
            read.Load(path);
            XmlNodeList nodes = read.SelectNodes("/Mang/PhanTu");
            foreach (XmlNode node in nodes)
            {
                if (i >= A.Length) break;
                A[i] = Convert.ToInt32(node.InnerText);
                i++;
            }
            return A;
        }
        static void XuatMang(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("{0} ", A[i]);
            }
            Console.WriteLine("\n");
        }
        static void Mang1Chieu()
        {
            int[] A;
            string file = "..//..//Mang1chieu.xml";
            Console.Write("Moi nhap nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());
            A = new int[n];
            //A = NhapMang(A, n);
            A = NhapFile(A, file);
            Console.WriteLine("Xuat mang sau khi nhap xong: ");
            XuatMang(A);
            Console.WriteLine("\nLiet ke cac phan tu le o vi tri chan.");
            PhanTuLeViTriChan(A);
            Console.WriteLine("\nLiet ke cac so nguyen to trong mang.");
            SoNguyenTo(A);
        }
        static void SapXepTangDan(int[] A)
        {
            Array.Sort(A);
        }
        static void SapXepGiamDan(int[] A)
        {
            Array.Sort(A);
            Array.Reverse(A);
        }
        static void PhanTuLeViTriChan(int[] A)
        {
            for (int i = 0; i < A.Length; i += 2)
            {
                if (A[i] % 2 != 0)
                    Console.WriteLine("Vi tri A[{0}]; Gia tri: {1}", i, A[i]);
            }
        }
        static void SoNguyenTo(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (KiemTraSNT(A[i]) == 1)
                    Console.WriteLine("Vi tri A[{0}]; Gia tri: {1}", i, A[i]);
            }
        }
        static int KiemTraSNT(int n)
        {
            if (n < 2)
                return 0;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return 0;                
            }
            return 1;
        }
    }
}
