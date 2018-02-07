using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Player2 : Player
    {
        Random r = new Random();
        public Player2()
        {
            this.name = "Mr. MeeSeeks";
        }

        public override string GenerateRoshambo()
        {
            int random = r.Next(1, 4);
            if (random == 1)
            {
                this.RoshamboValue = "rock";
            }
            else if (random == 2)
            {
                this.RoshamboValue = "paper";
            }
            else
            {
                this.RoshamboValue = "scissors";
            }
            return this.RoshamboValue;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
