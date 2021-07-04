using System.Drawing;

namespace Snake_Game_CSharp
{
    public class SnakeBuilder
    {
        public Size PartSize;
        public int Length;
        public Point StartPosition;
        public Brush HeadColor = Brushes.Blue;
        public Brush BodyColor = Brushes.LightBlue;

        public Snake Build()
        {
            return new Snake(this);
        }

        public SnakeBuilder SetStartPosition(Point startPosition)
        {
            StartPosition = startPosition;
            return this;
        }

        public SnakeBuilder SetLength(int length)
        {
            Length = length;
            return this;
        }

        public SnakeBuilder SetPartSize(Size partSize)
        {
            PartSize = partSize;
            return this;
        }

        public SnakeBuilder SetSnakeBrush(Brush snake)
        {
            BodyColor = snake;
            return this;
        }

        public SnakeBuilder SetSnakeHeadBrush(Brush snakeHead)
        {
            HeadColor = snakeHead;
            return this;
        }
    }
}
