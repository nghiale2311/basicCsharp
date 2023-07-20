using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi03_SoNguyenTo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n = 917;
            bool flag = true; 
            if (n < 2) Console.WriteLine("{0} ko la SNT", n);
            else if (n < 4) Console.WriteLine("{0} la SNT", n);
            else
            {   
                if (n % 2 == 0) Console.WriteLine("{0} ko la SNT", n);
                else
                {
                    for (int i = 3; i <= Math.Sqrt(n); i += 2)
                    {
                        if (n % i == 0)
                        {
                            flag = false; break;
                        }
                    }
                    if (flag) Console.WriteLine("{0} la SNT", n);
                    else Console.WriteLine("{0} ko la SNT", n);
                }
            }


            Console.ReadKey();
        }
    }
}
