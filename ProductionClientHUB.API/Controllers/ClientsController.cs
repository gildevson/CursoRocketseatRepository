using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductionClientHUB.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClientsController : ControllerBase
{
    [HttpPost]

    public IActionResult Register()
    {
        return Ok();
    }

    [HttpPut]

    public IActionResult Update()
    {
        return Ok();
    }
    
    [HttpGet] 

    public IActionResult GetAll()
    {
        return Ok();
    }

    [HttpGet("By-id")]

    public IActionResult GetById(Guid id)
    {
        return Ok();
    }

    [HttpGet]
    [Route("{id}")]


    [HttpDelete]

    public IActionResult Delete()
    {
        return Ok();
    }   
}
