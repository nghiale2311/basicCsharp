using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi04_Timgiatri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int find = 5;
            bool flag = false;
            for (int i=0; i < a.Length; i++)
            {
                if(a[i] == find)
                {
                    flag = true;
                    Console.WriteLine("Tim thay tai thu {0}", i);
                }
            }
            if (flag == false) Console.WriteLine("Ko tim thay");
        }
    }
}
