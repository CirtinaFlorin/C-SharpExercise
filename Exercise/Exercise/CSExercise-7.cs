using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class CSExercise_7
    {
        public void main() {
            int height;

            Console.WriteLine("Input the height of person (in centimetres): ");
            height = Convert.ToInt32(Console.ReadLine());

            if (height < 150)
                Console.WriteLine("The person is Dwarf.");
            else if ((height >= 150) && (height <= 165))
                Console.WriteLine("The person is average high.");
            else if ((height >= 165) && (height <= 195))
                Console.WriteLine("The person is taller.");
            else
                Console.WriteLine("Anormal height.");
        }
    }
}
