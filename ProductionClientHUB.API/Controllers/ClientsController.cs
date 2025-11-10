using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductionClientHUB.Communication.Requests;
using ProductionClientHUB.Communication.Responses;
using ProductionClientHUB.Communication.UseCases.Clients.Register;

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

        var useCase = new RegisterClientUseCase();

        var response = useCase.Execute(request);

        useCase.Execute(request);   
        return Created(string.Empty, response); // Created é o código 201 precisa ter dois parâmetros no caso do Created
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
