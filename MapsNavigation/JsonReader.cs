using System.Reflection;

namespace MapsNavigation;

public class JsonReader
{
    public static string ReadJsonFile(string fileName)
    {
        try
        {
            string assemblyLocation = Assembly.GetExecutingAssembly().Location;
            string directory = Path.GetDirectoryName(assemblyLocation);
            string filePath = Path.Combine(directory, fileName);

            string jsonContent = File.ReadAllText(filePath);
            return jsonContent;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al leer el archivo JSON: {ex.Message}");
            return null;
        }
    }
}