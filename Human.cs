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

        public override void ChooseGesture()
        {

        }
    }
}
