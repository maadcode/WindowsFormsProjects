namespace VideoconsolaGaming
{
    partial class Dino
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
            components = new System.ComponentModel.Container();
            btnStart = new MaterialSkin.Controls.MaterialButton();
            lblGameOver = new Label();
            timerWalk = new System.Windows.Forms.Timer(components);
            timerRacetrack = new System.Windows.Forms.Timer(components);
            timerJump = new System.Windows.Forms.Timer(components);
            lblPoints = new Label();
            imgDino = new PictureBox();
            timerRun = new System.Windows.Forms.Timer(components);
            timerPoints = new System.Windows.Forms.Timer(components);
            timerObstacle = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)imgDino).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnStart.Cursor = Cursors.Hand;
            btnStart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnStart.Depth = 0;
            btnStart.HighEmphasis = true;
            btnStart.Icon = null;
            btnStart.Location = new Point(327, 69);
            btnStart.Margin = new Padding(4, 6, 4, 6);
            btnStart.MouseState = MaterialSkin.MouseState.HOVER;
            btnStart.Name = "btnStart";
            btnStart.NoAccentTextColor = Color.Empty;
            btnStart.Size = new Size(111, 36);
            btnStart.TabIndex = 5;
            btnStart.Text = "Start Game";
            btnStart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnStart.UseAccentColor = false;
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lblGameOver
            // 
            lblGameOver.AutoSize = true;
            lblGameOver.BackColor = Color.Transparent;
            lblGameOver.Font = new Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGameOver.ForeColor = Color.Chocolate;
            lblGameOver.Location = new Point(312, 27);
            lblGameOver.Name = "lblGameOver";
            lblGameOver.Size = new Size(147, 32);
            lblGameOver.TabIndex = 6;
            lblGameOver.Text = "Dino Game";
            // 
            // timerWalk
            // 
            timerWalk.Tick += timerWalk_Tick;
            // 
            // timerRacetrack
            // 
            timerRacetrack.Interval = 1;
            timerRacetrack.Tick += timerRacetrack_Tick;
            // 
            // timerJump
            // 
            timerJump.Tick += timerJump_Tick;
            // 
            // lblPoints
            // 
            lblPoints.AutoSize = true;
            lblPoints.BackColor = Color.Transparent;
            lblPoints.Font = new Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPoints.ForeColor = Color.Chocolate;
            lblPoints.Location = new Point(638, 27);
            lblPoints.Name = "lblPoints";
            lblPoints.Size = new Size(130, 32);
            lblPoints.TabIndex = 7;
            lblPoints.Text = "Puntos: 0";
            // 
            // imgDino
            // 
            imgDino.BackColor = Color.Transparent;
            imgDino.Image = Properties.Resources.Walk1;
            imgDino.Location = new Point(12, 279);
            imgDino.Name = "imgDino";
            imgDino.Size = new Size(211, 159);
            imgDino.SizeMode = PictureBoxSizeMode.Zoom;
            imgDino.TabIndex = 3;
            imgDino.TabStop = false;
            // 
            // timerRun
            // 
            timerRun.Tick += timerRun_Tick;
            // 
            // timerPoints
            // 
            timerPoints.Interval = 1000;
            timerPoints.Tick += timerPoints_Tick;
            // 
            // timerObstacle
            // 
            timerObstacle.Interval = 1;
            timerObstacle.Tick += timerObstacle_Tick;
            // 
            // Dino
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.bgRace2;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(imgDino);
            Controls.Add(lblPoints);
            Controls.Add(lblGameOver);
            Controls.Add(btnStart);
            DoubleBuffered = true;
            MaximizeBox = false;
            Name = "Dino";
            Text = "Dino";
            TransparencyKey = Color.DarkGreen;
            ((System.ComponentModel.ISupportInitialize)imgDino).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnStart;
        private Label lblGameOver;
        private System.Windows.Forms.Timer timerWalk;
        private System.Windows.Forms.Timer timerRacetrack;
        private System.Windows.Forms.Timer timerJump;
        private Label lblPoints;
        private PictureBox imgDino;
        private System.Windows.Forms.Timer timerRun;
        private System.Windows.Forms.Timer timerPoints;
        private System.Windows.Forms.Timer timerObstacle;
    }
}