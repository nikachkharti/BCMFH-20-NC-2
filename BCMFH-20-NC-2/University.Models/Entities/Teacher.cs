using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace University.Models.Entities
{
    public class Teacher
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Required]
        public int Id { get; set; }

        //[Required]
        //[MaxLength(50)]
        public string Name { get; set; }

        public string ProfilePictureUrl { get; set; }


        //1xM
        public List<Course> Courses { get; set; }
    }
}
