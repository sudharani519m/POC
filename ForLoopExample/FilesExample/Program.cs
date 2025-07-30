using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //File : Collection of data 
            //filenam,path,extension,size,create,modify,readonly

            Console.WriteLine("Please Enter FilePath");
            string filePath = Console.ReadLine();

            FileInfo fileInfo = new FileInfo(filePath);

            if (fileInfo.Exists)
            {
                //Get the info of the file 
                Console.WriteLine(fileInfo.FullName);
                Console.WriteLine(fileInfo.Extension);
                Console.WriteLine(fileInfo.Length);
                Console.WriteLine(fileInfo.DirectoryName);
                Console.WriteLine(fileInfo.CreationTime);
                Console.WriteLine(fileInfo.LastAccessTime);
                Console.WriteLine(fileInfo.LastWriteTime);
            }
            else
            {
                Console.WriteLine("Invalid FilePath");
            }
            Console.Read();
        }
    }
}
