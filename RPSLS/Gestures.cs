using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Gestures
    {
        public string type;
        Gestures rock;
        Gestures paper;
        Gestures scissors;
        Gestures lizard;
        Gestures spock;
        List<Gestures> gestureList = new List<Gestures>();
        
        public Gestures(string type)
        {
            rock = new Gestures("rock");
            paper = new Gestures("paper");
            scissors = new Gestures ("scissors");
            lizard = new Gestures ("lizard");
            spock = new Gestures ("spock");
            gestureList = MakeGestureList();
        }

        public List<Gestures> MakeGestureList()
        {
            List<Gestures> tempGestureList = new List<Gestures>();
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
