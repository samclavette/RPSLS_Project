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
        
        public Gestures( string paper, string scissors, string lizard, string spock)
        {
            rock = "rock";
            this.paper = paper;
            this.scissors = scissors;
            this.lizard = lizard;
            this.spock = spock;
            List<string> gestureList = MakeGestureList();
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
    }
}
