using BlogWebApi.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogWebApi.DataAccess.Interfaces
{
    public interface ICommentDal : IGenericDal<Comment>
    {
        Task<List<Comment>> GetAllWithSubCommentsAsync(int blogId, int? parentId);
    }
}