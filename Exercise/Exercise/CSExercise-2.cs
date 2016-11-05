using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class CSExercise_2
    {
        public void main() {
            int nr, result;

            Console.WriteLine("Enter a number: ");
            nr = Convert.ToInt32(Console.ReadLine());

            result = nr % 2;
            if (result == 0)
                Console.WriteLine("{0} is an odd integer",nr);
            else if (result != 0)
                Console.WriteLine("{0} is an even integer", nr);
            else
                Console.WriteLine("Error");
        }
    }
}
