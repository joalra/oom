using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading;

namespace Task2
{
    public static class pushWithSubject
    {
        public static void Run()
        {
            var source = new Subject<SoccerPlayer>();

            //subscribe on all Players from Team 1:
            source
                //.Sample(TimeSpan.FromSeconds(1.0))
                .Where(x => x.getTeam() == "Team 1")
                .Subscribe(x => Console.WriteLine($"received<- {x.getName()} {x.getTeam()}"))
                ;

            var t = new Thread(() =>
            {
                var i = 0;
                while (i < 10)
                {
                    Thread.Sleep(250);
                    SoccerPlayer s = new SoccerPlayer("Player " + i, "Team " + i%3);
                    source.OnNext(s);
                    Console.WriteLine($"sent-> {s.getName()} {s.getTeam()}");
                    i++;
                }
            });
            t.Start();
        }
    }
}
