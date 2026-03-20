using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityEnrollmentCourse
{
    class LabCourse : Course
    {
        public bool SafetyTrainingCompleted { get; set; }

        public LabCourse(int id, string name, bool training) : base(id, name)
        {
            SafetyTrainingCompleted = training;
        }

        public override void EnrollStudent()
        {
            if (!SafetyTrainingCompleted)
            {
                Console.WriteLine("Enrollment Failed: Safety training not completed.");
            }
            else
            {
                Console.WriteLine($"Enrolled in Lab Course: {CourseName}");
            }
        }
    }
}
