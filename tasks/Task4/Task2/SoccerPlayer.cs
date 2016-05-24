using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class SoccerPlayer : athlete
    {
        private string name;
        private string team;
        private decimal _MarketValueM;

        public string getDescription()
        {
            return name + ", SoccerPlayer";
        }

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
            set {
                if (value < 0)
                    throw new Exception("market value has to be positiv");
                _MarketValueM = value;
            }
        }

        public string Position { get; set; }

        public override string ToString()
        {
            return "|name| " + name + " |team| " + team + " |market value| "
                + _MarketValueM + "m |position| " + Position;  
        }
    }
}
