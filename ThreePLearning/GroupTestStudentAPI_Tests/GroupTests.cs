using GroupTestStudentAPI.Domain;
using System;
using Xunit;

namespace GroupTestStudentAPI_Tests
{
    public class GroupTests
    {

        [Fact]
        public void Given_Leader_ShouldReturnValidInstance()
        {
            string leader = "James";
            var group = new Group(leader);

            Assert.NotNull(group);
            Assert.Equal(leader, group.Leader);
        }

        [Fact]
        public void Give_Leader_Members_ShouldReturnValidInstance()
        {
            var leader = "James";
            var members = new[] { "Jack", "Mike" };

            var group = new Group(leader, members);
            Assert.NotNull(group);
            Assert.Equal(leader, group.Leader);
            Assert.Equal(members, group.Members);
        }

        [Fact]
        public void Given_ExistingMember_ShouldReturnExist()
        {
            var leader = "James";
            var members = new[] { "Jack", "Mike" };

            var group = new Group(leader, members);
            Assert.NotNull(group);
            Assert.True(group.IsStudentInMembers("Jack"));
        }

        [Fact]
        public void Given_Null_Leader_ShouldThrownException()
        {
            Action act = () => new Group(null);

            Assert.Throws<ArgumentNullException>(act);
        }

        [Fact]
        public void Given_ExistStudent_ShouldHasStudent()
        {
            var leader = "James";
            var group = new Group(leader);

            Assert.NotNull(group);
            Assert.True(group.HasStudent("James"));
        }

        [Fact]
        public void Give_NonexistStudent_ShouldNotHasStudent()
        {
            var leader = "James";
            var group = new Group(leader);

            Assert.NotNull(group);
            Assert.False(group.HasStudent("Jack"));
        }
    }
}
