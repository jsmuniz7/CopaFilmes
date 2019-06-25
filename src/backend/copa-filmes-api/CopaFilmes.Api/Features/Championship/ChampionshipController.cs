using System.Collections.Generic;
using System.Linq;
using CopaFilmes.Api.Model;
using CopaFilmes.Application.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CopaFilmes.Api.Features.Championship
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChampionshipController : ControllerBase
    {
        [HttpPost]
        [Route("result")]
        public ActionResult<List<MovieResult>> Result([FromBody] List<Movie> movies)
        {
            var championshipResult = new List<MovieResult>
            {
                new MovieResult {Title = movies.First().Titulo, Position = 1},
                //new MovieResult {Title = movies.Last().Titulo, Position = 2}
            };

            return Ok(championshipResult);
        }

        [HttpGet]
        [Route("getvalue")]
        public ActionResult<int> GetValue()
        {
            return Ok(1);
        }
    }
}
