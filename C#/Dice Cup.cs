using System;
using System.Collections.Generic;
using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            List<int> nrs = new List<int>();
            nrs.Add(N);
            nrs.Add(M);

            if (N == M)
            {
                Console.WriteLine(M + 1);
            }
            else
            {
                for (int i = nrs.Min()+1; i < nrs.Max()+2; i++)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }

    }
