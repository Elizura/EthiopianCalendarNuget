using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calander.Common
{
    public static class EthiopianDateCalculator
    {
        public static int GetDay(int Month, int Day)
        {
            return 30 * (Month - 1) + Day;
        }
        public static String ToEthiopian(DateTime Date)
        {
            var GregorianMonth = Date.Month;
            var GregorianYear = Date.Year;
            var GregorianDay = Date.Day;
            int EthiopianYear;
            int EthiopianMonth;
            int EthiopianDay;
            var Buffer = (GregorianYear - 8) % 4 == 3 ? 12 : 11;
            if (Date < new DateTime(GregorianYear, 9, Buffer))
            {
                EthiopianYear = GregorianYear - 8;
            }
            else
            {
                EthiopianYear = GregorianYear - 7;
            }

            if (GregorianMonth == 1)
            {
                if (EthiopianYear % 4 == 0)
                {
                    if (GregorianDay < 10)
                    {
                        EthiopianMonth = 4;
                        EthiopianDay = (GregorianDay + 31) - 10;
                    }
                    else
                    {
                        EthiopianMonth = 5;
                        EthiopianDay = (GregorianDay - 9);
                    }
                }
                else
                {
                    if (GregorianDay < 9)
                    {
                        EthiopianMonth = 4;
                        EthiopianDay = (GregorianDay + 31) - 9;
                    }
                    else
                    {
                        EthiopianMonth = 5;
                        EthiopianDay = (GregorianDay - 8);
                    }
                }
            }
            else if (GregorianMonth == 2)
            {
                if (EthiopianYear % 4 == 0)
                {
                    if (GregorianDay < 10)
                    {
                        EthiopianMonth = 5;
                        EthiopianDay = ((GregorianDay + 31) - 9);
                    }
                    else
                    {
                        EthiopianMonth = 6;
                        EthiopianDay = (GregorianDay - 8);
                    }
                }
                else
                {
                    if (GregorianDay < 8)
                    {
                        EthiopianMonth = 5;
                        EthiopianDay = (GregorianDay + 31) - 8;
                    }
                    else
                    {
                        EthiopianMonth = 6;
                        EthiopianDay = (GregorianDay - 7);
                    }
                }
            }
            else if (GregorianMonth == 3)
            {
                if (GregorianDay < 10)
                {
                    EthiopianMonth = 6;
                    EthiopianDay = (GregorianDay + 29) - 8;
                }
                else
                {
                    EthiopianMonth = 7;
                    EthiopianDay = (GregorianDay - 9);
                }
            }
            else if (GregorianMonth == 4)
            {
                if (GregorianDay < 9)
                {
                    EthiopianMonth = 7;
                    EthiopianDay = (GregorianDay + 30) - 8;
                }
                else
                {
                    EthiopianMonth = 8;
                    EthiopianDay = (GregorianDay - 8);
                }
            }
            else if (GregorianMonth == 5)
            {
                if (GregorianDay < 9)
                {
                    EthiopianMonth = 8;
                    EthiopianDay = (GregorianDay + 30) - 8;
                }
                else
                {
                    EthiopianMonth = 9;
                    EthiopianDay = (GregorianDay - 8);
                }
            }
            else if (GregorianMonth == 6)
            {
                if (GregorianDay < 8)
                {
                    EthiopianMonth = 9;
                    EthiopianDay = (GregorianDay + 31) - 8;
                }
                else
                {
                    EthiopianMonth = 10;
                    EthiopianDay = (GregorianDay - 7);
                }
            }
            else if (GregorianMonth == 7)
            {
                if (GregorianDay < 8)
                {
                    EthiopianMonth = 10;
                    EthiopianDay = (GregorianDay + 30) - 7;
                }
                else
                {
                    EthiopianMonth = 11;
                    EthiopianDay = (GregorianDay - 7);
                }
            }
            else if (GregorianMonth == 8)
            {
                if (GregorianDay < 7)
                {
                    EthiopianMonth = 11;
                    EthiopianDay = (GregorianDay + 31) - 7;
                }
                else
                {
                    EthiopianMonth = 12;
                    EthiopianDay = (GregorianDay - 6);
                }
            }
            else if (GregorianMonth == 9)
            {
                if (EthiopianYear % 4 == 0)
                {
                    if (GregorianDay < 6)
                    {
                        EthiopianMonth = 12;
                        EthiopianDay = EthiopianDay = (GregorianDay + 31) - 6;
                    }
                    else
                    {
                        if (GregorianDay < 12)
                        {
                            EthiopianMonth = 13;
                            EthiopianDay = GregorianDay - 5;
                        }
                        else
                        {
                            EthiopianMonth = 1;
                            EthiopianDay = GregorianDay - 11;
                        }
                    }

                }
                else if (EthiopianYear % 4 == 3)
                {
                    if (GregorianDay < 6)
                    {
                        EthiopianMonth = 12;
                        EthiopianDay = EthiopianDay = (GregorianDay + 31) - 6;
                    }
                    else
                    {
                        if (GregorianYear % 4 == EthiopianYear % 4)
                        {
                            EthiopianMonth = 13;
                            EthiopianDay = GregorianDay - 5;
                        }
                        else
                        {
                            EthiopianMonth = 1;
                            EthiopianDay = GregorianDay - 10;
                        }
                    }

                }
                else
                {
                    if (GregorianDay < 6)
                    {
                        EthiopianMonth = 12;
                        EthiopianDay = EthiopianDay = (GregorianDay + 31) - 6;
                    }
                    else
                    {
                        if (GregorianDay < 11)
                        {
                            EthiopianMonth = 13;
                            EthiopianDay = GregorianDay - 5;
                        }
                        else
                        {

                            EthiopianMonth = 1;
                            EthiopianDay = GregorianDay - 10;
                        }
                    }


                }
            }
            else if (GregorianMonth == 10)
            {
                if (EthiopianYear % 4 == 0)
                {
                    if (GregorianDay < 12)
                    {
                        EthiopianMonth = 1;
                        EthiopianDay = GregorianDay + 30 - 11;
                    }
                    else
                    {
                        EthiopianMonth = 2;
                        EthiopianDay = GregorianDay - 11;
                    }
                }
                else
                {
                    if (GregorianDay < 11)
                    {
                        EthiopianMonth = 1;
                        EthiopianDay = GregorianDay + 30 - 10;
                    }
                    else
                    {
                        EthiopianMonth = 2;
                        EthiopianDay = GregorianDay - 10;
                    }
                }
            }
            else if (GregorianMonth == 11)
            {
                if (EthiopianYear % 4 == 0)
                {
                    if (GregorianDay < 11)
                    {
                        EthiopianMonth = 2;
                        EthiopianDay = GregorianDay + 31 - 11;
                    }
                    else
                    {
                        EthiopianMonth = 3;
                        EthiopianDay = GregorianDay - 10;
                    }
                }
                else
                {
                    if (GregorianDay < 10)
                    {
                        EthiopianMonth = 2;
                        EthiopianDay = GregorianDay + 31 - 10;
                    }
                    else
                    {
                        EthiopianMonth = 3;
                        EthiopianDay = GregorianDay - 9;
                    }
                }
            }
            else if (GregorianMonth == 12)
            {
                if (EthiopianYear % 4 == 0)
                {
                    if (GregorianDay < 11)
                    {
                        EthiopianMonth = 3;
                        EthiopianDay = GregorianDay + 30 - 10;
                    }
                    else
                    {
                        EthiopianMonth = 4;
                        EthiopianDay = GregorianDay - 10;
                    }
                }
                else
                {
                    if (GregorianDay < 10)
                    {
                        EthiopianMonth = 3;
                        EthiopianDay = GregorianDay + 30 - 9;
                    }
                    else
                    {
                        EthiopianMonth = 4;
                        EthiopianDay = GregorianDay - 9;
                    }
                }
            }
            else
            {
                Console.WriteLine($"{GregorianDay},{GregorianMonth}, {GregorianYear}");
                throw new ArgumentOutOfRangeException("Invalid Gregorian month. Please enter the date in YYYY-MM-DD format");
            }

            if (EthiopianDay > 30)
            {
                EthiopianMonth++;
                EthiopianDay -= 30;
                if (EthiopianMonth > 13)
                {
                    EthiopianMonth -= 13;
                    EthiopianYear++;
                }
            }

            return $"{EthiopianYear}-{EthiopianMonth}-{EthiopianDay}";
        }
    }
}