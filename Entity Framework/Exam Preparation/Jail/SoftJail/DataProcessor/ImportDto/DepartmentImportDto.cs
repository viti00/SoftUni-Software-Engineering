using SoftJail.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SoftJail.DataProcessor.ImportDto
{
    public class DepartmentImportDto
    {
        [Required]
        [MinLength(GlobalConstants.nameMinLenght)]
        [MaxLength(GlobalConstants.nameMaxLenght)]
        public string Name { get; set; }

        public DepartmentCelsImportDto[] Cells { get; set; }
    }
}
