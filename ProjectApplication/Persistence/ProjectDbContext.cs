using Microsoft.EntityFrameworkCore;

namespace ProjectApplication.Persistence
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options) { }

        public DbSet<TaskDb> TaskDbs { get; set; }
        public DbSet<ProjectDb> ProjectDbs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ProjectDb pdb = new ProjectDb
            {
                Id = -1, // from seed data
                Title = "Learning ASP.NET Core with MVC",
                CreatedDate = DateTime.Now,
                TaskDbs = new List<TaskDb>()
            };
            modelBuilder.Entity<ProjectDb>().HasData(pdb);

            TaskDb tdb1 = new TaskDb()
            {
                Id = -1,
                Description = "Follow the turtorials",
                LastUpdated = DateTime.Now,
                Status = Core.Status.IN_PROGRESS,
                ProjectId = -1,
            };
            TaskDb tdb2 = new TaskDb()
            {
                Id = -2,
                Description = "Do it yourself!",
                LastUpdated = DateTime.Now,
                Status = Core.Status.TO_DO,
                ProjectId = -1
            };
            modelBuilder.Entity<TaskDb>().HasData(tdb1);
            modelBuilder.Entity<TaskDb>().HasData(tdb2);
        }
    }
}
