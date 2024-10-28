using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class Student : User
    {
        public Student(string name, int userId) : base(name, userId) { }

        public override void BorrowBook(string bookTitle)
        {
            Console.WriteLine($"Student {Name} borrowed the book: {bookTitle}");
        }

        // No permissions to reserve or manage inventory, so no override needed
    }
}
