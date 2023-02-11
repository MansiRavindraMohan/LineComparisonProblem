using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class LineLength
        
    {
        public static void LineofLength()
        {
            int val1;
            int val2;
            int val3;
            int val4;

            Console.WriteLine("Enter the start point");

            Console.WriteLine("Enter x1: ");
            val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1: ");
            val2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the end point");

            Console.WriteLine("Enter x2: ");
            val3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2: ");
            val4 = Convert.ToInt32(Console.ReadLine());

            double length = Math.Sqrt((val3 - val1) ^ 2 + (val4 - val2) ^ 2);
            Console.WriteLine("Length of line is:" + length);
        }

        
    }
}
