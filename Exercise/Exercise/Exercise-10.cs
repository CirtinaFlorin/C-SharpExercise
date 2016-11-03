using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Exercise_10
    {
        public void main() {
            int x, y, z, result, secresult;

            Console.WriteLine("Enter the first number");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            z = Convert.ToInt32(Console.ReadLine());

            result = (x + y) * z;
            secresult = x * y + x * z;
            Console.WriteLine("Result of specified number {0},{1},{2}, (X+y)*z is: {3} and x*y+x*z is {4}",x,y,z, result, secresult);
        }
    }
}
