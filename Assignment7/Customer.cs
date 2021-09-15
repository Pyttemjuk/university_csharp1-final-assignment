using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    /// <summary>
    /// Customer class that handles all contact information about a customer
    /// </summary>
    public class Customer
    {
        private string id;
        private Contact contact;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Customer() : this(string.Empty, new Contact()) { }

        /// <summary>
        /// Constructor that accepts contact as parameter
        /// </summary>
        /// <param name="contact"></param>
        public Customer(Contact contact) : this(string.Empty, contact) { }

        /// <summary>
        /// Constructor that accepts id and contact data as input
        /// </summary>
        /// <param name="id"></param>
        /// <param name="contactData"></param>
        public Customer(string id, Contact contact)
        {
            this.id = id;
            this.contact = contact;
        }

        /// <summary>
        /// Property for ID variable
        /// </summary>
        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Property for contact data
        /// </summary>
        public Contact Contact
        {
            get { return contact; }
            set { contact = value; }
        }

        /// <summary>
        /// Override for ToString, returns a string with all contact data plus their id
        /// </summary>
        /// <returns>String with ID and contact data</returns>
        public override string ToString()
        {
            string strOut = String.Format("ID: {0}, {1}", id, contact.ToString());
            return strOut;
        }
    }    
}
