using System.Diagnostics.CodeAnalysis;

namespace MyAlgorithms.Tests
{
    class StudentEquilityComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y) => x.Name.Trim().ToLower() == y.Name.Trim().ToLower() && x.Age == y.Age;
        public int GetHashCode([DisallowNull] Student obj) => obj.Name.Length;
    }


    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override bool Equals(object obj) => new StudentEquilityComparer().Equals(this, obj as Student);
        public override int GetHashCode() => new StudentEquilityComparer().GetHashCode(this);
    }

    public class My_Distinct_Should
    {
        [Fact]
        public void Find_Unique_Value_Elements()
        {
            //Arrange
            List<int> intList = new() { 1, 10, 10, 2 };

            //Act
            var expected = new HashSet<int>() { 1, 10, 2 };
            var actual = intList.MyDistinct();

            //Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void Find_Unique_Reference_Elements()
        {
            //Arrange
            List<Student> studentList = new()
            {
                new Student() {Name = "Ketevan",Age = 20},
                new Student() {Name = "Ilia",Age = 22},
                new Student() {Name = "Ilia",Age = 22},
                new Student() {Name = "Ilia",Age = 22},
                new Student() {Name = "Tengiz",Age = 31},
                new Student() {Name = "Tengiz",Age = 31},
                new Student() {Name = "Petre",Age = 12}
            };

            //Act
            var expected = new HashSet<Student>()
            {
                new Student() {Name = "Ketevan",Age = 20},
                new Student() {Name = "Ilia",Age = 22},
                new Student() {Name = "Tengiz",Age = 31},
                new Student() {Name = "Petre",Age = 12}
            };

            var actual = studentList.MyDistinct(new StudentEquilityComparer());

            //Assert
            Assert.Equal(expected, actual, new StudentEquilityComparer());
        }

    }
}
