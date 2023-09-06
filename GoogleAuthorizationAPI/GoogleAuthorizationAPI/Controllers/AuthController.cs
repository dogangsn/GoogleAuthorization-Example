using GoogleAuthorizationAPI.Dto;
using GoogleAuthorizationAPI.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace GoogleAuthorizationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        readonly IGoogleIdTokenValidationService _googleIdTokenValidationService;
        public AuthController(IGoogleIdTokenValidationService googleIdTokenValidationService)
        {
            _googleIdTokenValidationService = googleIdTokenValidationService;
        }

        [HttpPost]
        public async Task<IActionResult> Login(GoogleLoginVMDto model)
        {
            TokenDto token = await _googleIdTokenValidationService.ValidateIdTokenAsync(model);
            return Ok(token);
        }
    }
}
