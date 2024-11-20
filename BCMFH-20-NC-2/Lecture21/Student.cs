using Lecture21.CustomAttributes;

namespace Lecture21
{
    public class Student
    {
        public string FirstName { get; set; }
        public DateTime StartDate { get; set; }

        [EndDateGreaterThanStartDate(nameof(StartDate))]
        public DateTime EndDate { get; set; }
    }
}
