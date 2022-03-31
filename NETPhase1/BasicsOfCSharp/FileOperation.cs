using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
    class FileOperation
    {
        public static void ReadFile()
        {
            string content = File.ReadAllText("C:\\data\\content.txt");
            Console.WriteLine(content);
        }

        public static void ReadFileLines()
        {
            if (!File.Exists("D:\\contents.txt"))
            {
                Console.WriteLine("File not found");
            }
            else
            {
                string[] content = File.ReadAllLines("D:\\content.txt");
                foreach (string str in content)
                {
                    Console.WriteLine(str);
                }
            }
        }

        public static void WriteFile()
        {
            File.WriteAllText("D:\\content.txt", "New content\n Another Content");
            ReadFile();
        }

        public static void UpdateFile()
        {
            File.AppendAllText("D:\\content.txt", "\nAnother content");
            ReadFile();
        }

        public static void DeleteFile()
        {
            File.Delete("D:\\content.txt");
            ReadFile();
        }
    }
}

// Write a program to store student's data in File.
// ID, Name, Year, Dept
// ID, Name, Year, Dept
// Write into a file.
// Read student's data from File and display it for every student in format -  ID: 1, Name: Jon Doe
// Write another function to delete student's data from file for given ID.


