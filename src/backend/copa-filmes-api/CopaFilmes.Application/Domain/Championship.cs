using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CopaFilmes.Application.Domain
{
    public class Championship
    {
        public ChampionshipResult Result { get; set; }
        public List<Match> QuarterFinals { get; set; } = new List<Match>();
        public List<Match> SemiFinals { get; set; } = new List<Match>();
        public Match Finals { get; set; }

        public void StartChampionship(List<Movie> teams)
        {
            BuildQuarterFinals(teams);
        }

        private void BuildQuarterFinals(List<Movie> teams)
        {
            teams = teams.OrderBy(x => x.Titulo).ToList();

            InitializePhase(QuarterFinals, 4);

            foreach (var match in QuarterFinals)
            {
                match.HomeTeam = teams.First();
                match.AwayTeam = teams.Last();

                teams.Remove(teams.First());
                teams.Remove(teams.Last());
            }
        }

        private void BuildSemiFinals()
        {
            InitializePhase(SemiFinals, 2);
            var qualifiedTeams = new List<Movie>();

            foreach (var match in QuarterFinals)
            {
                qualifiedTeams.Add(match.Winner);
            }

            foreach (var match in SemiFinals)
            {
                match.HomeTeam = qualifiedTeams.First();
                qualifiedTeams.Remove(qualifiedTeams.First());

                match.AwayTeam = qualifiedTeams.First();
                qualifiedTeams.Remove(qualifiedTeams.First());
            }
        }

        private void BuildFinals()
        {
            Finals = new Match();
            var qualifiedTeams = new List<Movie>();

            foreach (var match in SemiFinals)
            {
                qualifiedTeams.Add(match.Winner);
            }

            Finals.HomeTeam = qualifiedTeams.First();
            Finals.AwayTeam = qualifiedTeams.Last();

        }

        public void PlayQuarterFinals()
        {
            foreach (var match in QuarterFinals)
            {
                match.PlayMatch();
            }

            BuildSemiFinals();
        }

        public void PlaySemiFinals()
        {
            foreach (var match in SemiFinals)
            {
                match.PlayMatch();
            }

            BuildFinals();
        }

        public void PlayFinals()
        {
            Finals.PlayMatch();

            Result = new ChampionshipResult
            {
                FirstPlace = Finals.Winner,
                SecondPlace = Finals.HomeTeam == Finals.Winner ? Finals.AwayTeam : Finals.HomeTeam
            };
        }

        private static void InitializePhase(ICollection<Match> phase, int numberOfGames)
        {
            for (var i = 0; i < numberOfGames; i++)
            {
                phase.Add(new Match());
            }
        }


    }
}
