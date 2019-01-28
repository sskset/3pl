using GroupTestStudentAPI.Domain;
using GroupTestStudentAPI.Extensions;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace GroupTestStudentAPI_Tests
{
    public class ListExtensionsTests
    {
        List<Group> groups;

        public ListExtensionsTests()
        {
            groups = new List<Group>()
            {
                new Group("Simon",new []{ "Thomas", "Jack" })
            };
        }

        [Fact]
        public void Given_ExistingGroup_ShouldReturn()
        {
            var group = groups.FindGroup("Jack");
            Assert.NotNull(group);

            Assert.Equal(groups.First(), group);
        }

        [Fact]
        public void Given_NotExisting_ShouldReturnNewGroup()
        {
            string student = "Jenny";
            var group = groups.FindGroup(student);
            Assert.NotNull(group);
            Assert.Equal(student, group.Leader);
            Assert.Equal(groups.Last(), group);
        }
    }
}
