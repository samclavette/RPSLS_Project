using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        public string name;
        public int score = 0;
        public string chosenGesture;
        public List<string> gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock"};

        public Player()
        {
            
        }



        public abstract string ChooseGesture();
        
        
    }
}
