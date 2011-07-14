using Interfaces.Database;

namespace Objects.Database
{
    public class DatabaseConfiguration : IDatabaseConfiguration
    {
        public DatabaseConfiguration(string connection)
        {
            Server = connection;
        }

        public string Server { get; set; }

        public string DatabaseName { get; set; }
    }
}
