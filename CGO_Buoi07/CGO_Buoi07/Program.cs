using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi07
{
    internal class Program
    {
        private void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            SapXep();
            stopWatch.Stop();

            Console.WriteLine("Tong thoi gian sap xep: {0}", stopWatch.GetElapsedTime());
            Console.ReadKey();
        }
        private static void SapXep()
        {

        }
    }
}
