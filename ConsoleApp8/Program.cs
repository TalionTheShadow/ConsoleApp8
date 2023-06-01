using ConsoleApp8.codes;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FilHandler filHandler = new();
            filHandler.CreateFile();

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Create File");
                Console.WriteLine("2. Show user folder URL");
                Console.WriteLine("3. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter the file name: ");
                        string fileName = Console.ReadLine();
                        Console.Write("Enter the content: ");
                        string content = Console.ReadLine();

                        bool success = filHandler.CreateFile(fileName, content);

                        if (success)
                            Console.WriteLine("File created successfully.");
                        else
                            Console.WriteLine("Error creating file.");
                        break;

                    case "2":
                        string userFolder = filHandler.GetUserFolder();
                        Console.WriteLine("User folder URL: " + userFolder);
                        break;

                    case "3":
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}