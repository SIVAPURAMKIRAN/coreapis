using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        // GET: api/<EmployeeController>
        [HttpGet]
        public List<EmployeeDetails> Get()
        {
            var employeeDetails = new List<EmployeeDetails>()
            {
                new EmployeeDetails()
                {
                    EmployeeId ="P001",
                    Name ="Kiran",
                    MobileNo="9898989898",
                    Address="Hyderabad"
                },
                new EmployeeDetails()
                {
                    EmployeeId ="P002",
                    Name ="Kamal",
                    MobileNo="98321344454",
                    Address="Siddipet"
                }
            };
            return employeeDetails.ToList();
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public List<EmployeeDetails> Get(int id)
        {
            var getEmployeeDetails = new List<EmployeeDetails>()
            {
                new EmployeeDetails()
                {
                    EmployeeId =id.ToString(),
                    Name ="Kiran",
                    MobileNo="9898989898",
                    Address="Hyderabad"
                }
            };
            return getEmployeeDetails;
        }
    }
}
