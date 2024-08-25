namespace VideoconsolaGaming;

public partial class Dino : Form
{
    private int TrackSpeed;
    private int Score;
    private int BackgroundPosition;

    private int CurrentDinoFrame;
    private bool IsRunning;
    private bool IsJumping;

    private int JumpSpeed = 30;
    private bool Offline;
    private const int DinoBaseTop = 293;
    private const int Gravity = 5;


    public Dino()
    {
        InitializeComponent();
    }

    private void StartGame()
    {
        Score = 0;
        IsRunning = false;
        IsJumping = false;
        Offline = false;

        BackgroundPosition = 0;
        CurrentDinoFrame = 0;
        TrackSpeed = 10;
        imgDino.Top = DinoBaseTop;

        var obstacle = Controls.OfType<PictureBox>().FirstOrDefault(x => x.Tag?.ToString() == "obstacle");
        if(obstacle != null) obstacle.Dispose();

        timerWalk.Start();
        timerPoints.Start();
        timerRacetrack.Start();
        timerObstacle.Start();
    }

    private void StopGame()
    {
        Offline = true;
        timerWalk.Stop();
        timerRun.Stop();
        timerJump.Stop();
        timerPoints.Stop();
        timerRacetrack.Stop();
        timerObstacle.Stop();
    }

    private PictureBox GenerateObstacle()
    {
        PictureBox obstacle = new PictureBox();
        obstacle.Location = new Point(this.Width - 50, this.Height - 100);
        obstacle.Size = new Size(50, 50);
        obstacle.BackColor = Color.YellowGreen;
        obstacle.Tag = "obstacle";
        return obstacle;
    }

    private void ValidateCollision(PictureBox obstacle)
    {
        if (imgDino.Bounds.IntersectsWith(obstacle.Bounds))
        {
            StopGame();
            MessageBox.Show("Perdiste");
            btnStart.Text = "Start Game";
            btnStart.Click += btnStart_Click;
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.DrawImage(Properties.Resources.racetrack, BackgroundPosition, 375);
        e.Graphics.DrawImage(Properties.Resources.racetrack, BackgroundPosition + 1200, 375);

        base.OnPaint(e);
    }

    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
        if (Offline)
            return true;

        if (keyData == (Keys.ShiftKey | Keys.Shift) && !IsJumping)
        {
            CurrentDinoFrame = 0;

            if (!IsRunning)
            {
                timerWalk.Stop();
                TrackSpeed = 20;
                timerRun.Start();
            }

            if (IsRunning)
            {
                timerRun.Stop();
                TrackSpeed = 10;
                timerWalk.Start();
            }

            IsRunning = !IsRunning;
        }

        if (keyData == Keys.Space && !IsJumping)
        {
            if (IsRunning)
            {
                timerRun.Stop();
                TrackSpeed = 10;
                IsRunning = false;
            }
            else if (!IsRunning)
            {
                timerWalk.Stop();
                TrackSpeed = 5;
            }

            IsJumping = true;
            CurrentDinoFrame = 0;
            timerJump.Start();
            return true;
        }

        return base.ProcessCmdKey(ref msg, keyData);
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
        StartGame();
        btnStart.Text = "Stop Game";
        btnStart.Click += btnStop_Click;
    }

    private void btnStop_Click(object sender, EventArgs e)
    {
        StopGame();
        btnStart.Text = "Start Game";
        btnStart.Click += btnStart_Click;
    }

    private void timerWalk_Tick(object sender, EventArgs e)
    {
        CurrentDinoFrame++;

        if (CurrentDinoFrame > 9)
        {
            CurrentDinoFrame = 0;
        }
        imgDino.Image = CurrentDinoFrame switch
        {
            0 => Properties.Resources.Walk1,
            1 => Properties.Resources.Walk2,
            2 => Properties.Resources.Walk3,
            3 => Properties.Resources.Walk4,
            4 => Properties.Resources.Walk5,
            5 => Properties.Resources.Walk6,
            6 => Properties.Resources.Walk7,
            7 => Properties.Resources.Walk8,
            8 => Properties.Resources.Walk9,
            9 => Properties.Resources.Walk10,
        };
    }

    private void timerJump_Tick(object sender, EventArgs e)
    {
        if (IsJumping)
        {
            imgDino.Image = CurrentDinoFrame switch
            {
                0 => Properties.Resources.Jump1,
                1 => Properties.Resources.Jump2,
                2 => Properties.Resources.Jump3,
                3 => Properties.Resources.Jump4,
                4 => Properties.Resources.Jump5,
                5 => Properties.Resources.Jump6,
                6 => Properties.Resources.Jump7,
                7 => Properties.Resources.Jump8,
                8 => Properties.Resources.Jump9,
                9 => Properties.Resources.Jump10,
                10 => Properties.Resources.Jump11,
                11 => Properties.Resources.Jump12,
            };

            imgDino.Top -= JumpSpeed;

            JumpSpeed -= Gravity;

            CurrentDinoFrame++;

            if (CurrentDinoFrame > 11 || imgDino.Top >= DinoBaseTop)
            {
                imgDino.Top = DinoBaseTop;
                JumpSpeed = 30;
                IsJumping = false;
                TrackSpeed = 10;
                timerJump.Stop();
                timerWalk.Start();
            }
        }
    }

    private void timerRun_Tick(object sender, EventArgs e)
    {
        CurrentDinoFrame++;

        if (CurrentDinoFrame > 7)
        {
            CurrentDinoFrame = 0;
        }
        imgDino.Image = CurrentDinoFrame switch
        {
            0 => Properties.Resources.Run1,
            1 => Properties.Resources.Run2,
            2 => Properties.Resources.Run3,
            3 => Properties.Resources.Run4,
            4 => Properties.Resources.Run5,
            5 => Properties.Resources.Run6,
            6 => Properties.Resources.Run7,
            7 => Properties.Resources.Run8,
        };
    }

    private void timerRacetrack_Tick(object sender, EventArgs e)
    {
        BackgroundPosition -= TrackSpeed;

        if (BackgroundPosition <= -1200)
        {
            BackgroundPosition = 0;
        }

        this.Invalidate();
    }

    private void timerPoints_Tick(object sender, EventArgs e)
    {
        Score = Score + (TrackSpeed / 10);
        lblPoints.Text = "Puntos: " + Score.ToString();
    }

    private void timerObstacle_Tick(object sender, EventArgs e)
    {
        var obstacle = Controls.OfType<PictureBox>().FirstOrDefault(x => x.Tag?.ToString() == "obstacle");
        if (obstacle != null && obstacle.Left < 0)
        {
            obstacle.Dispose();
        }
        else if (obstacle != null)
        {
            obstacle.Left -= TrackSpeed;
        }
        else
        {
            obstacle = GenerateObstacle();
            this.Controls.Add(obstacle);
        }

        ValidateCollision(obstacle);
    }
}