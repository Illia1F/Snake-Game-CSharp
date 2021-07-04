using System;
using System.Drawing;
using System.Windows.Forms;

namespace Snake_Game_CSharp
{
    public partial class MainForm : Form
    {
        private readonly Size _gridSize = new Size(width: 20, height: 16);
        private readonly Timer _refreshTimer = new Timer();
        private readonly Graphics _graphics;
        private readonly Game _game;

        private readonly ToolStripMenuItem[] _levelOptions;
        private int _level = 5;

        public MainForm()
        {
            InitializeComponent();

            _levelOptions = new[]
            {
                firstToolStripMenuItem,
                twoToolStripMenuItem,
                threeToolStripMenuItem,
                fourToolStripMenuItem,
                fiveToolStripMenuItem
            };

            PaintingSurface.Image = new Bitmap(PaintingSurface.Width, PaintingSurface.Height);
            _graphics = Graphics.FromImage(PaintingSurface.Image);

            var cellSize = new Size(PaintingSurface.Width / _gridSize.Width,
                                            PaintingSurface.Height / _gridSize.Height);

            _game = new Game(_gridSize, cellSize);
            _game.CrashAccident += SnakeCrashAccident;
            _game.ScoreChanged += ScoreChanged;
            ScoreChanged(this, 0);

            _refreshTimer.Interval = 100;
            _refreshTimer.Tick += RefreshTimerTick;
            _refreshTimer.Start();

            RePaint();
        }

        private void ScoreChanged(object sender, int score)
        {
            lbScoreValue.Text = score.ToString();
            lbMaxScoreValue.Text = _game.Score.MaxValue.ToString();
        }

        private void SnakeCrashAccident(object sender, EventArgs e)
        {
            _game.Score.Save();
            _refreshTimer.Stop();
            MessageBox.Show(text: "Game over!",
                            caption: "Snake",
                            buttons: MessageBoxButtons.OK,
                            icon: MessageBoxIcon.Information);
        }

        private void RefreshTimerTick(object sender, EventArgs e)
        {
            _refreshTimer.Interval = 1000 / (_level * 2);
            _game.MoveForward();
            RePaint();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            _game.MovementVector = e.KeyCode.ToVectorDirection();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _game.Score.Save();
            _game.StartNewGame();
            _refreshTimer.Start();
        }

        private void RePaint()
        {
            _game.Repaint(_graphics);
            PaintingSurface.Refresh();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _game.Score.Save();
        }

        #region Change colors

        private Color ShowColors()
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
                return colorDialog.Color;

            return new Color();
        }

        private void ballToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _game.Ball.Color = new SolidBrush(ShowColors());
        }

        private void snakeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _game.Snake.BodyColor = new SolidBrush(ShowColors());
        }

        private void headToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _game.Snake.HeadColor = new SolidBrush(ShowColors());
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _game.BackgroundColor = ShowColors();
        }

        #endregion 

        #region Ghange level

        private void ActivateLevelOption(int index)
        {
            for (int i = 0; i < _levelOptions.Length; i++)
                _levelOptions[i].Checked = false;

            _levelOptions[index].Checked = true;
            _level = index + 1;
        }

        private void firstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivateLevelOption(0);
        }

        private void twoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivateLevelOption(1);
        }

        private void threeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivateLevelOption(2);
        }

        private void fourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivateLevelOption(3);
        }

        private void fiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivateLevelOption(4);
        }

        #endregion
    }
}
