namespace StudentGrading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("John", "12345", new int[] { 85, 90, 78, 92, 88 });
            Console.WriteLine(student1);
        }
    }
}
