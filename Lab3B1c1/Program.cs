using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3B1c1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("So phan tu cua mang:");
            int sopt = int.Parse(Console.ReadLine());

            int[] mangInts = new int[sopt];

            // Nhập mảng
            for (int i = 0; i < mangInts.Length; i++)
            {
                Console.WriteLine($"Nhap phan tu so {i + 1}");
                mangInts[i] = int.Parse(Console.ReadLine());
            }

            //Từ bé đến lớn
            Array.Sort(mangInts);
           
            Console.WriteLine("Tu nho den lon");
            foreach (int i in mangInts)
            {
                Console.WriteLine(i);
            }

            // Từ lớn đến bé
            Array.Reverse(mangInts);        

            Console.WriteLine("Tu lon den nho");
            foreach (int i in mangInts)
            {
                Console.WriteLine(i);
            }
            // Phần tử nhỏ nhất (Phần tủ cuối cùng sau khi săp xếp từ lơn đến bé
            Console.WriteLine($"Phan tu nho nhat:{mangInts[mangInts.Length-1]}");

            //tính TBC
            int tong = 0, count = 0;
            foreach (int i in mangInts)
            {
                if (i % 3 == 0)
                {
                    tong = tong + i;
                    count++;
                }
            }
            double tbc = tong * 1.0 / count;
            Console.WriteLine($"TBC = {tbc}");


            Console.ReadLine();


        }
    }
}
