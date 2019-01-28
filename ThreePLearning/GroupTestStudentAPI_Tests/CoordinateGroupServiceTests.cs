using GroupTestStudentAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace GroupTestStudentAPI_Tests
{
    public class CoordinateGroupServiceTests
    {
        IGroupingService groupingService;

        public CoordinateGroupServiceTests()
        {
            groupingService = new CoordinateGroupingService();
        }

     
        [Fact]
        public void Given_TimeMarksMatrix_ShouldReturnExpected()
        {
            string[,] matrix = new string[6, 5];
            matrix[3, 3] = "Simon";


            var groups = groupingService.GroupingStudents(matrix);

            Assert.NotNull(groups);
            Assert.NotNull(groups.First());
            Assert.True(groups.First().Leader == "Simon");
        }
    }
}
