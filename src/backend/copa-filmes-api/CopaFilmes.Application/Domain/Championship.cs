using System.Collections.Generic;
using System.Linq;
using CopaFilmes.Application.Domain.Interfaces;

namespace CopaFilmes.Application.Domain
{
    public class Championship
    {
        private readonly IChampionshipRules _championshipRules;
        private readonly IMatchRules _matchRules;

        public ChampionshipResult Result { get; set; }
        public List<Match> QuarterFinals { get; set; } = new List<Match>();
        public List<Match> SemiFinals { get; set; } = new List<Match>();
        public Match Finals { get; set; }

        public Championship(
            IChampionshipRules championshipRules,
            IMatchRules matchRules)
        {
            _championshipRules = championshipRules;
            _matchRules = matchRules;
        }

        public void StartChampionship(List<Movie> teams)
        {
            BuildQuarterFinals(teams);
        }

        private void BuildQuarterFinals(List<Movie> teams)
        {
            teams = _championshipRules.SortTeamsRule(teams);
            InitializePhase(QuarterFinals, 4);
            QuarterFinals = _championshipRules.QuarterFinalsRule(teams, QuarterFinals);
        }

        private void BuildSemiFinals()
        {
            InitializePhase(SemiFinals, 2);
            var qualifiedTeams = GetQualifiedTeams(QuarterFinals);
            SemiFinals = _championshipRules.SemifinalsRule(qualifiedTeams, SemiFinals);
        }

        private void InitializePhase(ICollection<Match> phase, int numberOfGames)
        {
            for (var i = 0; i < numberOfGames; i++)
            {
                phase.Add(new Match(_matchRules));
            }
        }

        private static List<Movie> GetQualifiedTeams(IEnumerable<Match> phase)
        {
            return phase.Select(match => match.Winner).ToList();
        }

        private void BuildFinals()
        {
            var qualifiedTeams = GetQualifiedTeams(SemiFinals);
            Finals = new Match(_matchRules) {HomeTeam = qualifiedTeams.First(), AwayTeam = qualifiedTeams.Last()};
        }

        public void PlayQuarterFinals()
        {
            PlayMatches(QuarterFinals);
            BuildSemiFinals();
        }

        public void PlaySemiFinals()
        {
            PlayMatches(SemiFinals);
            BuildFinals();
        }

        public void PlayFinals()
        {
            Finals.PlayMatch();
            Result = GetChampionshipResult();
        }

        private static void PlayMatches(IEnumerable<Match> matches)
        {
            foreach (var match in matches)
            {
                match.PlayMatch();
            }
        }

        private ChampionshipResult GetChampionshipResult()
        {
            return new ChampionshipResult
            {
                FirstPlace = Finals.Winner,
                SecondPlace = Finals.HomeTeam == Finals.Winner ? Finals.AwayTeam : Finals.HomeTeam
            };
        }
    }
}
