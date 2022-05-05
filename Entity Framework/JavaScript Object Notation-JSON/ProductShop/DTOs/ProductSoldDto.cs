using System;
using System.Collections.Generic;
using System.Text;

namespace ProductShop.DTOs
{
    public class ProductSoldDto
    {
        public int Count { get; set; }

        public ProductAllDto[] Products { get; set; }
    }
}
