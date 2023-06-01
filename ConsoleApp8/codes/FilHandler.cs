using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.codes
{
    internal class FilHandler
    {
        public void CreateFile()
        {
            try
            {
                string myUserFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                File.Create(Path.Combine(myUserFolder, "AndreasDarab.txt"));
            }
            catch (Exception)
            {
                Console.WriteLine("Error creating file.");
            }
        }

        public bool CreateFile(string fileName, string content)
        {
            bool success = true;

            try
            {
                string myUserFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                string filePath = Path.Combine(myUserFolder, fileName);

                File.WriteAllText(filePath, content);
            }
            catch (Exception)
            {
                success = false;
            }
            return success;
        }

        public string GetUserFolder()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        }
    }
}

