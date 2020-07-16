using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        public Player player1;
        public Player player2;

        public Game(string player1, string player2)
        {
            player1 = new Human();
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

        public void DisplayRules()
        {

        }

        public string ChooseHumanOrAI()
        {
            Console.WriteLine("Please choose a number:/n1.) Single player/n2. Mulitplayer");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                playerTwo = new Human();
            }
            else if (userInput == "2")
            {
                playerTwo = new AI();
            }
        }

        public void PlayAgainstHuman()
        {
            
        }

        public void PlayAgainstAI()
        {

        }
            
    }
}
