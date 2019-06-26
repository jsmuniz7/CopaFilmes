using System.Collections.Generic;

namespace CopaFilmes.Application.Domain.Interfaces
{
    public interface IChampionshipRules
    {
        List<Movie> SortTeamsRule(List<Movie> teams);
        List<Match> QuarterFinalsRule(List<Movie> teams, List<Match> matches);
        List<Match> SemifinalsRule(List<Movie> teams, List<Match> matches);
    }
}
