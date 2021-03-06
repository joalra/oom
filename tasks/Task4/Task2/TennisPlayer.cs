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

        public TennisPlayer(string name, string nation, int worldRank)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("emty name");

            Name = name;
            Nation = nation;
            WorldRank = worldRank;
        }

        public string Name { get; set; }
        public string Nation { get; set; }
        public int WorldRank { get; set; }

        public string getDescription()
        {
            return name + ", TennisPlayer";
        }

        public string getName() => name;
    }
}
