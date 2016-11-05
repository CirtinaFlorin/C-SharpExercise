using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class CSExercise_6
    {
        public void main() {
            int m;

            Console.WriteLine("Enter a number: ");
            m = Convert.ToInt32(Console.ReadLine());

            if(m > 0)
                Console.WriteLine("--> {0} <-- m is larger than 0", 1);
            else if (m == 0)
                Console.WriteLine("--> {0} <-- m is = 0", 0);
            else
                Console.WriteLine("--> {0} <-- m is less than 0", -1);
        }
    }
}
