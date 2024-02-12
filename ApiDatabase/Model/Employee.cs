using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ApiDatabase.Model
{
    public class Employee
    {
        public string Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public int Dept { get; set; }
        public required string Gender { get; set; }
        public required string Country { get; set; }
        public decimal Salary { get; set; }
        public DateTime DOB { get; set; }
    }
}