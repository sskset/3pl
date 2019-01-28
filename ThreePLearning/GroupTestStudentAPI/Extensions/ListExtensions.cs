using GroupTestStudentAPI.Domain;
using System.Collections.Generic;
using System.Linq;

namespace GroupTestStudentAPI.Extensions
{
    public static class ListExtensions
    {
        public static Group FindGroup(this List<Group> groups, string student)
        {
            var group = groups.FirstOrDefault(x => x.Members.Contains(student));
            if(group == null)
            {
                group = new Group(student);
                groups.Add(group);
            }

            return group;
        }
    }
}
