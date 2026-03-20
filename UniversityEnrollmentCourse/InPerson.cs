using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityEnrollmentCourse
{
    class InPersonCourse : Course
    {
        public string RoomNumber { get; set; }
        public int Capacity { get; set; }

        public InPersonCourse(int id, string name, string room, int capacity) : base(id, name)
        {
            RoomNumber = room;
            Capacity = capacity;
        }

        public override void EnrollStudent()
        {
            if (string.IsNullOrEmpty(RoomNumber) || Capacity <= 0)
            {
                Console.WriteLine("Enrollment Failed: Invalid room or capacity.");
            }
            else
            {
                Console.WriteLine($"Enrolled in In-Person Course: {CourseName}");
                Console.WriteLine($"Room: {RoomNumber}, Capacity: {Capacity}");
            }
        }
    }
}
