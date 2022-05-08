using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SoftJail.DataProcessor.ExportDto
{
    [XmlType("Message")]
    public class PrisonerMailsExportDto
    {
        [XmlElement("Description")]
        public string ReversedDescription { get; set; }
    }
}
