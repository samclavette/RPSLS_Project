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
        public Player playerOne;
        public Player playerTwo;

        public Game(string player1, string player2)
        {
            playerOne = new Human();
        }

        public void RunGame()
        {
            DisplayRules();
            ChooseHumanOrAI();
        }

        public void DisplayRules()
        {
            Console.WriteLine("You will be playing a variation of rock-paper-scissors with 2 (lizard,Spock) added gestures against an opponent. It will be a best of 3 series. Press any key to begin.");
            Console.ReadLine();
        }

        public void ChooseHumanOrAI()
        {
            Console.WriteLine("Please choose a number:/n1.) Single player/n2. Multiplayer");
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
