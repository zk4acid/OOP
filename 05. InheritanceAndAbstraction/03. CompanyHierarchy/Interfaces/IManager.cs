using System.Collections.Generic;
using CompanyHierarchy.Employees;

namespace CompanyHierarchy.Interfaces
{
    interface IManager
    {
        List<Employee> Employees { get; set; }
    }
}
