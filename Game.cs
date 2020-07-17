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

        public Game()
        {
            playerOne = new Human();
        
        }

        public void RunGame()
        {
            DisplayRules();
            ChooseHumanOrAI();
            while (playerOne.score < 2 || playerTwo.score < 2)
            {
                PlayRound();
            }
        }

        public void DisplayRules()
        {
            Console.WriteLine("You will be playing a variation of rock-paper-scissors with 2 (lizard,Spock) added gestures against an opponent. It will be a best of 3 series. Press enter to begin.");
            Console.ReadLine();
        }

        public void ChooseHumanOrAI()
        {
            Console.WriteLine("Please choose a number:/n1.) Single player/n2.) Multiplayer");
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

        public void CheckRoundWinner()
        {
            string gestureOne = playerOne.ChooseGesture();
            string gestureTwo = playerTwo.ChooseGesture();
            if (gestureOne == gestureTwo)
            {
                Console.WriteLine("It's a tie! Choose again!");
            }
            else if (gestureOne == "rock")
            {
                if (gestureTwo == "lizard" || gestureTwo == "scissors")
                {
                    Console.WriteLine("Player One wins this round!");
                    playerOne.score++;
                }
                else if (gestureTwo == "paper" || gestureTwo == "spock") 
                {
                    Console.WriteLine("Player Two wins this round!");
                    playerTwo.score++;
                }
            }
            else if (gestureOne == "paper")
            {
                if (gestureTwo == "rock" || gestureTwo == "spock")
                {
                    Console.WriteLine("Player One wins this round!");
                    playerOne.score++;
                }
                else if (gestureTwo == "scissors" || gestureTwo == "lizard")
                {
                    Console.WriteLine("Player Two wins this round!");
                    playerTwo.score++;
                }
            }
            else if (gestureOne == "scissors")
            {
                if (gestureTwo == "paper" || gestureTwo == "lizard")
                {
                    Console.WriteLine("Player One wins this round!");
                    playerOne.score++;
                }
                else if (gestureTwo == "rock" || gestureTwo == "spock")
                {
                    Console.WriteLine("Player Two wins this round!");
                    playerTwo.score++;
                }
            }
            else if (gestureOne == "lizard")
            {
                if (gestureTwo == "paper" || gestureTwo == "spock")
                {
                    Console.WriteLine("Player One wins this round!");
                    playerOne.score++;
                }
                else if (gestureTwo == "rock" || gestureTwo == "scissors")
                {
                    Console.WriteLine("Player Two wins this round!");
                    playerTwo.score++;
                }
            }
            else if (gestureOne == "spock")
            {
                if (gestureTwo == "rock" || gestureTwo == "scissors")
                {
                    Console.WriteLine("Player One wins this round!");
                    playerOne.score++;
                }
                else if (gestureTwo == "paper" || gestureTwo == "lizard")
                {
                    Console.WriteLine("Player Two wins this round!");
                    playerTwo.score++;
                }
            }
        }

        public void PlayRound()
        {
            playerOne.ChooseGesture();
            playerTwo.ChooseGesture();
            CheckRoundWinner();

        }
            
    }
}
