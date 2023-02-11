using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.DateModifier
{
    internal class DateModifier
    {
        public static int GetDiffrenceInDays(string start, string end)
        {
            DateTime startDate = DateTime.Parse(start);
            DateTime endDate = DateTime.Parse(end);

            TimeSpan diff = startDate - endDate;
            
            return Math.Abs(diff.Days);
        }
    }
}
