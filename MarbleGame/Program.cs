using System;

namespace MarbleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int starterMarbles = 10;
            int j = 1;
            double winRate = 0;
            double loseRate = 0;
            double resultat = 0;
            double resultat2 = 0;


            Console.WriteLine("Input the amount of simulations/tries: ");
            int tries = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------");

            Console.WriteLine("Input the amount of rounds: ");
            int rounds = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------");
            Console.WriteLine("choose odd or even: ");
            string oddeven = Console.ReadLine();

            do
            {
                for (int i = 1; i <= rounds; i++)
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

                    if (starterMarbles >= 20)
                    {
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("You have {0} marbles now", starterMarbles);
                        Console.WriteLine("You Win!");
                        Console.WriteLine("You won on round {0}!", i);
                        Console.WriteLine("\n");

                        starterMarbles = 10;
                        winRate += 100;
                        break;
                    }

                    else if (starterMarbles <= 0)
                    {
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("You have {0} marbles now", starterMarbles);
                        Console.WriteLine("You lose!");
                        Console.WriteLine("\n");

                        starterMarbles = 10;
                        loseRate += 100;
                        break;
                    }

                    else if (i >= rounds)
                    {
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("You have {0} marbles now", starterMarbles);
                        Console.WriteLine("You Win!");
                        Console.WriteLine("You won on round {0}!", i);
                        Console.WriteLine("\n");

                        starterMarbles = 10;
                        winRate += 100;
                        break;
                    }

                    Console.WriteLine("-------------------------");
                    Console.WriteLine("You have {0} marbles now", starterMarbles);
                }

                j++;
            } while (j <= tries);

            resultat = winRate / tries;
            resultat2 = loseRate / tries;

            Console.WriteLine("Your choice was {0} your winrate is {1}% with {2} tries and {3} rounds", oddeven, resultat, tries, rounds);
            Console.WriteLine("Your choice was {0} your loserate is {1}% with {2} tries and {3} rounds", oddeven, resultat2, tries, rounds);

            Console.ReadLine();
        }
    }
}
