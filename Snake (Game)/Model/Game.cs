using System;
using System.Drawing;

namespace Snake_Game_CSharp
{
    public class Game
    {
        private readonly Size _boardGridSize;

        public Snake Snake { get; private set; }
        public Ball Ball { get; private set; }
        public GameScore Score { get; private set; }

        public event EventHandler CrashAccident;
        public event EventHandler<int> ScoreChanged;

        private Point _currentMovementVector;
        private Point _movementVector;
        public Point MovementVector
        {
            get
            {
                return _movementVector;
            }
            set
            {
                if (_currentMovementVector != value.ToOpossite()) _movementVector = value;

            }
        }

        public Color BackgroundColor { get; set; }

        public Game(Size boardGridSize, Size cellSize)
        {
            _boardGridSize = boardGridSize;
            BackgroundColor = Color.White;

            Snake = new SnakeBuilder().SetStartPosition(new Point(x: _boardGridSize.Width / 2,  y: _boardGridSize.Height / 2))
                                        .SetLength(3)
                                        .SetPartSize(cellSize)
                                        .SetSnakeBrush(Brushes.LightBlue)
                                        .SetSnakeHeadBrush(Brushes.CornflowerBlue)
                                        .Build();
            Snake.CrashAccident += (sender, e) => CrashAccident?.Invoke(sender, e);

            Score = new GameScore();
            Score.ScoreChanged += (sender, e) => ScoreChanged?.Invoke(sender, e);

            Ball = new Ball(cellSize);

            StartNewGame();
        }

        public void StartNewGame()
        {
            _currentMovementVector = _movementVector = new Point(x: 0, y: 1); // bottom
            Snake.GenerateSnake();
            GenerateNewBall();
            Score.Value = 0;
        }

        public void MoveForward()
        {
            _currentMovementVector = _movementVector;
            Point snakeTail = Snake.GetTail();
            Snake.MoveTo(_currentMovementVector, _boardGridSize);

            if (Snake.GetHead() == Ball.Position)
            {
                Snake.AddPart(snakeTail);
                GenerateNewBall();
                Score.Value++;
            }
        }

        public void Repaint(Graphics graphics)
        {
            graphics.Clear(BackgroundColor);
            Snake.Repaint(graphics);
            Ball.Repaint(graphics);
        }

        private void GenerateNewBall()
        {
            while (Snake.Contains(Ball.GenerateBallWithinBounds(_boardGridSize)));
        }
    }
}
