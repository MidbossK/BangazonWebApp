using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BangazonWebApp.Models
{
    public class ProductType
    {
        [Key]
        public int ProductTypeId { get; set; }

        [Required]
        [Display(Name = "Product Category")]
        public string Category { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
