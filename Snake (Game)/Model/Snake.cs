using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Snake_Game_CSharp
{
    public class Snake
    {
        private readonly Size _partSize;
        private readonly int _startLength;
        private readonly Point _startPosition;

        private List<Point> _partsOfsnake;

        public Brush HeadColor { get; set; }
        public Brush BodyColor { get; set; }

        public event EventHandler CrashAccident;

        public Snake(SnakeBuilder builder)
        {
            _startPosition = builder.StartPosition;
            _partSize = builder.PartSize;
            _startLength = builder.Length;
            BodyColor = builder.BodyColor;
            HeadColor = builder.HeadColor;
            _partsOfsnake = new List<Point>();
        }

        public void Repaint(Graphics graphics)
        {
            if (_partsOfsnake.Count > 0)
            {
                // paint a head of snake
                Point head = GetHead();
                graphics.FillEllipse(HeadColor, head.X * _partSize.Width,
                                                        head.Y * _partSize.Height,
                                                        _partSize.Width, _partSize.Height);
                // paint a body of snake
                var body = _partsOfsnake.Skip(1).ToList();
                foreach (Point part in body)
                {
                    graphics.FillEllipse(BodyColor, part.X * _partSize.Width,
                                                        part.Y * _partSize.Height,
                                                        _partSize.Width, _partSize.Height);
                }
            }
        }

        public Point GetHead()
        {
            IsSnakeEmptyThrowException("GetHead() - Error: Snake is empty!");

            return _partsOfsnake[0];
        }

        public Point GetTail()
        {
            IsSnakeEmptyThrowException("GetTail() - Error: Snake is empty!");

            return _partsOfsnake[_partsOfsnake.Count - 1];
        }

        private void SetHead(Point newPosition)
        {
            IsSnakeEmptyThrowException("SetHead() - Error: Snake is empty!");

            _partsOfsnake[0] = newPosition;
        }

        private void IsSnakeEmptyThrowException(string message)
        {
            if (_partsOfsnake.Count < 0)
                throw new IndexOutOfRangeException(message);
        }

        public void GenerateSnake()
        {
            _partsOfsnake.Clear();
            int positionY = _startPosition.Y + _startLength - 1;
            for (int i = 0; i < _startLength; i++)
                _partsOfsnake.Add(new Point(_startPosition.X, positionY--));
        }

        public void MoveTo(Point movementVector, Size bounds)
        {
            var newPositionOfHead = GetHead().Add(movementVector);
            newPositionOfHead = new Point((newPositionOfHead.X + bounds.Width) % bounds.Width,
                                            (newPositionOfHead.Y + bounds.Height) % bounds.Height);

            if(IsCollisionExistsOnHead(newPositionOfHead))
            {
                CrashAccident?.Invoke(this, null);
                return;
            }

            // move a body ahead
            for (int i = _partsOfsnake.Count - 1; i > 0; --i)
            {
                _partsOfsnake[i] = _partsOfsnake[i - 1];
            }
            // move a head
            SetHead(newPositionOfHead);
        }

        private bool IsCollisionExistsOnHead(Point position)
        {
            bool result = false;

            for (int i = _partsOfsnake.Count - 2; i > 0; --i)
            {
                if (position == _partsOfsnake[i])
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        public void AddPart(Point point)
        {
            _partsOfsnake.Add(point);
        }

        public bool Contains(Point point)
        {
            bool result = false;

            if (_partsOfsnake.Contains(point))
                result = true;

            return result;
        }  
    }
}
