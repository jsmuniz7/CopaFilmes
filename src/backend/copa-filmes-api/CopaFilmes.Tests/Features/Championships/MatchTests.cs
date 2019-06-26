using CopaFilmes.Application.Domain;
using CopaFilmes.Application.Domain.Interfaces;
using Moq;
using Shouldly;
using Xunit;
using Match = CopaFilmes.Application.Domain.Match;

namespace CopaFilmes.Tests.Features.Championships
{
    public class MatchTests
    {
        [Fact]
        public void Should_have_winner()
        {
            var homeMovie = new Movie();
            var awayMovie = new Movie();

            var mock = new Mock<IMatchRules>();
            mock.Setup(x => x.GameRule(homeMovie, awayMovie)).Returns(new Movie());

            var match = new Match(mock.Object)
            {
                HomeTeam = homeMovie,
                AwayTeam = awayMovie
            };

            match.PlayMatch();

            match.Winner.ShouldNotBeNull();
        }
    }
}
