using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalLabApp.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please insert Item Name")]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please insert Item Code")]
        public int Code { get; set; }

        [Required(ErrorMessage = "Please insert Item Price")]
        public int Price { get; set; }
        public int Stock { get; set; }
        public bool Status { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
