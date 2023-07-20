using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int donvi = 5;
            for(int i =1; i <= 10; i+= 2) 
            {
                int product = donvi * i; 
                Console.WriteLine(donvi + " x " + i + " = " + product );
            }
            Console.ReadKey();
        }
    }
}
