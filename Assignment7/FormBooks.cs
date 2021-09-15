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
    public partial class FormBooks : Form
    {
        private BookManager bookManager;
        private Book book;

        public FormBooks(BookManager bookManager)
        {
            this.bookManager = bookManager;

            InitializeComponent();
            InitializeGUI();
        }

        public void InitializeGUI()
        {
            FillGenreComboBox();
            FillMediaFormatComboBox();
            UpdateGUI();
        }

        /// <summary>
        /// Updates GUI so that all textboxes are empty, comboboxes are set to default values, the listbox is cleared from old content
        /// and uptaded content is added. A new book object is created in order to handle additions and changes to current list of books
        /// Buttons are enabled or disabled according to possible actions that a user can take
        /// </summary>
        private void UpdateGUI() 
        {
            book = new Book();
            txtFname.Text = string.Empty;
            txtLname.Text = string.Empty;
            txtTitle.Text = string.Empty;

            //Clear listbox and add updated items
            lstBooks.Items.Clear();
            lstBooks.Items.AddRange(bookManager.GetBookInfo());

            //Enable/Disable buttons
            btnAdd.Enabled = true;
            btnOK.Enabled = false;
        }

        /// <summary>
        /// Property to return index of selected book
        /// </summary>
        public int ReturnIndex { get; set; }

        /// <summary>
        /// Handles add button click event. Adds a new book to the book manager if all input is valid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ReadTitle();
            ReadFullName();
            ReadGenre();
            ReadMediaFormat();

            if (book.CheckData())
            {
                bookManager.AddBook(book);
                UpdateGUI();
            }
            else
                MessageBox.Show("Missing information about the book, please check all data", "Missing data");
            
        }

        /// <summary>
        /// Handles change button click event. Check that the selected index contains a book object and procedes to 
        /// applying the changes that the user made
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Click(object sender, EventArgs e)
        {


            if(lstBooks.SelectedIndex != -1 && lstBooks.SelectedIndex < bookManager.Count)
            {
                if (CheckData())
                {
                    ReadTitle();
                    ReadFullName();
                    ReadGenre();
                    ReadMediaFormat();bookManager.ChangeBook(book, lstBooks.SelectedIndex);
                    UpdateGUI();
                }
                else
                    MessageBox.Show("Missing information about the book, please check all data", "Missing data");
            }
            else
                MessageBox.Show("No book selected, please select a book", "No book selected");
        }

        /// <summary>
        /// Handles delete button click event. Check that the selected index contains a book object and procedes to 
        /// deleting the object that the user has selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstBooks.SelectedIndex != -1 && lstBooks.SelectedIndex < bookManager.Count)
            {
                bookManager.DeleteBook(lstBooks.SelectedIndex);
                UpdateGUI();
            }
            else
                MessageBox.Show("No book selected, please select a book", "No book selected");

        }

        /// <summary>
        /// Uptades GUI to default values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            UpdateGUI();
        }

        /// <summary>
        /// Handles click event for when the user clicks on the select customer button. Returns the index of the book in
        /// the book manager.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            ReturnIndex = lstBooks.SelectedIndex;
        }

        /// <summary>
        /// Handles change in selected index and enable/disable buttons since the different actions a user can take
        /// has changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBooks.SelectedIndex != -1)
            {
                book = bookManager.GetBook(lstBooks.SelectedIndex);
                WriteDataToBoxes();

                //Enable/disable buttons
                btnAdd.Enabled = false;
                btnChange.Enabled = true;
                btnDelete.Enabled = true;
                btnOK.Enabled = true;
            }
        }

        /// <summary>
        /// Fills combobox with content and sets Sweden as initial value of the combo box
        /// </summary>
        private void FillGenreComboBox()
        {
            cmbGenre.DataSource = Enum.GetValues(typeof(Genre));
            cmbGenre.SelectedItem = Genre.Crime;
        }

        /// <summary>
        /// Fills combobox with content and sets Sweden as initial value of the combo box
        /// </summary>
        private void FillMediaFormatComboBox()
        {
            cmbMediaFormat.DataSource = Enum.GetValues(typeof(MediaFormat));
            cmbMediaFormat.SelectedItem = MediaFormat.Book;
        }

        /// <summary>
        /// Reads authors full name from user input i textboxes
        /// </summary>
        private void ReadFullName() 
        {
            book.Fname = txtFname.Text;
            book.Lname = txtLname.Text;
        }

        /// <summary>
        /// Reads book title from user input i textbox
        /// </summary>
        private void ReadTitle()
        {
            book.Title = txtTitle.Text;
        }

        /// <summary>
        /// Reads selected genre from the combobox
        /// </summary>
        private void ReadGenre()
        {
            book.Genre = (Genre)cmbGenre.SelectedItem;
        }

        /// <summary>
        /// Reads selected media format from the combobox
        /// </summary>
        private void ReadMediaFormat()
        {
            book.MediaFormat = (MediaFormat)cmbMediaFormat.SelectedItem;
        }

        /// <summary>
        /// Writes the data about the book in their respective areas
        /// </summary>
        private void WriteDataToBoxes()
        {
            txtFname.Text = book.Fname;
            txtLname.Text = book.Lname;
            txtTitle.Text = book.Title;
            cmbGenre.SelectedItem = book.Genre;
            cmbMediaFormat.SelectedItem = book.MediaFormat;
        }

        /// <summary>
        /// Check that no textbox is empty to avoid null values and empty strings
        /// </summary>
        /// <returns>ok if no null or empty strings</returns>
        private bool CheckData() 
        {
            bool ok = !string.IsNullOrEmpty(txtFname.Text) && !string.IsNullOrEmpty(txtLname.Text) && !string.IsNullOrEmpty(txtTitle.Text);

            return ok;
        }
    }
}
