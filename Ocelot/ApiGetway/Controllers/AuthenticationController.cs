using ApiGetway.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiGetway.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthenticationController : ControllerBase
{
    private readonly ITokenGenerationService _tokenGenerationService;
    
    public AuthenticationController(ITokenGenerationService tokenGenerationService)
    {
        _tokenGenerationService = tokenGenerationService;
    }
    
    [HttpGet]
    [AllowAnonymous]
    public ActionResult<string> Auth()
    {
        // Let's imagine that we are sending credentials like username
        return Ok(_tokenGenerationService.GenerateToken("Andy"));
    }
}