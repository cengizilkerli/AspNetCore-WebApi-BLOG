using System.Threading.Tasks;

namespace BlogWebApi.WebCore.ApiServices.Interfaces
{
    public interface IImageApiService
    {
        Task<string> GetBlogImageByIdAsync(int id);
    }
}