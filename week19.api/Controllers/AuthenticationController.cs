using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using week19.application.Common.Interface;
using week19.application.DTO.UserDTO;

namespace week19.api.Controllers;

[ApiController]
public class AuthenticationController : ControllerBase
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly IAuthentication _authenticationManager;

    public AuthenticationController(UserManager<IdentityUser> userManager, IAuthentication authenticationManager)
    {
        _userManager = userManager;
        _authenticationManager = authenticationManager;
    }

    [HttpPost]
    [Route("/api/authenticate/register")]
    public async Task<ResponseDTO> Register([FromBody] UserRegisterRequestDTO model)
    {
        var result = await _authenticationManager.Register(model);
        return result;
    }

}
