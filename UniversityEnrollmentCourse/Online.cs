using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityEnrollmentCourse
{
    class OnlineCourse : Course
    {
        public string VideoLink { get; set; }

        public OnlineCourse(int id, string name, string link) : base(id, name)
        {
            VideoLink = link;
        }

        public override void EnrollStudent()
        {
            if (string.IsNullOrEmpty(VideoLink))
            {
                Console.WriteLine("Enrollment Failed: Video link is required.");
            }
            else
            {
                Console.WriteLine($"Enrolled in Online Course: {CourseName}");
                Console.WriteLine($"Access via: {VideoLink}");
            }
        }
    }
}
