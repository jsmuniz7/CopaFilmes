using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CopaFilmes.Api.Features.Championship
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChampionshipController : ControllerBase
    {
        [HttpGet]
        public int GetValues()
        {
            return 1;
        }
    }
}
