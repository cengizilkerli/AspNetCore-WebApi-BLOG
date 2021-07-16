using BlogWebApi.DataAccess.Concrete.EntityFrameworkCore.Context;
using BlogWebApi.DataAccess.Interfaces;
using BlogWebApi.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebApi.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfCategoryRepository : EfGenericRepository<Category>, ICategoryDal
    {
        public async Task<List<Category>> GetAllWithCategoryBlogsAsync()
        {
            using var context = new UdemyBlogContext();
            return await context.Categories.OrderByDescending(I => I.Id).Include(I => I.CategoryBlogs).ToListAsync();
        }
    }
}