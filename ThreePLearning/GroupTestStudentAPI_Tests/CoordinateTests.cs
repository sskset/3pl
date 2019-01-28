using GroupTestStudentAPI.Domain;
using Xunit;

namespace GroupTestStudentAPI_Tests
{
    public class CoordinateTests
    {
        [Fact]
        public void Given_ValidValues_Should_ReturnValid()
        {
            var c = new Coordinate(0, 0);
            bool result = c.IsValid(3, 3);

            Assert.True(result);
        }

        [Fact]
        public void Given_InvalidValues_Should_ReturnInvalid()
        {
            var c = new Coordinate(-1, 0);
            bool result = c.IsValid(3, 3);

            Assert.False(result);
        }

        [Fact]
        public void Given_OutOfBoundayValues_Should_ReturnInvalid()
        {
            var c = new Coordinate(5, 0);
            bool result = c.IsValid(4, 7);

            Assert.False(result);
        }

        [Fact]
        public void Give_Same_Values_They_Should_Equal1()
        {
            var left = new Coordinate(2, 3);
            var right = new Coordinate(2, 3);

            Assert.Equal(left, right);
        }

        [Fact]
        public void Give_Same_Values_They_Should_Equal2()
        {
            var left = new Coordinate(2, 3);
            var right = new Coordinate(2, 3);

            Assert.True(left == right);
        }

        [Fact]
        public void Give_Different_Values_They_Should_NotEqual1()
        {
            var left = new Coordinate(2, 3);
            var right = new Coordinate(2, 4);

            Assert.NotEqual(left, right);
        }

        [Fact]
        public void Give_Different_Values_They_Should_NotEqual2()
        {
            var left = new Coordinate(2, 3);
            var right = new Coordinate(2, 4);

            Assert.True(left != right);
        }
    }
}
