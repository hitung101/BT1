using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCLN
{
    class Program
    {
        static int FindGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số thứ nhất: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhập số thứ hai: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int gcd = FindGCD(num1, num2);

            Console.WriteLine($"Ước chung lớn nhất của {num1} và {num2} là: {gcd}");
            Console.ReadKey();
        }

    }
}
