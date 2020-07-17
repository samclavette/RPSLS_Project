using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class AI : Player
    {

            Random rand = new Random();

            public AI()
            {
                name = "Computer";
            }

            public override string ChooseGesture()
            {
                rand = new Random();
                int randomNumber = rand.Next(5);
                return gestures[randomNumber];          
            }
        
    }
}
