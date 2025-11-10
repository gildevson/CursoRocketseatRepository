## 🛠️ Criando uma Controller em ASP.NET Core Web API

Este código define uma **API Controller** chamada `ClientsController`, que é responsável por lidar com as requisições HTTP para a gestão de recursos relacionados a "Clientes" (`Clients`).

### 🔑 Componentes Principais

| Elemento | Descrição |
| :--- | :--- |
| `using Microsoft.AspNetCore.Mvc;` | Importa as classes necessárias para criar Controllers, como `ControllerBase` e os atributos de roteamento. |
| `[Route("api/[controller]")]` | Define o **template da rota** para todos os _actions_ nesta Controller. `[controller]` será substituído automaticamente pelo nome da Controller (sem o sufixo `Controller`), resultando em `/api/clients`. |
| `[ApiController]` | Adiciona comportamentos importantes para APIs, como roteamento de atributos, validação automática de modelos e formatação de erros. |
| `public class ClientsController : ControllerBase` | Declara a classe. Herdar de **`ControllerBase`** é o padrão para Controllers de API sem suporte a Views. |

---

### 🌐 Endpoints (Rotas HTTP)

O código define vários métodos (_Action Methods_) que respondem a diferentes **verbos HTTP**, criando os **endpoints** da sua API para operações CRUD (Create, Read, Update, Delete) de Clientes.

| Verbo HTTP | Método | Rota Exemplo | Propósito |
| :--- | :--- | :--- | :--- |
| `[HttpPost]` | `Register()` | `POST /api/clients` | **CREATE**: Usado para criar um novo recurso (Cliente). |
| `[HttpPut]` | `Update()` | `PUT /api/clients` | **UPDATE**: Usado para atualizar um recurso existente. |
| `[HttpGet]` | `GetAll()` | `GET /api/clients` | **READ**: Usado para listar todos os recursos. |
| `[HttpGet("By-id")]` | `GetById(Guid id)` | `GET /api/clients/By-id?id=...` | **READ**: Uma forma de buscar um recurso específico por ID, usando uma rota personalizada. O ID seria passado como _Query Parameter_ ou Segmento de Rota. |
| `[HttpGet]` `[Route("{id}")]` | `Delete()` | `GET /api/clients/{id}` | **READ**: Exemplo de roteamento via template para buscar por ID, onde `{id}` é o parâmetro na rota. |
| `[HttpDelete]` | `Delete()` | `DELETE /api/clients/{id}` | **DELETE**: **A forma correta** para deletar um recurso específico. Embora haja dois métodos `Delete()` no código, apenas um com o verbo `[HttpDelete]` é o padrão RESTful para exclusão. |

#### ℹ️ Retorno Padrão

Todos os métodos estão retornando **`Ok()`**. Em ASP.NET Core, `Ok()` é um `IActionResult` que resulta em uma resposta HTTP com o **código de status 200 (OK)**, indicando que a requisição foi bem-sucedida. Em uma 
aplicação real, você retornaria dados ou códigos de status mais específicos (e.g., 201 Created, 404 Not Found).

#### ℹ️  Pastas 

Vamos ter as pastas RESPONSE E REQUESTS.

Resquest: todos os dados que vamos receber em nossa API.(REQUEST É QUE API RECEBE )
Response: Aqui vai ter todos dados que vai ter como resposta.(RESPONSE QUE API RESPONDE)
***


Este código é um **esqueleto básico** para construir a camada de entrada de uma aplicação RESTful, onde a `ClientsController` atua como a ponte entre as requisições HTTP e a lógica de negócios da sua aplicação..
