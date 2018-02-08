using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Player1 : Player
    {
        public Player1()
        {
            this.name = "Morty";
            this.RoshamboValue = "rock";
        }

        public override void AddLoss()
        {
            this.losses = losses++;
        }

        public override void AddTie()
        {
            this.ties = ties++;
        }

        public override void AddWin()
        {
            this.wins = wins++;
        }

        public override string GenerateRoshambo()
        {
            return this.RoshamboValue;
        }

        public override string ToString()
        {
            return this.name;
        }

        public override void Totals()
        {
            Console.WriteLine("\nWins: " + this.wins);
            Console.WriteLine("Loses: " + this.losses);
            Console.WriteLine("Ties: " + this.ties);
        }
    }
}
