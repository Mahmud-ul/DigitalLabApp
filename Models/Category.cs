using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalLabApp.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please insert Category Name")]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}
