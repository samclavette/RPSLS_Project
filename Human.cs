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
            Console.WriteLine("Please enter your name: ");
            string nameInput = Console.ReadLine();
            return nameInput;
        }

        public override string ChooseGesture()
        {
            Console.WriteLine("Please choose a number:\n1. rock\n2. paper\n3. scissors\n4. lizard\n5. spock");
            int userInput = Convert.ToInt32(Console.ReadLine());
            return gestures[userInput-1];
        }
    }
}
