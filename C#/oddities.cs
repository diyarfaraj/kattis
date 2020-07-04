using System;
using System.Collections.Generic;
using System.Linq;

   class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            List<int> nrs = new List<int>();

            while(n-- > 0)
            {
                int x = int.Parse(Console.ReadLine());
                nrs.Add(x);
            }

            foreach (int nr in nrs)
            {
                if (nr % 2 == 0)
                {
                    Console.WriteLine("{0} is even", nr);
                }else if(nr%2 != 0)
                {
                    Console.WriteLine("{0} is odd", nr);
                }
            }
            Console.ReadLine();

        }

    }
