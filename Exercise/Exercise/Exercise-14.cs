using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Exercise_14
    {
        public void main() {
            int temp;

            Console.WriteLine("Enter the amount of celsius: ");
            temp = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kelvin: {0} ", temp+273);
            Console.WriteLine("Fahrenheit: {0} ", temp*18/10+32);
        }
    }
}
