using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[3];
            int[] arr2 = new int[3] { 7, 3, 1 };
            int[] arr3 = new int[] { 7, 3, 1 };
            int[] arr4 =  { 7, 3, 1, 4 };
            Console.WriteLine("{0} | {1} | {2} | {3} ", arr1[0], arr2[0], arr3[0], arr4[0]);
            Console.WriteLine("{0} | {1} | {2} | {3} ", arr1[3], arr2[3], arr3[3], arr4[3]);
            Console.ReadKey();
        }
    }
}
