using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Backend.Models
{
    #region Context
    public class CourseContext
    {
        MongoClient client;

        IMongoDatabase database;

        public CourseContext(IConfiguration config)
        {
            client = new MongoClient(config.GetSection("MongoDB:server").Value);
            database = client.GetDatabase(config.GetSection("MongoDB:db").Value);

        }
        public IMongoCollection<Course> Courses => database.GetCollection<Course>("Courses");
        
    }
    #endregion
}
