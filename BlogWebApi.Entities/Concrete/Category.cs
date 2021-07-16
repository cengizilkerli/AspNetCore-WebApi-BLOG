using BlogWebApi.Entities.Interfaces;
using System.Collections.Generic;

namespace BlogWebApi.Entities.Concrete
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }







        public List<CategoryBlog> CategoryBlogs { get; set; }
    }
}