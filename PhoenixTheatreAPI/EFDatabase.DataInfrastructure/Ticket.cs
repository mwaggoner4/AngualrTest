using System;
using System.Collections.Generic;

namespace PhoenixTheatre.DataInfrastructure
{
    public partial class Ticket
    {
        public Ticket()
        {
            InvoiceLineItems = new HashSet<InvoiceLineItem>();
        }

        public string TicketType { get; set; } = null!;
        public decimal TicketPrice { get; set; }

        public virtual ICollection<InvoiceLineItem> InvoiceLineItems { get; set; }
    }
}
