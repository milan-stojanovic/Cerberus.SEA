using MongoDB.Driver;

namespace Cerberus.SEA.DataAccess.Configuration
{
    public class MongoFactory : IMongoFactory
    {
        private readonly IMongoClient _mongoClient;
        private readonly string _databaseName;

        public MongoFactory(IMongoConfiguration mongoConfiguration)
        {
            _databaseName = mongoConfiguration.DatabaseName;

            var username = mongoConfiguration.Username;
            var password = mongoConfiguration.Password;
            var host = mongoConfiguration.Host;
            var port = mongoConfiguration.Port;

            var credentials = MongoCredential.CreateCredential(_databaseName, username, password);
            var settings = MongoHelpers.GetMongoClientSettings(host, port, credentials);

            _mongoClient = new MongoClient(settings);
        }

        public IMongoDatabase GetMongoDatabase()
        {
            IMongoDatabase database = _mongoClient.GetDatabase(_databaseName);

            return database;
        }
    }
}