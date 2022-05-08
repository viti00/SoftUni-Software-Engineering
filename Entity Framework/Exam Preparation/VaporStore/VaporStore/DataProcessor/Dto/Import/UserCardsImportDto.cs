using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using VaporStore.Common;
using VaporStore.Data.Models.Enums;

namespace VaporStore.DataProcessor.Dto.Import
{
    public class UserCardsImportDto
    {
        [Required]
        [RegularExpression(GlobalConstants.numberRegex)]
        public string Number { get; set; }

        [Required]
        [RegularExpression(GlobalConstants.cvcRegex)]
        public string Cvc { get; set; }

        [Required]
        public CardType Type { get; set; }
    }
}
