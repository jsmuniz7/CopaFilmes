using System.Collections.Generic;
using CopaFilmes.Application.Core;
using CopaFilmes.Application.Domain;
using MediatR;

namespace CopaFilmes.Application.Application
{
    public class CreateChampionship : IRequest<Response>
    {
        public List<Movie> Movies { get; set; }

        public CreateChampionship(List<Movie> movies)
        {
            Movies = movies;
        }
    }
}
