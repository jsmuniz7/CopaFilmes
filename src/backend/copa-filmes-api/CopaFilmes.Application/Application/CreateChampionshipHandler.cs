using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CopaFilmes.Application.Core;
using CopaFilmes.Application.Domain;
using MediatR;

namespace CopaFilmes.Application.Application
{
    public class CreateChampionshipHandler : IRequestHandler<CreateChampionship, Response>
    {
        public Task<Response> Handle(CreateChampionship request, CancellationToken cancellationToken)
        {
            var championship = new Championship();
            championship.StartChampionship(request.Movies);
            championship.PlayQuarterFinals();
            championship.PlaySemiFinals();
            championship.PlayFinals();

            return Task.FromResult(new Response(championship.Result));
        }
    }
}
