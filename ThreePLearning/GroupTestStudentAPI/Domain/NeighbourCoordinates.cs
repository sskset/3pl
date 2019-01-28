using System.Collections;
using System.Collections.Generic;

namespace GroupTestStudentAPI.Domain
{
    /// <summary>
    /// Get neighbour coordinates
    /// </summary>
    public class NeighbourCoorinates : IReadOnlyCollection<Coordinate>
    {
        private static readonly int[] Offsets = { -1, 0, 1 };
        private readonly List<Coordinate> _neighbourCoordinates;

        public Coordinate CentralCoordinate { get; private set; }

        public int Count => _neighbourCoordinates.Count;

        public NeighbourCoorinates(Coordinate centralCoordinate, int maxBoundaryX, int maxBoundaryY)
        {
            this.CentralCoordinate = centralCoordinate;
            this._neighbourCoordinates = this.GetNeighbourCoordinates(centralCoordinate, maxBoundaryX, maxBoundaryY);
        }

        private List<Coordinate> GetNeighbourCoordinates(Coordinate centralCoordinate, int maxBoundaryX, int maxBoundaryY)
        {
            List<Coordinate> result = new List<Coordinate>();
            foreach (int offsetX in Offsets)
            {
                foreach (int offsetY in Offsets)
                {
                    var coordinate = new Coordinate(centralCoordinate.X + offsetX, centralCoordinate.Y + offsetY);
                    if (coordinate.IsValid(maxBoundaryX, maxBoundaryY) && coordinate != centralCoordinate)
                    {
                        result.Add(coordinate);
                    }
                }
            }
            return result;
        }

        public IEnumerator<Coordinate> GetEnumerator()
        {
            return _neighbourCoordinates.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _neighbourCoordinates.GetEnumerator();
        }
    }
}
