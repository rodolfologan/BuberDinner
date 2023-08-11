using Microsoft.AspNetCore.Mvc;
using BuberDinner.Contracts.Authentication;
using BuberDinner.Aplication.Services.Authentication;

namespace BuberDinner.Api.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticaionService _authenticationService;

    public AuthenticationController(IAuthenticaionService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [HttpPost("register")]
    public IActionResult Resgister(RegisterRequest request)
    {
        var register = _authenticationService.Register(request.FirstName, request.LastName, request.Email, request.Password);
        var response = new AuthenticationResponse(
            register.Id,
            register.FirstName,
            register.LastName,
            register.Email,
            register.Token
        );
        return Ok(response);
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)     {
        var register = _authenticationService.Login(request.Email, request.Password);
        var response = new AuthenticationResponse(
            register.Id,
            register.FirstName,
            register.LastName,
            register.Email,
            register.Token
        );
        return Ok(response);
    }

}