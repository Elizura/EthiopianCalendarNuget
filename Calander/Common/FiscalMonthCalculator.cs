using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calander.Common
{
    public static class FiscalMonthCalculator
    {
        public static int GetFiscalMonth(int Month)
        {
            var FiscalMonth = (((Month - 11) % 12 + 12)) % 12 + 1;
            return FiscalMonth;
        }
        public static int GetFiscalMonthEnglish(int Month)
        {
            int FiscalMonth;

            if (Month < 7)
            {
                FiscalMonth = Month + 6;
            }
            else
            {
                FiscalMonth = Month - 6;
            }
            return FiscalMonth;
        }
    }
}