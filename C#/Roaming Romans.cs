using System;
using System.Collections.Generic;
using System.Linq;


    class Program
    {
        static void Main(string[] args)
        {

            decimal X = decimal.Parse(Console.ReadLine());

            decimal romanFeet = 4854;
            decimal modernFeet = 5280;


            Console.WriteLine(Math.Round(X * (1000 * (modernFeet / romanFeet))));

            Console.ReadLine();


        }
    }

