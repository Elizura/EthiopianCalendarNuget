using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EthiopianCalendarConverter;

namespace CalendarTest;

[TestClass]
public class EthiopianCalendarTests
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
        // TODO - it should be 2016-07-23
        Assert.AreEqual("2016-7-24", ethiopianDate);
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
    // Console.WriteLine($"The day of the week is {ethiopianCalendar.Week()}");
    // Console.WriteLine($"The day of the week is {ethiopianCalendar.WeekDay()}");
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