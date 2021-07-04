namespace Snake_Game_CSharp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PaintingSurface = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.threeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ballToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbScoreValue = new System.Windows.Forms.Label();
            this.lbMaxScore = new System.Windows.Forms.Label();
            this.lbMaxScoreValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PaintingSurface)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PaintingSurface
            // 
            this.PaintingSurface.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PaintingSurface.Location = new System.Drawing.Point(11, 82);
            this.PaintingSurface.Margin = new System.Windows.Forms.Padding(2);
            this.PaintingSurface.Name = "PaintingSurface";
            this.PaintingSurface.Size = new System.Drawing.Size(600, 496);
            this.PaintingSurface.TabIndex = 0;
            this.PaintingSurface.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.levelToolStripMenuItem,
            this.colorsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(623, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // levelToolStripMenuItem
            // 
            this.levelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstToolStripMenuItem,
            this.twoToolStripMenuItem,
            this.threeToolStripMenuItem,
            this.fourToolStripMenuItem,
            this.fiveToolStripMenuItem});
            this.levelToolStripMenuItem.Name = "levelToolStripMenuItem";
            this.levelToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.levelToolStripMenuItem.Text = "Level";
            // 
            // firstToolStripMenuItem
            // 
            this.firstToolStripMenuItem.Name = "firstToolStripMenuItem";
            this.firstToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.firstToolStripMenuItem.Text = "First";
            this.firstToolStripMenuItem.Click += new System.EventHandler(this.firstToolStripMenuItem_Click);
            // 
            // twoToolStripMenuItem
            // 
            this.twoToolStripMenuItem.Name = "twoToolStripMenuItem";
            this.twoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.twoToolStripMenuItem.Text = "Two";
            this.twoToolStripMenuItem.Click += new System.EventHandler(this.twoToolStripMenuItem_Click);
            // 
            // threeToolStripMenuItem
            // 
            this.threeToolStripMenuItem.Name = "threeToolStripMenuItem";
            this.threeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.threeToolStripMenuItem.Text = "Three";
            this.threeToolStripMenuItem.Click += new System.EventHandler(this.threeToolStripMenuItem_Click);
            // 
            // fourToolStripMenuItem
            // 
            this.fourToolStripMenuItem.Name = "fourToolStripMenuItem";
            this.fourToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.fourToolStripMenuItem.Text = "Four";
            this.fourToolStripMenuItem.Click += new System.EventHandler(this.fourToolStripMenuItem_Click);
            // 
            // fiveToolStripMenuItem
            // 
            this.fiveToolStripMenuItem.Checked = true;
            this.fiveToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fiveToolStripMenuItem.Name = "fiveToolStripMenuItem";
            this.fiveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.fiveToolStripMenuItem.Text = "Five";
            this.fiveToolStripMenuItem.Click += new System.EventHandler(this.fiveToolStripMenuItem_Click);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.snakeToolStripMenuItem,
            this.ballToolStripMenuItem,
            this.backgroundToolStripMenuItem,
            this.headToolStripMenuItem});
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.colorsToolStripMenuItem.Text = "Colors";
            // 
            // snakeToolStripMenuItem
            // 
            this.snakeToolStripMenuItem.Name = "snakeToolStripMenuItem";
            this.snakeToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.snakeToolStripMenuItem.Text = "Snake";
            this.snakeToolStripMenuItem.Click += new System.EventHandler(this.snakeToolStripMenuItem_Click);
            // 
            // ballToolStripMenuItem
            // 
            this.ballToolStripMenuItem.Name = "ballToolStripMenuItem";
            this.ballToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.ballToolStripMenuItem.Text = "Ball";
            this.ballToolStripMenuItem.Click += new System.EventHandler(this.ballToolStripMenuItem_Click);
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.backgroundToolStripMenuItem.Text = "Background";
            this.backgroundToolStripMenuItem.Click += new System.EventHandler(this.backgroundToolStripMenuItem_Click);
            // 
            // headToolStripMenuItem
            // 
            this.headToolStripMenuItem.Name = "headToolStripMenuItem";
            this.headToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.headToolStripMenuItem.Text = "Head";
            this.headToolStripMenuItem.Click += new System.EventHandler(this.headToolStripMenuItem_Click);
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbScore.Location = new System.Drawing.Point(12, 34);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(74, 25);
            this.lbScore.TabIndex = 2;
            this.lbScore.Text = "Score:";
            // 
            // lbScoreValue
            // 
            this.lbScoreValue.AutoSize = true;
            this.lbScoreValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbScoreValue.Location = new System.Drawing.Point(92, 34);
            this.lbScoreValue.Name = "lbScoreValue";
            this.lbScoreValue.Size = new System.Drawing.Size(25, 25);
            this.lbScoreValue.TabIndex = 3;
            this.lbScoreValue.Text = "0";
            // 
            // lbMaxScore
            // 
            this.lbMaxScore.AutoSize = true;
            this.lbMaxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMaxScore.Location = new System.Drawing.Point(316, 34);
            this.lbMaxScore.Name = "lbMaxScore";
            this.lbMaxScore.Size = new System.Drawing.Size(115, 25);
            this.lbMaxScore.TabIndex = 4;
            this.lbMaxScore.Text = "MaxScore:";
            // 
            // lbMaxScoreValue
            // 
            this.lbMaxScoreValue.AutoSize = true;
            this.lbMaxScoreValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMaxScoreValue.Location = new System.Drawing.Point(437, 34);
            this.lbMaxScoreValue.Name = "lbMaxScoreValue";
            this.lbMaxScoreValue.Size = new System.Drawing.Size(25, 25);
            this.lbMaxScoreValue.TabIndex = 5;
            this.lbMaxScoreValue.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(623, 587);
            this.Controls.Add(this.lbMaxScoreValue);
            this.Controls.Add(this.lbMaxScore);
            this.Controls.Add(this.lbScoreValue);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.PaintingSurface);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PaintingSurface)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PaintingSurface;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem snakeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ballToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem headToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem threeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fiveToolStripMenuItem;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbScoreValue;
        private System.Windows.Forms.Label lbMaxScore;
        private System.Windows.Forms.Label lbMaxScoreValue;
    }
}

