using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TeisterMask.Common;

namespace TeisterMask.DataProcessor.ImportDto
{
    public class EmployeeImportDto
    {
        [Required]
        [MaxLength(GlobalConstants.usernameMaxLenght)]
        [RegularExpression(GlobalConstants.usernameRegex)]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [RegularExpression(GlobalConstants.phoneNumberRegex)]
        public string Phone { get; set; }

        public int[] Tasks { get; set; }
    }
}
