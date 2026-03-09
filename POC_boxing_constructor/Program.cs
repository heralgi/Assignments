namespace POC_boxing_constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 25;

            // Boxing
            object boxedAge = age;

            Console.WriteLine("Boxed value: " + boxedAge);

            // Unboxing
            int unboxedAge = (int)boxedAge;

            Console.WriteLine("Unboxed value: " + unboxedAge);
            Console.WriteLine();

            // Constructor demonstration
            Person p1 = new Person();
            Person p2 = new Person("Murugesh");
            Person p3 = new Person("Ravi", 1.75, 70);

            p1.Display();
            p2.Display();
            p3.Display();
        }
    }
}
