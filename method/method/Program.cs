using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your score is " + Math());
            Console.ReadLine();
        }
        private static double Math ()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = x - y;
            return z;
        }
    }
}
