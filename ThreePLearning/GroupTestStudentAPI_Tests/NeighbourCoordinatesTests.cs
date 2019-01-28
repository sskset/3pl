using GroupTestStudentAPI.Domain;
using Xunit;

namespace GroupTestStudentAPI_Tests
{
    public class NeighbourCoordinatesTests
    {

        [Fact]
        public void Given_ValidCentralCoordinate_Should_ReturnExpectedNeighbourCoordinates()
        {
            var c = new Coordinate(1, 1);
            var neighbours = new NeighbourCoorinates(c, 3, 3);

            Assert.Equal(8, neighbours.Count);
        }

        [Fact]
        public void Given_BoundaryCoordinate_Should_ResultLessNeighbourCoordinates1()
        {
            var c = new Coordinate(0, 0);
            var neighbours = new NeighbourCoorinates(c, 9, 9);

            Assert.Equal(3, neighbours.Count);
        }
        
        [Fact]
        public void Given_BoundaryCoordinate_Should_ResultLessNeighbourCoordinates2()
        {
            var c = new Coordinate(9, 9);
            var neighbours = new NeighbourCoorinates(c, 9, 9);

            Assert.Equal(3, neighbours.Count);
        }
    }
}
