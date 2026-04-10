using Microsoft.VisualBasic;
using System.Text.Json;

namespace MovieStore
{
    internal class Program
    {
        static List<Movie> Movies = new List<Movie>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nMovie Store developed by Murugesh:");
                Console.WriteLine("1.Add new Movie.\n2.Display All Movie.\n3.Find Movie by Id.");
                Console.WriteLine("4.Remove Movie by Id.\n5.Clear All Movie.\n6.Exit");
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    if(choice == 1)
                    {
                        CreateMovie();
                    } else if(choice == 2)
                    {
                        DisplayAllMovie();
                    } else if(choice == 3)
                    {
                        FindById();
                    } else if(choice == 4)
                    {
                        RemoveById();
                    } else if(choice == 5)
                    {
                        ClearAll();
                    } else if(choice == 6)
                    {
                        break;
                    }
                }
            }

        }

        static void CreateMovie()
        {
            Console.WriteLine("Enter Movie Name: ");
            string name = Console.ReadLine();

            int ID = 0;
            Console.WriteLine("Enter Movie Id: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                ID = id;
            }
            else
            {
                Console.WriteLine("Invalid Id: ");
                return;
            }

            DateTime Date;
            Console.WriteLine("Enter Year Of Release: ");
            if(DateTime.TryParse(Console.ReadLine(), out DateTime date))
            {
                Date = date;
            }
            else
            {
                Console.WriteLine("Invalid Date.");
                return;
            }

            Console.WriteLine("Enter Movie Genre: ");
            string genre = Console.ReadLine();
            if(genre == null)
            {
                return;
            }

            Movie movie = new Movie(name, ID, Date, genre);
            Movies.Add(movie);
        }
        static void DisplayAllMovie()
        {
            for(int i = 0; i < Movies.Count; i++)
            {
                Console.WriteLine($"{JsonSerializer.Serialize(Movies[i])}");
            }
        }
        static void FindById()
        {
            Console.WriteLine("Enter the Id: ");
            if(int.TryParse(Console.ReadLine(), out int id))
            {
                foreach(Movie m in Movies)
                {
                    if(m.Id == id)
                    {
                        Console.WriteLine($"{JsonSerializer.Serialize(m)}");
                    }
                }
                Console.WriteLine($"No movie with {id}");
            }
        }
        static void RemoveById()
        {
            Console.WriteLine("Enter the Id: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                for(int i=0;i< Movies.Count; i++)
                {
                    if (Movies[i].Id == id)
                    {
                        Movies.Remove(Movies[i]);
                        Console.WriteLine($"Removed.");
                    }
                }
                Console.WriteLine($"No movie with {id}");
            }
        }
        static void ClearAll()
        {
            Movies.Clear();
            Console.WriteLine("Cleared All Movies.");
        }
    }
}
