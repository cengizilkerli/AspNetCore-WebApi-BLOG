using BlogWebApi.Entities.Concrete;

namespace BlogWebApi.Business.Tools.JWTTool
{
    public interface IJwtService
    {
        JwtToken GenerateJwt(AppUser appUser);
    }
}