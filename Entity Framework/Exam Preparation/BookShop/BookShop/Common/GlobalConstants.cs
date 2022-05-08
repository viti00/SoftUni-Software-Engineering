using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop.Common
{
    public class GlobalConstants
    {
        //Book
        public const int bookNameMinLenght = 3;
        public const int bookNameMaxLenght = 30;

        public const string bookPriceMinRange = "0.01";
        public const string bookPriceMaxRange = "79228162514264337593543950335";

        public const int pagesMinRange = 50;
        public const int pagesMaxRange = 5000;

        public const int genreMinRange = 1;
        public const int genreMaxRange = 3;

        //Author
        public const int firstNameMinLenght = 3;
        public const int firstNameMaxLenght = 30;

        public const int lastNameMinLenght = 3;
        public const int lastNameMaxLenght = 30;

        public const string phoneRegex = @"^\d{3}-\d{3}-\d{4}$";
    }
}
