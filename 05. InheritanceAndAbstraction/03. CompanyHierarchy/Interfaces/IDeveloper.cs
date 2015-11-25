using System.Collections.Generic;

namespace CompanyHierarchy.Interfaces
{
    interface IDeveloper
    {
        List<Project> Projects { get; set; }
    }
}
