using BlogWebApi.DTO.Interfaces;

namespace BlogWebApi.DTO.DTOs.AppUserDtos
{
    public class AppUserLoginDto : IEntityDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}