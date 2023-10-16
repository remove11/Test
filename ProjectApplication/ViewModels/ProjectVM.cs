using ProjectApplication.Core;

namespace ProjectApplication.ViewModels
{
    public class ProjectVM
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool IsCompleted { get; set; }

        public static ProjectVM FromProject(Project project)
        {
            return new ProjectVM()
            {
                Id = project.Id,
                Title = project.Title,
                CreatedDate = project.CreatedDate,
                IsCompleted = project.IsCompleted()
            };
        }
    }
}