using System;
using System.Collections.Generic;
using System.Text;

namespace VaporStore.Common
{
    public class GlobalConstants
    {
        //User

        public const int usernameMaxLenght = 20;

        public const int usernameMinLenght = 3;

        public const string fullNameRegex = @"^[A-Z][a-z]+ [A-Z][a-z]+$";

        //User
        public const string numberRegex = @"^\d{4} \d{4} \d{4} \d{4}$";

        public const string cvcRegex = @"^\d{3}$";

        //Purchase
        public const string productKeyRegex = @"^[A-Z0-9]{4}-[A-Z0-9]{4}-[A-Z0-9]{4}$";
    }
}
