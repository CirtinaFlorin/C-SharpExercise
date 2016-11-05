using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class CSExercise_3
    {
        public void main() {
            int nr;

            Console.WriteLine("Enter a number: ");
            nr = Convert.ToInt32(Console.ReadLine());

            if (nr >= 0)
                Console.WriteLine("{0} is a positive number", nr);
            else
                Console.WriteLine("{0} is a negative number", nr);
        }
    }
}
