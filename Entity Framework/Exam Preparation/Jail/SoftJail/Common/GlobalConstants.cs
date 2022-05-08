using System;
using System.Collections.Generic;
using System.Text;

namespace SoftJail.Common
{
    public class GlobalConstants
    {
        //Prisoner
        public const int fullNameMinLenght = 3;
        public const int fullNameMaxLenght = 20;

        public const string nickNameRegex = @"^The [A-Z][a-z]+$";

        public const string bailMaxRange = "79228162514264337593543950335";
        public const string bailMinRange = "0";

        //Officer
        public const int officerFullNameMinLenght = 3;
        public const int officerFullNameMaxLenght = 30;

        public const string SalaryMaxRange = "79228162514264337593543950335";
        public const string SalaryMinRange = "0";

        //Mail
        public const string addressRegex = @"^[0-9\sA-z]+str.$";

        //Department
        public const int nameMinLenght = 3;
        public const int nameMaxLenght = 25;
    }
}
