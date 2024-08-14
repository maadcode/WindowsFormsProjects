using MaterialSkin.Controls;
using System.Text;
using System.Text.Json;

namespace MapsNavigation
{
    public partial class MapForm : Form
    {
        public const string urlSearchMap = "https://maps.google.com/maps?q=";
        public List<Departamento> DepartmentsModel { get; set; }

        public MapForm()
        {
            InitializeComponent();
            LoadDepartments();
            var departments = DepartmentsModel.Select(x => x.Nombre).ToArray();
            InitializeDropdown(cbxDepartamentos, items: departments, selectDefault: true);
        }

        private void LoadDepartments()
        {
            string jsonContent = JsonReader.ReadJsonFile("ciudades.json");
            DepartmentsModel = jsonContent != null 
                ? JsonSerializer.Deserialize<List<Departamento>>(jsonContent) 
                : new List<Departamento>();
        }

        private void InitializeDropdown(MaterialComboBox cbx, string[]? items = null, bool selectDefault = false)
        {
            cbx.Items.Clear();
            cbx.Items.Add("Seleccionar");

            if(items != null)
                cbx.Items.AddRange(items);
            
            if(selectDefault)
                cbx.SelectedIndex = 0;

        }

        private StringBuilder GetUrl()
        {
            var builder = new StringBuilder(urlSearchMap);
            if (cbxDepartamentos.SelectedIndex > 0)
                builder.Append(cbxDepartamentos.SelectedItem + ",+");
            if (cbxProvincias.SelectedIndex > 0)
                builder.Append(cbxProvincias.SelectedItem + ",+");
            if (cbxDistritos.SelectedIndex > 0)
                builder.Append(cbxDistritos.SelectedItem + ",+");
            builder.Append(txtCodigoZIP.Text);
            return builder;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var urlMap = GetUrl();
            mapView.Source = new Uri(urlMap.ToString());

        }

        private void cbxDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDepartamentos.SelectedIndex <= 0)
            {
                InitializeDropdown(cbxProvincias, selectDefault: true);
                return;
            }

            var department = DepartmentsModel.FirstOrDefault(x => x.Nombre == cbxDepartamentos.SelectedItem);
            var provincias = department.Provincias.Select(x => x.Nombre).ToArray();
            InitializeDropdown(cbxProvincias, provincias, selectDefault: true);
        }

        private void cbxProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxProvincias.SelectedIndex <= 0)
            {
                InitializeDropdown(cbxDistritos, selectDefault: true);
                return;
            }

            var department = DepartmentsModel.FirstOrDefault(x => x.Nombre == cbxDepartamentos.SelectedItem);
            var provincia = department.Provincias.FirstOrDefault(x => x.Nombre == cbxProvincias.SelectedItem);
            var distritos = provincia.Distritos.ToArray();
            InitializeDropdown(cbxDistritos, distritos, selectDefault: true);
        }
    }
}