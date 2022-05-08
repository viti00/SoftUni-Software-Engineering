using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;
using TeisterMask.Common;

namespace TeisterMask.DataProcessor.ImportDto
{
    [XmlType("Project")]
    public class ProjectImportDto
    {
        [XmlElement("Name")]
        [Required]
        [MinLength(GlobalConstants.projectNameMinLenght)]
        [MaxLength(GlobalConstants.projectNameMaxLenght)]
        public string Name { get; set; }

        [XmlElement("OpenDate")]
        [Required]
        public string OpenDate { get; set; }

        [XmlElement("DueDate")]
        public string DueDate { get; set; }

        [XmlArray("Tasks")]
        public ProjectTaskImportDto[] Tasks { get; set; }
    }
}
