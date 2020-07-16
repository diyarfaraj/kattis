using System;
using System.Collections.Generic;
using System.Linq;

  class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            int points = 2;

            for (int i = 0; i < n; i++)
            {
                points = (points+points)-1;
            }
            
            int finalPoints = points*points;
            Console.WriteLine(finalPoints);
            Console.ReadLine();
        }

    }
