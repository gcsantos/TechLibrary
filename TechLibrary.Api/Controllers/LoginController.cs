using Microsoft.AspNetCore.Mvc;
using TechLibrary.Api.UseCases.Login.DoLogin;
using TechLibrary.Communication.Request;
using TechLibrary.Communication.Responses;

namespace TechLibrary.Api.Controllers;
[Route("[controller]")]
[ApiController]
public class LoginController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredUserJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorMessagesJson), StatusCodes.Status401Unauthorized)]
    public IActionResult DoLogin(RequestLoginJson request) 
    {
        var useCase = new DoLoginUserCase();

        var response = useCase.Execute(request);

        return Ok(response);
    }
}
