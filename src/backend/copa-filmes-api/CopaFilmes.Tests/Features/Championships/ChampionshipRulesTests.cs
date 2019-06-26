using System.Collections.Generic;
using System.Linq;
using CopaFilmes.Application.Domain;
using CopaFilmes.Application.Domain.Interfaces;
using Moq;
using Shouldly;
using Xunit;
using Match = CopaFilmes.Application.Domain.Match;

namespace CopaFilmes.Tests.Features.Championships
{
    public class ChampionshipRulesTests
    {
        [Fact]
        public void Test_sort_teams_rule()
        {
            var teamA = new Movie { Titulo = "A", Nota = 10 };
            var teamB = new Movie { Titulo = "B", Nota = 10 };
            var teamC = new Movie { Titulo = "C", Nota = 10 };

            var teams = new List<Movie> {teamC, teamB, teamA};

            var championshipRules = new ChampionshipRules();

            var orderedTeams = championshipRules.SortTeamsRule(teams);

            orderedTeams.First().ShouldBe(teamA);
            orderedTeams.Last().ShouldBe(teamC);
        }

        [Fact]
        public void Test_quarter_finals_rule()
        {
            var teamA = new Movie { Titulo = "A"};
            var teamB = new Movie { Titulo = "B" };
            var teamC = new Movie { Titulo = "C" };
            var teamD = new Movie { Titulo = "D" };
            var teamE = new Movie { Titulo = "E" };
            var teamF = new Movie { Titulo = "F" };
            var teamG = new Movie { Titulo = "G" };
            var teamH = new Movie { Titulo = "H" };

            var mock = new Mock<IMatchRules>();

            var teams = new List<Movie> { teamA, teamB, teamC, teamD, teamE, teamF, teamG, teamH };
            var quarterFinals = new List<Match>
            {
                new Match(mock.Object),
                new Match(mock.Object),
                new Match(mock.Object),
                new Match(mock.Object)
            };

            var matches = new ChampionshipRules().QuarterFinalsRule(teams, quarterFinals);

            matches[0].HomeTeam.ShouldBe(teamA);
            matches[0].AwayTeam.ShouldBe(teamH);
            matches[1].HomeTeam.ShouldBe(teamB);
            matches[1].AwayTeam.ShouldBe(teamG);
            matches[2].HomeTeam.ShouldBe(teamC);
            matches[2].AwayTeam.ShouldBe(teamF);
            matches[3].HomeTeam.ShouldBe(teamD);
            matches[3].AwayTeam.ShouldBe(teamE);
        }

        [Fact]
        public void Test_semi_finals_rule()
        {
            var teamA = new Movie { Titulo = "A" };
            var teamB = new Movie { Titulo = "B" };
            var teamC = new Movie { Titulo = "C" };
            var teamD = new Movie { Titulo = "D" };

            var teams = new List<Movie> { teamA, teamB, teamC, teamD };

            var mock = new Mock<IMatchRules>();

            var semiFinals = new List<Match>
            {
                new Match(mock.Object),
                new Match(mock.Object)
            };

            var matches = new ChampionshipRules().SemifinalsRule(teams, semiFinals);

            matches[0].HomeTeam.ShouldBe(teamA);
            matches[0].AwayTeam.ShouldBe(teamB);
            matches[1].HomeTeam.ShouldBe(teamC);
            matches[1].AwayTeam.ShouldBe(teamD);
        }

    }
}
