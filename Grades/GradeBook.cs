using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {
        public NameChangedDelegate nameChanged;

        private List<float> grades;

        public string Name
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
                        nameChanged(Name, value);
                    }
                    Name = value;
                }
            }
        }



        public GradeBook()
        {
            Name = "empty";
            grades = new List<float>();
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
