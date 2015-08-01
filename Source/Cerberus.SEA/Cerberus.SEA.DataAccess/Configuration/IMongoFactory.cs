using MongoDB.Driver;

namespace Cerberus.SEA.DataAccess.Configuration
{
    public interface IMongoFactory
    {
        IMongoDatabase GetMongoDatabase();
    }
}
