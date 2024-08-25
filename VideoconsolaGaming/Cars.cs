namespace VideoconsolaGaming;

public partial class Cars : Form
{
    private const int DistanceMovement = 140;
    private const int PositionLeft = 12;
    private const int PositionRight = 152;

    private int Score;
    private int SpeedMovement;

    public Cars()
    {
        InitializeComponent();
    }

    private bool RandomTwoValue => new Random().Next(0, 2) == 0;

    private void StartGame()
    {
        Score = 0;
        SpeedMovement = 5;
        btnStart.Visible = false;
        lblPoints.Text = "Puntos: " + Score;

        timerGenerator.Start();
        timerMovement.Start();
    }

    private void EndGame()
    {
        timerGenerator.Stop();
        timerMovement.Stop();
        MessageBox.Show($"Perdiste! Obtuviste {Score} puntos");
        btnStart.Visible = true;

        var items = this.Controls.OfType<PictureBox>().Where(x => x.Tag?.ToString() == "point" || x.Tag?.ToString() == "obstacle").ToList();
        foreach (var item in items)
        {
            item.Dispose();
        }
    }

    private PictureBox GeneratePoint()
    {
        var pointPicture = new PictureBox();
        var leftOrRight = RandomTwoValue ? PositionLeft : PositionRight;
        pointPicture.Location = new Point(leftOrRight, 65);
        pointPicture.Size = new Size(120, 50);
        pointPicture.BackColor = Color.Yellow;
        pointPicture.Tag = "point";
        return pointPicture;
    }

    private PictureBox GenerateObstacle()
    {
        var obstaclePicture = new PictureBox();
        var leftOrRight = RandomTwoValue ? PositionLeft : PositionRight;
        obstaclePicture.Location = new Point(leftOrRight, 65);
        obstaclePicture.Size = new Size(120, 50);
        obstaclePicture.BackColor = Color.Red;
        obstaclePicture.Tag = "obstacle";
        return obstaclePicture;
    }

    private void ValidateCollision(IEnumerable<PictureBox> items)
    {
        if (items.Any(x => x.Tag == "obstacle" && imgCar.Bounds.IntersectsWith(x.Bounds)))
            EndGame();

        var point = items.FirstOrDefault(x => x.Tag == "point" && imgCar.Bounds.IntersectsWith(x.Bounds));
        if (point != null)
            AddPoints(point);
    }

    private void AddPoints(PictureBox pointPicture)
    {
        pointPicture.Dispose();
        Score++;
        lblPoints.Text = "Puntos: " + Score;
        SpeedMovement++;
    }

    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
        if (keyData == Keys.Right && imgCar.Left < DistanceMovement)
        {
            imgCar.Left += DistanceMovement;
        }

        if (keyData == Keys.Left && imgCar.Left > DistanceMovement)
        {
            imgCar.Left -= DistanceMovement;
        }

        return base.ProcessCmdKey(ref msg, keyData);
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
        StartGame();
    }

    private void timerGenerator_Tick(object sender, EventArgs e)
    {
        var item = RandomTwoValue ? GeneratePoint() : GenerateObstacle();
        this.Controls.Add(item);
    }

    private void timerMovement_Tick(object sender, EventArgs e)
    {
        var items = this.Controls.OfType<PictureBox>().Where(x => x.Tag?.ToString() == "point" || x.Tag?.ToString() == "obstacle");
        foreach (var item in items)
        {
            item.Top += SpeedMovement;
        }

        ValidateCollision(items);
    }
}