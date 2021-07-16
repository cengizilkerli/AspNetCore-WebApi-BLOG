using BlogWebApi.Business.Interfaces;
using BlogWebApi.DataAccess.Interfaces;
using BlogWebApi.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogWebApi.Business.Concrete
{
    public class CommentManager : GenericManager<Comment>, ICommentService
    {

        private readonly ICommentDal _commentDal;
        public CommentManager(IGenericDal<Comment> genericDal, ICommentDal commentDal) : base(genericDal)
        {
            _commentDal = commentDal;

        }

        public Task<List<Comment>> GetAllWithSubCommentsAsync(int blogId, int? parentId)
        {
            return _commentDal.GetAllWithSubCommentsAsync(blogId, parentId);
        }
    }
}