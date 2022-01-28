using System;
using System.Collections.Generic;

namespace PhoenixTheatre.DataInfrastructure
{
    public partial class Employee
    {
        public Guid EmployeeId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string UserPassword { get; set; } = null!;
        public string IsManager { get; set; } = null!;
        public int TheatreId { get; set; }

        public virtual Theatre Theatre { get; set; } = null!;
    }
}
