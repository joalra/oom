using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            SoccerPlayer origi = new SoccerPlayer("Divock Origi", "");
            origi.setTeam("Liverpool FC");
            origi.MarketValueM = 9;
            origi.Position = "Forward";
            Console.WriteLine(origi);

        }
    }
}
