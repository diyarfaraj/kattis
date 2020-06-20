using System;
using System.Collections.Generic;
using System.Linq;


    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<double> listNrs = new List<double>();

            while(n-- > 0)
            {
                int nr = int.Parse(Console.ReadLine());
                int finalNr = nr / 10;
                int pow = nr % (10);
                listNrs.Add(Math.Pow(finalNr, pow));
            }

            Console.WriteLine(listNrs.Sum());

            Console.ReadLine();
        }

    }
