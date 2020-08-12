using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());

            int matches = 0;
            string pattern = "^.*(pink|rose).*$";

            while (N-- > 0)
            {
                string input = Console.ReadLine().ToLower();

                if(Regex.IsMatch(input, pattern))
                {
                    matches++;
                }
            }


            if(matches > 0)
            {
                Console.WriteLine(matches);
            } else
            {
                Console.WriteLine("I must watch Star Wars with my daughter");
            }

        }

    }
