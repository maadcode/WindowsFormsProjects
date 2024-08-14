using System.Drawing.Drawing2D;

namespace WebBrowser;

public class RoundedPanel : Panel
{
    public int BorderRadius { get; set; } = 20;  // Radio de curvatura
    public int BorderThickness { get; set; } = 2;  // Grosor del borde
    public Color BorderColor { get; set; } = ColorTranslator.FromHtml("#484d64");  // Color del borde

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Crear un gráfico con antialiasing
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        // Crear el path para el borde curveado
        using (GraphicsPath path = new GraphicsPath())
        {
            int arcSize = BorderRadius * 2;
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, arcSize, arcSize), 180, 90); // Esquina superior izquierda
            path.AddArc(new Rectangle(Width - arcSize, 0, arcSize, arcSize), 270, 90); // Esquina superior derecha
            path.AddArc(new Rectangle(Width - arcSize, Height - arcSize, arcSize, arcSize), 0, 90); // Esquina inferior derecha
            path.AddArc(new Rectangle(0, Height - arcSize, arcSize, arcSize), 90, 90); // Esquina inferior izquierda
            path.CloseFigure();

            // Dibujar el borde curveado
            using (Pen pen = new Pen(BorderColor, BorderThickness))
            {
                e.Graphics.DrawPath(pen, path);
            }

            // Recortar el panel con el borde curveado
            this.Region = new Region(path);
        }
    }
}