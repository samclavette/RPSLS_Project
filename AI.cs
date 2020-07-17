using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class AI : Player
    {
        public AI()
        {
            Random rand = new Random();

            public AI(string name, int score, string chosenGesture)
            {
                name = "Computer";
                score = 0;
            }

            public void ChooseRandomGesture()
            {

            }
        }
    }
}
