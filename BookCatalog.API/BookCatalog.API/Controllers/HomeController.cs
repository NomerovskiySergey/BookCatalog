using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using BookCatalog.Service;

namespace BookCatalog.API.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        private IDataProvider _dataprovider;
        public HomeController(IDataProvider provider)
        {
            _dataprovider = provider;
        }

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

            throw new Exception(_dataprovider.Get()) ;
        }
    }
}