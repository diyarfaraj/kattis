using System;
using System.Collections.Generic;
using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int vertexes = 3;
            List<int> firstList = new List<int>();
            List<int> secondList = new List<int>();

            while (vertexes-- > 0)
            {
                string[] input = Console.ReadLine().Split(' ');
                int first = int.Parse(input[0]);
                int second = int.Parse(input[1]);

                firstList.Add(first);
                secondList.Add(second);
            }

            var firstNr = firstList
                     .GroupBy(n => n)
                     .Where(g => g.Count() == 1)
                     .Select(g => g.Key);
            var secondNr = secondList
                    .GroupBy(n => n)
                    .Where(g => g.Count() == 1)
                    .Select(g => g.Key);

            foreach (var item in firstNr)
            {
                foreach (var nr in secondNr)
                {
                    Console.WriteLine("{0} {1}", item, nr);
                }
            }
            
        }
    }
