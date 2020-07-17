using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player
    {
        public Human()
        {
            name = ReceiveNameInput();
        }


        public string ReceiveNameInput()
        {
            Console.WriteLine("Please enter name: ");
            string nameInput = Console.ReadLine();
            return nameInput;
        }

        public override string ChooseGesture()
        {
            string userInput = ""; 
            
            while (!userInput.Equals("1") && !userInput.Equals("2") && !userInput.Equals("3") && !userInput.Equals("4") && !userInput.Equals("5"))
            {
                Console.WriteLine("Please choose a number:\n1. rock\n2. paper\n3. scissors\n4. lizard\n5. spock");
                userInput = Console.ReadLine();
            }
            int userInputAsInt = Convert.ToInt32(userInput);  
            return gestures[userInputAsInt - 1];
            
            
        }
    }
}
