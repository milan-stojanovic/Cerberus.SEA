namespace Cerberus.SEA.DataAccess.Configuration
{
    public interface IMongoConfiguration
    {
        string DatabaseName { get; }
        string Username { get; }
        string Password { get; }
        string Host { get; }
        int Port { get; }
    }
}