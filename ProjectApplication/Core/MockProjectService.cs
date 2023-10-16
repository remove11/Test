using ProjectApplication.Core.Interfaces;

namespace ProjectApplication.Core
{
    public class MockProjectService : IProjectService 
    {
        public List<Project> GetAll()
        {
            Project p1 = new Project(1, "Learn ASP:NET with MVC");
            Project p2 = new Project(2, "Prepare for your Bachelor Thesis");
            p2.AddTask(new Core.Task(1, "Find an interesting topic and company"));
            p2.AddTask(new Core.Task(1, "Start a pre-study"));
            List<Project> projects = new();
            projects.Add(p1);
            projects.Add(p2);
            return projects;
        }
    }
}
