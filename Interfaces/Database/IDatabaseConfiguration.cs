namespace Interfaces.Database
{
    public interface IDatabaseConfiguration
    {
        string Server { get; set; }
        string DatabaseName { get; set; }
    }
}
