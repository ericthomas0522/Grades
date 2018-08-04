﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {

        List<float> grades = new List<float>();

        private string Name
        {
          get
            {
                return Name;
            }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    if (Name != value)
                    {
                        //namechanged(name, value)
                    }
                    Name = value;
                }
            }
        }



        public GradeBook()
        {

        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;

            foreach(float grade in grades)
            {
                if (grade > stats.HighestGrade)
                {
                    stats.HighestGrade = grade;
                }

                if (grade < stats.LowestGrade)
                {
                    stats.LowestGrade = grade;
                }

                sum += grade;
            }

            stats.AverageGrade = sum / grades.Count;

            return stats;
        }
    }
}