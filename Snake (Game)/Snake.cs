using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake__Game_Logic
{
    internal enum Direction
    {
        Top = 1,
        Right,
        Bot,
        Left
    };

    internal class Snake : Map
    {
        public List<Point> snake { get; private set; }
        public static int Score { get; set; } = 0;
        public Ball Ball { get; private set; }
        public Direction Direction { get; set; }
        public event EventHandler<string> CrashAccident;
        public event EventHandler<int> ScoreChanged;

        public Snake(int width, int height, Direction direction)
        {
            this.width = width;
            this.height = height;
            Direction = direction;
            snake = new List<Point>();
            Ball = new Ball(width, height);

            StartNewGame();
        }

        public void StartNewGame()
        {
            Direction = Direction.Bot;

            snake.Clear();
            for (int i = 0, j = 2; i < 3; i++, j--)
                snake.Add(new Point(width / 2, height / 2 + j));

            // generate a ball 
            GenerateNewBall();

            Snake.Score = 0;

            if(ScoreChanged != null)
                ScoreChanged(null, Snake.Score);
        }

        public void TurnTo(Direction direction)
        {
            if (Direction == Direction.Bot && direction != Direction.Top)
                Direction = direction;
            else if (Direction == Direction.Top && direction != Direction.Bot)
                Direction = direction;
            else if (Direction == Direction.Right && direction != Direction.Left)
                Direction = direction;
            else if (Direction == Direction.Left && direction != Direction.Right)
                Direction = direction;
        }

        public void GoOneStepAhead()
        {
            Point offset = DirectionToPoint();
            Point NewPosOfHead = snake[0] + offset;
            NewPosOfHead = new Point((NewPosOfHead.X + width) % width,
                                    (NewPosOfHead.Y + height) % height);
            for (int i = snake.Count - 1; i > 2; --i)
            {
                if (NewPosOfHead == snake[i])
                {
                    CrashAccident(null, Snake.Score.ToString());
                    return;
                }
            }

            Point lPoint = snake.Last();
            for (int i = snake.Count - 1; i > 0; --i)
            {
                snake[i] = snake[i - 1];
            }

            snake[0] = NewPosOfHead;

            if (snake[0] == Ball.Position)
            {
                snake.Add(lPoint);
                GenerateNewBall();
                Snake.Score++;
                ScoreChanged(null, Snake.Score);
            }
        }

        private void GenerateNewBall()
        {
            Ball.GetANextBall();
            for (int i = 0; i < snake.Count; i++)
                if (Ball.Position == snake[i])
                {
                    Ball.GetANextBall();
                    i = 0;
                }
        }

        private Point DirectionToPoint()
        {
            Point dir = null;

            switch (Direction)
            {
                case Direction.Top:
                    dir = new Point(0, -1);
                    break;
                case Direction.Right:
                    dir = new Point(1, 0);
                    break;
                case Direction.Bot:
                    dir = new Point(0, 1);
                    break;
                case Direction.Left:
                    dir = new Point(-1, 0);
                    break;
                default:
                    dir = new Point();
                    break;
            }

            return dir;
        }
    }
}
