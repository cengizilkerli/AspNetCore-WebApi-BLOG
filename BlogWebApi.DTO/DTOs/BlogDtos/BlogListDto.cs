using BlogWebApi.DTO.Interfaces;
using System;

namespace BlogWebApi.DTO.DTOs.BlogDtos
{
    public class BlogListDto : IEntityDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public DateTime PostedTime { get; set; }
    }
}