using BookShop.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;

namespace BookShop.DataProcessor.ImportDto
{
    [XmlType("Book")]
    public class ImportBookDto
    {
        [XmlElement("Name")]
        [Required]
        [MinLength(GlobalConstants.bookNameMinLenght)]
        [MaxLength(GlobalConstants.bookNameMaxLenght)]
        public string Name { get; set; }

        [XmlElement("Genre")]
        [Range(GlobalConstants.genreMinRange, GlobalConstants.genreMaxRange)]
        public int Genre { get; set; }

        [XmlElement("Price")]
        [Range(typeof(decimal), GlobalConstants.bookPriceMinRange, GlobalConstants.bookPriceMaxRange)]
        public decimal Price { get; set; }

        [XmlElement("Pages")]
        [Range(GlobalConstants.pagesMinRange, GlobalConstants.pagesMaxRange)]
        public int Pages { get; set; }

        [XmlElement("PublishedOn")]
        [Required]
        public string PublishedOn { get; set; }
    }
}
