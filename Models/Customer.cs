using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalLabApp.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please insert Name")]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }
        public string Code { get; set; }

        [Required(ErrorMessage = "Please insert Phone Number")]
        public int Phone { get; set; }

        [Required(ErrorMessage = "Please insert Address")]
        [StringLength(70, MinimumLength = 2)]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
        public bool Status { get; set; }

        public virtual  ICollection<InvoiceDetail> InvoiceDetails { get; set; }
    }
}
