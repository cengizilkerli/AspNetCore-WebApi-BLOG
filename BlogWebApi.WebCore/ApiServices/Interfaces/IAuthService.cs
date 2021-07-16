using BlogWebApi.WebCore.Models;
using System.Threading.Tasks;

namespace BlogWebApi.WebCore.ApiServices.Interfaces
{
    public interface IAuthApiService
    {
        Task<bool> SignIn(AppUserLoginModel model);
    }
}