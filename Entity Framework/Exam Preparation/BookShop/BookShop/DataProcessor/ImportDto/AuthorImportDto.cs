using BookShop.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookShop.DataProcessor.ImportDto
{
    public class AuthorImportDto
    {
        [Required]
        [MinLength(GlobalConstants.firstNameMinLenght)]
        [MaxLength(GlobalConstants.firstNameMaxLenght)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(GlobalConstants.lastNameMinLenght)]
        [MaxLength(GlobalConstants.lastNameMaxLenght)]
        public string LastName { get; set; }

        [Required]
        [RegularExpression(GlobalConstants.phoneRegex)]
        public string Phone { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public AuthorBooksImportDto[] Books { get; set; }
    }
}
