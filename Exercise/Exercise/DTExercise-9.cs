using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class DTExercise_9
    {
        public void main() {
            char symbol;

            Console.WriteLine("Input a symbol: ");
            symbol = Convert.ToChar(Console.ReadLine());

            if ((symbol == 'a') || (symbol == 'e') || (symbol == 'i') || (symbol == 'o') || (symbol == 'u'))
                Console.WriteLine("It's a lowercase vowel!");
            else if ((symbol >= '0') && (symbol <= '9'))
                Console.WriteLine("It's a digit!");
            else
                Console.WriteLine("It's another symbol!");


        }
    }
}
