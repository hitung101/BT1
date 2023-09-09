using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTongCacChuSo
{
    class Program
    {
        public static int CalculateDigitSum(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }
            return sum;
        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập một số nguyên:");
            int number = Convert.ToInt32(Console.ReadLine());

            int digitSum = CalculateDigitSum(number);
            Console.WriteLine("Tổng các chữ số của số nguyên đã nhập là: " + digitSum);
            Console.ReadLine();
        }
    }
}
//Trong ví dụ trên, chúng ta sử dụng hàm CalculateDigitSum để tính tổng các chữ số của một số nguyên.
//Hàm này sử dụng một vòng lặp while để lấy từng chữ số cuối cùng của số và cộng vào biến sum.
//Sau đó, chúng ta chia số cho 10 để loại bỏ chữ số cuối cùng và tiếp tục vòng lặp cho đến khi số trở thành 0.


//Trong hàm Main, chúng ta yêu cầu người dùng nhập một số nguyên,
//sau đó tính tổng các chữ số của số đó bằng cách gọi hàm CalculateDigitSum và hiển thị kết quả.