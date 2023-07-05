using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dem_sai = 3;

            if (dem_sai > 0) Console.WriteLine(">0");
            else Console.WriteLine("<0");
            //toan tu 3 ngoi
            string s = (dem_sai > 0) ? ">0" : "<0";
            Console.WriteLine(s);
        nhap_dob:
            Console.Write("Nhap ngay sinh cua ban: ");
            string input = Console.ReadLine();

            DateTime dob;       //ngày sn bản thân
            //if (DateTime.TryParse(input, out dob) == false) {
            if (!DateTime.TryParse(input, out dob))
            {
                Console.WriteLine("Du lieu bi sau!");
                dem_sai--;
                if (dem_sai > 0) goto nhap_dob;
                else
                {
                    Console.WriteLine("Het luot nhap lai!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }

            DateTime dob_year = new DateTime(DateTime.Now.Year, dob.Month, dob.Day); //ngày sn trong năm
            if (dob_year > DateTime.Now)
                Console.WriteLine("Ngay sinh nhat sap toi, con " + (dob_year - DateTime.Now).TotalDays);
            else if (dob_year == DateTime.Now.Date)
                Console.WriteLine("Chuc mung sinh nhat ban!");
            else
            {
                dob_year = dob_year.AddYears(1); //do đã qua ngày sn, nên tính năm tiếp theo
                Console.WriteLine("Ngay sinh nhat sap toi, con " + (dob_year - DateTime.Now).TotalDays);
            }
            Console.ReadKey();
        }
    }
}
