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

        }

        public void ChooseHumanOrAI()
        {
            Console.WriteLine("Please choose a number:/n1.) Single player/n2. Mulitplayer");
            int userInput = Convert.ToInt32(Console.ReadLine());
        }

        public void PlayAgainstHuman()
        {

        }

        public void PlayAgainstAI()
        {

        }
            
    }
}
