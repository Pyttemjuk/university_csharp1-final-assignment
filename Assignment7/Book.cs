using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    /// <summary>
    /// Book class that handles information about a book
    /// </summary>
    public class Book
    {
        private string title;
        private string fname;
        private string lname;
        private Genre genre;
        private MediaFormat mediaFormat;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Book() : this(string.Empty, string.Empty, string.Empty, Genre.Crime, MediaFormat.Book) { }

        /// <summary>
        /// Constructor that takes title, author, genre and media format as input
        /// </summary>
        /// <param name="title"></param>
        /// <param name="author"></param>
        /// <param name="genre"></param>
        /// <param name="mediaFormat"></param>
        public Book(string title, string authorFName, string authorLName, Genre genre, MediaFormat mediaFormat) 
        {
            this.title = title;
            this.fname = authorFName;
            this.lname = authorLName;
            this.genre = genre;
            this.mediaFormat = mediaFormat;
        }

        /// <summary>
        /// Property for title variable
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        /// <summary>
        /// Property for author first name variable
        /// </summary>
        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }

        /// <summary>
        /// Property for author last name variable
        /// </summary>
        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }

        /// <summary>
        /// Property that converts first and last name into one string with the authors
        /// full name
        /// </summary>
        public string FullName
        {
            get { return String.Format("{0} {1}", fname, lname); }
        }

        /// <summary>
        /// Property for enum genre
        /// </summary>
        public Genre Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        /// <summary>
        /// Property for enum media format
        /// </summary>
        public MediaFormat MediaFormat
        {
            get { return mediaFormat; }
            set { mediaFormat = value; }
        }

        /// <summary>
        /// Override ToString method to return all book data in one string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string strOut = String.Format("Author: {0},  Title: {1},  Genre: {2},  Media format: {3}", FullName, Title, Genre, MediaFormat);
            return strOut;
        }

        /// <summary>
        /// Checks that there are no empty or null values in string
        /// </summary>
        /// <returns>ok in not null or empty</returns>
        public bool CheckData()
        {
            bool ok = true;

            if (string.IsNullOrEmpty(fname) || string.IsNullOrEmpty(lname) || string.IsNullOrEmpty(title))
                ok = false;

            return ok;
        }
    }
}
