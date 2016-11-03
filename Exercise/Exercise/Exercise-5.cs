using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Exercise_5
    {
        public void main() {
            string nr1; string nr2; string temp;
            Console.WriteLine("First number is: ");
            nr1 = Console.ReadLine();
            Console.WriteLine("Second number is: ");
            nr2 = Console.ReadLine();
            Console.WriteLine("Number before swaping are {0} and {1}",nr1, nr2);
            temp = nr1;
            nr1 = nr2;
            nr2 = temp;
            Console.WriteLine("Number after swaping are {0} and {1} ",nr1, nr2);
        }
    }
}
