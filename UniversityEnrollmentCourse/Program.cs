namespace UniversityEnrollmentCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select Course Type:");
            Console.WriteLine("1. Online");
            Console.WriteLine("2. In-Person");
            Console.WriteLine("3. Lab");

            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter Course ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Course Name: ");
            string name = Console.ReadLine();

            Course course = null;

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Video Link: ");
                    string link = Console.ReadLine();
                    course = new OnlineCourse(id, name, link);
                    break;

                case 2:
                    Console.Write("Enter Room Number: ");
                    string room = Console.ReadLine();

                    Console.Write("Enter Capacity: ");
                    int capacity = int.Parse(Console.ReadLine());

                    course = new InPersonCourse(id, name, room, capacity);
                    break;

                case 3:
                    Console.Write("Safety Training Completed (true/false): ");
                    bool training = bool.Parse(Console.ReadLine());

                    course = new LabCourse(id, name, training);
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    return;
            }

            Console.WriteLine("\n--- Enrollment Process ---");
            course.EnrollStudent();
        }
    }
}
