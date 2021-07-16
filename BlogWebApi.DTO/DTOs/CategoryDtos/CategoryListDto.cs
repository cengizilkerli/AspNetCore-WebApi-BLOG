using BlogWebApi.DTO.Interfaces;

namespace BlogWebApi.DTO.DTOs.CategoryDtos
{
    public class CategoryListDto : IEntityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}