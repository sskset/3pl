using GroupTestStudentAPI.Domain;
using System.Collections.Generic;

namespace GroupTestStudentAPI.Services
{
    public interface IGroupingService
    {
        List<Group> GroupingStudents(string[,] timeMarksMatrix);
    }
}
