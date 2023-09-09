using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCNN
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

        // Hàm tính bội chung nhỏ nhất
        static int FindLCM(int a, int b)
        {
            int gcd = FindGCD(a, b);
            int lcm = (a * b) / gcd;
            return lcm;
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số thứ nhất: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhập số thứ hai: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int lcm = FindLCM(num1, num2);

            Console.WriteLine($"Bội chung nhỏ nhất của {num1} và {num2} là: {lcm}");
            Console.ReadKey();
        }
    }
}
