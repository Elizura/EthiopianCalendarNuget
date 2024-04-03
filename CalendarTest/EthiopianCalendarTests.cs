using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EthiopianCalendarConverter;

namespace CalendarTest;

[TestClass]
public class EthiopianCalendarConversionTest
{
    [TestMethod]
    // Correctly converts Gregorian date to Ethiopian date
    public void TestEthiopianDateConversion()
    {
        // Arrange
        DateTime gregorianDate = new DateTime(2024, 4, 2);
        EthiopianCalendarConverter.EthiopianCalendar ethiopianCalendar = new EthiopianCalendarConverter.EthiopianCalendar(gregorianDate);

        // Act
        string ethiopianDate = ethiopianCalendar.Date();

        // Assert        
        Assert.AreEqual("2016-07-24", ethiopianDate);
    }
    [TestMethod]
    // Correctly show the current Year Month and Day
    public void TestCurrentYearMonthDay()
    {
        // Arrange
        DateTime gregorianDate = new DateTime(2024, 4, 2);
        EthiopianCalendarConverter.EthiopianCalendar ethiopianCalendar = new EthiopianCalendarConverter.EthiopianCalendar(gregorianDate);

        // Act
        int year = ethiopianCalendar.Year();
        int month = ethiopianCalendar.Month();
        int day = ethiopianCalendar.Day();

        // Assert
        Assert.AreEqual(2016, year);
        Assert.AreEqual(7, month);
        Assert.AreEqual(24, day);

    }

    [TestMethod]
    // Correctly calculates the day of the year
    public void TestDayOfYear()
    {
        // Arrange
        DateTime gregorianDate = new DateTime(2024, 4, 2);
        EthiopianCalendarConverter.EthiopianCalendar ethiopianCalendar = new EthiopianCalendarConverter.EthiopianCalendar(gregorianDate);

        // Act
        int dayOfYear = ethiopianCalendar.DayOfYear();

        // Assert
        Assert.AreEqual(204, dayOfYear);
    }

    [TestMethod]
    // Correctly identifies leap year
    public void TestLeapYear()
    {
        // Arrange
        DateTime gregorianDate = new DateTime(2024, 4, 2);
        DateTime gregorianDate2 = new DateTime(2023, 4, 2);
        EthiopianCalendarConverter.EthiopianCalendar ethiopianCalendar = new EthiopianCalendarConverter.EthiopianCalendar(gregorianDate);
        EthiopianCalendarConverter.EthiopianCalendar ethiopianCalendar2 = new EthiopianCalendarConverter.EthiopianCalendar(gregorianDate2);

        // Act
        bool isLeapYear = ethiopianCalendar.IsLeapYear();
        bool isLeapYear2 = ethiopianCalendar2.IsLeapYear();

        // Assert
        Assert.AreEqual(false, isLeapYear);
        Assert.AreEqual(true, isLeapYear2);
    }

    [TestMethod]
    // Correctly identifies the month name
    public void TestMonthName()
    {
        // Arrange
        DateTime gregorianDate = new DateTime(2024, 4, 2);
        EthiopianCalendarConverter.EthiopianCalendar ethiopianCalendar = new EthiopianCalendarConverter.EthiopianCalendar(gregorianDate);

        // Act
        string monthName = ethiopianCalendar.MonthName();

        // Assert
        Assert.AreEqual("መጋቢት", monthName);
    }

    [TestMethod]
    // Correctly identifies the quarter
    public void TestQuarter()
    {
        // Arrange
        DateTime gregorianDate = new DateTime(2024, 4, 2);
        EthiopianCalendarConverter.EthiopianCalendar ethiopianCalendar = new EthiopianCalendarConverter.EthiopianCalendar(gregorianDate);

        // Act
        int quarter = ethiopianCalendar.Quarter();
        string quarterName = ethiopianCalendar.QuarterName();

        // Assert
        Assert.AreEqual(3, quarter);
        Assert.AreEqual("ሩብ ዓመት 3", quarterName);

    }

    [TestMethod]
    // Correctly identifies the day of the week
    public void TestWeek()
    {
        // Arrange
        DateTime gregorianDate = new DateTime(2024, 4, 2);
        EthiopianCalendarConverter.EthiopianCalendar ethiopianCalendar = new EthiopianCalendarConverter.EthiopianCalendar(gregorianDate);

        // Act
        int week = ethiopianCalendar.Week();
        string weekDay = ethiopianCalendar.WeekDay();

        // Assert
        Assert.AreEqual(30, week);
        Assert.AreEqual("ማክሰኞ", weekDay);
    }
}

[TestClass]
public class EthiopianCalendarLocalizationTest
{

    [TestMethod]
    // Correctly identifies the month name in the given localization
    public void TestMonthNames()
    {
        // Arrange
        DateTime gregorianDate = new DateTime(2024, 4, 2);
        EthiopianCalendarConverter.EthiopianCalendar ethiopianCalendar = new EthiopianCalendarConverter.EthiopianCalendar(gregorianDate);

        // Act
        string tigrayMonthName = ethiopianCalendar.MonthName(culture: new CultureInfo("tg-ET"));
        string affanOromoMonthName = ethiopianCalendar.MonthName(culture: new CultureInfo("om-ET"));
        string somaliMonthName = ethiopianCalendar.MonthName(culture: new CultureInfo("sm-ET"));
        string sidamaMonthName = ethiopianCalendar.MonthName(culture: new CultureInfo("sd-ET"));

        // Assert
        Assert.AreEqual("Bitoottessa", affanOromoMonthName);
        Assert.AreEqual("መጋቢት", tigrayMonthName);
        // Issue with somali month name and the calendar usage
        Assert.AreEqual("Maarso", somaliMonthName);
        Assert.AreEqual("Badheessa", sidamaMonthName);
    }
    [TestMethod]
    // Correctly identifies the name of day of the week in the given localization
    public void TestWeekNames()
    {
        // Arrange
        DateTime gregorianDate = new DateTime(2024, 4, 2);
        EthiopianCalendarConverter.EthiopianCalendar ethiopianCalendar = new EthiopianCalendarConverter.EthiopianCalendar(gregorianDate);

        // Act        
        string sidamaDayName = ethiopianCalendar.WeekDay(culture: new CultureInfo("sd-ET"));
        string somaliDayName = ethiopianCalendar.WeekDay(culture: new CultureInfo("sm-ET"));
        string tigrayDayName = ethiopianCalendar.WeekDay(culture: new CultureInfo("tg-ET"));
        string affanOromoDayName = ethiopianCalendar.WeekDay(culture: new CultureInfo("om-ET"));


        // Assert        
        Assert.AreEqual("Kibxata", affanOromoDayName);
        Assert.AreEqual("ሶሉስ", tigrayDayName);
        Assert.AreEqual("Qawaado", sidamaDayName);
    }
}



[TestClass]
public class EthiopianCalendarFormatTest
{

    [TestMethod]
    // Return the date in the given format
    public void TestDateFormats()
    {
        // Arrange
        DateTime gregorianDate = new DateTime(2024, 4, 2);
        EthiopianCalendarConverter.EthiopianCalendar ethiopianCalendar = new EthiopianCalendarConverter.EthiopianCalendar(gregorianDate);

        // Act
        string ethiopianDate = ethiopianCalendar.Date(format: "MM/dd/yyyy");
        string ethiopianDate1 = ethiopianCalendar.Date(format: "dd/MM/yyyy");
        string ethiopianDate2 = ethiopianCalendar.Date(format: "yyyy/MM/dd");
        string ethiopianDate3 = ethiopianCalendar.Date(format: "dddd, dd MMMM yyyy");

        // Assert        
        Assert.AreEqual("07/24/2016", ethiopianDate);
        Assert.AreEqual("24/07/2016", ethiopianDate1);
        Assert.AreEqual("2016/07/24", ethiopianDate2);
        Assert.AreEqual("ማክሰኞ, መጋቢት 24 2016", ethiopianDate3);
    }
}