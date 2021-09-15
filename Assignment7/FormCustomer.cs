using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment7
{
    public partial class FormCustomer : Form
    {
        private CustomerManager customerManager;
        private Contact contact;

        public FormCustomer(CustomerManager customerManager)
        {
            this.customerManager = customerManager;

            InitializeComponent();
            InitializeGUI();
        }

        public void InitializeGUI()
        {
            UpdateGUI();
        }

        public void UpdateGUI()
        {
            contact = new Contact();

            ClearDataInBoxes();

            //Clear listbox and add uptaded items
            lstCustomer.Items.Clear();
            lstCustomer.Items.AddRange(customerManager.GetCustomersInfo());

            //Enable/Disable buttons
            btnAdd.Enabled = true;
            btnOK.Enabled = false;
        }

        /// <summary>
        /// Property to return index of selected customer
        /// </summary>
        public int ReturnIndex { get; set; }

        /// <summary>
        /// Handles add customer click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ReadFullName();
            ReadAddress();
            ReadPhone();
            ReadEmail();

            if (contact.CheckData())
            {
                Customer customer = new Customer(contact);
                customerManager.AddCustomer(customer);
                UpdateGUI();
            }
            else
                MessageBox.Show("Missing information about the book, please check all data", "Missing data");
        }

        /// <summary>
        /// Handles change customer data click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Click(object sender, EventArgs e)
        {


            if(lstCustomer.SelectedIndex != -1)
            {
                if (CheckData())
                {
                    ReadFullName();
                    ReadAddress();
                    ReadPhone();
                    ReadEmail();
                    Customer customer = new Customer(contact);
                    customerManager.ChangeCustomer(contact, lstCustomer.SelectedIndex);
                    UpdateGUI();
                }
                else
                    MessageBox.Show("Missing information about the book, please check all data", "Missing data");
            }
            else
                MessageBox.Show("No customer selected, please select a customer", "No customer selected");

        }

        /// <summary>
        /// Handles delete customer button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstCustomer.SelectedIndex != -1 && lstCustomer.SelectedIndex < customerManager.Count)
            {
                customerManager.DeleteCustomer(lstCustomer.SelectedIndex);
                UpdateGUI();
            }
            else
                MessageBox.Show("No customer selected, please select a customer", "No customer selected");
        }

        /// <summary>
        /// Handles clear customer data button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            UpdateGUI();
        }

        /// <summary>
        /// Handles selected index changed in the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCustomer.SelectedIndex != -1)
            {
                contact = customerManager.GetCustomer(lstCustomer.SelectedIndex).Contact;
                WriteDataToBoxes();

                btnAdd.Enabled = false;
                btnOK.Enabled = true;
            }
        }

        /// <summary>
        /// Saves user input for name in contact object
        /// </summary>
        private void ReadFullName()
        {
            contact.Fname = txtFname.Text;
            contact.Lname = txtLname.Text;
        }

        /// <summary>
        /// Saves user input for address in contact object
        /// </summary>
        private void ReadAddress()
        {
            contact.Address.Street = txtStreet.Text;
            contact.Address.ZipCode = txtZipcode.Text;
            contact.Address.City = txtCity.Text;
        }

        /// <summary>
        /// Saves user input for phone in contact object
        /// </summary>
        private void ReadPhone()
        {
            contact.PhoneNumber = txtPhone.Text;
        }

        /// <summary>
        /// Saves user input for email in contact object
        /// </summary>
        private void ReadEmail()
        {
            contact.Email = txtEmail.Text;
        }

        /// <summary>
        /// Clears all input data in the textboxes
        /// </summary>
        private void ClearDataInBoxes()
        {
            txtFname.Text = string.Empty;
            txtLname.Text = string.Empty;
            txtStreet.Text = string.Empty;
            txtZipcode.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

        /// <summary>
        /// Writes data about the contact object into textboxes
        /// </summary>
        private void WriteDataToBoxes()
        {
            txtFname.Text = contact.Fname;
            txtLname.Text = contact.Lname;
            txtStreet.Text = contact.Address.Street;
            txtZipcode.Text = contact.Address.ZipCode;
            txtCity.Text = contact.Address.City;
            txtPhone.Text = contact.PhoneNumber;
            txtEmail.Text = contact.Email;
        }

        /// <summary>
        /// Check that no textbox is empty to avoid null values and empty strings
        /// </summary>
        /// <returns>ok if no null or empty strings</returns>
        private bool CheckData()
        {
            bool ok = !string.IsNullOrEmpty(txtFname.Text) && !string.IsNullOrEmpty(txtLname.Text) && !string.IsNullOrEmpty(txtStreet.Text) &&
                !string.IsNullOrEmpty(txtZipcode.Text) && !string.IsNullOrEmpty(txtCity.Text) && !string.IsNullOrEmpty(txtPhone.Text) && 
                !string.IsNullOrEmpty(txtEmail.Text);

            return ok;
        }
    }
}
