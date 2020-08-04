using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0])*4;
            char B = char.Parse(input[1]);

            List<string> listOfHands = new List<string>();

            while (N-- > 0)
            {
                string card = Console.ReadLine();
                listOfHands.Add(card);
            }

            int points = 0;

            foreach (string hand in listOfHands)
            {
                switch (hand[0])
                {
                    case 'A':
                        points += 11;
                        continue;
                    case 'K':
                        points += 4;
                        continue;
                    case 'Q':
                        points += 3;
                        continue;
                    case 'J':
                        if(hand[1] == B)
                        {
                            points += 20;
                        } else
                        {
                            points += 2;
                        }
                     
                        continue;
                    case 'T':
                        points += 10;
                        continue;
                    case '9':
                        if (hand[1] == B)
                        {
                            points += 14;
                        }
                        else
                        {
                            points += 0;
                        }
                        continue;
                    case '8':
                    case '7':
                        points += 0;
                        continue;
                    default:
                        return;
                }
            }

            Console.WriteLine(points);

            Console.ReadLine();
        }

    }
