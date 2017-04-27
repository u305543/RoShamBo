using System;

namespace RoShamBo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to play RoShamBo? Enter Yes or No.");
            string wantToPlay = Console.ReadLine().ToLower();

            startGame:
            if (wantToPlay == "yes")
            {
                Console.WriteLine("Make a selection:  r for rock, p for paper, s for scissors");
                string playersChoice = Console.ReadLine();

                makeSelection:

                if (playersChoice == "r" || playersChoice == "p" || playersChoice == "s")
                {
                    string computerPick = computerChoice();
                    Console.WriteLine("You chose {0} and the computer chose {1}."
                        , playersChoice, computerPick);
                    int gameResult = compareToWin(playersChoice, computerPick);
                    
                    switch(gameResult)
                    {
                        case 0:
                            {
                                Console.WriteLine("The result is a tie.");
                                break;
                            }
                        case -1:
                            {
                                Console.WriteLine("The Computer Wins");
                                break;
                            }
                        case 1:
                            {
                                Console.WriteLine("You win");
                                break;
                            }

                    }
                    Console.WriteLine("Would you like to play again?");
                    wantToPlay = Console.ReadLine().ToLower();

                    if (wantToPlay == "yes" || wantToPlay == "no")
                    {
                        goto startGame;
                    }
                    else
                    {
                        Console.WriteLine("Please Enter Yes or No.");
                        wantToPlay = Console.ReadLine().ToLower();
                        goto startGame;
                    }

                }
                else
                {
                    Console.WriteLine("Your only choices are r, p, and s. Choose again.");
                    playersChoice = Console.ReadLine();
                    goto makeSelection;
                }
            }
            else if(wantToPlay == "no")
            {
                Console.WriteLine("Good Bye");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Please Enter Yes or No.");
                wantToPlay = Console.ReadLine().ToLower();
                goto startGame;
            }

        }

        private static string computerChoice()
        {
       
            Random rnd = new Random();
            int i = rnd.Next(1, 4);

            if (i == 1)
            {
                return "r";
            }
            else if (i == 2)
            {
                return "p";
            }
            else
            {
                return "s";
            }

        }

        private static int compareToWin(string humanChoice, string compChoice)
        {
            if (humanChoice == "r" && compChoice == "p")
            {
                return -1;
            }
            else if (humanChoice == "r" && compChoice == "s")
            {
                return 1;
            }
            else if (humanChoice == "p" && compChoice == "s")
            {
                return -1;
            }
            else if (humanChoice == "p" && compChoice == "r")
            {
                return 1;
            }
            else if (humanChoice == "s" && compChoice == "r")
            {
                return -1;
            }
            else if (humanChoice == "s" && compChoice == "p")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
