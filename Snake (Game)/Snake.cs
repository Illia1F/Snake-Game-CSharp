using System;
using System.Collections.Generic;
using System.Drawing;

namespace Snake_Game_CSharp
{
    public class Snake
    {
        private readonly int _startLength;
        private readonly Point _startPosition;
        private List<Point> _partsOfsnake;
        public event EventHandler CrashAccident;

        public List<Point> PartsOfSnake => _partsOfsnake;

        public Snake(Point startPosition, int startLength)
        {
            _startPosition = startPosition;
            _startLength = startLength;
            _partsOfsnake = new List<Point>();
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

            // check collisions
            for (int i = _partsOfsnake.Count - 1; i > 2; --i)
            {
                if (newPositionOfHead == _partsOfsnake[i])
                {
                    CrashAccident?.Invoke(this, null);
                    return;
                }
            }

            // move ahead
            for (int i = _partsOfsnake.Count - 1; i > 0; --i)
            {
                _partsOfsnake[i] = _partsOfsnake[i - 1];
            }

            SetHead(newPositionOfHead);
        }

        public void AddPart(Point point)
        {
            _partsOfsnake.Add(point);
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

        public bool Contains(Point point)
        {
            bool result = false;

            if (_partsOfsnake.Contains(point))
                result = true;

            return result;
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
    }
}
