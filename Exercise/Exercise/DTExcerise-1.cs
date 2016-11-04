using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class DTExcerise_1
    {
        public void main() {
            string x, y, z;

            Console.WriteLine("Enter a letter: ");
            x = Console.ReadLine();
            Console.WriteLine("Enter a letter: ");
            y = Console.ReadLine();
            Console.WriteLine("Enter a letter: ");
            z = Console.ReadLine();

            Console.WriteLine("Reverse letter: {0}{1}{2}", z,y,x);
        }
    }
}
