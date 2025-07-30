using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReadExmaple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = ConfigurationManager.AppSettings["FilePath"].ToString(); //@"C:\Users\Mahender\Desktop\Dotnet Zoom invitation.txt";
           // string filePath = @"C:\Users\Mahender\Desktop\Test.txt";
            FileInfo fileInfo = new FileInfo(filePath);

            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                Console.WriteLine("File Content:");
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("The file does not exist at the specified path.");

                // Read the content  from the file to the command prompt 
                //C: \Users\Mahender\Desktop\test.txt

                Console.ReadLine();
            }
        }
    }
}
