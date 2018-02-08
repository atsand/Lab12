using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    static class RoshamboApp
    {
        static Player user = new Player3();
        static Player computerPlayer;
        
        static public Player GetPlayer()
        {
            string input;
            Console.WriteLine("\nWho whould you like to play against? (1 or 2)\n1) Morty\n2) Mr. Meeseeks");
            input = Console.ReadLine();
            if (int.TryParse(input, out int inputDigit))
            {
                if (inputDigit==1)
                {
                    return computerPlayer = new Player1();
                }
                else if (inputDigit==2)
                {
                    return computerPlayer = new Player2();
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                    return GetPlayer();
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
                return GetPlayer();
            }
        }

        static public void Play()
        {
            bool again = true;
            computerPlayer = GetPlayer();
            while (again)
            {
                string pcRoll = computerPlayer.GenerateRoshambo();
                string userRoll = user.GenerateRoshambo();
                Console.WriteLine("\n" + computerPlayer.ToString()+ ": " + pcRoll);
                Console.WriteLine("You: " + userRoll);
                if (userRoll == "rock")
                {

                    switch (pcRoll)
                    {
                        case "rock":
                            user.AddTie();
                            Console.WriteLine("Result: Tie!");
                            again = Again();
                            break;
                        case "paper":
                            user.AddLoss();
                            Console.WriteLine("Result: Loss!");
                            again = Again();
                            break;
                        case "scissors":
                            user.AddWin();
                            Console.WriteLine("Result: Win!");
                            again = Again();
                            break;
                        default:
                            break;
                    }
                }
                else if (userRoll == "paper")
                {
                    switch (pcRoll)
                    {
                        case "rock":
                            user.AddWin();
                            Console.WriteLine("Result: Win!");
                            again = Again();
                            break;
                        case "paper":
                            user.AddTie();
                            Console.WriteLine("Result: Tie!");
                            again = Again();
                            break;
                        case "scissors":
                            user.AddLoss();
                            Console.WriteLine("Result: Loss!");
                            again = Again();
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (pcRoll)
                    {
                        case "rock":
                            user.AddLoss();
                            Console.WriteLine("Result: Loss!");
                            again = Again();
                            break;
                        case "paper":
                            user.AddWin();
                            Console.WriteLine("Result: Win!");
                            again = Again();
                            break;
                        case "scissors":
                            user.AddTie();
                            Console.WriteLine("Result: Tie!");
                            again = Again();
                            break;
                        default:
                            break;
                    }
                }
            }
            if (AnotherPlayer()==true)
            {
                Play();
            }
        }

        static public string ComputerRoll(Player computer)
        {
            return computer.GenerateRoshambo();
        }

        static public bool Again()
        {
            string input;
            Console.WriteLine("\nWould you like to play again? (Y/N)");
            input = Console.ReadLine();
            if (input.ToLower()=="y")
            {
                return true;
            }
            else if (input.ToLower()=="n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("\nInvalid input.");
                return Again();
            }
        }

        static public bool AnotherPlayer()
        {
            string input;
            Console.WriteLine("\nWould you like to play against a different player? (Y/N)");
            input = Console.ReadLine();
            if (input.ToLower() == "y")
            {
                return true;
            }
            else if (input.ToLower() == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("\nInvalid input.");
                return Again();
            }
        }

        static public void PrintResults()
        {
            user.Totals();
        }
    }
}

