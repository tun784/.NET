using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1_12_08
{
    class TienDien
    {
        int sodien;
        public int Sodien
        {
            get { return sodien; }
            set { sodien = value; }
        }

        // Corrected array declarations
        public static int[] DG = {5, 7, 10, 15, 20 }; // Đơn giá
        public static int[] Muc = { 100, 150, 200, 300 }; // Mức tiêu thụ

        public TienDien()
        {
            Sodien = 0;
        }

        public TienDien(int td)
        {
            Sodien = td;
        }

        public void Nhap()
        {
            Console.Write("Nhap so KW dien da tieu thu trong thang {0}: ", DateTime.Today.Month);
            try
            {
                Sodien = int.Parse(Console.ReadLine());

                if (Sodien <= 0)
                {
                    throw new Exception("So KW dien phai la so nguyen duong.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }

        public long TienDienPhaiTra()
        {
            //DG[5] =  {5,   7,   10,  15, 20}; // Đơn giá
            //Muc[4] = {100, 150, 200, 300}; // Mức tiêu thụ
            if (sodien <= Muc[0])
                return DG[0] * sodien;
            else if (sodien > Muc[0] && sodien <= Muc[1])
                return DG[0] * Muc[0] + DG[1] * (sodien - Muc[0]);
            else if (sodien > Muc[1] && sodien <= Muc[2])
                return DG[0] * Muc[0] + DG[1] * (Muc[1] - Muc[0]) + DG[2] * (sodien - Muc[1]);
            else if (sodien > Muc[2] && sodien <= Muc[3])
                return DG[0] * Muc[0] + DG[1] * (Muc[1] - Muc[0]) + DG[2] * (Muc[2] - Muc[1]) + DG[3] * (sodien - Muc[2]);
            else
                return DG[0] * Muc[0] + DG[1] * (Muc[1] - Muc[0]) + DG[2] * (Muc[2] - Muc[1]) + DG[3] * (Muc[3] - Muc[2]) + DG[4] * (sodien - Muc[3]);
        }

        public void Xuat()
        {
            Console.WriteLine("So KW dien da tieu thu: {0}KW", sodien);
            Console.WriteLine("Tien dien phai tra: ${0}", TienDienPhaiTra());
        }
    }
}

