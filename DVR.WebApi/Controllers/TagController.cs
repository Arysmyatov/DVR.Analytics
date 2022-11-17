using DVR.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace DVR.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class TagController  : Controller
    {
        [HttpGet("[action]")]
        public IActionResult Get()
        {
            var tags =  TagDescriptions.GetAllTagDescriptions().Select(t => new { Value = t.Name, Text = t.Name });
            return Ok(tags);
        }
    }
}