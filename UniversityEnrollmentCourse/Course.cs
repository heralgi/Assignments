using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityEnrollmentCourse
{
    abstract class Course
    {
        public string CourseName { get; set; }
        public int CourseId { get; set; }

        public Course(int id, string name)
        {
            CourseId = id;
            CourseName = name;
        }

        public abstract void EnrollStudent();
    }
}
