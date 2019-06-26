using System.Collections.Generic;
using CopaFilmes.Application.Domain;
using Shouldly;
using Xunit;
using Movie = CopaFilmes.Application.Domain.Movie;

namespace CopaFilmes.Tests.Features.Championships
{
    public class ChampionshipTests
    {

        [Fact]
        public void Test_championship()
        {
            var championship = new Championship(new ChampionshipRules(), new MatchRules());

            var movie1 = new Movie {Titulo = "Os Incríveis 2", Nota = 8.5};
            var movie2 = new Movie { Titulo = "Jurassic World: Reino Ameaçado", Nota = 6.7 };
            var movie3 = new Movie { Titulo = "Oito Mulheres e um Segredo", Nota = 6.3 };
            var movie4 = new Movie { Titulo = "Hereditário", Nota = 7.8 };
            var movie5 = new Movie { Titulo = "Vingadores: Guerra Infinita", Nota = 8.8 };
            var movie6 = new Movie { Titulo = "Deadpool 2", Nota = 8.1 };
            var movie7 = new Movie { Titulo = "Han Solo: Uma História Star Wars", Nota = 7.2 };
            var movie8 = new Movie { Titulo = "Thor: Ragnarok", Nota = 7.9 };

            var teams = new List<Movie> {movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8};

            championship.StartChampionship(teams);
            championship.PlayQuarterFinals();
            championship.PlaySemiFinals();
            championship.PlayFinals();
            
            championship.Result.FirstPlace.ShouldBe(movie5);
            championship.Result.SecondPlace.ShouldBe(movie1);
        }

    }
}
