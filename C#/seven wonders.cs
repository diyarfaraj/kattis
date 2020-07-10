using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


    class Program
    {
        static void Main(string[] args)
        {

            int outp = CountLetters(Console.ReadLine());

            Console.WriteLine(outp);
            Console.ReadLine();

        }

        public static int CountLetters(string input)
        {
            int points = 0;

            int t = input.Count(l => l == 'T');
            int c = input.Count(l => l == 'C');
            int g = input.Count(l => l == 'G');

            points += (t * t) + (c * c) + (g * g);

            string subString = "TCG";
             var setOfThree = subString.All(input.Contains) ? input
           .Where(subString.Contains)
           .GroupBy(x => x)
           .Min(z => z.Count()) : 0;
            setOfThree *= 7;

            return points + setOfThree;

        }

    }
