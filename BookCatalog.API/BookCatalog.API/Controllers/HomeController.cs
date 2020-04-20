namespace BookCatalog.API.Controllers
{
    using System.Net;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("api/bookcatalog/grid/get")]
        public IActionResult LoadGridData()
        {
            return StatusCode((int)HttpStatusCode.BadRequest);
        }
    }
}