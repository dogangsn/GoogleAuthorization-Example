using GoogleAuthorizationAPI.Dto;
using Newtonsoft.Json.Linq;

namespace GoogleAuthorizationAPI.Service
{
    public interface ITokenHandler
    {
        TokenDto CreateAccessToken(int minute);
    }
}
