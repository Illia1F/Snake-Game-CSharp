using System.Drawing;

namespace Snake_Game_CSharp
{
    public static class PointExtensions
    {
        public static Point Add(this Point pointSource, Point point)
        {
            return new Point(pointSource.X + point.X, pointSource.Y + point.Y);
        }

        public static Point Subtract(this Point pointSource, Point point)
        {
            return new Point(pointSource.X - point.X, pointSource.Y - point.Y);
        }

        public static Point ToOpossite(this Point pointSource)
        {
            return new Point(-pointSource.X, -pointSource.Y);
        }
    }
}
