using System.Collections.Generic;
using System.Linq;
using CopaFilmes.Application.Domain.Interfaces;

namespace CopaFilmes.Application.Domain
{
    public class ChampionshipRules : IChampionshipRules
    {
        public List<Movie> SortTeamsRule(List<Movie> teams)
        {
            return teams.OrderBy(x => x.Titulo).ToList();
        }

        public List<Match> QuarterFinalsRule(List<Movie> teams, List<Match> matches)
        {
            foreach (var match in matches)
            {
                match.HomeTeam = teams.First();
                match.AwayTeam = teams.Last();

                teams.Remove(teams.First());
                teams.Remove(teams.Last());
            }

            return matches;
        }

        public List<Match> SemifinalsRule(List<Movie> teams, List<Match> matches)
        {
            foreach (var match in matches)
            {
                match.HomeTeam = teams.First();
                teams.Remove(teams.First());

                match.AwayTeam = teams.First();
                teams.Remove(teams.First());
            }

            return matches;
        }
    }
}
