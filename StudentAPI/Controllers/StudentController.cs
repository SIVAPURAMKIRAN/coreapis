using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        // GET: api/<StudentController>
        [HttpGet]
        public List<StudentDetails> Get()
        {
            var studentDetails = new List<StudentDetails>()
            {
                new StudentDetails()
                {
                    StudentId ="P001",
                    Name ="Kiran",
                    MobileNo="9898989898",
                    Address="Hyderabad"
                },
                new StudentDetails()
                {
                    StudentId ="P002",
                    Name ="Kamal",
                    MobileNo="98321344454",
                    Address="Siddipet"
                }
            };
            return studentDetails.ToList();
        }
        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public List<StudentDetails> Get(int id)
        {
            var getstudentDetails = new List<StudentDetails>()
            {
                new StudentDetails()
                {
                    StudentId =id.ToString(),
                    Name ="Kiran",
                    MobileNo="9898989898",
                    Address="Hyderabad"
                }
            };
            return getstudentDetails;
        }
    }
}
