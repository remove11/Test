using System.ComponentModel.DataAnnotations;

namespace ProjectApplication.Persistence
{
    public class ProjectDb
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(128)]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; }

        public List<TaskDb> TaskDbs { get; set; } = new List<TaskDb>();
    }
}
