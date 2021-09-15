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
    public partial class MainForm : Form
    {
        private BookManager bookManager = new BookManager();
        private CustomerManager customerManager = new CustomerManager();
        private LoanManager loanManager = new LoanManager();
        private int bookIndex;
        private int customerIndex;

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            dtpReturnLoan.Format = DateTimePickerFormat.Custom;
            dtpReturnLoan.CustomFormat = "yyyy-MM-dd";
            
            UpdateGUI();
        }

        private void UpdateGUI()
        {
            ClearLabels();
            dtpReturnLoan.Value = DateTime.Now;
            bookIndex = -1;
            customerIndex = -1;

            //Clear and update loan list
            lstLoan.Items.Clear();
            lstLoan.Items.AddRange(loanManager.GetLoanInfo());

            //Enable/disable buttons
            btnChangeDate.Enabled = false;
            btnAddLoan.Enabled = true;
            btnGetDataBook.Enabled = true;
            btnGetCustInfo.Enabled = true;
        }

        /// <summary>
        /// Handles get book information button click event. Opens the Book form and saves the index that book has
        /// in the customer manager list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetBookInfo_Click(object sender, EventArgs e)
        {
            FormBooks dlg = new FormBooks(bookManager);
            DialogResult dlgResult = dlg.ShowDialog();
            if(dlgResult == DialogResult.OK)
            {
                bookIndex = dlg.ReturnIndex;
                lblAuthorNameOut.Text = bookManager.GetBook(bookIndex).FullName;
                lblTitleOut.Text = bookManager.GetBook(bookIndex).Title;
                lblMediaFormatOut.Text = bookManager.GetBook(bookIndex).MediaFormat.ToString();
            }
        }

        /// <summary>
        /// Handles get customer information button click event. Opens the Customer form and saves the index that customer has
        /// in the customer manager list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetCustInfo_Click(object sender, EventArgs e)
        {
            FormCustomer dlg = new FormCustomer(customerManager);
            DialogResult dlgResult = dlg.ShowDialog();
            if(dlgResult == DialogResult.OK)
            {
                customerIndex = dlg.ReturnIndex;
                lblCustIDOut.Text = customerManager.GetCustomer(customerIndex).ID;
                lblCustNameOut.Text = customerManager.GetCustomer(customerIndex).Contact.FullName;
            }
        }

        /// <summary>
        /// Handles clear button click event. Calls UpdateGUI method to clear all current loan data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            UpdateGUI();
        }

        /// <summary>
        /// Handles add loan button click event. Adds a new loan to the loan manager that has the selected book and
        /// customer from input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddLoan_Click(object sender, EventArgs e)
        {
            if(bookIndex != -1 && customerIndex != -1)
            {
                Loan loan = new Loan();
                loan.Book = bookManager.GetBook(bookIndex);
                loan.Customer = customerManager.GetCustomer(customerIndex);
                loan.ReturnDate = dtpReturnLoan.Value;

                loanManager.AddLoan(loan);

                UpdateGUI();
            }
            else
                MessageBox.Show("Missing information about the loan, please check all data", "Missing data");
        }

        /// <summary>
        /// Handles the change loan click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangeLoan_Click(object sender, EventArgs e)
        {
            loanManager.ChangeLoanDate(dtpReturnLoan.Value, lstLoan.SelectedIndex);
            UpdateGUI();
        }

        /// <summary>
        /// Handles the delete button click event. Deletes a loan from the loan list and calls UpdateGUI method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteLoan_Click(object sender, EventArgs e)
        {
            if (lstLoan.SelectedIndex != -1 && lstLoan.SelectedIndex < loanManager.Count)
            {
                loanManager.DeleteLoan(lstLoan.SelectedIndex);
                UpdateGUI();
            }
            else
                MessageBox.Show("No loan selected, please select a loan", "No loan selected");
        }

        /// <summary>
        /// Handles event when user clicks on a loan in the loan list. It writes values for the loan to the textboxes
        /// and date time picker. Some buttons are disabled so that a user can't change the customer or book data for that
        /// loan. Only the date is changeable.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstLoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            WriteLables();
            dtpReturnLoan.Value = loanManager.GetLoan(lstLoan.SelectedIndex).ReturnDate;

            //Disable buttons
            btnAddLoan.Enabled = false;
            btnGetDataBook.Enabled = false;
            btnGetCustInfo.Enabled = false;
        }

        /// <summary>
        /// Clears all lables that has information from user input in customer and book form.
        /// </summary>
        private void ClearLabels()
        {
            lblAuthorNameOut.Text = string.Empty;
            lblTitleOut.Text = string.Empty;
            lblMediaFormatOut.Text = string.Empty;
            lblCustIDOut.Text = string.Empty;
            lblCustNameOut.Text = string.Empty;
        }

        /// <summary>
        /// Writes data to lables for loan information
        /// </summary>
        private void WriteLables()
        {
            lblAuthorNameOut.Text = loanManager.GetLoan(lstLoan.SelectedIndex).Book.FullName;
            lblTitleOut.Text = loanManager.GetLoan(lstLoan.SelectedIndex).Book.Title;
            lblMediaFormatOut.Text = loanManager.GetLoan(lstLoan.SelectedIndex).Book.MediaFormat.ToString();
            lblCustIDOut.Text = loanManager.GetLoan(lstLoan.SelectedIndex).Customer.ID;
            lblCustNameOut.Text = loanManager.GetLoan(lstLoan.SelectedIndex).Customer.Contact.FullName;
        }
    }
}
