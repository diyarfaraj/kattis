using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(' ');
            List<string> hands = new List<string>();

            foreach (string hand in input)
            {
                hands.Add(hand.ToUpper().Remove(1, 1));
                
            }
            var strength = from hand in hands
                           group hand by hand into h
                           select h.Count();

            Console.WriteLine(strength.Max()); 
            
            Console.ReadLine();
        }

    }
