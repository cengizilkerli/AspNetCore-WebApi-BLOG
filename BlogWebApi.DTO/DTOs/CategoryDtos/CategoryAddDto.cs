using BlogWebApi.DTO.Interfaces;

namespace BlogWebApi.DTO.DTOs.CategoryDtos
{
    public class CategoryAddDto : IEntityDto
    {
        public string Name { get; set; }
    }
}