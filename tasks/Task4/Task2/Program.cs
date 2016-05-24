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
            /*Taks 2*/
            SoccerPlayer origi = new SoccerPlayer("Divock Origi", "Liverpool U21");
            origi.Position = "Forward";
            Console.WriteLine(origi);
            origi.setTeam("Liverpool FC");
            origi.MarketValueM = 9;
            Console.WriteLine(origi);

            /*Task 3*/
            var athletes = new athlete[]
            {
                new SoccerPlayer("Gilbert Prilassnig", "SK Sturm Graz"),
                new SoccerPlayer("Dieter Ramusch", "GAK"),
                new TennisPlayer("Björn Borg"),
                new TennisPlayer("Yevgeny Kafelnikov")
            };
            
            foreach(var a in athletes)
            {
                Console.WriteLine(a.getDescription());
            }
            /*-------------*/

        }
    }
}
