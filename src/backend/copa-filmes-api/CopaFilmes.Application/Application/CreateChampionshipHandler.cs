using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CopaFilmes.Application.Core;
using CopaFilmes.Application.Domain;
using CopaFilmes.Application.Domain.Interfaces;
using MediatR;

namespace CopaFilmes.Application.Application
{
    public class CreateChampionshipHandler : IRequestHandler<CreateChampionship, Response>
    {
        private IChampionshipRules _championshipRules;
        private IMatchRules _matchRules;

        public CreateChampionshipHandler(IChampionshipRules championshipRules, IMatchRules matchRules)
        {
            _championshipRules = championshipRules;
            _matchRules = matchRules;
        }
        public Task<Response> Handle(CreateChampionship request, CancellationToken cancellationToken)
        {
            var championship = new Championship(_championshipRules, _matchRules);
            championship.StartChampionship(request.Movies);
            championship.PlayQuarterFinals();
            championship.PlaySemiFinals();
            championship.PlayFinals();

            return Task.FromResult(new Response(championship.Result));
        }
    }
}
