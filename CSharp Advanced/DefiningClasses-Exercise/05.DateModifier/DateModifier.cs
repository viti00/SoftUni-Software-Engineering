using System;
using System.Collections.Generic;
using System.Text;

namespace _05.DateModifier
{
    public class DateModifier
    {
        public DateModifier(string firstDate, string secondDate)
        {
            FirstDate = firstDate;
            SecondDate = secondDate;
        }

        public string FirstDate { get; set; }
        public string SecondDate { get; set; }


        public double GetDifference (string firstDate, string secondDate)
        {
            double daysDifference = 0;
            var parseFirst = DateTime.Parse(firstDate);
            var parseSecond = DateTime.Parse(secondDate);
            daysDifference = (parseFirst - parseSecond).TotalDays;
            daysDifference = Math.Abs(daysDifference);
            return daysDifference;
        }
    }
}
