using BlogWebApi.Business.Interfaces;
using BlogWebApi.DataAccess.Interfaces;
using BlogWebApi.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogWebApi.Business.Concrete
{
    public class CategoryManager : GenericManager<Category>, ICategoryService
    {
        private readonly IGenericDal<Category> _genericDal;
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(IGenericDal<Category> genericDal, ICategoryDal categoryDal) : base(genericDal)
        {
            _categoryDal = categoryDal;
            _genericDal = genericDal;
        }

        public async Task<List<Category>> GetAllSortedByIdAsync()
        {
            return await _genericDal.GetAllAsync(I => I.Id);
        }

        public async Task<List<Category>> GetAllWithCategoryBlogsAsync()
        {
            return await _categoryDal.GetAllWithCategoryBlogsAsync();
        }


    }
}