﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise_1 afisare = new Exercise_1();
            afisare.main();

            Exercise_2 rezultat = new Exercise_2();
            rezultat.main();

            Exercise_3 impartire = new Exercise_3();
            impartire.main();

            Exercise_4 output = new Exercise_4();
            output.main();

            Exercise_5 swap = new Exercise_5();
            swap.main();



            Console.ReadKey();
        }
    }
}
