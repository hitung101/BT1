using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int num;
            bool isPrime = true;

            Console.Write("Nhập một số nguyên dương: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 2; i <= num / 2; i++) 
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine("{0} là số nguyên tố", num);
            }
            else
            {
                Console.WriteLine("{0} không phải là số nguyên tố", num);
            }

            Console.ReadKey();
        }
    }
    
}
