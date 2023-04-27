/*
using System.Globalization;
CultureInfo cultureInfo = new("fi-FI");

Console.WriteLine(@"Enter the starting date and time in following format 'DD-MM-YYYY HH:MM:SS'");
var startingDateString = Console.ReadLine();
DateTime date1 = DateTime.Parse(startingDateString, cultureInfo);
Console.WriteLine(date1.ToString());
*/


Console.WriteLine(@"Enter the starting date and time in following format 'DD-MM-YYYY HH:MM:SS'");
var startingDateString = Console.ReadLine();
DateTime startingDateTime;
DateTime endDateTime;
if (DateTime.TryParse(startingDateString, out startingDateTime))
{
    startingDateTime = startingDateTime;
}
else
{
    Console.WriteLine("Invalid date and time. Please enter date and time in correct format");
}
Console.WriteLine();
Console.WriteLine(@"Enter the end date and time in following format 'DD-MM-YYYY HH:MM:SS'");
var endDateString = Console.ReadLine();
if (DateTime.TryParse(endDateString, out endDateTime, CultureAwareComparer.InvariantCulture))
{
    endDateTime = endDateTime;
}
else
{
    Console.WriteLine("Invalid date and time. Please enter date and time in correct format");
}
var duration = endDateTime - startingDateTime;
Console.WriteLine(duration.TotalDays.ToString());
