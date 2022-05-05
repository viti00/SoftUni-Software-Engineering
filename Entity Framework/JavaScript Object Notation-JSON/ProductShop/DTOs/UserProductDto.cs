using System;
using System.Collections.Generic;
using System.Text;

namespace ProductShop.DTOs
{
    public class UserProductDto
    {
        public string LastName { get; set; }

        public int? Age { get; set; }

        public ProductSoldDto SoldProducts { get; set; }
    }
}
