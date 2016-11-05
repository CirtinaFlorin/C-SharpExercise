using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class CSExercise_5
    {
        public void main() {
            int age;

            Console.WriteLine("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
                Console.WriteLine("Congratulation! You are eligible for casting your vote");
            else
                Console.WriteLine("Sorry! You are not eligible for casting your vote. You should have over {0}.", 18);
        }
    }
}
