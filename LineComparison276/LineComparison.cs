using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison276
{
    internal class LineComparison
    {
        public int x1, y1, x2, y2, x3, y3, x4, y4;
        public double length, length2;
        public void LineCompare()
        {
            Console.WriteLine("Enter the value of x1 and y1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value x2 and y2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x3 and y3");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x4 and y4");
            int x4 = Convert.ToInt32(Console.ReadLine());
            int y4 = Convert.ToInt32(Console.ReadLine());
        }
        public void LengthCalculate()
        {
            length = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            length2 = Math.Sqrt((x4 - x3) ^ 2 + (y4 - y3) ^ 2);
            Console.WriteLine("Length of line1 is:" + length);
            Console.WriteLine("Length of line2 is:" + length2);
        }
        public void Ifequals()
        {
            if (length.Equals(length2))
            {
                Console.WriteLine("Two lines are equal");
                if (length.CompareTo(length2) == 1)
                    Console.WriteLine("Length of line1 is greater than lin2");
            }
            else if (length.CompareTo(length2) == -1)
                Console.WriteLine("Length of line1 is less than line2");
            else
            {
                Console.WriteLine("Two lines are not Equal");
            }
            Console.WriteLine("Length of both Lines are equal");
            if (length.Equals(length2))
            {
                Console.WriteLine("Lines are equals");
            }
            else
            {
                Console.WriteLine("Lines are not Equal");
            }
        }
    }
}
