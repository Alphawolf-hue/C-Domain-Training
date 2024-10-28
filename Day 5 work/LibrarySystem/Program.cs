namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User student = new Student("Alice", 101);
            User teacher = new Teacher("Mr. Smith", 102);
            User librarian = new Librarian("Ms. Johnson", 103);

            LibraryService studentService = new LibraryService(student);
            LibraryService teacherService = new LibraryService(teacher);
            LibraryService librarianService = new LibraryService(librarian);

            Console.WriteLine("== Student Actions ==");
            studentService.BorrowBook("The Great Gatsby");
            studentService.ReserveBook("To Kill a Mockingbird");
            studentService.ManageInventory("The Catcher in the Rye", true);

            Console.WriteLine("\n== Teacher Actions ==");
            teacherService.BorrowBook("1984");
            teacherService.ReserveBook("Brave New World");
            teacherService.ManageInventory("The Hobbit", false);

            Console.WriteLine("\n== Librarian Actions ==");
            librarianService.BorrowBook("Moby Dick");
            librarianService.ReserveBook("Pride and Prejudice");
            librarianService.ManageInventory("The Alchemist", true);
            librarianService.ManageInventory("War and Peace", false);
        }
    }
}
