using System;
using System.Collections.Generic;
using System.Text;

namespace TeisterMask.Common
{
    public class GlobalConstants
    {
        //Employee
        public const int usernameMaxLenght = 40;

        public const string usernameRegex = @"^[A-Za-z0-9]{3,}$";

        public const string phoneNumberRegex = @"^\d{3}\-\d{3}\-\d{4}$";

        //Project

        public const int projectNameMinLenght = 2;
        public const int projectNameMaxLenght = 40;


        //Task
        public const int taskNameMinLenght = 2;
        public const int taskNameMaxLenght = 40;
    }
}
