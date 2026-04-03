using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Assignment studentSummary = new Assignment("Samuel Bennett","Multiplication");
        Console.WriteLine(studentSummary.GetSummary());

        Console.WriteLine();

        MathAssignment hwList = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19" );
        Console.WriteLine(hwList.GetSummary());
        Console.WriteLine(hwList.GetHomeworkList());

        Console.WriteLine();

        WritingAssignment writA = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writA.GetSummary());
        Console.WriteLine(writA.GetWritingInformation());
    }
}