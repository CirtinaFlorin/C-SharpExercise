using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class DTExercise_8
    {
        public void main() {
            int radius;

            Console.WriteLine("Input radius: ");
            radius = Convert.ToInt32(Console.ReadLine());

            double v,a, pi;
            pi = 3.1415926535f;
            v = 4 / 3 * pi * (radius * radius * radius);
            a= 4 * pi * (radius * radius);
            Console.WriteLine("The volum of the sphere is: {0}", v);
            Console.WriteLine("The area of the sphere is: {0}", a);
        }
    }
}
