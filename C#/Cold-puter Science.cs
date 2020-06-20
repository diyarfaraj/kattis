using System;
using System.Collections.Generic;
using System.Linq;


    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int nrOfZeroDays = 0;
            List<int> days = new List<int>();

            string[] input = Console.ReadLine().Split(' ');

            foreach (var item in input)
            {
                days.Add(int.Parse(item));
                days.Take(n);
            }

            foreach (var day in days)
            {
                if(day < 0)
                {
                    nrOfZeroDays++;
                }
            }

            Console.WriteLine(nrOfZeroDays);


            Console.ReadLine();
        }

    }
