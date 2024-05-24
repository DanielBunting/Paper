using Microsoft.AspNetCore.Mvc;

namespace Paper.Controllers
{
    [Route("api/Template/Workbook")]
    [ApiController]
    public class WorkbookTemplateController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllTemplates() 
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult PostTemplate()
        {
            return Ok();
        }

        [HttpDelete("{templateId}/Delete")]
        public IActionResult DeleteTemplate([FromRoute]string templateId) 
        {
            // Make sure they're the owner and shit further down...

            return Ok();
        }

        [HttpPost("{templateId}/Favourite")]
        public IActionResult FavouriteTemplate([FromRoute]string templateId)
        { 
            return Ok();
        }
    }
}
