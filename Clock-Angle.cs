using System;
using System.Collections.Generic;

class ClockAngle
{

    static void CalcAngleDifference(int hour, int min)
    {
        double hourAngle = (hour * 30) + (0.5 * min);
        double minAngle = (min * 6);
        double angleDifference = 0;
        if (hourAngle > minAngle)
        {
           angleDifference = hourAngle - minAngle;
        }
        else if (minAngle > hourAngle)
        {
            angleDifference = minAngle - hourAngle;
        }
        if (angleDifference > 180)
        {
            angleDifference = 360 - angleDifference;
        }
        Console.WriteLine("Angle Difference: " + angleDifference + "°");
    }
    static void Main()
    {
        int hour = 0;
        int min = 0;
        Console.WriteLine("Enter a time: ");
        string userInput = Console.ReadLine();
        if (userInput.Length < 4 || userInput.Length > 5)
        {
            Console.WriteLine("Invalid input. Please try again.");
            Main();
        }
        if (userInput.Length == 4)
        {
            //userInput[] is a Char datatype. It must be converted to a string before you can int.Parse
            hour = int.Parse(userInput[0].ToString());
            min = int.Parse(userInput[2].ToString() + userInput[3].ToString());

        } else if (userInput.Length == 5)
        {
            hour = int.Parse(userInput[0].ToString() + userInput[1].ToString());
            min = int.Parse(userInput[3].ToString() + userInput[4].ToString());
        }
        if (hour < 1 || hour > 12 || min < 0 || min > 59)
        {
            Console.WriteLine("Invalid time. Please try again.");
            Main();
        }
        else
        {
        Console.WriteLine("Hour: " + hour + " Min: " + min);
        CalcAngleDifference(hour, min);
        }
    }
}