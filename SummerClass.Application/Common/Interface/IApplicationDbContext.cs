using Microsoft.EntityFrameworkCore;
using SummerClass.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerClass.Application.Common.Interface
{
    public interface IApplicationDbContext
    {
        DbSet<Employee> Employee { get; set; }
        DbSet<Department> Department { get; set; }
    }
}
