using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calander.Common
{
    public class FiscalYearCalculator
    {
        public static int GetFiscalYear(int Year, int Month)
        {
            var FiscalYear = Month > 10 ? Year + 1 : Year;
            return FiscalYear;
        }
        public static int GetFiscalYearEnglish(int Year, int Month)
        {
            var FiscalYear = Month > 7 ? Year + 1 : Year;
            return FiscalYear;
        }
    }
}