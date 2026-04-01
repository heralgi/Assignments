namespace PredicateDemo
{
    internal class Program
    {
        public static Predicate<Student> MarksGraterThen60 = s => s.Marks > 60;
        public static Predicate<Student> AgeGraterThen18 = s => s.Age > 18;
        public static Predicate<Student> nameStartsWithA = s => s.Name.StartsWith("A");
        static void Main(string[] args)
        {
            List<Student> student = new List<Student>();
            student.Add(new Student { Name = "John", Marks = 70, Age = 19 });
            student.Add(new Student { Name = "Alice", Marks = 85, Age = 20 });
            student.Add(new Student { Name = "Bob", Marks = 60, Age = 18 });
            student.Add(new Student { Name = "Eve", Marks = 90, Age = 17 });
            student.Add(new Student { Name = "Charlie", Marks = 75, Age = 19 });
            student.Add(new Student { Name = "David", Marks = 80, Age = 20 });

            Console.WriteLine("\nList of Students Marks Grater then 60");
            var resultMarksGraterThen60 = student.FindAll(MarksGraterThen60);
            foreach (var item in resultMarksGraterThen60)
            {
                Console.WriteLine($"Name: {item.Name}, Marks: {item.Marks}, Age: {item.Age}");
            }

            Console.WriteLine("\nList of Students Age Grater then 18");
            var resultAgeGraterThen18 = student.FindAll(AgeGraterThen18);
            foreach(var item in resultAgeGraterThen18)
            {
                Console.WriteLine($"Name: {item.Name}, Marks: {item.Marks}, Age: {item.Age}");
            }

            Console.WriteLine("\nList of Students Name starts with A");
            var resultNameStartsWithA = student.FindAll(nameStartsWithA);
            foreach(var item in resultNameStartsWithA)
            {
                Console.WriteLine($"Name: {item.Name}, Marks: {item.Marks}, Age: {item.Age}");
            }
        }
    }
}
