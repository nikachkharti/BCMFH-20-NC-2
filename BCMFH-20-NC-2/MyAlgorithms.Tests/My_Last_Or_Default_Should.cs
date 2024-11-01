namespace MyAlgorithms.Tests
{
    public class My_Last_Or_Default_Should
    {
        [Fact]
        public void Find_Last_Element_In_IEnumerable()
        {
            //Arrange
            List<int> intList = new() { -1, 2, 3, -4 };

            //Act
            var expected = -4;
            var actual = intList.MyLastOrDefault(x => x < 0);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Return_Default_Value()
        {
            //Arrange
            List<int> intList = new() { -1, 2, 3, -4 };

            //Act
            var expected = 0;
            var actual = intList.MyLastOrDefault(x => x > 100);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
