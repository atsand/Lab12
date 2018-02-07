using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class RoshamboApp
    {
        Player user = new Player3();
        Player computerPlayer;

        public void GetPlayer()
        {
            string input;
            Console.WriteLine("Who whould you like to play against? (1 or 2)\n1)\tMorty\n2)\tMr. Meeseeks");
            input = Console.ReadLine();
            if (int.TryParse(input, out int inputDigit))
            {
                if (inputDigit==1)
                {
                    computerPlayer = new Player1();
                }
                else if (inputDigit==2)
                {
                    computerPlayer = new Player2();
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                    GetPlayer();
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
                GetPlayer();
            }
        }

        public void Play()
        {
            GetPlayer();



        }
    }
}
