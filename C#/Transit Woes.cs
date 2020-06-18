using System;
using System.Collections.Generic;
using System.Linq;


    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int s = int.Parse(input[0]);
            int t = int.Parse(input[1]);
            int n = int.Parse(input[2]);

            string[] input2 = Console.ReadLine().Split(' ');
            List<int> walks = new List<int>();
            foreach (var item in input2)
            {
                walks.Add(int.Parse(item));
                walks.Take(n + 1);
            }

            string[] input3 = Console.ReadLine().Split(' ');
            List<int> drives = new List<int>();
            foreach (var item in input3)
            {
                drives.Add(int.Parse(item));
                drives.Take(n);
            }

            string[] input4 = Console.ReadLine().Split(' ');
            List<int> arrivals = new List<int>();
            foreach (var item in input4)
            {
                arrivals.Add(int.Parse(item));
                arrivals.Take(n);


            }
            List<int> arrivalArr = new List<int>();
            for (int i = 0; i < arrivals.Count; ++i)
            {
                int diff = i == 0 ? arrivals[0] - 1 : arrivals[i] - arrivals[i - 1];

                arrivalArr.Add(diff);
                
            }

            s += walks.Sum();
            s += drives.Sum();
            s += arrivalArr.Sum();


            if (s > t)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine("yes");
            }

            Console.ReadLine();
        }

    }
