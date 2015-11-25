using System.Collections.Generic;

namespace CompanyHierarchy.Interfaces
{
    interface ISalesEmployee
    {
        List<Sale> Sales { get; set; }
    }
}
