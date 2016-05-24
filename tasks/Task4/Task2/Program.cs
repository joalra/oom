using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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

            foreach (var a in athletes)
            {
                Console.WriteLine(a.getDescription());
            }
            /*-------------*/

            /*---Task 4.3 JSON --------*/
            var golfPlayers = new GolfPlayer[]
            {
                new GolfPlayer("Tiger Woods", "USA", 1),
                new GolfPlayer("Jordan Spieth", "NED", 2),
                new GolfPlayer("Happy Gilmore", "USA", 200),
            };

            string json = JsonConvert.SerializeObject(golfPlayers, Formatting.Indented);

            Console.Write(json);
            System.IO.File.WriteAllText("golf_players.json", json);

            string json2 = System.IO.File.ReadAllText("golf_players.json");
            var golfPlayers2 = JsonConvert.DeserializeObject<GolfPlayer[]> (json);
            Console.WriteLine(golfPlayers2[0].Name);

            /*-----------*/
        }
    }
}
