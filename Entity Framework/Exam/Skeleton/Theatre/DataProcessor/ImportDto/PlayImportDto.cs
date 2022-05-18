using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;

namespace Theatre.DataProcessor.ImportDto
{
    [XmlType("Play")]
    public class PlayImportDto
    {
        [XmlElement("Title")]
        [Required]
        [MaxLength(GlobalConstants.playTitleMaxLenght)]
        [MinLength(GlobalConstants.playTitleMinLenght)]
        public string Title { get; set; }

        [XmlElement("Duration")]
        public string Duration { get; set; }

        [XmlElement("Rating")]
        [Range(0.00, 10.00)]
        public float Rating { get; set; }

        [XmlElement("Genre")]
        [Required]
        public string Genre { get; set; }

        [XmlElement("Description")]
        [Required]
        [MaxLength(GlobalConstants.descrtiptionMaxLenght)]
        public string Description { get; set; }

        [XmlElement("Screenwriter")]
        [Required]
        [MinLength(GlobalConstants.screenWriterMinLenght)]
        [MaxLength(GlobalConstants.screenWriterMaxLenght)]
        public string Screenwriter { get; set; }
    }
}
