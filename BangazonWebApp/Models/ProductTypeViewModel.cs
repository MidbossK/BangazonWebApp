using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bangazon.Models;


namespace Bangazon.Models.ProductTypeViewModel

{
    public class ProductTypeViewModel
    {
        public IEnumerable<GroupedProducts> GroupedProducts { get; set; }
    }
}