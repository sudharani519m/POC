using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWriteExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter FilePath:");
            string FilePath = Console.ReadLine();
            
           
            FileInfo fileInfo = new FileInfo(FilePath);
            Console.WriteLine("please enter the content");
            string content = Console.ReadLine();
            File.WriteAllText(FilePath,content);

           

            Console.WriteLine("Data written sucessfully into the file");
            Console.ReadLine();

            //Logic --to write the data from the cmd to the file .

            //output 
            //Please Enter FilePath 
            //c:/users/desktop/sample.txt
            //Please Enter the content 
            //Hi Welocme to console apps
            //Data written sucessfully into the file .
        }
       
    }
}
