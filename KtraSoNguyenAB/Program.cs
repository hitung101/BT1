using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtraSoNguyenAB
{
    class Program
    {
        public static bool IsValidNumber(string input, int a, int b)
        {
            bool isValid = false;
            int number;

            if (int.TryParse(input, out number))
            {
                if (number > a && number < b)
                {
                    isValid = true;
                }
            }

            return isValid;
        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập một số nguyên trong khoảng (a, b):");
            int a = 0; // Giá trị a
            int b = 10; // Giá trị b

            string input = Console.ReadLine();

            while (!IsValidNumber(input, a, b))
            {
                Console.WriteLine("Số nhập vào không hợp lệ. Vui lòng nhập lại:");
                input = Console.ReadLine();
            }

            int number = int.Parse(input);
            Console.WriteLine("Số nguyên đã nhập trong khoảng (a, b) là: " + number);
            input = Console.ReadLine();
        }
    }
}
