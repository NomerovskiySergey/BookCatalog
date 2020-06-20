namespace BookCatalog.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Net;

    [ApiController]
    public class AuthorController : ControllerBase
    {
        [HttpPost]
        [Route("api/bookcatalog/author/create")]
        public IActionResult CreateAuthor(ViewModel.AuthorVM data)
        {
            return StatusCode((int)HttpStatusCode.BadRequest);
        }

        [HttpPatch]
        [Route("api/bookcatalog/author/edit/{id}")]
        public IActionResult Edit(int id, ViewModel.AuthorVM model)
        {
            return StatusCode((int)HttpStatusCode.BadRequest);
        }
        
        [HttpDelete]
        [Route("api/bookcatalog/author/edit/{commaIds}")]
        public IActionResult Delete(string commaIds)
        {
            return StatusCode((int)HttpStatusCode.BadRequest);
        }

        [HttpGet]
        [Route("api/bookcatalog/author/get/{id}")]
        public IActionResult Get(int id)
        {
            return StatusCode((int)HttpStatusCode.BadRequest);
        }
    }
}