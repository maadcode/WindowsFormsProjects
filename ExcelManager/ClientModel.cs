namespace ExcelManager;

public class ClientModel
{
    public string Name { get; set; }
    public string Email { get; set; }
    public double Account { get; set; }
    public ClientCategory Category { get; set; }
    public int Age { get; set; }
    public DateTime DateRegister { get; set; }
}

public enum ClientCategory
{
    REGULAR,
    NUEVO,
    DUDOSO,
}