using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class MrMeeSeeks : Player
    {
        
        public override string GenerateRoshambo()
        {
            Random r = new Random();
            int random = r.Next(1, 4);
            if (random == 1)
            {
                return "rock";
            }
            else if (random==2)
            {
                return "paper";
            }
            else
            {
                return "scissors";
            }
        }

        public override string ToString()
        {
            return "Mr. MeeSeeks";
        }
    }
}
