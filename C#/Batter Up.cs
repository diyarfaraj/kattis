using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            string[] bats = Console.ReadLine().Split(' ');

            List<string> batsList = new List<string>();

            foreach (var bat in bats)
            {
                batsList.Add(bat);
                
            }
            int walks = 0;
            double sum = 0;
            for (int i = 0; i < batsList.Count; i++)
            {
                if(int.Parse(batsList[i]) > 0)
                {
                    sum += int.Parse(batsList[i]);
                }
                if (int.Parse(batsList[i]) < 0)
                {
                    walks++;
                }
                    
            }

            Console.WriteLine(sum/(n-walks));


            Console.ReadLine();
        }

    }

