using NSubstitute;
using NUnit.Framework;
using StartippWebServer.Controllers;
using StartippWebServer.DataContext;
using StartippWebServer.Models;

namespace StartippWebServer.Tests.Controllers
{
    public class TournamentControllerTest
    {
        private TournamentsController _systemUnderTest;
        private IStartippDb _database;

        [SetUp]
        public void SetUp()
        {
            _database = Substitute.For<IStartippDb>();
            _systemUnderTest = new TournamentsController(_database);
        }

        [TearDown]
        public void TearDown()
        {
            _systemUnderTest.Dispose();
        }

        [Test]
        public void Test_GetTournaments()
        {
            //Arrange
            var expected = new TestDbSet<Tournament> {new Tournament(), new Tournament(), new Tournament()};
            _database.Tournaments.Returns(expected);

            //Assert
            Assert.That(() => _systemUnderTest.GetTournaments(), Is.EqualTo(expected));
        }
    }
}
