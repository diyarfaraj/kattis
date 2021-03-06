using System;
using System.Collections.Generic;
using System.Linq;


    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            List<int> nums = new List<int>();
            
            foreach (var item in input)
            {               
                nums.Add(int.Parse(Reverse(item)));
            }
            Console.WriteLine(nums.Max());
            Console.ReadLine();
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        
    }
