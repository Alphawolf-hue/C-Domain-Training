// See https://aka.ms/new-console-template for more information
using FileIODemos;
using System.Runtime.InteropServices;
using System.Text;

//string path = "C:\\Users\\Aniket Barua\\OneDrive\\Desktop\\C# code\\Day 4 C# DT\\Sample.txt";
//string path1 = @"C:\Users\Aniket Barua\OneDrive\Desktop\C# code\Day 4 C# DT\Sample.txt";
//if(File.Exists(path))
//{
//    File.Delete(path);
//}
//using(FileStream fs=File.Create(path))
//{
//    AddTextintheFile(fs, "Hello.....");
//    Console.WriteLine("Enter Content to write in File");
//    string con=Console.ReadLine();
//    AddTextintheFile(fs, "\nWelcome To File Concept");
//    AddTextintheFile(fs, "\rWelcome To File Concept");
//}
//Console.ReadLine();
//static void AddTextintheFile(FileStream fs, string input)
//{
//    byte[] byteInfo=new UTF32Encoding().GetBytes(input);
//    fs.Write(byteInfo, 0, byteInfo.Length);
//}

StreamWriterReader stream = new StreamWriterReader();
stream.writeandread();
Console.ReadLine();