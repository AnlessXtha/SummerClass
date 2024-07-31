using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerClass.Application.Common.Interface
{
    public interface IEmployeeService
    {
        Task<string> GetName(Guid employeeId);
    }
}
