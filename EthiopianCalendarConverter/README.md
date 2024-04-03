# Ethiopian Calendar Converter

## Overview

Ethiopian Calendar Converter is a .NET library that provides methods to convert and manipulate dates in the Ethiopian and Gregorian calendars. It allows you to easily convert dates from GC to EC and perform various date-related calculations.

## Installation

You can install the Ethiopian Calendar Converter library via NuGet. To install the package, run the following command in the Package Manager Console:

PM> Install-Package EthiopianCalendarConverter

## Usage

### Initializing Ethiopian Calendar

To start using the Ethiopian Calendar Converter, you need to create an instance of the `EthiopianCalendar` class by providing a date in the Gregorian calendar.

```csharp
using EthiopianCalendarConverter;

// ...

DateTime gregorianDate = new DateTime(2023, 1, 1);
EthiopianCalendar ethiopianCalendar = new EthiopianCalendar(gregorianDate);

```

### Converting Dates

The `EthiopianCalendar class` provides methods to convert dates between the Gregorian and Ethiopian calendars and to display different properties of the date.

Gregorian to Ethiopian

```csharp
DateTime gregorianDate = new DateTime(2023, 1, 1);
string ethiopianDate = ethiopianCalendar.Date(); // Output: "2015-04-23"
```

"

### Date Information

The EthiopianCalendar class also allows you to retrieve various date-related information.

```csharp
int year = ethiopianCalendar.Year(); // Output: 2015
int month = ethiopianCalendar.Month(); // Output: 4
int day = ethiopianCalendar.Day(); // Output: 23
int quarter = ethiopianCalendar.Quarter(); // Output: 2
string monthName = ethiopianCalendar.MonthName(); // Output: "ታኅሣሥ"
string weekDay = ethiopianCalendar.WeekDay(); // Output: "እሑድ"
bool isLeapYear = ethiopianCalendar.IsLeapYear(); // Output: true
int fiscalYear = ethiopianCalendar.FiscalYear(); // Output: 2014
int fiscalMonth = ethiopianCalendar.FiscalMonth(); // Output: 10
```


### Date Formatting

V1.2.0 and above also support for date formatting

```csharp
DateTime gregorianDate = new DateTime(2024, 4, 2);
EthiopianCalendar ethiopianCalendar = new EthiopianCalendar(gregorianDate);
string ethiopianDate = ethiopianCalendar.Date(format: "dddd, dd MMMM yyyy");
Console.WriteLine(ethiopianDate); //ሀሙስ, መጋቢት 26 2016
```

## License

This project is licensed under the MIT License.
