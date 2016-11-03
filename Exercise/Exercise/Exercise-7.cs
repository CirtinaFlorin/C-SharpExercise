using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Exercise_7
    {
        public void main() {
            int nr1, nr2;
            Console.WriteLine("Input the first number: ");
            nr1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number: ");
            nr2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}+{1}={2}", nr1, nr2, nr1 + nr2);
            Console.WriteLine("{0}-{1}={2}", nr1, nr2, nr1 - nr2);
            Console.WriteLine("{0}*{1}={2}", nr1, nr2, nr1 * nr2);
            Console.WriteLine("{0}/{1}={2}", nr1, nr2, nr1 / nr2);
            Console.WriteLine("{0} mod {1}={2}", nr1, nr2, nr1 % nr2);
        }
    }
}
