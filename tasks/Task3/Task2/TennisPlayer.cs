﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class TennisPlayer : athlete
    {
        private string name;

        public TennisPlayer(string name)
        {
            this.name = name;
        }

        public string getDescription()
        {
            return name + ", TennisPlayer";
        }
    }
}
