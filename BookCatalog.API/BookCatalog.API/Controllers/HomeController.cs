namespace BookCatalog.API.Controllers
{
    using System;
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

        [HttpGet]
        [Route("api/bookcatalog/book/test")]
        public IActionResult Test()
        {
            throw new Exception("Test custom exception");
        }
    }
}