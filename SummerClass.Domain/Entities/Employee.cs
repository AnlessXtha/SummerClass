using SummerClass.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerClass.Domain.Entities
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; }
        public float Salary { get; set; }
        public string Designation { get; set; }
    }
}
