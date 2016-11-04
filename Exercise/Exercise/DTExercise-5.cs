using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class DTExercise_5
    {
        public void main() {
            int radius;

            Console.WriteLine("Input the radius of the cirsle: ");
            radius = Convert.ToInt32(Console.ReadLine());

            double perimetru;
            perimetru = 2 * 3.14 * radius;
            Console.WriteLine("Perimeter of circle: {0}", perimetru);
        }
    }
}
