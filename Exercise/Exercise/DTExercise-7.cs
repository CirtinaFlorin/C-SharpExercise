using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class DTExercise_7
    {
        public void main() {
            int distance, hour, min, sec;

            Console.WriteLine("Input distance(meters): ");
            distance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input timeSec(hour): ");

            hour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input timeSec(minutes): ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input timeSec(seconds): ");
            sec = Convert.ToInt32(Console.ReadLine());

            float timsec, mps, kph, mph;

            timsec = (hour * 3600) + (min * 60) + sec;
            mps = distance / timsec;
            kph = (distance / 1000.0f) / (timsec / 3600.0f);
            mph = kph / 1.609f;

            Console.WriteLine("Your speed in meters/sec is: {0}",mps);
            Console.WriteLine("Your speed in km/h is: {0}", kph);
            Console.WriteLine("Your speed in miles/h is: {0}", mph);
        }
    }
}
