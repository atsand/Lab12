using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Player3 : Player
    {
        public Player3()
        {
            this.name = "Glip Glop";
        }

        public override string GenerateRoshambo()
        {
            this.RoshamboValue = Options();
            return RoshamboValue;
        }

        public string Options()
        {
            Console.WriteLine("\nPick a number:\n1) Rock\n2) Paper\n3) Scissors");
            return GetChoice();
        }

        public string GetChoice()
        {
            string choice = Console.ReadLine();
            if (int.TryParse(choice, out int digit))
            {
                if (digit == 1)
                {
                    return "rock";
                }
                else if (digit == 2)
                {
                    return "paper";
                }
                else if (digit == 3)
                {
                    return  "scissors";
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    return Options();
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
                return Options();
            }
        }

        public override string ToString()
        {
            return this.name;
        }

        public override void AddWin()
        {
            this.wins = wins+1;
        }

        public override void AddLoss()
        {
            this.losses = losses+1;
        }

        public override void AddTie()
        {
            this.ties = ties+1;
        }

        public override void Totals()
        {
            Console.WriteLine("\n======================\nYour results:\n======================");
            Console.WriteLine("Wins: " + this.wins);
            Console.WriteLine("Loses: " + this.losses);
            Console.WriteLine("Ties: " + this.ties + "\n");
        }
    }
}
