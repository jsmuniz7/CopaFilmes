namespace CopaFilmes.Application.Domain.Interfaces
{
    public interface IMatchRules
    {
        Movie GameRule(Movie homeTeam, Movie awayTeam);
        Movie TieBreakRule(Movie homeTeam, Movie awayTeam);
    }
}
