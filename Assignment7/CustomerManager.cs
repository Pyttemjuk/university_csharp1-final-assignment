using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    /// <summary>
    /// Customer manager class that handles a list of customers
    /// </summary>
    public class CustomerManager
    {
        private List<Customer> customerList;

        /// <summary>
        /// Default constructor
        /// </summary>
        public CustomerManager()
        {
            customerList = new List<Customer>();
        }

        /// <summary>
        /// Get number of customers currently in the list
        /// </summary>
        public int Count
        {
            get { return customerList.Count; }
        }

        /// <summary>
        /// Check what ID is next in line and return for use in customer object
        /// </summary>
        public int GetNewID
        {
            get
            {
                int newID;

                if (Count <= 0)
                    newID = 100;
                else
                {
                    string strID = customerList[Count - 1].ID;

                    bool ok = int.TryParse(strID, out newID);

                    if (ok)
                        newID += 1;
                    else
                        newID = -1;
                }

                return newID;
            }
        }

        /// <summary>
        /// Adds customer to list if the input parameter, customer object, isn't null
        /// returns false if the customer can't be added to list (prevents null values in list)
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>ok if customer object not null</returns>
        public bool AddCustomer(Customer customer)
        {
            //Check variable
            bool ok = customer != null;

            int ID = GetNewID;
            customer.ID = ID.ToString();

            if (ok)
                customerList.Add(customer);

            return ok;
        }

        /// <summary>
        /// Changes data for a specific customer object in the list as long as the index parameter
        /// is in the range of the list
        /// </summary>
        /// <param name="changeContact"></param>
        /// <param name="index"></param>
        /// <returns>true if data changed in customer</returns>
        public bool ChangeCustomer(Contact changeContact, int index)
        {
            bool ok = index >= 0 && index < Count;

            if (ok)
                GetCustomer(index).Contact = changeContact;

            return ok;
        }

        /// <summary>
        /// Removes a customer object if the index parameter is in the range of the list
        /// </summary>
        /// <param name="index"></param>
        /// <returns>true if the customer is deleted</returns>
        public bool DeleteCustomer(int index)
        {
            //Check variable
            bool ok = index >= 0 && index < Count;

            if (ok)
                customerList.RemoveAt(index);

            return ok;
        }

        /// <summary>
        /// Gets customer object for a specific index provided by caller
        /// </summary>
        /// <param name="index"></param>
        /// <returns>customer for input index</returns>
        public Customer GetCustomer(int index)
        {
            if (index < 0 || index >= customerList.Count)
                return null;

            return customerList[index];
        }

        /// <summary>
        /// Get information on all customers in the list as a string array
        /// </summary>
        /// <returns>string array with customers</returns>
        public string[] GetCustomersInfo()
        {
            string[] strCustomerInfo = new string[customerList.Count];

            int index = 0;
            foreach (Customer customerObj in customerList)
                strCustomerInfo[index++] = customerObj.ToString();

            return strCustomerInfo;
        }
    }
}
