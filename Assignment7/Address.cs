using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    /// <summary>
    /// Address class that manages address variables with street address, zip code and city
    /// </summary>
    public class Address
    {
        private string street;
        private string zipCode;
        private string city;

        /// <summary>
        ///Default constructor
        /// </summary>
        public Address() : this(string.Empty, string.Empty, string.Empty) { }

        /// <summary>
        /// Constructor that accepts street, zip code and city as in parameters
        /// </summary>
        /// <param name="street"></param>
        /// <param name="zipCode"></param>
        /// <param name="city"></param>
        public Address(string street, string zipCode, string city)
        {
            this.street = street;
            this.zipCode = zipCode;
            this.city = city;
        }

        /// <summary>
        /// Property for street variable
        /// </summary>
        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        /// <summary>
        /// property for zipCode variable
        /// </summary>
        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

        /// <summary>
        /// Properties for city variable
        /// </summary>
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        /// <summary>
        /// Checks that that no variable is null or empty
        /// </summary>
        /// <returns>ok if not null or empty</returns>
        public bool CheckAddress()
        {
            bool ok = !string.IsNullOrEmpty(street) && !string.IsNullOrEmpty(zipCode) && !string.IsNullOrEmpty(city);


            return ok;
        }

        /// <summary>
        /// Overides ToString method and provides output with all variables in the same string
        /// </summary>
        /// <returns>string with all variables</returns>
        public override string ToString()
        {
            string strOut = String.Format("{0} {1} {2}", street, zipCode, city);
            return strOut;
        }
    }
}
