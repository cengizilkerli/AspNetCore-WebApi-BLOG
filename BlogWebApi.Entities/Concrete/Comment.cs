using BlogWebApi.Entities.Interfaces;
using System;
using System.Collections.Generic;

namespace BlogWebApi.Entities.Concrete
{
    public class Comment : IEntity
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public string AuthorEmail { get; set; }
        public string Description { get; set; }
        public DateTime PostedTime { get; set; } = DateTime.Now;
        public int? ParentCommentId { get; set; }
        public int BlogId { get; set; }







        public Comment ParentComment { get; set; }
        public Blog Blog { get; set; }
        public List<Comment> SubComments { get; set; }
    }
}