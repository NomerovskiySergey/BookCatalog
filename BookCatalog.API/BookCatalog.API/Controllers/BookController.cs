
namespace BookCatalog.API.Controllers
{
    using System.Net;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class BookController : ControllerBase
    {
        [HttpPost]
        [Route("api/bookcatalog/book/create")]
        public IActionResult Create(ViewModel.BookVM book)
        {
            return StatusCode((int)HttpStatusCode.BadRequest);
        }

        [HttpDelete]
        [Route("api/bookcatalog/book/delete/{commaIds}")]
        public IActionResult Delete(string commaIds)
        {
            return StatusCode((int)HttpStatusCode.BadRequest);
        }

        [HttpGet]
        [Route("api/bookcatalog/book/get/{id}")]
        public IActionResult Get(int Id)
        {
            return StatusCode((int)HttpStatusCode.BadRequest);
        }

        [HttpPatch]
        [Route("api/bookcatalog/book/update/{id}")]
        public IActionResult UpdateBook(int id, ViewModel.BookVM data)
        {
            return StatusCode((int)HttpStatusCode.BadRequest);
        }
    }
}