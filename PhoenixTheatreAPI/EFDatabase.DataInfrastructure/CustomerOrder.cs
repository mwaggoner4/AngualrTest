using System;
using System.Collections.Generic;

namespace PhoenixTheatre.DataInfrastructure
{
    public partial class CustomerOrder
    {
        public CustomerOrder()
        {
            InvoiceLineItems = new HashSet<InvoiceLineItem>();
        }

        public Guid OrderId { get; set; }
        public Guid CustomerId { get; set; }
        public int TheatreId { get; set; }
        public decimal TotalPrice { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual Theatre Theatre { get; set; } = null!;
        public virtual ICollection<InvoiceLineItem> InvoiceLineItems { get; set; }
    }
}
