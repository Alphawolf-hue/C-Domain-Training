using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIODemos
{
    internal class StreamWriterReader
    {
        public void writeandread() 
        {
            string filepath = "C:\\Users\\Aniket Barua\\OneDrive\\Desktop\\C# code\\Day 4 C# DT\\Sample.txt";
            using (StreamWriter writer = new StreamWriter(filepath)) 
            {
                writer.WriteLine("Sample Content from Console App");
            }
            using (StreamReader reader = new StreamReader(filepath))
            {
                string contentReadFromFile=reader.ReadToEnd();
                Console.WriteLine(contentReadFromFile);
            }
        }
    }
}
