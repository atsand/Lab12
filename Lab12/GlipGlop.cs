using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class GlipGlop : Player
    {
        public override string GenerateRoshambo()
        {
            return Options();
        }

        public string Options()
        {
            Console.WriteLine("Pick a number:\n1)\tRock\n2)\tPaper\n3)\tScissors");
            return GetChoice();
        }

        public string GetChoice()
        {
            string choice = Console.ReadLine();
            if (int.TryParse(choice, out int digit))
            {
                if (digit==1)
                {
                    return "rock";
                }
                else if (digit==2)
                {
                    return "paper";
                }
                else if (digit==3)
                {
                    return "scissors";
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
            return "Glip Glop";
        }
    }
}
