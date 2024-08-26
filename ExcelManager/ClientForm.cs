using SpreadsheetLight;
using System.Drawing.Printing;

namespace ExcelManager;

public partial class ClientForm : Form
{
    public readonly string DirectoryPath;
    private const string FileNameImport = "Data.xlsx";
    private const string FileNameExport = "Data2.xlsx";

    private Panel loadingPanel;

    public ClientForm()
    {
        DirectoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
        InitializeComponent();
        dataGV.DataSource = new List<ClientModel>();
        InitializeLoadingPanel();
    }

    private void InitializeLoadingPanel()
    {
        loadingPanel = new Panel
        {
            Size = new Size(200, 100),
            BackColor = Color.Gray,
            Visible = false
        };
        Label loadingLabel = new Label
        {
            Text = "Procesando...",
            ForeColor = Color.White,
            TextAlign = ContentAlignment.MiddleCenter,
            Dock = DockStyle.Fill
        };
        loadingPanel.Controls.Add(loadingLabel);
        Controls.Add(loadingPanel);

        loadingPanel.Location = new Point(
            (this.ClientSize.Width - loadingPanel.Width) / 2,
            (this.ClientSize.Height - loadingPanel.Height) / 2
        );
    }

    private void ImportData()
    {
        SLDocument s1 = new SLDocument(Path.Combine(DirectoryPath, FileNameImport));
        int iRow = 2;
        var clients = new List<ClientModel>();
        while (!string.IsNullOrEmpty(s1.GetCellValueAsString(iRow, 1)))
        {
            var client = new ClientModel
            {
                Name = s1.GetCellValueAsString(iRow, 1),
                Email = s1.GetCellValueAsString(iRow, 2),
                Account = s1.GetCellValueAsDouble(iRow, 3),
                Category = Enum.Parse<ClientCategory>(s1.GetCellValueAsString(iRow, 4)),
                Age = s1.GetCellValueAsInt32(iRow, 5),
                DateRegister = s1.GetCellValueAsDateTime(iRow, 6)
            };
            clients.Add(client);
            iRow++;
        }

        dataGV.DataSource = clients;
    }

    private void ExportData()
    {
        SLDocument s1 = new SLDocument();
        s1.SetCellValue(1, 1, "Name");
        s1.SetCellValue(1, 2, "Email");
        s1.SetCellValue(1, 3, "Account");
        s1.SetCellValue(1, 4, "Category");
        s1.SetCellValue(1, 5, "Age");
        s1.SetCellValue(1, 6, "DateRegister");

        int iRow = 2;
        foreach (DataGridViewRow row in dataGV.Rows)
        {
            s1.SetCellValue(iRow, 1, row.Cells[0].Value.ToString());
            s1.SetCellValue(iRow, 2, row.Cells[1].Value.ToString());
            s1.SetCellValue(iRow, 3, row.Cells[2].Value.ToString());
            s1.SetCellValue(iRow, 4, row.Cells[3].Value.ToString());
            s1.SetCellValue(iRow, 5, row.Cells[4].Value.ToString());
            s1.SetCellValue(iRow, 6, row.Cells[5].Value.ToString());
            iRow++;
        }

        s1.SaveAs(Path.Combine(DirectoryPath, FileNameExport));
    }

    private void Imprimir()
    {
        loadingPanel.Visible = true;
        loadingPanel.BringToFront();

        var printDocument = new PrintDocument();
        printDocument.PrinterSettings = new PrinterSettings();
        printDocument.PrintPage += WritePDF;

        Task.Run(() =>
        {
            printDocument.Print();

            this.Invoke((() =>
            {
                loadingPanel.Visible = false;
            }));
        });
    }

    private void WritePDF(object sender, PrintPageEventArgs e)
    {
        var font = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point);
        e.Graphics.DrawString("Un documento feliz", font, Brushes.Black, new Rectangle(0, 10, 400, 800));
        e.Graphics.DrawString("Un documento feliz 2", font, Brushes.Black, new Rectangle(0, 34, 400, 800));
    }

    private void btnImportar_Click(object sender, EventArgs e)
    {
        ImportData();
    }

    private void btnExportar_Click(object sender, EventArgs e)
    {
        ExportData();
    }

    private void btnPrint_Click(object sender, EventArgs e)
    {
        Imprimir();
    }
}
