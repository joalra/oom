using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Threading;


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
                new TennisPlayer("Björn Borg","",1),
                new TennisPlayer("Yevgeny Kafelnikov","",1)
            };

            foreach (var a in athletes)
            {
                Console.WriteLine(a.getDescription());
            }
            /*-------------*/

            /*---Task 4.3 JSON serial--------*/
            var players = new athlete[]
            {
                new GolfPlayer("Tiger Woods", "USA", 1),
                new GolfPlayer("Jordan Spieth", "NED", 2),
                new GolfPlayer("Happy Gilmore", "USA", 200),
                new TennisPlayer("Björn Borg","",1),
                new TennisPlayer("Yevgeny Kafelnikov","",1)
            };

            var settings = new JsonSerializerSettings() { Formatting = Formatting.Indented, TypeNameHandling = TypeNameHandling.Auto };

            string json = JsonConvert.SerializeObject(players, settings);

            Console.Write(json);
            System.IO.File.WriteAllText("players.json", json);

            string json2 = System.IO.File.ReadAllText("players.json");
    
            var players2 = JsonConvert.DeserializeObject<athlete[]> (json2,settings);
            Console.WriteLine(players2[0].getDescription());

            /*-----------*/

            /*----Task6.2--Experiment with tasks--*/
            Task<int> callback = Task.Run(() =>
            {
                Thread.Sleep(2000);
                return 42;
            });

            //Console.WriteLine(futureInt.Result); //blockierend

            var f2 = callback.ContinueWith(x => Console.WriteLine("callback executed: " + x.Result));

            var cnt = 0;
            while (cnt++ < 6)
            {
                Console.WriteLine("do something else...");
                Thread.Sleep(500);
            }
            /*-------------- */

            /*----Task 6.1--Pushing/Subscribe with query---*/
            Console.WriteLine();
            pushWithSubject.Run();
            /*------------*/

        }
    }
}
