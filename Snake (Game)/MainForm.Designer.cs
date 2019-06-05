namespace Snake__Game_
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
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ballToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.threeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PaintingSurface)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PaintingSurface
            // 
            this.PaintingSurface.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PaintingSurface.Location = new System.Drawing.Point(0, 28);
            this.PaintingSurface.Name = "PaintingSurface";
            this.PaintingSurface.Size = new System.Drawing.Size(800, 428);
            this.PaintingSurface.TabIndex = 0;
            this.PaintingSurface.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.levelToolStripMenuItem,
            this.colorsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.snakeToolStripMenuItem,
            this.ballToolStripMenuItem,
            this.backgroundToolStripMenuItem,
            this.headToolStripMenuItem});
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.colorsToolStripMenuItem.Text = "Colors";
            // 
            // snakeToolStripMenuItem
            // 
            this.snakeToolStripMenuItem.Name = "snakeToolStripMenuItem";
            this.snakeToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.snakeToolStripMenuItem.Text = "Snake";
            this.snakeToolStripMenuItem.Click += new System.EventHandler(this.snakeToolStripMenuItem_Click);
            // 
            // ballToolStripMenuItem
            // 
            this.ballToolStripMenuItem.Name = "ballToolStripMenuItem";
            this.ballToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ballToolStripMenuItem.Text = "Ball";
            this.ballToolStripMenuItem.Click += new System.EventHandler(this.ballToolStripMenuItem_Click);
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.backgroundToolStripMenuItem.Text = "Background";
            this.backgroundToolStripMenuItem.Click += new System.EventHandler(this.backgroundToolStripMenuItem_Click);
            // 
            // headToolStripMenuItem
            // 
            this.headToolStripMenuItem.Name = "headToolStripMenuItem";
            this.headToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.headToolStripMenuItem.Text = "Head";
            this.headToolStripMenuItem.Click += new System.EventHandler(this.headToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            this.levelToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.levelToolStripMenuItem.Text = "Level";
            // 
            // firstToolStripMenuItem
            // 
            this.firstToolStripMenuItem.Name = "firstToolStripMenuItem";
            this.firstToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.firstToolStripMenuItem.Text = "First";
            this.firstToolStripMenuItem.Click += new System.EventHandler(this.firstToolStripMenuItem_Click);
            // 
            // twoToolStripMenuItem
            // 
            this.twoToolStripMenuItem.Name = "twoToolStripMenuItem";
            this.twoToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.twoToolStripMenuItem.Text = "Two";
            this.twoToolStripMenuItem.Click += new System.EventHandler(this.twoToolStripMenuItem_Click);
            // 
            // threeToolStripMenuItem
            // 
            this.threeToolStripMenuItem.Name = "threeToolStripMenuItem";
            this.threeToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.threeToolStripMenuItem.Text = "Three";
            this.threeToolStripMenuItem.Click += new System.EventHandler(this.threeToolStripMenuItem_Click);
            // 
            // fourToolStripMenuItem
            // 
            this.fourToolStripMenuItem.Name = "fourToolStripMenuItem";
            this.fourToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.fourToolStripMenuItem.Text = "Four";
            this.fourToolStripMenuItem.Click += new System.EventHandler(this.fourToolStripMenuItem_Click);
            // 
            // fiveToolStripMenuItem
            // 
            this.fiveToolStripMenuItem.Checked = true;
            this.fiveToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fiveToolStripMenuItem.Name = "fiveToolStripMenuItem";
            this.fiveToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.fiveToolStripMenuItem.Text = "Five";
            this.fiveToolStripMenuItem.Click += new System.EventHandler(this.fiveToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.PaintingSurface);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
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
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem headToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem threeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fiveToolStripMenuItem;
    }
}

