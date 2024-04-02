using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EthiopianCalendarConverter;

namespace CalendarTest;

[TestClass]
public class EthiopianCalendarTests
{
    [TestMethod]
    public void TestEthiopianDateConversion()
    {
        // Arrange
        DateTime gregorianDate = new DateTime(2024, 4, 2);
        EthiopianCalendarConverter.EthiopianCalendar ethiopianCalendar = new EthiopianCalendarConverter.EthiopianCalendar(gregorianDate);

        // Act
        string ethiopianDate = ethiopianCalendar.Date();    

        // Assert
        Assert.AreEqual("2016-7-24", ethiopianDate);
    }
}




// namespace EthiopianCalendar.Tests
// {
//     [TestClass]
//     public class EthiopianCalendarTests
//     {
//         [TestMethod]
//         public void TestEthiopianDateConversion()
//         {
//             // Arrange
//             DateTime gregorianDate = new DateTime(2024, 4, 2);
//             EthiopianCalendar ethiopianCalendar = new EthiopianCalendar(gregorianDate);

//             // Act
//             string ethiopianDate = ethiopianCalendar.Date();

//             // Assert
//             Assert.AreEqual("2016-07-23", ethiopianDate);
//         }

//         // Add more test methods for other functionalities of EthiopianCalendar class
//     }
// }