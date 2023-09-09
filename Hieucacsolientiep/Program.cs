using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hieucacsolientiep
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số bắt đầu lớn hơn số kết thúc: ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhập số kết thúc: ");
            int end = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            if (start <= end)
            {
                for (int i = start; i <= end; i++)
                {
                    sum += i;
                }
            }
            else
            {
                for (int i = start; i >= end; i--)
                {
                    sum -= i;
                }
            }

            Console.WriteLine($"Hiệu của các số liên tiếp từ {start} đến {end} là: {sum}");
            Console.ReadKey();
        }
    }

}

