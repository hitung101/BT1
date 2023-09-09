using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktrasonguyenduong
{
    class Program
    {
        public static bool IsPositiveInteger(string input)
        {
            int number;
            bool isInteger = int.TryParse(input, out number);
            return (isInteger && number > 0);
        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập một số nguyên dương:");
            string input = Console.ReadLine();

            while (!IsPositiveInteger(input))
            {
                Console.WriteLine("Số nhập vào không hợp lệ. Vui lòng nhập lại:");
                input = Console.ReadLine();
            }

            int number = int.Parse(input);
            Console.WriteLine("Số nguyên dương đã nhập là: " + number);
            input = Console.ReadLine();
        }
    }
}
//Trong ví dụ trên, chúng ta sử dụng hàm IsPositiveInteger
//để kiểm tra xem một chuỗi nhập vào có phải là số nguyên dương hay không.
//Hàm này sử dụng int.TryParse để kiểm tra xem chuỗi có thể được chuyển đổi thành số nguyên hay không,
//và sau đó kiểm tra xem số đó có lớn hơn 0 hay không.

//Trong hàm Main, chúng ta sử dụng một vòng lặp để yêu cầu người dùng nhập lại nếu số không hợp lệ.
//Khi số hợp lệ được nhập vào, chúng ta chuyển đổi chuỗi thành số nguyên và hiển thị kết quả.