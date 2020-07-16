using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Gestures testGesture = new Gestures();
            List<Player> players = new List<Player>();
            Human human = new Human("holla at ya boy", 0, "yo");
            AI ai = new AI();
            players.Add(human);
            players.Add(ai);


        }
    }
}
