using Microsoft.EntityFrameworkCore;
using ProjectApplication.Core;
using ProjectApplication.Core.Interfaces;

namespace ProjectApplication.Persistence
{
    public class ProjectSqlPersistence : IProjectPersistence
    {
        private ProjectDbContext _dbContext;

        public ProjectSqlPersistence(ProjectDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Project> GetAll()
        {
            var projectDbs = _dbContext.ProjectDbs
                //.Where(p => true)
                //.Include(p => p.TaskDbs)
                .ToList();

            List<Project> result = new List<Project>();
            foreach (ProjectDb pdb in projectDbs)
            {
                Project project = new Project( // TODO: use an auto-mapper instead
                    pdb.Id,
                    pdb.Title,
                    pdb.CreatedDate);
                result.Add(project);
            }

            return result;
        }
    }
}
