using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class CSExercise_8
    {
        public void main() {
            int nr1, nr2, nr3;

            Console.WriteLine("Input the 1st number: ");
            nr1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the 2nd number: ");
            nr2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the 3nd number: ");
            nr3 = Convert.ToInt32(Console.ReadLine());


            if ((nr1 > nr2) && (nr1 > nr3))
                Console.WriteLine("The 1st number is greatest among three.");
            else if ((nr2 > nr1) && (nr2 > nr3))
                Console.WriteLine("The 2nd number is greatest among three.");
            else if ((nr3 > nr1) && (nr3 > nr2))
                Console.WriteLine("The 3nd number is greatest among three.");
            else
                Console.WriteLine("Error");
        }
    }
}
