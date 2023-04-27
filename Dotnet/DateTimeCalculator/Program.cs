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
if (DateTime.TryParse(endDateString, out endDateTime))
{
    endDateTime = endDateTime;
}
else
{
    Console.WriteLine("Invalid date and time. Please enter date and time in correct format");
}
var duration = endDateTime - startingDateTime;
Console.WriteLine(duration.TotalDays.ToString());

