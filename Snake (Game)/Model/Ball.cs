using System;
using System.Drawing;

namespace Snake_Game_CSharp
{
    public class Ball
    {
        private readonly Random _random;
        private Size _size;
        public Brush Color { get; set; }

        public Point Position { get; private set; }

        public Ball(Size size)
        {
            _size = size;
            Color = Brushes.Red;
            _random = new Random();
        }

        public Point GenerateBallWithinBounds(Size gridBounds)
        {
            return Position = new Point(x: _random.Next(1, gridBounds.Width), 
                                        y: _random.Next(1, gridBounds.Height));
        }

        public void Repaint(Graphics graphics)
        {
            graphics.FillEllipse(brush: Color, 
                                x: Position.X * _size.Width,
                                y: Position.Y * _size.Height,
                                width: _size.Width, 
                                height: _size.Height);
        }
    }
}
