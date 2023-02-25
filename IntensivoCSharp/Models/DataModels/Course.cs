using System.ComponentModel.DataAnnotations;
namespace IntensivoCSharp.Models.DataModels
{
    public class Course : BaseEntity
    {
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [StringLength(280)]
        public string ShortDescription { get; set; } = string.Empty;
        public string LongDescription { get; set; } = string.Empty;
        public string Target { get; set; } = string.Empty;
        public string Objectives { get; set; } = string.Empty;
        public string requirements { get; set; } = string.Empty;
        public Level CourseLevel { get; set; }
    }

    public enum Level
    {
        Basic, Medium, Advanced
    }

}
