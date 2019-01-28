using System.Collections.Generic;
using System.Linq;
using System;

namespace GroupTestStudentAPI.Domain
{
    public class Group
    {
        public string Leader { get; set; }
        public List<string> Members { get; set; } = new List<string>();

        public Group(string leader)
        {
            if (string.IsNullOrEmpty(leader)) throw new ArgumentNullException(nameof(leader));

            Leader = leader;
        }

        public Group(string leader, IEnumerable<string> members) : this(leader)
        {
            Members = members.ToList();
        }

        public bool IsStudentInMembers(string student)
        {
            return this.Members.Contains(student);
        }

        public bool HasStudent(string student)
        {
            return Leader == student || IsStudentInMembers(student);
        }
    }
}
