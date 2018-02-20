using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BangazonWebApp.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [Display(Name = "Product Name")]
        public string Name;

        [Required]
        public string Description;

        [Required]
        [Display(Name = "Quantity Available")]
        public int Quantity { get; set; }

        [Required]
        [Display(Name = "Date created ")]
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }

        [Required]
        [Display(Name = "Product Category")]
        public int ProductTypeId { get; set; }

        [Required]
        [Display(Name = "Price")]
        public string Price;

        public ProductType ProductType { get; set; }
    }
}
