using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());

            List<string> cupsList = new List<string>();

            while(N-- > 0)
            {
                string[] input = Console.ReadLine().Split(' ');
                cupsList.AddRange(input);

            }

            List<string> finalCupsList = new List<string>();

            for (int i = 0; i < cupsList.Count; i+=2)
            {
                string first = cupsList[i];
                string second = cupsList[i + 1];

                int nr;
                if(int.TryParse(first, out nr))
                {

                    finalCupsList.Add(second +' '+ (nr / 2).ToString());
                } else
                {
                    finalCupsList.Add(first +' '+ second);

                }
            }

            finalCupsList = finalCupsList.Select(s => new { Str = s, Split = s.Split(' ') })
            .OrderBy(x => int.Parse(x.Split[1]))
            .ThenBy(x => x.Split[0])
            .Select(x => x.Str)
            .ToList();

            foreach (var item in finalCupsList)
            {
                Console.WriteLine(item.Split(' ')[0]);
            }

        }

    }
}
