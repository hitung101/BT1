using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoHoanHao
{
    class Program
    {
        public static bool IsPerfectNumber(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            return (sum == number);
        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số cần kiểm tra:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (IsPerfectNumber(number))
            {
                Console.WriteLine("Đây là số hoàn hảo.");
            }
            else
            {
                Console.WriteLine("Đây không phải là số hoàn hảo.");
            }
            Console.ReadKey();
        }
    }
}

