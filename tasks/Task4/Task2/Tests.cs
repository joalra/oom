using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task2
{
    [TestFixture]
    class Tests /*---T4.3 8 Unit Tests----*/
    {
        /*-------SoccerPlayer------------------*/
        [Test]
        public void SoccerPlayerNameReturnsSameValueUsedForInitialization()
        {
            var x = new SoccerPlayer("Test Player", "TestTeam");
            Assert.IsTrue(x.getName() == "Test Player");
        }

        [Test]
        public void CannotCreateSoccerPlayerWithEmptyName()
        {
            Assert.Catch(() =>
            {
                var x = new SoccerPlayer("", "");
            });

        }

        [Test]
        public void SoccerPlayerDescriptionIsCorrect()
        {
            var x = new SoccerPlayer("Test Player", "");
            Assert.IsTrue(x.getDescription() == "Test Player, SoccerPlayer");
        }

        [Test]
        public void SoccerPlayerConnotSetNegativeMarketValue()
        {
            Assert.Catch(() =>
            {
                var x = new SoccerPlayer("Test Player", "");
                x.MarketValueM = -1;
            });

        }
        public void SoccerPlayerPositionReturnsSameValueAsSet()
        {
            var x = new SoccerPlayer("Test Player", "TestTeam");
            x.Position = "Test Position";
            Assert.IsTrue(x.Position == "Test Position");
        }
        /*-----------------------------------*/

        /*-------TennisPlayer----------------*/
        [Test]
        public void TennisPlayerNameReturnsSameValueUsedForInitialization()
        {
            var x = new TennisPlayer("Test Player");
            Assert.IsTrue(x.getName() == "Test Player");
        }
        [Test]
        public void CannotCreateTennisPlayerWithEmptyName()
        {
            Assert.Catch(() =>
            {
                var x = new TennisPlayer("");
            });

        }
        [Test]
        public void TennisPlayerDescriptionIsCorrect()
        {
            var x = new TennisPlayer("Test Player");
            Assert.IsTrue(x.getDescription() == "Test Player, TennisPlayer");
        }
        /*----------------------------------*/
    }
}
