using System;
using System.Collections.Generic;
using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double q;
            double y;
            List<double> qali = new List<double>();

            while(n-- > 0)
            {
                string[] input = Console.ReadLine().Split(' ');

                 q = double.Parse(input[0]);
                 y = double.Parse(input[1]);

                qali.Add(q * y);

            }

            
                Console.WriteLine(qali.Sum());
            


            Console.ReadLine();
        }

    }
