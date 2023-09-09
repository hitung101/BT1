using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giaithua
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số nguyên dương n: ");
            int n = int.Parse(Console.ReadLine());

            int giaiThua = TinhGiaiThua(n);

            Console.WriteLine("Giai thừa của {0} là {1}", n, giaiThua);

            Console.ReadKey();
        }

        static int TinhGiaiThua(int n)
        {
            int giaiThua = 1;

            for (int i = 1; i <= n; i++)
            {
                giaiThua *= i;
            }

            return giaiThua;
        }
    }
}
