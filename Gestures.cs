﻿using System;
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
        
        public Gestures(string rock, string paper, string scissors, string lizard, string spock)
        {
            this.rock = rock;
            this.paper = paper;
            this.scissors = scissors;
            this.lizard = lizard;
            this.spock = spock;
        }
    }
}
