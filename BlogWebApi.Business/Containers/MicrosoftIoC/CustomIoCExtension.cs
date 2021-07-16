using BlogWebApi.Business.Concrete;
using BlogWebApi.Business.Interfaces;
using BlogWebApi.Business.Tools.JWTTool;
using BlogWebApi.Business.Tools.LogTool;
using BlogWebApi.Business.ValidationRules.FluentValidation;
using BlogWebApi.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using BlogWebApi.DataAccess.Interfaces;
using BlogWebApi.DTO.DTOs.AppUserDtos;
using BlogWebApi.DTO.DTOs.CategoryBlogDtos;
using BlogWebApi.DTO.DTOs.CategoryDtos;
using BlogWebApi.DTO.DTOs.CommentDtos;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace BlogWebApi.Business.Containers.MicrosoftIoC
{
    public static class CustomIoCExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {

            services.AddScoped(typeof(IGenericDal<>), typeof(EfGenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));

            services.AddScoped<IBlogService, BlogManager>();
            services.AddScoped<IBlogDal, EfBlogRepository>();

            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryRepository>();

            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserRepository>();

            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentDal, EfCommentRepository>();

            services.AddScoped<IJwtService, JwtManager>();
            services.AddScoped<ICustomLogger, NLogAdapter>();


            services.AddTransient<IValidator<AppUserLoginDto>, AppUserLoginValidator>();
            services.AddTransient<IValidator<CategoryAddDto>, CategoryAddValidator>();
            services.AddTransient<IValidator<CategoryBlogDto>, CategoryBlogValidator>();
            services.AddTransient<IValidator<CategoryUpdateDto>, CategoryUpdateValidator>();
            services.AddTransient<IValidator<CommentAddDto>, CommentAddValidator>();


        }
    }
}