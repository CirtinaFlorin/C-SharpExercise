using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class CSExercise_1
    {
        public void main() {
            int nr1, nr2;

            Console.WriteLine("Input 1st number: ");
            nr1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input 2nd number: ");
            nr2 = Convert.ToInt32(Console.ReadLine());

            if (nr1 == nr2)
                Console.WriteLine("{0} and {1} are equal!", nr1, nr2);
            else
                Console.WriteLine("{0} and {1} are not equals!", nr1, nr2);
        }
    }
}
