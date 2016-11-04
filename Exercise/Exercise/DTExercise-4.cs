using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class DTExercise_4
    {
        public void main() {
            int nr1, nr2;
            char operation;

            Console.WriteLine("Input first number: ");
            nr1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input operation: ");
            operation = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Input second number: ");
            nr2 = Convert.ToInt32(Console.ReadLine());

            if (operation == '+')
                Console.WriteLine("{0}+{1}={2}", nr1,nr2, nr1+nr2);
            else if (operation == '-')
                Console.WriteLine("{0}-{1}={2}", nr1, nr2, nr1 - nr2);
            else if (operation == '*')
                Console.WriteLine("{0}X{1}={2}", nr1, nr2, nr1 * nr2);
            else if (operation == '/')
                Console.WriteLine("{0}/{1}={2}", nr1, nr2, nr1 / nr2);
            else
                Console.WriteLine("Wrong character");

        }
    }
}
