using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {


            string[] input = Console.ReadLine().Split(' ');
            string Y = input[0];
            string P = input[1];
            extendNames(Y, P);

        }

        public static void extendNames(string first, string last)
        {
            var vowels = new List<string>() {"a", "i", "o", "u"};
            if(first.Substring(first.Length -1).Equals("e"))
            {
                Console.WriteLine(first + "x" + last);
                return;
            } else if(first.Substring(first.Length - 2).Equals("ex"))
            {
                Console.WriteLine(first+last);
                return;
            }
            else
            {
                foreach (string letter in vowels)
                {
                    if (first.Substring(first.Length - 1).Equals(letter))
                    {
                        string shortFirst = first.Remove(first.Length - 1, 1);
                        shortFirst += "ex";
                        Console.WriteLine(shortFirst + last);
                        return;
                    }
                }
                
                
            }

            Console.WriteLine(first+"ex"+last);
        }

    }
