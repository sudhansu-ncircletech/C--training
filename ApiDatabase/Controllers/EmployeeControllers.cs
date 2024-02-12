using ApiDatabase.data;
using ApiDatabase.Model;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace ApiDatabase.Controllers
{
    [ApiController]
    [Route("api/emp")]
    public class EmployeeController(MongoDbContext context) : ControllerBase
    {
        private readonly MongoDbContext _context = context;

        [HttpPost("add")]
        public IActionResult AddEmployee([FromBody] Employee employee)
        {
            try
            {
                // Add employee to the MongoDB collection and return Employee ID
                _context.Employees.InsertOne(employee);

                return Ok(new { EmployeeId = employee.Id, FirstName = employee.FirstName, LastName = employee.LastName, Dept = employee.Dept, Gender = employee.Gender, Country = employee.Country, Salary = employee.Salary, DOB = employee.DOB });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while adding the employee: {ex.Message}");
            }
        }

        [HttpGet("all")]
        public IActionResult GetAllEmployees()
        {
            try
            {
                // Retrieve all employees from the MongoDB collection and return as JSON
                var allEmployees = _context.Employees.Find(_ => true).ToList();

                return Ok(allEmployees);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while retrieving all employees: {ex.Message}");
            }
        }

        [HttpGet("data/{id}")]
        public IActionResult GetEmployeeById(string id)
        {
            try
            {
                // Retrieve employee by ID from the MongoDB collection and return as JSON
                var employee = _context.Employees.Find(e => e.Id == id).FirstOrDefault();

                if (employee == null)
                    return NotFound("Employee not found");

                return Ok(employee);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while retrieving the employee: {ex.Message}");
            }
        }

        [HttpGet("male")]
        public IActionResult GetMaleEmployees()
        {
            try
            {
                // Retrieve all male employees from the MongoDB collection and return as JSON
                var maleEmployees = _context.Employees.Find(e => e.Gender == "Male").ToList();

                return Ok(maleEmployees);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while retrieving male employees: {ex.Message}");
            }
        }

        [HttpGet("female")]
        public IActionResult GetFemaleEmployees()
        {
            try
            {
                // Retrieve all female employees from the MongoDB collection and return as JSON
                var femaleEmployees = _context.Employees.Find(e => e.Gender == "Female").ToList();

                return Ok(femaleEmployees);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while retrieving female employees: {ex.Message}");
            }
        }
    }
}


