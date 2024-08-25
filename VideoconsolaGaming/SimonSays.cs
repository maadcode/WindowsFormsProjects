namespace VideoconsolaGaming;

public partial class SimonSays : Form
{
    private int Nivel;
    private List<string> CardsIdSimonSaid;
    private List<string> CardsIdSelected;

    public SimonSays()
    {
        InitializeComponent();
        btnStart.Text = "Iniciar juego";
    }

    private int VelocityDelay => 1000 - (Nivel * 200);
    private int Cantidad => (Nivel * 2) + 2;

    private string GetCardTag(int id) => "card" + id;

    private void StartGame()
    {
        CardsIdSimonSaid = new List<string>();
        CardsIdSelected = new List<string>();

        lblNivel.Text = $"Nivel: {Nivel}";
        btnStart.Text = "Reiniciar juego";
        lblGameOver.Text = string.Empty;
        lblGameOver.Visible = false;
        
        AddCards();
        SimonSaying();
    }

    private async Task SimonSaying()
    {
        CardsIdSimonSaid.Clear();
        CardsIdSelected.Clear();

        progressTime.Value = 0;
        CardsIdSimonSaid = GetOrdenRandom();

        foreach (var card in CardsIdSimonSaid)
        {
            var cardControl = tblCards.Controls.OfType<PictureBox>().FirstOrDefault(x => x.Tag.ToString() == card);
            await Task.Delay(VelocityDelay < 100 ? 100 : VelocityDelay);
            cardControl.BackColor = Color.CornflowerBlue;
            await Task.Delay(VelocityDelay < 100 ? 100 : VelocityDelay);
            cardControl.BackColor = Color.Black;
        }

        var cardsControls = tblCards.Controls.OfType<PictureBox>().Where(x => x.Tag.ToString().StartsWith("card"));
        foreach (var cardControl in cardsControls)
            cardControl.Click += btnCard_Click;

        timer.Start();
    }

    private List<string> GetOrdenRandom()
    {
        var cards = new List<string>();
        Random random = new Random();
        for (int i = 0; i < Cantidad; i++)
        {
            var randomId = random.Next(0, Cantidad);
            var cardTag = GetCardTag(randomId);
            cards.Add(cardTag);
        }

        return cards;
    }

    private void AddCards()
    {
        tblCards.Controls.Clear();
        tblCards.ColumnStyles.Clear();
        tblCards.RowStyles.Clear();

        int columnas = (int)Math.Ceiling(Math.Sqrt(Cantidad));
        int filas = (int)Math.Ceiling((double)Cantidad / columnas);

        tblCards.ColumnCount = columnas;
        tblCards.RowCount = filas;

        for (int i = 0; i < columnas; i++)
        {
            tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / columnas));
        }

        for (int i = 0; i < filas; i++)
        {
            tblCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / filas));
        }

        for (int i = 0; i < Cantidad; i++)
        {
            var card = CreateCards(tblCards.Width / columnas, tblCards.Height / filas, i);
            int row = i / columnas;
            int col = i % columnas;
            tblCards.Controls.Add(card, col, row);
        }
    }

    private PictureBox CreateCards(int width, int height, int id)
    {
        PictureBox card = new PictureBox();
        card.Size = new Size(width, height);
        card.BackColor = Color.Black;
        card.BorderStyle = BorderStyle.FixedSingle;
        card.Tag = GetCardTag(id);
        card.Cursor = Cursors.Hand;
        card.MouseDown += btnCard_MouseDown;
        card.MouseUp += btnCard_MouseUpn;
        return card;
    }

    private void ValidateEndGame()
    {
        for (int i = 0; i < CardsIdSimonSaid.Count; i++)
        {
            if (CardsIdSimonSaid[i] != CardsIdSelected[i])
            {
                timer.Stop();
                tblCards.Controls.Clear();
                lblGameOver.Text = "Perdiste! Sólo alcanzaste el nivel " + Nivel;
                lblGameOver.ForeColor = Color.Red;
                lblGameOver.Visible = true;
                btnStart.Text = "Iniciar juego";
                return;
            }
        }

        if (Nivel == 5)
        {
            timer.Stop();
            tblCards.Controls.Clear();
            lblGameOver.Text = "Felicitaciones! Llegaste al nivel " + Nivel;
            lblGameOver.ForeColor = Color.DarkGreen;
            lblGameOver.Visible = true;
            btnStart.Text = "Iniciar juego";
            return;
        }

        SiguienteNivel();
    }

    private void SiguienteNivel()
    {
        MessageBox.Show("Excelente! Siguiente nivel.");
        Nivel++;
        StartGame();
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
        Nivel = 5;
        StartGame();
    }

    private void timer_Tick(object sender, EventArgs e)
    {
        progressTime.Value += 1;
    }

    private void btnCard_MouseDown(object sender, MouseEventArgs e)
    {
        PictureBox card = (PictureBox)sender;
        card.BackColor = Color.AntiqueWhite;
    }

    private void btnCard_MouseUpn(object sender, MouseEventArgs e)
    {
        PictureBox card = (PictureBox)sender;
        card.BackColor = Color.Black;
    }

    private void btnCard_Click(object sender, EventArgs e)
    {
        if (CardsIdSelected.Count < CardsIdSimonSaid.Count)
        {
            PictureBox cardSelected = (PictureBox)sender;
            CardsIdSelected.Add(cardSelected.Tag.ToString());
        }

        if (CardsIdSelected.Count == CardsIdSimonSaid.Count)
        {
            ValidateEndGame();
        }
    }
}