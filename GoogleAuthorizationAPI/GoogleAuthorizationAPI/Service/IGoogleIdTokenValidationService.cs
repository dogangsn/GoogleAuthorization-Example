using GoogleAuthorizationAPI.Dto;

namespace GoogleAuthorizationAPI.Service
{
    public interface IGoogleIdTokenValidationService
    {
        public Task<TokenDto> ValidateIdTokenAsync(GoogleLoginVMDto model);
    }
}
