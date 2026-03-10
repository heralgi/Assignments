using System;
using System.Collections.Generic;
using System.Text;

namespace StudentGrading
{
    internal class Student
    {
        string? studentName;
        string? rollNumber;
        int[] marks = new int[5];
        int Average = 0;
        string Grade = string.Empty;

        public Student(string name, string rollNumber, int[] marks)
        {
            studentName = name;
            this.rollNumber = rollNumber;
            this.marks = marks;

            CalculateAverage();
            CalculateGrade();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("{0, -14} {1}","Student Name: ", studentName));
            sb.AppendLine(String.Format("{0, -14} {1}","Roll Number: ", rollNumber));
            sb.AppendLine(String.Format("{0, -14}", "Marks: "));
            foreach (var mark in marks) {
                sb.AppendLine(String.Format("{0, 17}", mark));
            }
            sb.AppendLine(String.Format("{0, -14} {1}", "Average: ", Average));
            sb.AppendLine(String.Format("{0, -14} {1}", "Grade: ", Grade));

            return sb.ToString();
        }
        void CalculateAverage()
        {
            foreach (var mark in marks)
            {
                Average += mark;
            }
            Average = Average / marks.Length;
        }

        void CalculateGrade()
        {
            if(Average >= 90)
            {
                Grade = "A+";
            }
            if(Average >= 80 && Average < 90)
            {
                Grade = "A";
            }
            if(Average >= 70 && Average < 80)
            {
                Grade = "B";
            }
            if(Average >= 60 && Average < 70)
            {
                Grade = "C";
            }
            if(Average >= 50 && Average < 60)
            {
                Grade = "D";
            }
            if(Average < 50)
            {
                Grade = "Fail";
            }
        }
    }
}
