using CopaFilmes.Application.Domain;
using Shouldly;
using Xunit;

namespace CopaFilmes.Tests.Features.Championships
{
    public class MatchRulesTests
    {
        [Fact]
        public void Test_game_rule()
        {
            var homeTeam = new Movie {Nota = 10};
            var awayTeam = new Movie {Nota = 9};
            var matchRules = new MatchRules();

            var winnerTeam = matchRules.GameRule(homeTeam, awayTeam);

            winnerTeam.ShouldBe(homeTeam);
        }

        [Fact]
        public void Test_tie_break_rule()
        {
            var homeTeam = new Movie { Titulo = "A" };
            var awayTeam = new Movie { Titulo = "B" };
            var matchRules = new MatchRules();

            var winnerTeam = matchRules.TieBreakRule(homeTeam, awayTeam);

            winnerTeam.ShouldBe(homeTeam);
        }

        [Fact]
        public void Test_game_rule_with_tie()
        {
            var homeTeam = new Movie { Titulo = "A", Nota = 10};
            var awayTeam = new Movie { Titulo = "B", Nota = 10 };
            var matchRules = new MatchRules();

            var winnerTeam = matchRules.TieBreakRule(homeTeam, awayTeam);

            winnerTeam.ShouldBe(homeTeam);
        }
    }
}
