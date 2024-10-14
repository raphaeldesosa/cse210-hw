using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
       WritingAssignment writingAssignment = new WritingAssignment("Kathleen De Sosa", "Interior Design", "A brief history of colors");
       Console.WriteLine(writingAssignment.GetSummary());
       Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}