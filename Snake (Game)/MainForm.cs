using System;
using System.Drawing;
using System.Windows.Forms;

namespace Snake_Game_CSharp
{
    public partial class MainForm : Form
    {
        private Graphics _graphics;
        private Game _game;
        private int sizeX, sizeY;
        private string ScoreMessage = "SCORE: 0\t\tMAX SCORE: 0";

        private Timer timer = new Timer();
        private Timer timerHead = new Timer();

        private Brush BallBrush = Brushes.Blue;
        private Brush SnakeBrush = Brushes.Red;
        private Color Background = Color.White;
        private Brush SnakeHeadBrush = Brushes.LightCoral;

        private int level = 5;

        public MainForm()
        {
            InitializeComponent();

            Size snakePartSize = new Size(20, 15);

            sizeX = this.PaintingSurface.Width / snakePartSize.Width;
            sizeY = this.PaintingSurface.Height / snakePartSize.Height;

            PaintingSurface.Image = new Bitmap(PaintingSurface.Width, PaintingSurface.Height);
            _graphics = Graphics.FromImage(PaintingSurface.Image);

            _game = new Game(snakePartSize);
            _game.CrashAccident += Snake_CrashAccident;
            _game.ScoreChanged += Snake_ScoreChanged;

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

            _graphics.FillEllipse(brush, _game.snake[0].X * sizeX,
                                                        _game.snake[0].Y * sizeY,
                                                        sizeX, sizeY);
            PaintingSurface.Refresh();
        }

        private void Snake_ScoreChanged(object sender, int e)
        {
            ScoreMessage = "SCORE: " + e.ToString() + "\t\tMAX SCORE: " + _game.Score.MaxValue;
        }

        private void Snake_CrashAccident(object sender, string e)
        {
            _game.Score.Save();
            timer.Stop();
            MessageBox.Show("Game over!");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Interval = 1000 / level - 100;
            _game.GoOneStepAhead();
            RePaint();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            _game.MovementVector = e.KeyCode.ToVectorDirection();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _game.Score.Save();
            Application.Exit();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _game.Score.Save();
            _game.StartNewGame();
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
                _graphics.Clear(Background);

                var listSnakeParts = _game.snake;

                foreach (var snakePart in listSnakeParts)
                    _graphics.FillEllipse(SnakeBrush, snakePart.X * sizeX, 
                                                        snakePart.Y * sizeY, 
                                                        sizeX, sizeY);

                _graphics.FillEllipse(BallBrush, _game.Ball.Position.X * sizeX, 
                                                    _game.Ball.Position.Y * sizeY, 
                                                    sizeX, sizeY);

                _graphics.DrawString(ScoreMessage, new Font("Cambri", sizeY / 2), Brushes.Blue, 1, 1);

                PaintingSurface.Refresh();
            }
        }
    }
}
