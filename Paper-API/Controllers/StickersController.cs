using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Paper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StickersController : ControllerBase
    {
        [HttpGet]
        public IActionResult LoadStickers()
        {
            return Ok();
        }
    }
}
