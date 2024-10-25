using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookXML
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public int YearOfPublishing { get; set; }
        public string Theme { get; set; }

        public override string ToString()
        {
            return $"BookID: {BookID}\t Title: {Title}\t AuthorID: {AuthorID}\t Year Of Publishing: {YearOfPublishing}\t Theme: {Theme}";
        }
    }

}
