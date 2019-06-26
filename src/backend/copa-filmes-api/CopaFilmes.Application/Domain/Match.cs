using CopaFilmes.Application.Domain.Interfaces;

namespace CopaFilmes.Application.Domain
{
    public class Match
    {
        private readonly IMatchRules _matchRules;

        public Movie HomeTeam { get; set; }
        public Movie AwayTeam { get; set; }
        public Movie Winner { get; set; }

        public Match(IMatchRules matchRules)
        {
            _matchRules = matchRules;
        }

        public void PlayMatch()
        {
            Winner = _matchRules.GameRule(HomeTeam, AwayTeam);
        }

    }
}
