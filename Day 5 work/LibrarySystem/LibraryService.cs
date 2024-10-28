using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class LibraryService
    {
        private readonly IUser _user;

        public LibraryService(IUser user)
        {
            _user = user;
        }

        public void BorrowBook(string bookTitle)
        {
            _user.BorrowBook(bookTitle);
        }

        public void ReserveBook(string bookTitle)
        {
            _user.ReserveBook(bookTitle);
        }

        public void ManageInventory(string bookTitle, bool isAdding)
        {
            _user.ManageInventory(bookTitle, isAdding);
        }
    }
}
