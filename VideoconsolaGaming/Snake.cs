using System.Linq;

namespace VideoconsolaGaming;

public partial class Snake : Form
{
    // Snake
    private List<PictureBox> snake;
    private int BodySquare;
    private const int SizeSquare = 20;
    private MovimientosSnake CurrentDirection;
    // Game
    private int Points;
    private int Speed;

    public Snake()
    {
        InitializeComponent();
        StartGame();
    }

    private void StartGame()
    {
        Controls.Clear();

        Points = 0;
        CreateLabelPoints();

        BodySquare = 2;
        CurrentDirection = MovimientosSnake.RIGHT;
        CreateSnake(GetRandomCoordinate());

        Speed = 200;
        timerSnake.Interval = Speed;
        timerSnake.Start();
        timerFood.Start();
        timerCollision.Start();
    }

    private void CreateLabelPoints()
    {
        Label lblPoints = new Label();
        lblPoints.AutoSize = true;
        lblPoints.BackColor = Color.Transparent;
        lblPoints.Font = new Font("Yu Gothic UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblPoints.ForeColor = Color.Lime;
        lblPoints.Location = new Point(715, 505);
        lblPoints.Name = "lblPoints";
        lblPoints.Size = new Size(73, 86);
        lblPoints.TabIndex = 0;
        lblPoints.Tag = "lblPoints";
        lblPoints.Text = "0";
        Controls.Add(lblPoints);
    }

    private PictureBox CreateSquareSnake(Color color)
    {
        PictureBox segment = new PictureBox();
        segment.Width = SizeSquare;
        segment.Height = SizeSquare;
        segment.BackColor = color;
        return segment;
    }

    private void AddHeadSnake(List<PictureBox> snake, int posicionX, int posicionY)
    {
        PictureBox headSegment = CreateSquareSnake(Color.Green);
        headSegment.Location = new Point(posicionX, posicionY);
        //headSegment.Tag = "SnakeHead" + Points; // Funcionalidad oculta
        headSegment.Tag = "SnakeHead";
        snake.Add(headSegment);
        Controls.Add(headSegment);
    }

    private void AddBodySnake(List<PictureBox> snake, int posicionX, int posicionY)
    {
        PictureBox bodySegment = CreateSquareSnake(Color.DarkGreen);
        bodySegment.Location = new Point(posicionX, posicionY);
        bodySegment.Tag = "SnakeBody";
        snake.Add(bodySegment);
        Controls.Add(bodySegment);
    }

    private void CreateSnake(Point coordenada)
    {
        snake = new List<PictureBox>();
        AddHeadSnake(snake, coordenada.X, coordenada.Y);
        for (int i = 1; i <= BodySquare; i++)
        {
            AddBodySnake(snake, coordenada.X - (i * SizeSquare), coordenada.Y);
        }
    }

    private Point GetRandomCoordinate()
    {
        Random random = new Random();
        int randomX = random.Next(0, ClientSize.Width);
        int randomY = random.Next(0, ClientSize.Height);
        return new Point(randomX, randomY);
    }

    private void CreateFood()
    {
        PictureBox food = new PictureBox();
        food.Width = SizeSquare;
        food.Height = SizeSquare;
        food.BackColor = Color.Red;
        food.Tag = "ImageFood";
        food.Location = GetRandomCoordinate();
        Controls.Add(food);
    }

    private void ValidateColision()
    {
        var snakeBody = Controls.OfType<PictureBox>().Where(pb => pb.Tag.ToString() == "SnakeBody").ToList();
        //var snakeHead = Controls.OfType<PictureBox>().FirstOrDefault(pb => pb.Tag.ToString() == "SnakeHead" + Points); // Funcionalidad oculta
        var snakeHead = Controls.OfType<PictureBox>().FirstOrDefault(pb => pb.Tag.ToString() == "SnakeHead");
        if (snakeBody.Any(x => snakeHead.Bounds.IntersectsWith(x.Bounds)))
        {
            timerSnake.Stop();
            timerFood.Stop();
            timerCollision.Stop();
            MessageBox.Show($"Game over. Conseguiste {Points} puntos");
            StartGame();
            return;
        }

        if (snake[0].Location.X >= this.Width - SizeSquare ||
            snake[0].Location.Y >= this.Height - SizeSquare ||
            snake[0].Location.X <= 0 ||
            snake[0].Location.Y <= 0)
        {
            timerSnake.Stop();
            timerFood.Stop();
            timerCollision.Stop();
            MessageBox.Show($"Game over. Conseguiste {Points} puntos");
            StartGame();
            return;
        }

        var foodPictureBoxes = Controls.OfType<PictureBox>().Where(pb => pb.Tag.ToString() == "ImageFood").ToList();
        var foodCollision = foodPictureBoxes.FirstOrDefault(x => snake[0].Bounds.IntersectsWith(x.Bounds));
        if (foodCollision != null)
        {
            Points++;
            Controls.Remove(foodCollision);
            Label lblPoints = Controls.OfType<Label>().FirstOrDefault(x => x.Tag.ToString() == "lblPoints");
            lblPoints.Text = Points.ToString();
            BodySquare++;
            AddBodySnake(snake, snake.LastOrDefault().Location.X, snake.LastOrDefault().Location.Y);
            //CreateSnake(GetRandomCoordinate()); // Funcionalidad oculta
            Speed -= 10;
            timerSnake.Interval = Speed > 0 ? Speed : 1;
        }
    }

    private void MoveSnake()
    {
        for (int i = snake.Count - 1; i > 0; i--)
        {
            snake[i].Location = snake[i - 1].Location;
        }

        if (CurrentDirection == MovimientosSnake.UP || CurrentDirection == MovimientosSnake.DOWN)
            snake[0].Top = ChangeDirection(snake[0].Top);
        else if (CurrentDirection == MovimientosSnake.LEFT || CurrentDirection == MovimientosSnake.RIGHT)
            snake[0].Left = ChangeDirection(snake[0].Left);
    }

    private int ChangeDirection(int position)
    {
        return CurrentDirection switch
        {
            MovimientosSnake.UP => position - SizeSquare,
            MovimientosSnake.DOWN => position + SizeSquare,
            MovimientosSnake.LEFT => position - SizeSquare,
            MovimientosSnake.RIGHT => position + SizeSquare,
        };
    }

    private void timerSnake_Tick(object sender, EventArgs e)
    {
        MoveSnake();
    }

    private void Snake_KeyDown(object sender, KeyEventArgs e)
    {
        CurrentDirection = e.KeyCode switch
        {
            Keys.Up when CurrentDirection != MovimientosSnake.DOWN => MovimientosSnake.UP,
            Keys.Down when CurrentDirection != MovimientosSnake.UP => MovimientosSnake.DOWN,
            Keys.Left when CurrentDirection != MovimientosSnake.RIGHT => MovimientosSnake.LEFT,
            Keys.Right when CurrentDirection != MovimientosSnake.LEFT => MovimientosSnake.RIGHT,
            _ => CurrentDirection
        };
        MoveSnake();
    }

    private void timerFood_Tick(object sender, EventArgs e)
    {
        CreateFood();
    }

    private void timerCollision_Tick(object sender, EventArgs e)
    {
        ValidateColision();
    }
}