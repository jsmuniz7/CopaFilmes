using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CopaFilmes.Api.Model;
using CopaFilmes.Application.Application;
using CopaFilmes.Application.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CopaFilmes.Api.Features.Championship
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChampionshipController : ControllerBase
    {
        private IMediator _mediator;

        public ChampionshipController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        [Route("result")]
        public async Task<ActionResult<List<MovieResult>>> Result([FromBody] List<Movie> movies)
        {
            var response = await _mediator.Send(new CreateChampionship(movies));

            if (response.Errors.Any())
                return BadRequest(response.Errors);

            var championshipResult = (ChampionshipResult) response.Result;

            var moviesResult = new List<MovieResult>
            {
                new MovieResult {Position = 1, Title = championshipResult.FirstPlace.Titulo},
                new MovieResult {Position = 2, Title = championshipResult.SecondPlace.Titulo}
            };

            return Ok(moviesResult);
        }

    }
}
