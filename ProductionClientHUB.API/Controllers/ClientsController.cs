using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductionClientHUB.Communication.Requests;
using ProductionClientHUB.Communication.Responses;

namespace ProductionClientHUB.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClientsController : ControllerBase
{
    [HttpPost]
   // [ProducesResponseType(typeof(ResponseClientJson), 201] é mesma coisa 

    [ProducesResponseType(typeof(ResponseClientJson), StatusCodes.Status201Created)] // versão recomendada

    public IActionResult Register([FromBody] RequestClientJson request) // vai receber os dados do corpo da requisição
    {
        return Created();
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

    public IActionResult GetById([FromRouteAttribute]Guid id)
    {
        return Ok();
    }



    [HttpDelete]

    public IActionResult Delete()
    {
        return Ok();
    }   
}
