using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ProductShop.DTOs.Import
{
    [XmlType("Product")]
    public class ProductsInputDto
    {
        [XmlElement(ElementName ="name")]
        public string Name { get; set; }

        [XmlElement(ElementName ="price")]
        public decimal Price { get; set; }

        [XmlElement(ElementName = "sellerId")]
        public int SellerId { get; set; }

        [XmlElement(ElementName = "buyerId")]
        public int? BuyerId { get; set; }

    }
}
