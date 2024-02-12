using ApiDatabase.Model;
using MongoDB.Driver;

namespace ApiDatabase.data
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("MongoDBConnection");
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase("EmployeesDb");
        }

        public IMongoCollection<Employee> Employees => _database.GetCollection<Employee>("Employees");
    }
}

