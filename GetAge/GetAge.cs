using System;

class GetAge
{
    static void Main()
    {
        DateTime Today = DateTime.Now;
        Console.Write("Enter your birthday: ");
        DateTime Birthday = DateTime.Parse(Console.ReadLine());//1, 2
        TimeSpan AgeNow = Today - Birthday;                   //3
        double YourAge = AgeNow.TotalDays / 365.2425;        // 4
        Console.WriteLine("Your age is " + ((int)YourAge));
        Console.WriteLine("After 10 years yor age will be " + ((int)YourAge + 10));
    }
}
//1. Converts the string representation of a date and time to its DateTime equivalent.;
//2. Reads the next line of characters from the standard input stream.;
//3. Represents a time interval.;
//4. Statistical value for 400 years;
