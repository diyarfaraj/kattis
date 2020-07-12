using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            int l = int.Parse(input[0]);
            int r = int.Parse(input[1]);

            List<int> highestSide = new List<int>();

            foreach (var item in input)
            {
                highestSide.Add(int.Parse(item));
            }


            if(l <= 0 && r <= 0 )
                Console.WriteLine("Not a moose");
            else if(l == r)
                Console.WriteLine("Even {0}", l+r);
            else
                Console.WriteLine("Odd {0}", highestSide.Max() * 2);


            Console.ReadLine();
        }

       
    }
