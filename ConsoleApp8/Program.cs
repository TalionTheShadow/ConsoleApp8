using ConsoleApp8.codes;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FilHandler filHandler = new();
            

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Show user folder");
                Console.WriteLine("2. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        string userFolder = filHandler.GetUserFolder();
                        Console.WriteLine("User folder: " + userFolder);
                        break;

                    case "2":
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();

                PrintCount();
            }

            static void PrintCount()
            {
                Console.Write("1");

                int count = 2;
                while (true)
                {
                    Thread.Sleep(1000);
                    Console.Write("\r{0}", count);
                    count++;
                }
            }

        }
    }
}