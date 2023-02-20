using Microsoft.EntityFrameworkCore;
namespace razorweb.models{
    public class MyBlogContext :DbContext
    {
        public MyBlogContext(DbContextOptions<MyBlogContext> options) : base(options)
        {
            //...
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);
        }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
        }
        public DbSet<Article> ? articles {get; set;}
    }
}