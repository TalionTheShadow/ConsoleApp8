using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.codes
{
    internal class FilHandler 
    {
        public bool CreateFile()
        {
            bool success = true;

            try
            {
                string myUserFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                File.Create(Path.Combine(myUserFolder, "AndreasDarab.txt"));
            }
            catch (Exception)
            {
                success = false;
            }

            return success;
        }
    }
}
