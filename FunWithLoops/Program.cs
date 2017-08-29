using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach loops
            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            foreach(string month in months)
            {
            //    Console.WriteLine(month);
            //    if(month == "Dec")
            //    {
            //        Console.WriteLine("Thats the best month");
            //    }
            //    else
            //    {
            //        Console.WriteLine("That month is ok I guess....");
            //    }

            }

            string[] musicians = { "U2", "Maroon 5", "Ed Sheeran", "Nas", "Jarryd" };
            foreach(string band in musicians)
            {
                Console.WriteLine(band);
            }
        }
    }
}
