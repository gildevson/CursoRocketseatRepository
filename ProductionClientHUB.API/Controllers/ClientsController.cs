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

    [HttpGet]
    [Route("{id}/gilson/{sobrenome}")]

    public IActionResult GetById(Guid id, string sobrenome)
    {
        return Ok();
    }



    [HttpDelete]

    public IActionResult Delete()
    {
        return Ok();
    }   
}
