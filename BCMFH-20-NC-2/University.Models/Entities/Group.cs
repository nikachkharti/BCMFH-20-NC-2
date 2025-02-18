using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.Models.Entities
{
    public class Group
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Required]
        public int Id { get; set; }

        //[Required]
        //[MaxLength(100)]
        public string Name { get; set; }

        //MxM
        //[ForeignKey(nameof(Student))]
        public int StudentId { get; set; }
        public Student Student { get; set; }


        //[ForeignKey(nameof(Course))]
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
