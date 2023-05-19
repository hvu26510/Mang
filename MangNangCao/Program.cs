using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangNangCao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            Console.OutputEncoding = Encoding.UTF8;

            string[] mangStr = { "Hà Kỳ Anh", "Lê Đình Hoàng Anh", "Phạm Thị Phương Anh", "Trương Đức Anh", "Lê Văn Bắc" };

            //Array.Sort(mangStr);

            Array.Reverse(mangStr);
            foreach(string s in mangStr)
            {
                Console.WriteLine(s);
            }


            Console.ReadLine();

        }
    }
}
