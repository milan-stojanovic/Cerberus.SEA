using MongoDB.Driver;

namespace Cerberus.SEA.DataAccess.Configuration
{
    public static class MongoHelpers
    {
        public static MongoClientSettings GetMongoClientSettings(string host, int port, MongoCredential credentials)
        {
            return new MongoClientSettings
            {
                Server = new MongoServerAddress(host, port),
                Credentials = new[] { credentials }
            };
        }
    }
}