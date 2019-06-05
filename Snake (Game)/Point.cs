namespace Snake__Game_Logic
{
    internal class Point
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Point(int X = 0, int Y = 0)
        {
            this.X = X;
            this.Y = Y;
        }

        public static Point operator-(Point p1, Point p2)
        {
            return new Point(p1.X - p2.X, p1.Y - p2.Y);
        }

        public static Point operator+(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }

        public static bool operator!=(Point p, Point p2)
        {
            return p.X != p2.X || p.Y != p2.Y ? true : false;
        }

        public static bool operator==(Point p, Point p2)
        {
            return p.X == p2.X && p.Y == p2.Y ? true : false;
        }
    }
}
