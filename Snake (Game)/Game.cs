using System;
using System.Collections.Generic;
using System.Drawing;

namespace Snake_Game_CSharp
{
    public class Game
    {
        private readonly Size _boardSize;

        public Snake Snake { get; private set; }
        public List<Point> snake => Snake.PartsOfSnake;

        public GameScore Score { get; set; }
        public Ball Ball { get; private set; }
        public event EventHandler<string> CrashAccident;
        public event EventHandler<int> ScoreChanged;

        private Point _movementVector;
        public Point MovementVector
        {
            get
            {
                return _movementVector;
            }
            set
            {
                if (_movementVector != value.ToOpossite()) _movementVector = value;
            }
        }

        public Game(Size boardSize)
        {
            _boardSize = boardSize;

            Snake = new Snake(startPosition: new Point(_boardSize.Width / 2, _boardSize.Height / 2), 
                                startLength: 3);
            Snake.CrashAccident += Snake_CrashAccident;

            Ball = new Ball(_boardSize.Width, _boardSize.Height);
            Score = new GameScore();

            StartNewGame();
        }

        private void Snake_CrashAccident(object sender, EventArgs e)
        {
            CrashAccident?.Invoke(sender, Score.Value.ToString());
        }

        public void StartNewGame()
        {
            _movementVector = new Point(0, -1);

            Snake.GenerateSnake();

            // generate a ball 
            GenerateNewBall();

            Score.Value = 0;

            ScoreChanged?.Invoke(null, Score.Value);
        }

        public void GoOneStepAhead()
        {
            Point snakeTail = Snake.GetTail();
            Snake.MoveTo(MovementVector, _boardSize);

            if (Snake.GetHead() == Ball.Position)
            {
                Snake.AddPart(snakeTail);
                GenerateNewBall();
                Score.Value++;
                ScoreChanged(null, Score.Value);
            }
        }

        private void GenerateNewBall()
        {
            Ball.GetANextBall();

            while(Snake.Contains(Ball.Position))
            {
                Ball.GetANextBall();
            }
        }
    }
}
