using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Gestures
    {
        public string rock;
        public string paper;
        public string scissors;
        public string lizard;
        public string spock;
        public List<string> gestureList;
        
        public Gestures()
        {
            rock = "rock";
            paper = "paper";
            scissors = "scissors";
            lizard = "lizard";
            spock = "spock";
            gestureList = MakeGestureList();
        }

        public List<string> MakeGestureList()
        {
            List<string> tempGestureList = new List<string>();
            tempGestureList.Add(rock);
            tempGestureList.Add(paper);
            tempGestureList.Add(scissors);
            tempGestureList.Add(lizard);
            tempGestureList.Add(spock);
            return tempGestureList;
        }

        public void ChooseRandomGesture()
        {
            Random rand = new Random();
        }
    }
}
