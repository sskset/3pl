using System;

namespace GroupTestStudentAPI.Domain
{
    /// <summary>
    /// The element location in the matrix
    /// </summary>
    public struct Coordinate
    {
        public const int MIN_BOUNDARY_INDEX = 0;

        public Coordinate(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; private set; }
        public int Y { get; private set; }

        public static bool operator ==(Coordinate left, Coordinate right)
        {
            return left.GetHashCode() == right.GetHashCode();
        }

        public static bool operator !=(Coordinate left, Coordinate right)
        {
            return !(left == right);
        }

        public bool IsValid(int maxBounrdayX, int maxBoundaryY)
        {
            return X >= MIN_BOUNDARY_INDEX && X <= maxBounrdayX && Y >= MIN_BOUNDARY_INDEX && Y <= maxBoundaryY;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Coordinate)) return false;
            Coordinate other = (Coordinate)obj;

            return this.GetHashCode() == other.GetHashCode();
        }
    }
}
