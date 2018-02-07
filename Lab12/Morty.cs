using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Morty : Player
    {
        public override string GenerateRoshambo()
        {
            return "rock";
        }
    }
}
