using DVR.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace DVR.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class StatisticController : Controller
    {        
        private readonly ITagResultsService tagResultsService;

        public StatisticController(ITagResultsService tagResultsService)
        {
            this.tagResultsService = tagResultsService;
        }

        [HttpGet("[action]")]
        public IActionResult Get()
        {
            var results = tagResultsService.GetResults();
            return Ok(results);
        }
    }
}