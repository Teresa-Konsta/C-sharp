using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w1Q1
{
    class Cinema
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of the movie: ");
            string movieName = Console.ReadLine();
            int duration = 90;
            string output = DisplayFilm(movieName, ref duration);
            Console.WriteLine(output);
            Console.WriteLine(DisplayFilm(movieName, ref duration));
        }

        static string DisplayFilm(string movieName, ref int duration)
        {
            if (duration != 90)
            {
                Random randomDuration = new Random();
                duration = randomDuration.Next(60, 120);
            }
            //Console.WriteLine(movieName);
            //Console.Write($"- {duration} minutes");
            string output = movieName + " - " + duration + "minutes";
            return output;
        }
    }
}
