using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Exercise_12
    {
        public void main() {
            int number;

            Console.WriteLine("Enter a digit: ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(number + " " + number + " " + number + " " + number);
            Console.WriteLine(number + "" + number + "" + number + "" + number);

            Console.WriteLine("{0}{0}{0}{0}", number);
            Console.WriteLine("{0} {0} {0} {0}", number);

           
            
        }
    }
}
