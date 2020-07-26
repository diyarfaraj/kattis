using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

    class Program
    {
        static void Main(string[] args)
        {
            
            String[] input = Console.ReadLine().Split(" ");

            int day = int.Parse(input[0]);
            int month = int.Parse(input[1]);

            Console.WriteLine(GetDayOfTheWeek2009(day, month));
            Console.ReadLine();

        }

        public static string GetDayOfTheWeek2009(int d, int m)
        {
            DateTime date = new DateTime(2009, m, d);
            
            return date.ToString("dddd");
        }


    }
