

using P01_StudentSystem.Data.Models.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P01_StudentSystem.Data.Models
{
    public class Resource
    {
        [Key]
        public int ResourceId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Url { get; set; }

        public ResourceType ResourceType { get; set; }

        [ForeignKey(nameof(Course))]
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
