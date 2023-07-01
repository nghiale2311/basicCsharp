using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi01_DoiTienTe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int tigia = 23000;
            Console.WriteLine("Mời bạn nhập số USD: ");
            string input = Console.ReadLine();
            int dola = int.Parse(input);
            Console.WriteLine("Số tiền VND của bạn là " + dola*tigia);
            Console.ReadKey();
        }
    }
}
