using System;
using System.Collections.Generic;
using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int lines = 10;

            List<int> nrs = new List<int>();

            while(lines-- > 0)
            {
                int input = int.Parse(Console.ReadLine());
                nrs.Add(input);
            }

            List<int> values = new List<int>();


            foreach (int nr in nrs)
            {
                values.Add(nr % 42);
            }

            Console.WriteLine(values.Distinct().Count());


        }
    }
