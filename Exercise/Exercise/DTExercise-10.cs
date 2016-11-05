using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class DTExercise_10
    {
        public void main() {
            int nr1, nr2;

            Console.WriteLine("Input first number: ");
            nr1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second number: ");
            nr2 = Convert.ToInt32(Console.ReadLine());

            if ((nr1 % 2 == 0) && (nr2 % 2 == 0))
                Console.WriteLine("Both number are even!");
            else if ((nr1 % 2 != 0) && (nr2 % 2 != 0))
                Console.WriteLine("Both number are odd!");
            else
                Console.WriteLine("A number is even and another is odd!");
        }
    }
}
