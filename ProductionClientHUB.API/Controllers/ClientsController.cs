using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductionClientHUB.Communication.Requests;
using ProductionClientHUB.Communication.Responses;
using ProductionClientHUB.Communication.UseCases.Clients.Register;
using ProductionClientHUB.Exception.ExceptionsBase;

namespace ProductionClientHUB.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClientsController : ControllerBase
{
    [HttpPost]
   // [ProducesResponseType(typeof(ResponseClientJson), 201] é mesma coisa 

    [ProducesResponseType(typeof(ResponseClientJson), StatusCodes.Status201Created)] // versão recomendada
    [ProducesResponseType(typeof(ResponseErrorMessagesJson), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RequestClientJson request) // vai receber os dados do corpo da requisição
    {

        try { // dentro do executa que esta abaixo
            var useCase = new RegisterClientUseCase();

            var response = useCase.Execute(request);

            useCase.Execute(request);
            return Created(string.Empty, response); // Created é o código 201 precisa ter dois parâmetros no caso do Created

        }
        
        catch (ProductClientHubException ex) // se não conseguir se alguma execção cai no catch Exception clasxse de exeções
        {
            return BadRequest(new ResponseErrorMessagesJson(ex.Message)); // BadRequest é o código 400 ele tambem puxa o ex.message como parametro
        }

        catch {

            return StatusCode(StatusCodes.Status500InternalServerError, new ResponseErrorMessagesJson("Erro Desconhecido")); 
            // 500
            // sempre que recever uuma exessão quando não tiver tratamento colcoar erro desconhecido
        }


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
