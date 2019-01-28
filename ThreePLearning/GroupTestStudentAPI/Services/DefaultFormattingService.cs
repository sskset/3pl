using System.Collections.Generic;
using System.Text;
using GroupTestStudentAPI.Domain;

namespace GroupTestStudentAPI.Services
{
    public class DefaultFormattingService : IFormattingService
    {
        public string Format(IEnumerable<Group> groups)
        {
            List<string> groupStrings = new List<string>();
            foreach(var group in groups)
            {
                StringBuilder formatString = new StringBuilder();
                formatString.Append("{");

                string memberString = string.Join(",", group.Members);

                if (string.IsNullOrEmpty(memberString))
                {
                    formatString.Append(group.Leader);
                }
                else
                {
                    formatString.Append($"{group.Leader},{memberString}");
                }

                formatString.Append("}");
                groupStrings.Add(formatString.ToString());
            }

            string resultString = string.Join(",", groupStrings);

            return $"{{{resultString}}}";
        }
    }
}
