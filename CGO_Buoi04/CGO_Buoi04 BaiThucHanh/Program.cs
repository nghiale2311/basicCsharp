using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi04_BaiThucHanh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0;i < n; i++)
            {
                Console.Write(" Gia tri thu {0}= ",i);
                a[i] = int.Parse(Console.ReadLine()) ;
            }
            foreach (int item in a)
                console.Write(item+" ");
            Console.ReadKey();
        }
    }
}
