using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.Models.Entities
{
    public class Student
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Required]
        public int Id { get; set; }

        //[Required]
        //[MaxLength(50)]
        public string Name { get; set; }

        //[Required]
        //[MaxLength(11)]
        //[StringLength(11)]
        //[Column(TypeName = "char(11)")]
        public string PersonalNumber { get; set; }

        //[Required]
        //[MaxLength(50)]
        //[Column(TypeName = "varchar(50)")]
        //[EmailAddress]
        public string Email { get; set; }

        //[Column(TypeName = "datetime2")]
        public DateTime BirthDate { get; set; }

        //1x1
        public Address Address { get; set; }

        //MxM
        public List<Group> Groups { get; set; }
    }
}
