using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Exercise_13
    {
        public void main() {
            int nr;

            Console.WriteLine("Enter the number: ");
            nr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Rectangle: ");
            Console.WriteLine(" ");
            Console.WriteLine("          {0}{0}{0}", nr);
            Console.WriteLine("          {0} {0}", nr);
            Console.WriteLine("          {0} {0}", nr);
            Console.WriteLine("          {0} {0}", nr);
            Console.WriteLine("          {0}{0}{0}", nr);
        }
    }
}
