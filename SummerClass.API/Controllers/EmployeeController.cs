using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SummerClass.Application.Common.Interface;

namespace SummerClass.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }


        [HttpGet("Name")]
        public async Task<string> GetEmployeeName(Guid id)
        {
            return await _employeeService.GetName(id);
        }
    }
}
