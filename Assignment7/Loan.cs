using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    /// <summary>
    /// Class that handles data about a specific loan
    /// </summary>
    class Loan
    {
        private Customer customer;
        private Book book;
        private DateTime returnDate;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Loan() : this(new Customer(), new Book(),new DateTime()) {}

        /// <summary>
        /// Constructor that accepts customer, book and date time object as input
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="book"></param>
        /// <param name="returnDate"></param>
        public Loan(Customer customer, Book book, DateTime returnDate)
        {
            this.customer = customer;
            this.book = book;
            this.returnDate = returnDate;
        }

        /// <summary>
        /// Property for customer object
        /// </summary>
        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        /// <summary>
        /// Property for book object
        /// </summary>
        public Book Book
        {
            get { return book; }
            set { book = value; }
        }

        /// <summary>
        /// Property for return date
        /// </summary>
        public DateTime ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }

        /// <summary>
        /// Override for to string method in order to give a good string output.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string strOut = String.Format("ID: {0}, Name: {1}, Author: {2}, Title: {3}, Return date: {4}", customer.ID, 
                customer.Contact.FullName, book.FullName, book.Title, returnDate.ToString("yyyy-MM-dd"));
            return strOut;
        }
    }
}
