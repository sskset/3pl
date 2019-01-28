using GroupTestStudentAPI.Domain;
using GroupTestStudentAPI.Services;
using System.Collections.Generic;
using Xunit;

namespace GroupTestStudentAPI_Tests
{
    public class DefaultFormattingServiceTests
    {
        private IFormattingService formatService;
        private List<Group> groups;

        public DefaultFormattingServiceTests()
        {
            formatService = new DefaultFormattingService();
            groups = new List<Group>()
            {
                new Group("Simon", new []{"Sergey", "Thomas"})
            };
        }


        [Fact]
        public void Given_ShouldReturnExpectedValues()
        {
            string expected = "{{Simon,Sergey,Thomas}}";
            string actual = formatService.Format(groups);

            Assert.Equal(expected, actual);
        }
    }
}
