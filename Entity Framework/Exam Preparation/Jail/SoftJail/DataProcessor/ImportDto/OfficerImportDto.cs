using SoftJail.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;

namespace SoftJail.DataProcessor.ImportDto
{
    [XmlType("Officer")]
    public class OfficerImportDto
    {
        [XmlElement("Name")]
        [Required]
        [MinLength(GlobalConstants.fullNameMinLenght)]
        [MaxLength(GlobalConstants.officerFullNameMaxLenght)]
        public string FullName { get; set; }

        [XmlElement("Money")]
        [Range(typeof(decimal), GlobalConstants.SalaryMinRange, GlobalConstants.SalaryMaxRange)]
        public decimal Salary { get; set; }

        [XmlElement("Position")]
        [Required]
        public string Position { get; set; }

        [XmlElement("Weapon")]
        [Required]
        public string Weapon { get; set; }

        [XmlElement("DepartmetnId")]
        [Required]
        public int DepartmentId { get; set; }

        [XmlArray("Prisoners")]
        public OfficerPrisonerImportDto[] Prisoners { get; set; }

    }
}
