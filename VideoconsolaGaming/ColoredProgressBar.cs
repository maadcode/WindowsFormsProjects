namespace VideoconsolaGaming;

public class ColoredProgressBar : ProgressBar
{
    public Color ProgressBarColor { get; set; } = Color.Green;

    public ColoredProgressBar()
    {
        this.SetStyle(ControlStyles.UserPaint, true);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        Rectangle rect = ClientRectangle;
        Graphics g = e.Graphics;

        ProgressBarRenderer.DrawHorizontalBar(g, rect);
        rect.Inflate(-3, -3);

        if (Value > 0)
        {
            Rectangle clip = new Rectangle(rect.X, rect.Y, (int)Math.Round((float)Value / Maximum * rect.Width), rect.Height);
            using (SolidBrush brush = new SolidBrush(ProgressBarColor))
            {
                g.FillRectangle(brush, clip);
            }
        }
    }
}