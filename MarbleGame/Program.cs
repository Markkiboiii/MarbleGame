﻿using System;

namespace MarbleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int starterMarbles = 10;

            Console.WriteLine("Input the amount of rounds: ");
            int rounds = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------");
            Console.WriteLine("choose odd or even: ");
            string oddeven = Console.ReadLine();

            for (int i = 0; i < rounds; i++)
            {
                var rng = new Random();
                int marbles = rng.Next(1, 6);

                if (oddeven.ToLower() == "odd")
                {
                    Console.WriteLine("You have {0} Marbles", starterMarbles);
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("The amount of marbles: {0}", marbles);
                    switch (marbles)
                    {
                        case 1:
                            starterMarbles += 1;
                            break;
                        case 2:
                            starterMarbles -= 2;
                            break;
                        case 3:
                            starterMarbles += 3;
                            break;
                        case 4:
                            starterMarbles -= 4;
                            break;
                        case 5:
                            starterMarbles += 5;
                            break;
                    }
                }
                else if (oddeven.ToLower() == "even")
                {
                    Console.WriteLine("You have {0} Marbles", starterMarbles);
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("The amount of marbles: {0}", marbles);
                    switch (marbles)
                    {
                        case 1:
                            starterMarbles -= 1;
                            break;
                        case 2:
                            starterMarbles += 2;
                            break;
                        case 3:
                            starterMarbles -= 3;
                            break;
                        case 4:
                            starterMarbles += 4;
                            break;
                        case 5:
                            starterMarbles -= 5;
                            break;
                    }
                }

                if (starterMarbles <= 0)
                {
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("You have {0} marbles now", starterMarbles);
                    Console.WriteLine("You lose! NOOOOB!");
                    break;
                }
                Console.WriteLine("-------------------------");
                Console.WriteLine("You have {0} marbles now", starterMarbles);
            }
            Console.ReadLine();
        }
    }
}
