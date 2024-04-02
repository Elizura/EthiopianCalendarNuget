using System.Globalization;
using Calander;
using Calander.Common;

namespace EthiopianCalendarConverter;

/// <summary>
/// Represents an Ethiopian calendar and provides methods to convert and manipulate dates in Ethiopian and Gregorian calendars.
/// </summary>
public class EthiopianCalendar
{
    private DateTime _date;
    /// <summary>
    /// Initializes a new instance of the <see cref="EthiopianCalendar"/> class with the specified date in the Gregorian calendar.
    /// </summary>
    /// <param name="date">The date in the Gregorian calendar.</param>

    public EthiopianCalendar(DateTime date)
    {
        _date = date;
    }
    /// <summary>
    /// Converts the Gregorian date to the Ethiopian date.
    /// </summary>
    /// <param name="culture">The culture info for formatting the date.</param>
    /// <param name="format">The format of the Ethiopian date.</param>
    /// <returns>The Ethiopian date in the format "yyyy-MM-dd".</returns>

    public string Date(CultureInfo? culture = null, string format = "yyyy-MM-dd")
    {
        if (culture != null && culture.Name == Language.English)
        {
            return _date.ToString(format);
        }
        var EthiopianDateTranslation = EthiopianDateCalculator.ToEthiopian(_date);
        return EthiopianDateTranslation;

    }
    /// <summary>
    /// Gets the year of the Ethiopian date.
    /// </summary>
    /// <param name="culture">The culture info for formatting the date.</param>
    /// <returns>The year of the Ethiopian date.</returns>

    public int Year(CultureInfo? culture = null)
    {
        if (culture != null && culture.Name == Language.English)
        {
            return _date.Year;
        }
        return int.Parse(Date(culture).Split("-")[0]);
    }
    /// <summary>
    /// Gets the month of the Ethiopian date.
    /// </summary>
    /// <param name="culture">The culture info for formatting the date.</param>
    /// <returns>The month of the Ethiopian date.</returns>
    public int Month(CultureInfo? culture = null)
    {
        if (culture != null && culture.Name == Language.English)
        {
            return _date.Month;
        }
        var EthiopianDateTranslation = EthiopianDateCalculator.ToEthiopian(_date);
        return int.Parse(EthiopianDateTranslation.Split("-")[1]);
    }
    /// <summary>
    /// Gets the quarter of the Ethiopian date.
    /// </summary>
    /// <param name="culture">The culture info for formatting the date.</param>
    /// <returns>The quarter of the Ethiopian date.</returns>

    public int Quarter(CultureInfo? culture = null)
    {
        if (culture != null && culture.Name == Language.English)
        {
            return (int)Math.Ceiling(_date.Month / 3.0);
        }
        return (int)Math.Ceiling(Month(culture) / 3.0);
    }
    /// <summary>
    /// Gets the name of the quarter in the specified culture's language.
    /// </summary>
    /// <param name="culture">The culture info for formatting the name.</param>
    /// <returns>The name of the quarter in the specified culture's language.</returns>
    public string QuarterName(CultureInfo? culture = null)
    {
        if (culture == null || culture.Name == Language.Amharic)
        {
            return $"ሩብ ዓመት {Quarter(culture)}";
        }
        else if (culture.Name == Language.AfaanOromoo)
        {
            return $"Nuusa Waggaa {Quarter(culture)}";
        }
        else if (culture.Name == Language.Tigrigna)
        {
            return $"ሩብ ዓመት {Quarter(culture)}";
        }

        else if (culture.Name == Language.Somale)
        {
            return $"Quarter {Quarter(culture)}";
        }
        else if (culture.Name == Language.Sidama)
        {
            return $"Quarter {Quarter(culture)}";
        }
        return $"Quarter {Quarter(culture)}";

    }
    /// <summary>
    /// Gets the name of the month in the specified culture's language.
    /// </summary>
    /// <param name="culture">The culture info for formatting the name.</param>
    /// <returns>The name of the month in the specified culture's language.</returns>
    public string MonthName(CultureInfo? culture = null)
    {
        if (culture == null || culture.Name == Language.Amharic)
        {
            return MonthNames.AmharicMonths[Month(culture) - 1];
        }
        else if (culture.Name == Language.AfaanOromoo)
        {
            return MonthNames.AffanOromoMonths[Month(culture) - 1];
        }
        else if (culture.Name == Language.Tigrigna)
        {
            return MonthNames.TigrignaMonths[Month(culture) - 1];
        }

        else if (culture.Name == Language.Somale)
        {
            return MonthNames.SomaleMonths[Month(culture) - 1];
        }
        else if (culture.Name == Language.Sidama)
        {
            return MonthNames.SidamaMonths[Month(culture) - 1];
        }
        return MonthNames.EnglishMonths[Month(culture) - 1];

    }
    /// <summary>
    /// Gets the day of the Ethiopian date.
    /// </summary>
    /// <param name="culture">The culture info for formatting the date.</param>
    /// <returns>The day of the Ethiopian date.</returns>
    public int Day(CultureInfo? culture = null)
    {
        if (culture != null && culture.Name == Language.English)
        {
            return _date.Day;
        }
        return int.Parse(Date(culture).Split("-")[2]);
    }
    /// <summary>
    /// Gets the week of the Ethiopian date.
    /// </summary>
    /// <param name="culture">The culture info for formatting the date.</param>
    /// <returns>The week of the Ethiopian date.</returns>
    public int Week(CultureInfo? culture = null)
    {

        if (culture != null && culture.Name == Language.English)
        {

            return CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(_date, CalendarWeekRule.FirstFullWeek, DayOfWeek.Monday);
        }
        var EthiopianDate = EthiopianDateCalculator.GetDay(Month(culture), Day(culture));
        return (int)Math.Ceiling(EthiopianDate / 7.0);


    }
    /// <summary>
    /// Gets the day of the year in the Ethiopian calendar.
    /// </summary>
    /// <param name="culture">The culture info for formatting the date.</param>
    /// <returns>The day of the year in the Ethiopian calendar.</returns>
    public int DayOfYear(CultureInfo? culture = null)
    {
        if (culture != null && CultureInfo.CurrentCulture.Name == Language.English)
        {
            return _date.DayOfYear;
        }
        return EthiopianDateCalculator.GetDay(Month(culture), Day(culture));
    }
    /// <summary>
    /// Gets the name of the weekday in the specified culture's language.
    /// </summary>
    /// <param name="culture">The culture info for formatting the name.</param>
    /// <returns>The name of the weekday in the specified culture's language.</returns>
    public string WeekDay(CultureInfo? culture = null)
    {
        if (culture == null || culture.Name == Language.Amharic)
        {
            var CorrespondingEnglishDate = Date(new CultureInfo(Language.English));
            var CorrespondingEnglishDay = DateTime.Parse(CorrespondingEnglishDate).ToString("dddd", new CultureInfo(Language.English));
            var CorrespondingAmharicName = WeekDays.EnglishToAmharicDayMap[CorrespondingEnglishDay];
            return CorrespondingAmharicName;
        }
        if (culture.Name == Language.AfaanOromoo)
        {
            var CorrespondingEnglishDate = Date(new CultureInfo(Language.English));
            var CorrespondingEnglishDay = DateTime.Parse(CorrespondingEnglishDate).ToString("dddd", new CultureInfo(Language.English));
            var CorrespondingAmharicName = WeekDays.EnglishToAffanOromoDayMap[CorrespondingEnglishDay];
            return CorrespondingAmharicName;
        }
        if (culture.Name == Language.Tigrigna)
        {
            var CorrespondingEnglishDate = Date(new CultureInfo(Language.English));
            var CorrespondingEnglishDay = DateTime.Parse(CorrespondingEnglishDate).ToString("dddd", new CultureInfo(Language.English));
            var CorrespondingAmharicName = WeekDays.EnglishToTigrignaDayMap[CorrespondingEnglishDay];
            return CorrespondingAmharicName;
        }
        if (culture.Name == Language.Sidama)
        {
            var CorrespondingEnglishDate = Date(new CultureInfo(Language.English));
            var CorrespondingEnglishDay = DateTime.Parse(CorrespondingEnglishDate).ToString("dddd", new CultureInfo(Language.English));
            var CorrespondingAmharicName = WeekDays.EnglishToSidamaDayMap[CorrespondingEnglishDay];
            return CorrespondingAmharicName;
        }
        if (culture.Name == Language.Somale)
        {
            var CorrespondingEnglishDate = Date(new CultureInfo(Language.English));
            var CorrespondingEnglishDay = DateTime.Parse(CorrespondingEnglishDate).ToString("dddd", new CultureInfo(Language.English));
            var CorrespondingAmharicName = WeekDays.EnglishToSomaleDayMap[CorrespondingEnglishDay];
            return CorrespondingAmharicName;
        }
        return _date.ToString("dddd", CultureInfo.CurrentCulture);
    }
    /// <summary>
    /// Gets the fiscal year in the Ethiopian calendar.
    /// </summary>
    /// <param name="culture">The culture info for formatting the date.</param>
    /// <returns>The fiscal year in the Ethiopian calendar.</returns>
    public int FiscalYear(CultureInfo? culture = null)
    {

        if (CultureInfo.CurrentCulture.Name == Language.English)
        {
            return FiscalYearCalculator.GetFiscalYearEnglish(Year(culture), Month(culture));
        }

        return FiscalYearCalculator.GetFiscalYear(Year(culture), Month(culture));


    }
    /// <summary>
    /// Gets the fiscal month in the Ethiopian calendar.
    /// </summary>
    /// <param name="culture">The culture info for formatting the date.</param>
    /// <returns>The fiscal month in the Ethiopian calendar.</returns>
    public int FiscalMonth(CultureInfo? culture = null)
    {

        if (CultureInfo.CurrentCulture.Name == Language.English)
        {
            return FiscalMonthCalculator.GetFiscalMonthEnglish(Month(culture));
        }
        return FiscalMonthCalculator.GetFiscalMonth(Month(culture));

    }
    /// <summary>
    /// Checks if the specified year is a leap year in the Ethiopian calendar.
    /// </summary>
    /// <param name="culture">The culture info to use for leap year calculation.</param>
    /// <returns>True if the specified year is a leap year; otherwise, false.</returns>
    public bool IsLeapYear(CultureInfo? culture = null)
    {
        if (culture != null && culture.Name == Language.English)
        {
            return Year(culture) % 4 == 3;
        }
        return Year() % 4 == 3;
    }



}