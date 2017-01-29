using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions.Samples
{
    public static class LegacyExtensions
    {
        public static string ToLegacyFormat(this DateTime datetime)
        {
            return datetime.Year > 1930 ?
                datetime.ToString("1yyMMdd") :
                datetime.ToString("0yyMMdd");
        }

        public static DateTime StartOfDay(this DateTime datetime)
        {
            return new DateTime(datetime.Year, datetime.Month, datetime.Day);
        }

        
    }
}
