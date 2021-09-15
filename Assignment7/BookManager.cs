using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    /// <summary>
    /// Class that handles all data about a book manager. It contains a list of book objects where new can be added, others changed
    /// or deleted
    /// </summary>
    public class BookManager
    {
        private List<Book> bookList;

        /// <summary>
        /// Default constructor
        /// </summary>
        public BookManager()
        {
            bookList = new List<Book>();
        }

        /// <summary>
        /// Get number of books currently in the list
        /// </summary>
        public int Count
        {
            get { return bookList.Count; }
        }

        /// <summary>
        /// Adds a book to list if the input parameter, book object, isn't null
        /// returns false if the book can't be added to list (prevents null values in list)
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>ok if customer object not null</returns>
        public bool AddBook(Book book)
        {
            //Check variable
            bool ok = book != null;

            if (ok)
                bookList.Add(book);

            return ok;
        }

        /// <summary>
        /// Change the contents in a book object in the list
        /// </summary>
        /// <param name="book"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool ChangeBook(Book book, int index)
        {
            bool ok = index >= 0 && index < Count && book != null;

            if (ok)
                bookList[index] = book;

            return ok;
        }

        /// <summary>
        /// Removes a book object if the index parameter is in the range of the list
        /// </summary>
        /// <param name="index"></param>
        /// <returns>true if the book is deleted</returns>
        public bool DeleteBook(int index)
        {
            //Check variable
            bool ok = index >= 0 && index < Count;

            if (ok)
                bookList.RemoveAt(index);

            return ok;
        }

        /// <summary>
        /// Gets book object for a specific index provided by caller
        /// </summary>
        /// <param name="index"></param>
        /// <returns>book for input index</returns>
        public Book GetBook(int index)
        {
            if (index < 0 || index >= bookList.Count)
                return null;

            return bookList[index];
        }

        /// <summary>
        /// Get information on all books in the list as a string array
        /// </summary>
        /// <returns>string array with books</returns>
        public string[] GetBookInfo()
        {
            string[] strBookInfo = new string[bookList.Count];

            int index = 0;
            foreach (Book bookObj in bookList)
                strBookInfo[index++] = bookObj.ToString();

            return strBookInfo;
        }

    }
}
