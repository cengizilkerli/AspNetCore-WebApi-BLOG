using AutoMapper;
using BlogWebApi.DTO.DTOs.BlogDtos;
using BlogWebApi.DTO.DTOs.CategoryDtos;
using BlogWebApi.DTO.DTOs.CommentDtos;
using BlogWebApi.Entities.Concrete;
using BlogWebApi.WebApi.Models;

namespace BlogWebApi.WebApi.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<BlogListDto, Blog>();
            CreateMap<Blog, BlogListDto>();

            CreateMap<BlogUpdateModel, Blog>();
            CreateMap<Blog, BlogUpdateModel>();

            CreateMap<BlogAddModel, Blog>();
            CreateMap<Blog, BlogAddModel>();

            CreateMap<CategoryAddDto, Category>();
            CreateMap<Category, CategoryAddDto>();

            CreateMap<CategoryListDto, Category>();
            CreateMap<Category, CategoryListDto>();

            CreateMap<CategoryUpdateDto, Category>();
            CreateMap<Category, CategoryUpdateDto>();


            CreateMap<Comment, CommentListDto>();
            CreateMap<CommentListDto, Comment>();

            CreateMap<Comment, CommentAddDto>();
            CreateMap<CommentAddDto, Comment>();
        }
    }
}