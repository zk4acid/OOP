using System;

namespace CompanyHierarchy.Interfaces
{
    interface IProject
    {
        string Name { get; set; }

        DateTime StartDate { get; set; }

        string Details { get; set; }

        string State { get; }

        void CloseProject();
    }
}
