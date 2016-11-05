using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class CSExercise_10
    { public void mian() {
            int p, c, m;

            Console.WriteLine("Marks in Math >=65 ");
            Console.WriteLine("Marks in Phy >=55 ");
            Console.WriteLine("Marks in Chem >=50 ");
            Console.WriteLine("Total in all three subject >=180 ");
            Console.WriteLine("or Total in Math and Physics >=140 ");
            Console.WriteLine(".................................\n ");

            Console.WriteLine("Input the marks obtained in Physics: ");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the marks obtained in Chemistry: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the marks obtained in Mathematics: ");
            m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(".................................\n ");
            Console.WriteLine("Total marks of Math, Physics and Chemistry: {0} ",m+p+c);
            Console.WriteLine("Total marks of Math and Physics: {0} ", m+p);
            Console.WriteLine(".................................\n ");

            if (m >= 65)
                if (p >= 55)
                    if (c >= 50)
                        if ((m + p + c) >= 180 || (m + p) >= 140)
                            Console.WriteLine("The candidate is eligible for admision");
            else
                            Console.WriteLine("The candidate is not eligible for admision");
            else
                        Console.WriteLine("The candidate is not eligible for admision");
            else
                    Console.WriteLine("The candidate is not eligible for admision");
            else
                Console.WriteLine("The candidate is not eligible for admision");
        }
    }
}
