using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoChinhPhuong
{
    class Program
    {
        public static bool IsPerfectSquare(int number)
        {
            int sqrt = (int)Math.Sqrt(number);
            return (sqrt * sqrt == number);
        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số cần kiểm tra:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (IsPerfectSquare(number))
            {
                Console.WriteLine("Đây là số chính phương.");
            }
            else
            {
                Console.WriteLine("Đây không phải là số chính phương.");
            }
            Console.ReadKey();

        }
    }
}
