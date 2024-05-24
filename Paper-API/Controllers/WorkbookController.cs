using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Paper.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class WorkbookController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetWorkbooks()
        {
            return Ok();
        }

        [HttpGet("Book")] // TODO: Make this a route request?
        public IActionResult GetWorkbook([FromQuery]string workbookId)
        { 
            return Ok(); // This would return the stored payload of the individual workbook. 
        }

        [HttpPut("Book")] // TODO: Make this a route request?
        public IActionResult SyncWorkbook([FromQuery]string workbookId) // Here we will need to add a payload of what needs to be stored. IE, the vector spaces etc
        {
            // This will sync the _whole_ workbook at once, allowing us to store the data in one fell swoop. (PUT OP)

            return Ok();
        }

        [HttpDelete("Book")] // TODO: Make this a route request?
        public IActionResult DeleteWorkbook([FromQuery] string workbookId) // Here we will need to add a payload of what needs to be stored. IE, the vector spaces etc
        {
            // This will be a _SOFT_ delete.

            return Ok();
        }
    }
}
