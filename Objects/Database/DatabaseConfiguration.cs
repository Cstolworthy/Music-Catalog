namespace Objects.Database
{
    public class DatabaseConfiguration
    {
        public DatabaseConfiguration(string connection)
        {
            Server = connection;
        }

        public string Server { get; set; }

        public string DatabaseName { get; set; }
    }
}
