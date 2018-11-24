using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook:BaseGradeBook
    {
        public RankedGradeBook(string name):base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            int requiredStudentMinimum = 5;
            char grade = 'F';

            if (Students.Count < requiredStudentMinimum)
                throw new InvalidOperationException($"You must have a minimum of {requiredStudentMinimum} students for Ranked Grading");

            int studentsPerGrade = Students.Count / 5;

            List<double> averageGrades = new List<double>();
            foreach(var Student in Students)
                averageGrades.Add(Student.AverageGrade);

            averageGrades.Sort();
            averageGrades.Reverse();

            var index = Math.Floor(Convert.ToDouble(averageGrades.IndexOf(averageGrade) / studentsPerGrade));

            switch (index)
            {
                case 0:
                    grade = 'A';
                    break;
                case 1:
                    grade = 'B';
                    break;
                case 2:
                    grade = 'C';
                    break;
                case 3:
                    grade = 'D';
                    break;
                case 4:
                    grade = 'F';
                    break;
            }

            return grade;
        }
    }
}
