using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public abstract class User : IUser
    {
        public string Name { get; set; }
        public int UserId { get; set; }

        protected User(string name, int userId)
        {
            Name = name;
            UserId = userId;
        }

        public virtual void BorrowBook(string bookTitle)
        {
            Console.WriteLine($"{Name} borrowed the book: {bookTitle}");
        }

        public virtual void ReserveBook(string bookTitle)
        {
            Console.WriteLine($"{Name} does not have permission to reserve books.");
        }

        public virtual void ManageInventory(string bookTitle, bool isAdding)
        {
            Console.WriteLine($"{Name} does not have permission to manage inventory.");
        }
    }
}
