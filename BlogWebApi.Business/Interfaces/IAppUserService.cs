using BlogWebApi.DTO.DTOs.AppUserDtos;
using BlogWebApi.Entities.Concrete;
using System.Threading.Tasks;

namespace BlogWebApi.Business.Interfaces
{
    public interface IAppUserService : IGenericService<AppUser>
    {
        Task<AppUser> CheckUserAsync(AppUserLoginDto appUserLoginDto);
        Task<AppUser> FindByNameAsync(string userName);
    }
}