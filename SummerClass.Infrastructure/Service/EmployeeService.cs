using Microsoft.EntityFrameworkCore;
using SummerClass.Application.Common.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerClass.Infrastructure.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public EmployeeService(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<string> GetName(Guid employeeId)
        {
            var employeeDetails =  await _applicationDbContext.Employee.FirstOrDefaultAsync(x => x.Id == employeeId);

            return employeeDetails.Name;
        }
    }
}
