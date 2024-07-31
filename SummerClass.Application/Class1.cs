using Microsoft.EntityFrameworkCore;
using SummerClass.Application.Common.Interface;

namespace SummerClass.Application
{
    public class Class1
    {
        private readonly IApplicationDbContext _applicationDbContext;
        public Class1(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public void Hello()
        {
           var employeeDetails =  _applicationDbContext.Employee.FirstOrDefaultAsync();
        }
    }
}
