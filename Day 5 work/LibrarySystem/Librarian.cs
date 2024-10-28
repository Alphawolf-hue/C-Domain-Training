using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class Librarian : User
    {
        public Librarian(string name, int userId) : base(name, userId) { }

        public override void BorrowBook(string bookTitle)
        {
            Console.WriteLine($"Librarian {Name} borrowed the book: {bookTitle}");
        }

        public override void ManageInventory(string bookTitle, bool isAdding)
        {
            if (isAdding)
            {
                Console.WriteLine($"Librarian {Name} added the book: {bookTitle} to inventory.");
            }
            else
            {
                Console.WriteLine($"Librarian {Name} removed the book: {bookTitle} from inventory.");
            }
        }
    }
}
