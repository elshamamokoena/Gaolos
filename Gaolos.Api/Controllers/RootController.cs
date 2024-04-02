using Gaolos.Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gaolos.Api.Controllers;

[Route("api")]
[ApiController]
public class RootController : ControllerBase
{
    [HttpGet(Name = "GetRoot")]
    public IActionResult GetRoot()
    { 
        // create links for root
        var links = new List<LinkDto>();

        links.Add(
          new(Url.Link("GetRoot", new { }),
          "self",
          "GET"));

        links.Add(
          new(Url.Link("GetCategories", new { }),
          "categories",
          "GET"));

 

        return Ok(links);
    }
}