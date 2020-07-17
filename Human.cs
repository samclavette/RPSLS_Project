using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player
    {
        public Human(string name, int score, string chosenGesture)
        {
            this.name = name;
            score = 0;
            this.chosenGesture = chosenGesture;
        }

        public void ReceiveNameInput()
        {
            Console.WriteLine("Please enter your name: ");
            string nameInput = Console.ReadLine();
            name = nameInput;
        }

        public void ChooseGesture()
        {

        }
    }
}
