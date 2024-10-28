using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public interface IUser
    {
        void BorrowBook(string bookTitle);
        void ReserveBook(string bookTitle);
        void ManageInventory(string bookTitle, bool isAdding); // Add or Remove book
    }
}
