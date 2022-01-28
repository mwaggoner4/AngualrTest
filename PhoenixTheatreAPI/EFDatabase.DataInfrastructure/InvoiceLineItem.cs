using System;
using System.Collections.Generic;

namespace PhoenixTheatre.DataInfrastructure
{
    public partial class InvoiceLineItem
    {
        public int InvoiceId { get; set; }
        public Guid OrderId { get; set; }
        public string TicketType { get; set; } = null!;
        public int Quantity { get; set; }

        public virtual CustomerOrder Order { get; set; } = null!;
        public virtual Ticket TicketTypeNavigation { get; set; } = null!;
    }
}
