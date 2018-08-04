using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.nameChanged = new NameChangedDelegate(OnNameChanged);
            book.Name = "Eric's Gradebook";
            book.AddGrade(95);
            book.AddGrade(89.5f);
            book.AddGrade(77);

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine(book.Name);
            WriteResult("Lowest", stats.LowestGrade);
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", (int)stats.HighestGrade);


            //keeps the program open so I can see the results.
            Console.ReadLine();
        }

        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine("{0}: {1}", description, result);
        }

        static void OnNameChanged(string exisitingName, string newName)
        {
            Console.WriteLine($"Gradebook changing name from {exisitingName} to {newName}");
        }
    }
}
