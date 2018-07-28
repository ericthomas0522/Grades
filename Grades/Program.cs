﻿using System;
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
            book.AddGrade(95);
            book.AddGrade(89.5f);
            book.AddGrade(77);

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);
            Console.WriteLine(stats.AverageGrade);

            //keeps the program open so I can see the results.
            Console.ReadLine();
        }
    }
}
