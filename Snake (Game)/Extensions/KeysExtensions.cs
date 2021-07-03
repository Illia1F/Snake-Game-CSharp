using System.Drawing;
using System.Windows.Forms;

namespace Snake_Game_CSharp
{
    public static class KeysExtensions
    {
        public static Point ToVectorDirection(this Keys key)
        {
            Point dir = Point.Empty;

            switch (key)
            {
                case Keys.Up:
                    dir = new Point(0, -1);
                    break;
                case Keys.Right:
                    dir = new Point(1, 0);
                    break;
                case Keys.Down:
                    dir = new Point(0, 1);
                    break;
                case Keys.Left:
                    dir = new Point(-1, 0);
                    break;
            }

            return dir;
        }
    }
}
