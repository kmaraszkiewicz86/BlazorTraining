namespace BlazorDemo.Api.Database
{
    using BlazorDemo.Api.Database.Entities;
    using Microsoft.EntityFrameworkCore;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TodoItem> TodoItems => Set<TodoItem>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>(entity =>
            {
                for (var index = 1; index <= 20; index++)
                {
                    entity.HasData(new TodoItem
                    {
                        Id = index,
                        Title = $"Todo {index}",
                        IsDone = index % 2 == 0
                    });
                }
            });

            base.OnModelCreating(modelBuilder);
        }
    }

}
