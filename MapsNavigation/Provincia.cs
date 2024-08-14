using System.Text.Json.Serialization;

namespace MapsNavigation;

public class Provincia
{
    public string Nombre { get; set; }
    public List<string> Distritos { get; set; }
}