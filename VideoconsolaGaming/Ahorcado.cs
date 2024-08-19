namespace VideoconsolaGaming;

public partial class Ahorcado : Form
{
    private char[] LetrasPorAdivinar;
    private char[] LetrasAdivinadas;
    private int Intentos;

    public Ahorcado()
    {
        InitializeComponent();
        StartGame();
    }

    private char[] GetAlphabet => Enumerable.Range('A', 26).Select(c => (char)c).ToArray();

    private void StartGame()
    {
        Intentos = 1;
        imgAhorcado.Image = Constantes.MappingImageAhorcadoFromIntentos.GetValueOrDefault(Intentos);
        btnStart.Image = Properties.Resources.btnPlaying;
        lblGameOver.Visible = false;

        flFichas.Controls.Clear();
        GenerateButtons();

        LetrasPorAdivinar = GetRandomWord();
        LetrasAdivinadas = LetrasPorAdivinar.Select(c => char.Parse("-")).ToArray();
        paintRandomWord(LetrasAdivinadas);
    }

    private char[] GetRandomWord()
    {
        var secretsWord = new string[] { "BANANA" };
        Random random = new Random();
        var index = random.Next(0, secretsWord.Length);
        return secretsWord[index].ToCharArray();
    }

    private void GenerateButtons()
    {
        foreach (var letter in GetAlphabet)
        {
            var button = new Button();
            button.Tag = letter;
            button.Text = letter.ToString();
            button.Width = 60;
            button.Height = 40;
            button.Click += btnLetter_Click;
            flFichas.Controls.Add(button);
        }
    }

    private void paintRandomWord(char[] letters)
    {
        flPalabra.Controls.Clear();
        foreach (var letter in letters)
        {
            var label = new Label();
            label.Text = letter.ToString();
            label.Width = 40;
            label.Height = 40;
            label.Font = new Font("Arial", 16, FontStyle.Bold | FontStyle.Underline);
            label.ForeColor = Color.DarkGreen;
            label.TextAlign = ContentAlignment.MiddleCenter;

            var panel = new Panel();
            panel.Width = 60;
            panel.Height = 40;
            panel.Controls.Add(label);

            flPalabra.Controls.Add(panel);
        }
    }

    private void ValidateWordSelected(char word)
    {
        if (LetrasPorAdivinar.Contains(word))
        {
            for (int i = 0; i < LetrasPorAdivinar.Length; i++)
            {
                if (LetrasPorAdivinar[i] == word)
                    LetrasAdivinadas[i] = LetrasPorAdivinar[i];
            }
            paintRandomWord(LetrasAdivinadas);
        }
        else
        {
            Intentos++;
            imgAhorcado.Image = Constantes.MappingImageAhorcadoFromIntentos.GetValueOrDefault(Intentos);
        }
        ValidateEndGame();
    }

    private void ValidateEndGame()
    {
        if (LetrasAdivinadas.SequenceEqual(LetrasPorAdivinar))
        {
            lblGameOver.Text = "Ganaste!";
            lblGameOver.Visible = true;
            btnStart.Image = Properties.Resources.btnStart;
            return;
        }

        if (Intentos >= 7)
        {
            lblGameOver.Text = "Perdiste!";
            lblGameOver.Visible = true;
            btnStart.Image = Properties.Resources.btnStart;
            return;
        }
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
        StartGame();
    }

    private void btnLetter_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        button.Click -= btnLetter_Click;
        button.BackColor = Color.Gray;
        button.ForeColor = Color.White;
        ValidateWordSelected(button.Text.ToCharArray()[0]);
    }
}