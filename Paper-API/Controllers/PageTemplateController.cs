using Microsoft.AspNetCore.Mvc;

namespace Paper.Controllers
{
    [Route("api/Template/Page")]
    [ApiController]
    public class PageTemplateController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllPages()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult PostPage()
        {
            return Ok();
        }

        [HttpDelete("{templateId}/Delete")]
        public IActionResult DeletePage([FromRoute] string templateId)
        {
            // Make sure they're the owner and shit further down...

            return Ok();
        }

        [HttpPost("{templateId}/Favourite")]
        public IActionResult FavouritePage([FromRoute] string templateId)
        {
            return Ok();
        }
    }
}
