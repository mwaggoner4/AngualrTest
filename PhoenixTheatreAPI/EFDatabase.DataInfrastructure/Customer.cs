using System;
using System.Collections.Generic;

namespace PhoenixTheatre.DataInfrastructure
{
    public partial class Customer
    {
        public Customer()
        {
            CustomerOrders = new HashSet<CustomerOrder>();
        }

        public Guid CustomerId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string UserPassword { get; set; } = null!;

        public virtual ICollection<CustomerOrder> CustomerOrders { get; set; }
    }
}
