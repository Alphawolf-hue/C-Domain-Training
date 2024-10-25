using System.Text.RegularExpressions;

///Email Validation
//string emailPattern = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov|in)$";

//string[] emails = { "aniketbarua17@example.com", "kleutenant@gmail", "example@co.in" };
//foreach(string email in emails)
//{
//    if (Regex.IsMatch(email,emailPattern))
//    {
//        Console.WriteLine($"{email} is Valid");
//    }
//    else { Console.WriteLine($"{email} is not valid"); }
//}
//Console.ReadLine();

//Example 2
//Console.WriteLine("Enter text to extract number from string");
//string input=Console.ReadLine();
//string numberPattern = @"\d+";
//foreach(Match match in Regex.Matches(input, numberPattern))
//{
//    Console.WriteLine($"Found Number:{match.Value}");
//}

//Example 3
//string message = "You can reach me @123-456-8905 or @947-595-8891";
//string mobilePattern = @"\d{3}-\d{3}-\d{4}";

//string replaceWith = "***-***-****";
//string result=Regex.Replace(message, mobilePattern, replaceWith);
//Console.WriteLine(result);

/////////////Example 4:Finding specific pattern
string content = "I forgot my botox at work";

string wordPattern = @"\b\w+?ox\b";

string findResult=Regex.Replace(content, wordPattern,match => $"[{match.Value}]");
Console.WriteLine(findResult);
Console.ReadLine();


