using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class SoccerPlayer
    {
        private string name;
        private string team;
        private decimal _MarketValueM;
        private string _position;

        public SoccerPlayer(string name, string team)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("emty name");
            this.name = name;
            setTeam(team);
        }

        public void setTeam(string team)
        {
            this.team = team;
        }
        public string getTeam()
        {
            return this.team;
        }

        public string getName() => name;

        public decimal MarketValueM
        {
            get { return _MarketValueM; }
            set { _MarketValueM = value; }
        }

        public string Position { get; set; }

        public override string ToString()
        {
            return "|name| " + name + " |team| " + team + " |market value| "
                + _MarketValueM + "m |position| " + Position;  
        }
    }
}
