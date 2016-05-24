using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class GolfPlayer
    {
        public GolfPlayer(string name, string nation, int worldRank)
        {
            Name = name;
            Nation = nation;
            WorldRank = worldRank;
        }
        public string Name { get; set; }
        public string Nation { get; set; }
        public int WorldRank { get; set; }
    }
}
