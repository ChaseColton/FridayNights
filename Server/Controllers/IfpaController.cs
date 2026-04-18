using Microsoft.AspNetCore.Mvc;
using BlazorApp.Shared;
using IfpaHosted.Server.Services;


namespace Server.Controllers
{
    [ApiController]
    [Route("api/ifpa")]
    public class IfpaController : ControllerBase
    {
        private readonly IfpaService _ifpa;

        public IfpaController(IfpaService ifpa)
        {
            _ifpa = ifpa;
        }

        [HttpGet("rankings")]
        public async Task<List<IfpaPlayerRanking>> GetRankings()
        {
            return await _ifpa.GetRankings();
        }
    }


    //[ApiController]
    //[Route("api/ifpa")]
    //public class IfpaController : ControllerBase
    //{
    //    [HttpGet("rankings")]
    //    public IActionResult GetRankings()
    //    {
    //        return Ok(new[] { "Test1", "Test2" });
    //    }
    //}

}