using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Xml.Serialization;

namespace BookXML
{
    internal class Assignment1
    {
        public void AssignmentOne()
        {
            //) Create a Book and Author class with suitable properties and Hardcoded with Minimum 5 data for both the classes
            //and convert into Json and XML Format  and store that data in Local Disk using File  concept .
            //Read the Json and XML data and display the same in console App;
            List<Book> books = new()
            {
                new () {BookID = 1, AuthorID = 1,Title = "Meditations", YearOfPublishing = 2018 , Theme = "Sci-Fi"},
                new () {BookID = 2, AuthorID = 2,Title = "Wings", YearOfPublishing = 2014 , Theme = "Mystery"},
                new () {BookID = 3, AuthorID = 3,Title = "The Good Work", YearOfPublishing = 2019 , Theme = "Thriller"},
                new () {BookID = 4, AuthorID = 1,Title = "The Money Mind", YearOfPublishing = 2013 , Theme = "Fiction"},
                new () {BookID = 5, AuthorID = 2,Title = "People of Atlanta", YearOfPublishing = 2017 , Theme = "Non-Fiction"},
            };
            List<Author> authors = new()
            {
                new () {AuthorID = 1, AuthorName = "Tejas"},
                new () {AuthorID = 2, AuthorName = "Akash"},
                new () {AuthorID = 3, AuthorName = "Anil"},
                new () {AuthorID = 4, AuthorName = "Omar"},
                new () {AuthorID = 5, AuthorName = "ThePrimeagen"},
            };
            SerializeJSON(@"C:\Users\Aniket Barua\OneDrive\Desktop\C# code\Day 4 C# DT\books.json", books);
            SerializeJSON(@"C:\Users\Aniket Barua\OneDrive\Desktop\C# code\Day 4 C# DT\authors.json", authors);
            SerializeToXml(@"C:\Users\Aniket Barua\OneDrive\Desktop\C# code\Day 4 C# DT\books.dat", books);
            SerializeToXml(@"C:\Users\Aniket Barua\OneDrive\Desktop\C# code\Day 4 C# DT\books.dat", authors);

            var booksFromJson = DeserializeFromJson<List<Book>>(@"C:\Users\Aniket Barua\OneDrive\Desktop\C# code\Day 4 C# DT\books.json");
            var authorsFromJson = DeserializeFromJson<List<Author>>(@"C:\Users\Aniket Barua\OneDrive\Desktop\C# code\Day 4 C# DT\authors.json");
            var booksFromXml = DeserializeFromXml<List<Book>>(@"C:\Users\Aniket Barua\OneDrive\Desktop\C# code\Day 4 C# DT\books.dat");
            var authorsFromXml = DeserializeFromXml<List<Author>>(@"C:\Users\Aniket Barua\OneDrive\Desktop\C# code\Day 4 C# DT\books.dat");

            Console.WriteLine("Books from JSON:");
            booksFromJson.ForEach(b => Console.WriteLine(b));

            Console.WriteLine("\nAuthors from JSON:");
            authorsFromJson.ForEach(a => Console.WriteLine(a));

            Console.WriteLine("\nBooks from XML:");
            booksFromXml.ForEach(b => Console.WriteLine(b));

            Console.WriteLine("\nAuthors from XML:");
            authorsFromXml.ForEach(a => Console.WriteLine(a));
        }
        public static void SerializeJSON<T>(string filePath, T obj)
        {
            string json = JsonSerializer.Serialize(obj);
            File.WriteAllText(filePath, json);
        }
        public static T DeserializeFromJson<T>(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<T>(json);
        }
        static void SerializeToXml<T>(string filePath, T data)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                serializer.Serialize(stream, data);
            }
        }

        // XML Deserialization
        static T DeserializeFromXml<T>(string filePath)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var stream = new FileStream(filePath, FileMode.Open))
            {
                return (T)serializer.Deserialize(stream);
            }
        }
    }
}
