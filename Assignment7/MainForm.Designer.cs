namespace Assignment7
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetDataBook = new System.Windows.Forms.Button();
            this.grpBookInfo = new System.Windows.Forms.GroupBox();
            this.lblMediaFormatOut = new System.Windows.Forms.Label();
            this.lblTitleOut = new System.Windows.Forms.Label();
            this.lblAuthorNameOut = new System.Windows.Forms.Label();
            this.lblMediaFormat = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.grpLoanInfo = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDeleteLoan = new System.Windows.Forms.Button();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.dtpReturnLoan = new System.Windows.Forms.DateTimePicker();
            this.btnChangeDate = new System.Windows.Forms.Button();
            this.btnAddLoan = new System.Windows.Forms.Button();
            this.btnGetCustInfo = new System.Windows.Forms.Button();
            this.grpCustomerInfo = new System.Windows.Forms.GroupBox();
            this.lblCustNameOut = new System.Windows.Forms.Label();
            this.lblCustIDOut = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.grpLoanList = new System.Windows.Forms.GroupBox();
            this.lstLoan = new System.Windows.Forms.ListBox();
            this.grpBookInfo.SuspendLayout();
            this.grpLoanInfo.SuspendLayout();
            this.grpCustomerInfo.SuspendLayout();
            this.grpLoanList.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetDataBook
            // 
            this.btnGetDataBook.Location = new System.Drawing.Point(6, 145);
            this.btnGetDataBook.Name = "btnGetDataBook";
            this.btnGetDataBook.Size = new System.Drawing.Size(130, 23);
            this.btnGetDataBook.TabIndex = 3;
            this.btnGetDataBook.Text = "Get book data";
            this.btnGetDataBook.UseVisualStyleBackColor = true;
            this.btnGetDataBook.Click += new System.EventHandler(this.btnGetBookInfo_Click);
            // 
            // grpBookInfo
            // 
            this.grpBookInfo.Controls.Add(this.lblMediaFormatOut);
            this.grpBookInfo.Controls.Add(this.lblTitleOut);
            this.grpBookInfo.Controls.Add(this.lblAuthorNameOut);
            this.grpBookInfo.Controls.Add(this.lblMediaFormat);
            this.grpBookInfo.Controls.Add(this.lblTitle);
            this.grpBookInfo.Controls.Add(this.lblAuthorName);
            this.grpBookInfo.Location = new System.Drawing.Point(6, 19);
            this.grpBookInfo.Name = "grpBookInfo";
            this.grpBookInfo.Size = new System.Drawing.Size(295, 120);
            this.grpBookInfo.TabIndex = 4;
            this.grpBookInfo.TabStop = false;
            this.grpBookInfo.Text = "Book information";
            // 
            // lblMediaFormatOut
            // 
            this.lblMediaFormatOut.AutoSize = true;
            this.lblMediaFormatOut.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblMediaFormatOut.Location = new System.Drawing.Point(105, 87);
            this.lblMediaFormatOut.Name = "lblMediaFormatOut";
            this.lblMediaFormatOut.Size = new System.Drawing.Size(91, 13);
            this.lblMediaFormatOut.TabIndex = 8;
            this.lblMediaFormatOut.Text = "Media Format Out";
            // 
            // lblTitleOut
            // 
            this.lblTitleOut.AutoSize = true;
            this.lblTitleOut.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTitleOut.Location = new System.Drawing.Point(105, 59);
            this.lblTitleOut.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.lblTitleOut.Name = "lblTitleOut";
            this.lblTitleOut.Size = new System.Drawing.Size(47, 13);
            this.lblTitleOut.TabIndex = 7;
            this.lblTitleOut.Text = "Title Out";
            // 
            // lblAuthorNameOut
            // 
            this.lblAuthorNameOut.AutoSize = true;
            this.lblAuthorNameOut.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblAuthorNameOut.Location = new System.Drawing.Point(105, 31);
            this.lblAuthorNameOut.Margin = new System.Windows.Forms.Padding(15, 15, 3, 15);
            this.lblAuthorNameOut.Name = "lblAuthorNameOut";
            this.lblAuthorNameOut.Size = new System.Drawing.Size(55, 13);
            this.lblAuthorNameOut.TabIndex = 6;
            this.lblAuthorNameOut.Text = "Name Out";
            // 
            // lblMediaFormat
            // 
            this.lblMediaFormat.AutoSize = true;
            this.lblMediaFormat.Location = new System.Drawing.Point(6, 87);
            this.lblMediaFormat.Name = "lblMediaFormat";
            this.lblMediaFormat.Size = new System.Drawing.Size(68, 13);
            this.lblMediaFormat.TabIndex = 5;
            this.lblMediaFormat.Text = "MediaFormat";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(6, 59);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Title";
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Location = new System.Drawing.Point(6, 31);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(81, 13);
            this.lblAuthorName.TabIndex = 3;
            this.lblAuthorName.Text = "Name of Author";
            // 
            // grpLoanInfo
            // 
            this.grpLoanInfo.Controls.Add(this.btnClear);
            this.grpLoanInfo.Controls.Add(this.btnDeleteLoan);
            this.grpLoanInfo.Controls.Add(this.lblReturnDate);
            this.grpLoanInfo.Controls.Add(this.dtpReturnLoan);
            this.grpLoanInfo.Controls.Add(this.btnChangeDate);
            this.grpLoanInfo.Controls.Add(this.btnAddLoan);
            this.grpLoanInfo.Controls.Add(this.btnGetCustInfo);
            this.grpLoanInfo.Controls.Add(this.grpCustomerInfo);
            this.grpLoanInfo.Controls.Add(this.grpBookInfo);
            this.grpLoanInfo.Controls.Add(this.btnGetDataBook);
            this.grpLoanInfo.Location = new System.Drawing.Point(12, 12);
            this.grpLoanInfo.Name = "grpLoanInfo";
            this.grpLoanInfo.Size = new System.Drawing.Size(780, 228);
            this.grpLoanInfo.TabIndex = 5;
            this.grpLoanInfo.TabStop = false;
            this.grpLoanInfo.Text = "Loan information";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(632, 187);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 15, 15, 15);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear selection";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDeleteLoan
            // 
            this.btnDeleteLoan.Location = new System.Drawing.Point(632, 70);
            this.btnDeleteLoan.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.btnDeleteLoan.Name = "btnDeleteLoan";
            this.btnDeleteLoan.Size = new System.Drawing.Size(130, 23);
            this.btnDeleteLoan.TabIndex = 11;
            this.btnDeleteLoan.Text = "Delete loan";
            this.btnDeleteLoan.UseVisualStyleBackColor = true;
            this.btnDeleteLoan.Click += new System.EventHandler(this.btnDeleteLoan_Click);
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Location = new System.Drawing.Point(12, 194);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(63, 13);
            this.lblReturnDate.TabIndex = 10;
            this.lblReturnDate.Text = "Return date";
            // 
            // dtpReturnLoan
            // 
            this.dtpReturnLoan.Location = new System.Drawing.Point(81, 188);
            this.dtpReturnLoan.Name = "dtpReturnLoan";
            this.dtpReturnLoan.Size = new System.Drawing.Size(138, 20);
            this.dtpReturnLoan.TabIndex = 9;
            // 
            // btnChangeDate
            // 
            this.btnChangeDate.Location = new System.Drawing.Point(237, 187);
            this.btnChangeDate.Margin = new System.Windows.Forms.Padding(15, 3, 3, 15);
            this.btnChangeDate.Name = "btnChangeDate";
            this.btnChangeDate.Size = new System.Drawing.Size(130, 23);
            this.btnChangeDate.TabIndex = 8;
            this.btnChangeDate.Text = "Change return date";
            this.btnChangeDate.UseVisualStyleBackColor = true;
            this.btnChangeDate.Click += new System.EventHandler(this.btnChangeLoan_Click);
            // 
            // btnAddLoan
            // 
            this.btnAddLoan.Location = new System.Drawing.Point(632, 29);
            this.btnAddLoan.Margin = new System.Windows.Forms.Padding(15, 3, 3, 15);
            this.btnAddLoan.Name = "btnAddLoan";
            this.btnAddLoan.Size = new System.Drawing.Size(130, 23);
            this.btnAddLoan.TabIndex = 7;
            this.btnAddLoan.Text = "Add loan";
            this.btnAddLoan.UseVisualStyleBackColor = true;
            this.btnAddLoan.Click += new System.EventHandler(this.btnAddLoan_Click);
            // 
            // btnGetCustInfo
            // 
            this.btnGetCustInfo.Location = new System.Drawing.Point(307, 145);
            this.btnGetCustInfo.Name = "btnGetCustInfo";
            this.btnGetCustInfo.Size = new System.Drawing.Size(130, 23);
            this.btnGetCustInfo.TabIndex = 6;
            this.btnGetCustInfo.Text = "Get Customer data";
            this.btnGetCustInfo.UseVisualStyleBackColor = true;
            this.btnGetCustInfo.Click += new System.EventHandler(this.btnGetCustInfo_Click);
            // 
            // grpCustomerInfo
            // 
            this.grpCustomerInfo.Controls.Add(this.lblCustNameOut);
            this.grpCustomerInfo.Controls.Add(this.lblCustIDOut);
            this.grpCustomerInfo.Controls.Add(this.lblCustName);
            this.grpCustomerInfo.Controls.Add(this.lblCustomerID);
            this.grpCustomerInfo.Location = new System.Drawing.Point(307, 19);
            this.grpCustomerInfo.Name = "grpCustomerInfo";
            this.grpCustomerInfo.Size = new System.Drawing.Size(295, 120);
            this.grpCustomerInfo.TabIndex = 5;
            this.grpCustomerInfo.TabStop = false;
            this.grpCustomerInfo.Text = "Customer information";
            // 
            // lblCustNameOut
            // 
            this.lblCustNameOut.AutoSize = true;
            this.lblCustNameOut.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCustNameOut.Location = new System.Drawing.Point(89, 59);
            this.lblCustNameOut.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.lblCustNameOut.Name = "lblCustNameOut";
            this.lblCustNameOut.Size = new System.Drawing.Size(55, 13);
            this.lblCustNameOut.TabIndex = 7;
            this.lblCustNameOut.Text = "Name Out";
            // 
            // lblCustIDOut
            // 
            this.lblCustIDOut.AutoSize = true;
            this.lblCustIDOut.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCustIDOut.Location = new System.Drawing.Point(89, 31);
            this.lblCustIDOut.Margin = new System.Windows.Forms.Padding(15, 15, 3, 15);
            this.lblCustIDOut.Name = "lblCustIDOut";
            this.lblCustIDOut.Size = new System.Drawing.Size(38, 13);
            this.lblCustIDOut.TabIndex = 6;
            this.lblCustIDOut.Text = "ID Out";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(6, 59);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(35, 13);
            this.lblCustName.TabIndex = 4;
            this.lblCustName.Text = "Name";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(6, 31);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(65, 13);
            this.lblCustomerID.TabIndex = 3;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // grpLoanList
            // 
            this.grpLoanList.Controls.Add(this.lstLoan);
            this.grpLoanList.Location = new System.Drawing.Point(12, 258);
            this.grpLoanList.Name = "grpLoanList";
            this.grpLoanList.Size = new System.Drawing.Size(780, 276);
            this.grpLoanList.TabIndex = 6;
            this.grpLoanList.TabStop = false;
            this.grpLoanList.Text = "List of current loans";
            // 
            // lstLoan
            // 
            this.lstLoan.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLoan.FormattingEnabled = true;
            this.lstLoan.HorizontalScrollbar = true;
            this.lstLoan.ItemHeight = 14;
            this.lstLoan.Location = new System.Drawing.Point(6, 32);
            this.lstLoan.Name = "lstLoan";
            this.lstLoan.Size = new System.Drawing.Size(768, 228);
            this.lstLoan.TabIndex = 0;
            this.lstLoan.SelectedIndexChanged += new System.EventHandler(this.lstLoan_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 546);
            this.Controls.Add(this.grpLoanList);
            this.Controls.Add(this.grpLoanInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.grpBookInfo.ResumeLayout(false);
            this.grpBookInfo.PerformLayout();
            this.grpLoanInfo.ResumeLayout(false);
            this.grpLoanInfo.PerformLayout();
            this.grpCustomerInfo.ResumeLayout(false);
            this.grpCustomerInfo.PerformLayout();
            this.grpLoanList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGetDataBook;
        private System.Windows.Forms.GroupBox grpBookInfo;
        private System.Windows.Forms.Label lblMediaFormat;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthorName;
        private System.Windows.Forms.Label lblMediaFormatOut;
        private System.Windows.Forms.Label lblTitleOut;
        private System.Windows.Forms.Label lblAuthorNameOut;
        private System.Windows.Forms.GroupBox grpLoanInfo;
        private System.Windows.Forms.GroupBox grpCustomerInfo;
        private System.Windows.Forms.Label lblCustNameOut;
        private System.Windows.Forms.Label lblCustIDOut;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Button btnGetCustInfo;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.DateTimePicker dtpReturnLoan;
        private System.Windows.Forms.Button btnChangeDate;
        private System.Windows.Forms.Button btnAddLoan;
        private System.Windows.Forms.GroupBox grpLoanList;
        private System.Windows.Forms.ListBox lstLoan;
        private System.Windows.Forms.Button btnDeleteLoan;
        private System.Windows.Forms.Button btnClear;
    }
}

