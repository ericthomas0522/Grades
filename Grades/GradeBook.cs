using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {
        public event NameChangedDelegate nameChanged;

        protected List<float> grades;
        private string _name;

        public string Name
        {
          get
            {
                return _name;
            }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    NameChangedEventArgs args = new NameChangedEventArgs();
                    args.ExistingName = _name;
                    args.NewName = value;

                    if (_name != value)
                    {
                        nameChanged(this, args);
                    }
                    _name = value;
                }
            }
        }

        public void WriteGrades(TextWriter destination)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                destination.WriteLine(grades[i]);
            }
        }

        public GradeBook()
        {
            _name = "empty";
            grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public virtual GradeStatistics ComputeStatistics()
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
