namespace MultiLevel_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Son son = new Son();

            Console.WriteLine("Accessing Members from Son's object.");

            son.AncestralTrait();

            son.FathersTrait();

            son.SonsTrait();
        }
    }
}
