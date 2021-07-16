using BlogWebApi.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogWebApi.DataAccess.Interfaces
{
    public interface ICategoryDal : IGenericDal<Category>
    {
        Task<List<Category>> GetAllWithCategoryBlogsAsync();
    }
}