using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace CarDealer.DTOs.Import
{
    [XmlType("Car")]
    public class CarInputModel
    {
        [XmlElement("make")]
        public string Make { get; set; }

        [XmlElement("model")]
        public string Model { get; set; }

        [XmlElement("TraveledDistance")]
        public long TraveledDistance { get; set; }

        [XmlArray("parts")]
        public PartIdModel[] Parts { get; set; }
    }

    [XmlType("partId")]
    public class PartIdModel
    {
        [XmlAttribute("id")]
        public int PartId { get; set; }
    }
}
