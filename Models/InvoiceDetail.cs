using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalLabApp.Models
{
    public class InvoiceDetail
    {
        public int Id { get; set; }
        
        public string Type { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
        
        public string ShopingAddress { get; set; }
        
    }
}
