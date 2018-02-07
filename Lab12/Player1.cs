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

        public override string GenerateRoshambo()
        {
            return this.RoshamboValue;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
