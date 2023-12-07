using System;

class Calendar
{
    // Nested enum type
    public enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    // Method to print weekdays
    public void PrintWeekdays()
    {
        Console.WriteLine("Weekdays:");
        foreach (DaysOfWeek day in Enum.GetValues(typeof(DaysOfWeek)))
        {
            if (day >= DaysOfWeek.Monday && day <= DaysOfWeek.Friday)
            {
                Console.WriteLine(day);
            }
        }
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of the Calendar class
        Calendar myCalendar = new Calendar();

        // Call the PrintWeekdays method
        myCalendar.PrintWeekdays();
    }
}
