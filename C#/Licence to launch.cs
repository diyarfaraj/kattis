using System;
using System.Collections.Generic;
using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());

            string[] junks = Console.ReadLine().Split(' ');

            List<int> jList = new List<int>();

            foreach (var item in junks)
            {
                jList.Add(int.Parse(item));
            }

            Console.WriteLine(jList.IndexOf(jList.Min()));

            Console.ReadLine();
        }
    }
