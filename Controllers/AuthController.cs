using dotnet_rpg.Data;
using dotnet_rpg.Dtos.User;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthRepository _authRepo;
    
    public AuthController(IAuthRepository authRepo)
    {
        _authRepo = authRepo;
    }

    [HttpPost("register")]
    public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegisterDto  request)
    {
        var response = await _authRepo.Register(
            new User { Username = request.Username }, request.Password
        );

        if (!response.Success)
        {
            if (string.IsNullOrWhiteSpace(response.Message)) response.Message = "Error during registration.";
            return BadRequest(response);
        }

        response.Message = "Registration successful";
        return Ok(response);
    }
}