using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tong = 0;
            int[] mangInt = new int[5];

            // Nhập mảng
            for (int i = 0; i < mangInt.Length; i++)
            {
                Console.WriteLine($"Nhap phan tu so {i + 1}");
                mangInt[i] = int.Parse(Console.ReadLine());
            }

            //tính tổng
            foreach (int x in mangInt)
            {
                tong = tong + x;
            }
            double tbc = tong * 1.0 / mangInt.Length;
            Console.WriteLine($"TBC = {tbc}");

            //Tính lâp phương các phần tử
            foreach (int x in mangInt)
            {
                Console.WriteLine(Math.Pow(x, 3));
            }

            Console.ReadLine();
        }
    }
}
