using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Exercise_9
    {
        public void main() {
            int nr1, nr2, nr3, nr4, result;
            Console.WriteLine("Enter the first number: ");
            nr1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            nr2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            nr3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the four number: ");
            nr4 = Convert.ToInt32(Console.ReadLine());

            result = (nr1 + nr2 + nr3 + nr4) / 4;
            Console.WriteLine("The average of {0},{1},{2},{3} is: {4}", nr1, nr2, nr3, nr4, result);
        }
    }
}
