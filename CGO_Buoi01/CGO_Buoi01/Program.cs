//Ghi chu: using thư viện sài. Nếu chữ xám thư viện chưa sài 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;








namespace CGO_Buoi01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Mời bạn nhập tên: ");
            string sHoTen = Console.ReadLine();
            Console.WriteLine("Tên của bạn là " + sHoTen );
            Console.ReadKey(); 
        }
    }
}
