using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Exercise_11
    {
        public void main() {
            int age;

            Console.WriteLine("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You look older than " + age);
        }
    }
}
