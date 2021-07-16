using BlogWebApi.DataAccess.Interfaces;
using BlogWebApi.Entities.Concrete;

namespace BlogWebApi.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfAppUserRepository : EfGenericRepository<AppUser>, IAppUserDal
    {
    }
}