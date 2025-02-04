using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._Date_Modifier
{
    public static class DateModifier
    {
        public static int CalculateDateDiffInDays(DateTime date1, DateTime date2)
        {
            TimeSpan diff = date1 - date2;
            return Math.Abs(diff.Days);
        }
    }
}
