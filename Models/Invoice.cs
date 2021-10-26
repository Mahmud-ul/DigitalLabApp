using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalLabApp.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public string Payment { get; set; }
        public string InvoiceDetailId { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual InvoiceDetail InvoiceDetail { get; set; }
    }
}
