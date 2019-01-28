using GroupTestStudentAPI.Domain;
using System.Collections.Generic;

namespace GroupTestStudentAPI.Services
{
    /// <summary>
    /// This service is going to format the response
    /// </summary>
    public interface IFormattingService
    {
        string Format(IEnumerable<Group> groups);
    }
}
