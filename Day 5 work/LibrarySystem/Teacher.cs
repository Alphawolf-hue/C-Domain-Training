using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class Teacher : User
    {
        public Teacher(string name, int userId) : base(name, userId) { }

        public override void BorrowBook(string bookTitle)
        {
            Console.WriteLine($"Teacher {Name} borrowed the book: {bookTitle}");
        }

        public override void ReserveBook(string bookTitle)
        {
            Console.WriteLine($"Teacher {Name} reserved the book: {bookTitle}");
        }
    }
}
