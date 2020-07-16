using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        public string player1;
        public string player2;

        public Game(string player1, string player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }

        public void RunGame()
        {
            int userInput = ChooseHumanOrAI();
            if (userInput == 1)
            {
                PlayAgainstHuman();
            }
            else if (userInput == 2)
            {
                PlayAgainstAI();
            }
            else if (userInput != 1 | userInput != 2)
            {
                ChooseHumanOrAI();
            }
        }

        public int ChooseHumanOrAI()
        {
            Console.WriteLine("Please choose a number:/n1.) Single player/n2. Mulitplayer");
            int userInput = Convert.ToInt32(Console.ReadLine());
            return userInput;
        }

        public void PlayAgainstHuman()
        {
            
        }

        public void PlayAgainstAI()
        {

        }
            
    }
}
