using System.Text.RegularExpressions;

namespace WebBrowser
{
    public partial class Browser : Form
    {
        public const string urlSearchDefault = "https://www.google.com/search?q=";
        public Browser()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#252835");
            panelSearch.BackColor = ColorTranslator.FromHtml("#484d64");
            txtSearch.BackColor = ColorTranslator.FromHtml("#484d64");
        }

        private Uri GetUri(string termSearch)
        {
            if (Uri.TryCreate(termSearch, UriKind.Absolute, out Uri uriResultado))
                return uriResultado;

            if (IsDomain(termSearch))
                return new Uri("https://" + termSearch);

            return new Uri(urlSearchDefault + termSearch);
        }

        private bool IsDomain(string termSearch)
        {
            string patronDominio = @"^(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?\.)+[a-zA-Z]{2,}$";
            Regex regex = new Regex(patronDominio);
            return regex.IsMatch(termSearch);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            browserView.Source = GetUri(txtSearch.Text.Trim());
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            browserView.Source = GetUri(txtSearch.Text.Trim());
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                browserView.Source = GetUri(txtSearch.Text.Trim());
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            browserView.GoBack();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            browserView.GoForward();
        }
    }
}
