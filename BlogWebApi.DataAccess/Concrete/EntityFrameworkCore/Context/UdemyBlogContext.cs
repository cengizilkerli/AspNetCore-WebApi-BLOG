using BlogWebApi.DataAccess.Concrete.EntityFrameworkCore.Mapping;
using BlogWebApi.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BlogWebApi.DataAccess.Concrete.EntityFrameworkCore.Context
{
    public class UdemyBlogContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=LAPTOP-F436T3TL\SQL2017; database=FinalProjeBlogDb; user id=sa; password=1;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppUserMap());
            modelBuilder.ApplyConfiguration(new BlogMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new CategoryBlogMap());
            modelBuilder.ApplyConfiguration(new CommentMap());
        }


        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryBlog> CategoryBlogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}