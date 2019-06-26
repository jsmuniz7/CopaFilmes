using System;
using System.Collections.Generic;
using System.Text;
using CopaFilmes.Application.Domain.Interfaces;

namespace CopaFilmes.Application.Domain
{
    public class MatchRules : IMatchRules
    {
        public Movie GameRule(Movie homeTeam, Movie awayTeam)
        {
            if (homeTeam.Nota > awayTeam.Nota)
                return homeTeam;

            return homeTeam.Nota < awayTeam.Nota ? awayTeam : TieBreakRule(homeTeam, awayTeam);
        }

        public Movie TieBreakRule(Movie homeTeam, Movie awayTeam)
        {
            return string.CompareOrdinal(homeTeam.Titulo, awayTeam.Titulo) < 0 ? homeTeam : awayTeam;
        }
    }
}
