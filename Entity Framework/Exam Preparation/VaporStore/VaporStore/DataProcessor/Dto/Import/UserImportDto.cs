using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using VaporStore.Common;

namespace VaporStore.DataProcessor.Dto.Import
{
    public class UserImportDto
    {

        [Required]
        [RegularExpression(GlobalConstants.fullNameRegex)]
        public string FullName { get; set; }

        [Required]
        [MinLength(GlobalConstants.usernameMinLenght)]
        [MaxLength(GlobalConstants.usernameMaxLenght)]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; }

        [Range(3, 103)]
        public int Age { get; set; }

        public UserCardsImportDto[] Cards { get; set; }
    }
}
