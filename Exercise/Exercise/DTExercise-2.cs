using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class DTExercise_2
    {
        public void main() {
            int nr, wid;

            Console.WriteLine("Enter a number: ");
            nr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the desired width: ");
            wid = Convert.ToInt32(Console.ReadLine());

            int height = wid;
            int row, column;
            Console.WriteLine("Triangle is: ");
            for (row = 0; row < height; row++) {
                for (column = 0; column < wid; column++) {
                    Console.WriteLine(nr);
                }
                Console.WriteLine();
                wid--;
            }

            
        }
    }
}
