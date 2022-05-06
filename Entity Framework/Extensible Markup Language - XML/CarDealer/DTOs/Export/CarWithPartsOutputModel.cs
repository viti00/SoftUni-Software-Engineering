using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace CarDealer.DTOs.Export
{
    [XmlType("car")]
    public class CarWithPartsOutputModel
    {
        [XmlAttribute("make")]
        public string Make { get; set; }

        [XmlAttribute("model")]
        public string Model { get; set; }

        [XmlAttribute("travelled-distance")]
        public string TraveledDistance { get; set; }

        [XmlArray("parts")]
        public PartsOutputModel[] Parts { get; set; }
    }

    [XmlType("part")]
    public class PartsOutputModel
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("price")]
        public string Price { get; set; }
    }
}
