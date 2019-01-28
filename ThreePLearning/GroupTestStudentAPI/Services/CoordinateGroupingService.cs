using System.Collections.Generic;
using GroupTestStudentAPI.Domain;
using GroupTestStudentAPI.Extensions;

namespace GroupTestStudentAPI.Services
{
    public class CoordinateGroupingService : IGroupingService
    {
        /// <summary>
        /// Grouping students by horizontally, vertically or diagonally adjacent cells.
        /// </summary>
        /// <param name="timeMarksMatrix"></param>
        /// <returns></returns>
        public List<Group> GroupingStudents(string[,] timeMarksMatrix)
        {
            List<Group> groups = new List<Group>();

            if (timeMarksMatrix == null)
                return groups;

            int rowCount = timeMarksMatrix.GetLength(0);
            int colCount = timeMarksMatrix.GetLength(1);

            for (int x = 0; x < rowCount; x++)
            {
                for (int y = 0; y < colCount; y++)
                {
                    string student = timeMarksMatrix[x, y];
                    if (string.IsNullOrEmpty(student)) continue;

                    var group = groups.FindGroup(student);
                    var centralCoordinate = new Coordinate(x, y);
                    var neighbourCoordinates = new NeighbourCoorinates(centralCoordinate, rowCount, colCount);

                    foreach (var @coordinate in neighbourCoordinates)
                    {
                        string studentAtCoordinate = timeMarksMatrix[@coordinate.X, @coordinate.Y];
                        if (!string.IsNullOrEmpty(studentAtCoordinate) && !group.HasStudent(studentAtCoordinate))
                        {
                            group.Members.Add(studentAtCoordinate);
                        }
                    }
                }
            }

            return groups;
        }
    }
}
