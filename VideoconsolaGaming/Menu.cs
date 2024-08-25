namespace VideoconsolaGaming;

public partial class Menu : Form
{
    private Ahorcado _ahorcado;
    private Cars _cars;
    private Dino _dino;
    private SimonSays _simon;
    private Snake _snake;

    public Menu()
    {
        InitializeComponent();
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
        if ( _ahorcado == null || _ahorcado.IsDisposed ) _ahorcado = new Ahorcado();
        _ahorcado.Show();
    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {
        if ( _cars == null || _cars.IsDisposed ) _cars = new Cars();
        _cars.Show();
    }

    private void pictureBox3_Click(object sender, EventArgs e)
    {
        if ( _dino == null || _dino.IsDisposed ) _dino = new Dino();
        _dino.Show();
    }

    private void pictureBox4_Click(object sender, EventArgs e)
    {
        if ( _simon == null || _simon.IsDisposed ) _simon = new SimonSays();
        _simon.Show();
    }

    private void pictureBox5_Click(object sender, EventArgs e)
    {
        if ( _snake == null || _snake.IsDisposed ) _snake = new Snake();
        _snake.Show();
    }
}