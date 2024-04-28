using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sundent_Class1.BusinessLogic;

namespace Sundent_Class1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet("getAllStudent")]
        public ActionResult GetallStudent()
        {
            ServiceLayer serviceLayer = new ServiceLayer();
            return Ok(serviceLayer.GetStudent());
        }  
    }
}
