using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class DTExercise_3
    {
        public void main() {
            string username, password;
            int contor = 0;

            Console.Write("\n\nCheck username and password -->\n");
            Console.Write("Default username and password is : username and password");
            Console.Write("\n..................................\n");

            do {
                Console.Write("\nInput a username: ");
                username = Console.ReadLine();

                Console.Write("Input a password: ");
                password = Console.ReadLine();

                contor++;
            }

            while((username != "username" && password != "password") && (contor!=3));

            if (contor == 3)
                Console.WriteLine("Login attempt more then 3 times. Try later!");
            else
                Console.WriteLine("\nLogin successfulL!\n");


        }
    }
}
