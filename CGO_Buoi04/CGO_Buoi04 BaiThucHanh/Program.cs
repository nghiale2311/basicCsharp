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
            //
            //Console.Write("Nhap so luong phan tu: ");
           // int n = int.Parse(Console.ReadLine());
           // int[] a = new int[n];
            //for (int i = 0;i < n; i++)
           // {
             //   Console.Write(" Gia tri thu {0}= ",i);
            //    a[i] = int.Parse(Console.ReadLine()) ;
          //  }
           // int tong = 0;
           // foreach (int item in a)
           // {
             //   tong += item;
              //  Console.Write(item + " ");
          //  }
            //Console.WriteLine("\n Tong cac so la "+ tong);    
           // Console.ReadKey();
            // Su dung list
            List<int> lstInput = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write(" Gia tri thu {0}= ", i);
                lstInput.Add(int.Parse(Console.ReadLine())) ;
            }
            Console.WriteLine(string.Join("|", lstInput));
            Console.WriteLine("\n Tong cac so la " + lstInput.Sum()) ;
            Console.ReadKey();
        }
    }
}
