using System;
using System.Collections.Generic;
using System.Text;

namespace Theatre
{
    public class GlobalConstants
    {

        //Theatre
        public const int theatreNameMinLenght = 4;
        public const int theatreNameMaxLenght = 30;

        public const byte numberOfHallsMinRange = 1;
        public const byte numberOfHallsMaxRange = 10;

        public const int theatreDirectorMinLenght = 4;
        public const int theatreDirectorMaxLenght = 30;

        //Play
        public const int playTitleMinLenght = 4;
        public const int playTitleMaxLenght = 50;

        public const string ratingMinRange = "0.00";
        public const string ratingMaxRange = "10.00";

        public const int descrtiptionMaxLenght = 700;

        public const int screenWriterMinLenght = 4;
        public const int screenWriterMaxLenght = 30;

        //Cast
        public const string phoneRegex = @"^\+44-\d{2}-\d{3}-\d{4}$";

        public const int fullNameMinLenght = 4;
        public const int fullNameMaxLenght = 30;
    }
}
