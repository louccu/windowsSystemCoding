using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductService.Models
{

    // Entity Relations in OData v4 Using ASP.NET Web API 2.2
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}