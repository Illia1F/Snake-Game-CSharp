using System;
using System.Drawing;
using System.Windows.Forms;
using Snake__Game_Logic;

namespace Snake__Game_
{
    public partial class MainForm : Form
    {
        Graphics graphics;
        Snake snake;
        int sizeX, sizeY;
        string score = "SCORE: 0\t\tMAX SCORE: 0";

        Timer timer = new Timer();
        Timer timerHead = new Timer();

        Brush BallBrush = Brushes.Blue;
        Brush SnakeBrush = Brushes.Red;
        Color Background = Color.White;
        Brush SnakeHeadBrush = Brushes.LightCoral;

        short level = 5;

        public MainForm()
        {
            InitializeComponent();

            sizeX = this.PaintingSurface.Width / 20;
            sizeY = this.PaintingSurface.Height / 15;

            PaintingSurface.Image = new Bitmap(PaintingSurface.Width, PaintingSurface.Height);
            graphics = Graphics.FromImage(PaintingSurface.Image);

            snake = new Snake(20, 15, Direction.Bot);
            snake.CrashAccident += Snake_CrashAccident;
            snake.ScoreChanged += Snake_ScoreChanged;

            Snake_ScoreChanged(null, 0);

            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();

            timerHead.Interval = 50;
            timer.Tick += Timer_Tick1;
            timerHead.Start();

            RePaint();
        }

        bool blink = true;
        private void Timer_Tick1(object sender, EventArgs e)
        {
            timerHead.Interval = timer.Interval / 2;

            Brush brush;
            if (blink)
            {
                brush = SnakeHeadBrush;
                blink = false;
            }
            else { brush = SnakeBrush; blink = true; }

            graphics.FillEllipse(brush, snake.snake[0].X * sizeX,
                                                        snake.snake[0].Y * sizeY,
                                                        sizeX, sizeY);
            PaintingSurface.Refresh();
        }

        private void Snake_ScoreChanged(object sender, int e)
        {
            score = "SCORE: " + e.ToString() + "\t\tMAX SCORE: " + SaveManager.GetMaxScoreOutOfFile();
        }

        private void Snake_CrashAccident(object sender, string e)
        {
            SaveScore();
            timer.Stop();
            MessageBox.Show("Game over!");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Interval = 1000 / level - 100;
            snake.TurnTo(newDirection);
            snake.GoOneStepAhead();
            RePaint();
        }

        private Direction newDirection = Direction.Bot;
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Right:
                    newDirection = Direction.Right;
                    break;
                case Keys.Left:
                    newDirection = Direction.Left;
                    break;
                case Keys.Up:
                    newDirection = Direction.Top;
                    break;
                case Keys.Down:
                    newDirection = Direction.Bot;
                    break;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveScore();
            Application.Exit();
        }

        private void SaveScore()
        {
            int max = SaveManager.GetMaxScoreOutOfFile();
            if (max < Snake.Score)
                SaveManager.SaveNewMaxScore();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveScore();
            newDirection = Direction.Bot;
            snake.StartNewGame();
            timer.Start();
        }

        #region Change colors
        private void ballToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BallBrush = new SolidBrush(ShowColors());
        }

        private void snakeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SnakeBrush = new SolidBrush(ShowColors());
        }

        private Color ShowColors()
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
                return colorDialog.Color;

            return new Color();
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Background = ShowColors();
        }

        private void headToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SnakeHeadBrush = new SolidBrush(ShowColors());
        }
        #endregion 

        #region Ghange levels
        private void firstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            level = 1;
            fiveToolStripMenuItem.Checked = false;
            fourToolStripMenuItem.Checked = false;
            threeToolStripMenuItem.Checked = false;
            twoToolStripMenuItem.Checked = false;
            firstToolStripMenuItem.Checked = true;
        }

        private void twoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            level = 2;
            fiveToolStripMenuItem.Checked = false;
            fourToolStripMenuItem.Checked = false;
            threeToolStripMenuItem.Checked = false;
            twoToolStripMenuItem.Checked = true;
            firstToolStripMenuItem.Checked = false;
        }

        private void threeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            level = 3;
            fiveToolStripMenuItem.Checked = false;
            fourToolStripMenuItem.Checked = false;
            threeToolStripMenuItem.Checked = true;
            twoToolStripMenuItem.Checked = false;
            firstToolStripMenuItem.Checked = false;
        }

        private void fourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            level = 4;
            fiveToolStripMenuItem.Checked =false;
            fourToolStripMenuItem.Checked = true;
            threeToolStripMenuItem.Checked = false;
            twoToolStripMenuItem.Checked = false;
            firstToolStripMenuItem.Checked = false;
        }

        private void fiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            level = 5;
            fiveToolStripMenuItem.Checked = true;
            fourToolStripMenuItem.Checked = false;
            threeToolStripMenuItem.Checked = false;
            twoToolStripMenuItem.Checked = false;
            firstToolStripMenuItem.Checked = false;
        }
        #endregion

        private void RePaint()
        {
            if (timer.Enabled)
            {
                graphics.Clear(Background);

                var listSnakeParts = snake.snake;

                foreach (var snakePart in listSnakeParts)
                    graphics.FillEllipse(SnakeBrush, snakePart.X * sizeX, 
                                                        snakePart.Y * sizeY, 
                                                        sizeX, sizeY);

                graphics.FillEllipse(BallBrush, snake.Ball.Position.X * sizeX, 
                                                    snake.Ball.Position.Y * sizeY, 
                                                    sizeX, sizeY);

                graphics.DrawString(score, new Font("Cambri", sizeY / 2), Brushes.Blue, 1, 1);

                PaintingSurface.Refresh();
            }
        }
    }
}
