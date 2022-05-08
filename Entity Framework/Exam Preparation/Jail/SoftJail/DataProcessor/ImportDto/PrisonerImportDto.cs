using SoftJail.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SoftJail.DataProcessor.ImportDto
{
    public class PrisonerImportDto
    {
        [Required]
        [MinLength(GlobalConstants.fullNameMinLenght)]
        [MaxLength(GlobalConstants.fullNameMaxLenght)]
        public string FullName { get; set; }
        [Required]
        [RegularExpression(GlobalConstants.nickNameRegex)]
        public string Nickname { get; set; }

        [Range(18, 65)]
        public int Age { get; set; }

        [Required]
        public string IncarcerationDate { get; set; }

        public string ReleaseDate { get; set; }

        [Range(typeof(decimal), GlobalConstants.bailMinRange, GlobalConstants.bailMaxRange)]
        public decimal? Bail { get; set; }

        public int? CellId { get; set; }

        public PrisonerMailsImportDto[] Mails { get; set; }

    }
}
