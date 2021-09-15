using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    /// <summary>
    /// Contact class that can handle information about a person. Their name, address, a phonenumber and an emailaddress
    /// </summary>
    public class Contact
    {
        private string fname;
        private string lname;
        private Address address;
        private string phoneNumber;
        private string email;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Contact() : this(string.Empty, string.Empty, new Address(), string.Empty, string.Empty) { }

        /// <summary>
        /// Constructor that accepts all variables as in parameters
        /// </summary>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <param name="address"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="email"></param>
        public Contact(string fname, string lname, Address address, string phoneNumber, string email) 
        {
            this.fname = fname;
            this.lname = lname;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        /// <summary>
        /// Properties for fName variable
        /// </summary>
        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }

        /// <summary>
        /// Properties for lName variable
        /// </summary>
        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }

        /// <summary>
        /// Property that converts first and last name into one string with the customers
        /// full name
        /// </summary>
        public string FullName
        {
            get { return String.Format("{0} {1}", fname, lname); }
        }

        /// <summary>
        /// Properties for address variable
        /// </summary>
        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        /// <summary>
        /// Properties for phoneNumber variable
        /// </summary>
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        /// <summary>
        /// Properties for email variable
        /// </summary>
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        /// <summary>
        /// Checks that no data is null or empty
        /// </summary>
        /// <returns>ok if not null or empty</returns>
        public bool CheckData()
        {
            bool ok = CheckName() && CheckAddress() &&  CheckPhoneEmail();

            return ok;
        }

        /// <summary>
        /// Checks that first name or last name not null or empty
        /// </summary>
        /// <returns>ok if not null or empty</returns>
        private bool CheckName()
        {
            bool ok = !string.IsNullOrEmpty(fname) && !string.IsNullOrEmpty(lname);

            return ok;
        }

        /// <summary>
        /// Checks that address is not null or empty
        /// </summary>
        /// <returns>ok if not null or empty</returns>
        private bool CheckAddress()
        {
            bool ok = address.CheckAddress();

            return ok;
        }

        /// <summary>
        /// Checks that phone and email is not null or empty
        /// </summary>
        /// <returns>ok if not null or empty</returns>
        private bool CheckPhoneEmail()
        {
            bool ok = !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(phoneNumber);

            return ok;
        }

        /// <summary>
        /// Overrides ToString method in order to get a string output with all variables in the same string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string strOut = String.Format("Name: {0},  Address: {1},  Phone number:{2},  Email:{3}", FullName, address.ToString(), phoneNumber, email);
            return strOut;
        }
    }
}
