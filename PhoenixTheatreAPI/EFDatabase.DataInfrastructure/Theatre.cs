using System;
using System.Collections.Generic;

namespace PhoenixTheatre.DataInfrastructure
{
    public partial class Theatre
    {
        public Theatre()
        {
            CustomerOrders = new HashSet<CustomerOrder>();
            Employees = new HashSet<Employee>();
            FilmShowings = new HashSet<FilmShowing>();
        }

        public int TheatreId { get; set; }
        public string TheatreLocation { get; set; } = null!;

        public virtual ICollection<CustomerOrder> CustomerOrders { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<FilmShowing> FilmShowings { get; set; }
    }
}
