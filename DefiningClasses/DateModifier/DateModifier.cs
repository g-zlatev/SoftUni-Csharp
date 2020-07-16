using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    public static class DateModifier
    {
        public static double CalculateSumBetweenDays(string dateOne, string dateTwo)
        {
            var parsedDateOne = DateTime.Parse(dateOne);
            var parsedDateTwo = DateTime.Parse(dateTwo);

            var sumBetweenDays = Math.Abs((parsedDateOne - parsedDateTwo).TotalDays);

            return sumBetweenDays;
        }

    }
}
