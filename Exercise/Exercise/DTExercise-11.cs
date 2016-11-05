using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class DTExercise_11
    {
        public void main() {
            string nr;
            string result;

            Console.WriteLine("Number to be convert: ");
            nr = Console.ReadLine();

            int num = Convert.ToInt32(nr);
            result = "";

            while (num > 1) {
                int remainder = num % 2;
                result = Convert.ToString(remainder) + result;
                num /= 2;
            }

            result = Convert.ToString(num) + result;
            Console.WriteLine("Binary: {0}", result);
        }
    }
}
