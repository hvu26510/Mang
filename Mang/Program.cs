using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang
{
    internal class Program
    {
        static void Main(string[] args)
        {
           


            int[] intArray3 = { 5, 9, 6, 1, 5 };

            // foreach lặp qua từng phần tử (i là phần tử)
            foreach (int i in intArray3)
            {
                Console.WriteLine(i);
            }

            // for: i là vị trí phần tử
            for (int i = 0; i < intArray3.Length; i++)
            {
                Console.WriteLine(intArray3[i]);
            }


            Console.ReadLine();

            #region
            //ghi phan tu
            //Console.WriteLine("Gia tri truoc thay doi: " + intArray3[0]);

            //intArray3[0] = 6; // gan gia tri cho phan tu

            //Console.WriteLine("Gia tri sau thay doi: " + intArray3[0]);


            //doc phan tu
            //Console.WriteLine("Phan tu so:");
            //int i = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Phan tu so {i} mang gia tri: {intArray3[i-1]}");
            #endregion






        }
    }
}
