using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1_12_08
{
    class BangCuuChuong
    {
        public BangCuuChuong()
        {

        }
        public void HangDoc()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
                }
                Console.WriteLine();
            }
        }
        public void HangNgang()
        {
            for (int i = 1; i <= 9; i++) // Duyệt qua các số nhân từ 1 đến 9
            {
                for (int j = 1; j <= 9; j++) // Duyệt qua các bảng từ 1 đến 9
                {
                    Console.Write("{0} x {1} = {2}\t", j, i, j * i); // In kết quả và giữ trên cùng một dòng
                }
                Console.WriteLine(); // Xuống dòng sau khi in hết một hàng của cửu chương
            }
        }
    }
}
