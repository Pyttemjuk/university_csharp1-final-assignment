namespace Assignment7
{
    partial class FormCustomer
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
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtZipcode = new System.Windows.Forms.TextBox();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblZipcode = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.grpCustInfo = new System.Windows.Forms.GroupBox();
            this.lstCustomer = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpCustInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(176, 19);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(287, 20);
            this.txtFname.TabIndex = 0;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(176, 45);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(287, 20);
            this.txtLname.TabIndex = 1;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(176, 71);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(287, 20);
            this.txtStreet.TabIndex = 2;
            // 
            // txtZipcode
            // 
            this.txtZipcode.Location = new System.Drawing.Point(176, 97);
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.Size = new System.Drawing.Size(97, 20);
            this.txtZipcode.TabIndex = 3;
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(6, 22);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(55, 13);
            this.lblFname.TabIndex = 4;
            this.lblFname.Text = "First name";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(6, 48);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(56, 13);
            this.lblLname.TabIndex = 5;
            this.lblLname.Text = "Last name";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(6, 74);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(35, 13);
            this.lblStreet.TabIndex = 6;
            this.lblStreet.Text = "Street";
            // 
            // lblZipcode
            // 
            this.lblZipcode.AutoSize = true;
            this.lblZipcode.Location = new System.Drawing.Point(6, 100);
            this.lblZipcode.Name = "lblZipcode";
            this.lblZipcode.Size = new System.Drawing.Size(50, 13);
            this.lblZipcode.TabIndex = 7;
            this.lblZipcode.Text = "Zip Code";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(176, 123);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(287, 20);
            this.txtCity.TabIndex = 8;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(6, 126);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 9;
            this.lblCity.Text = "City";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(6, 152);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(76, 13);
            this.lblPhone.TabIndex = 10;
            this.lblPhone.Text = "Phone number";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(176, 149);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(141, 20);
            this.txtPhone.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 178);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email address";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(176, 175);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(287, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // grpCustInfo
            // 
            this.grpCustInfo.Controls.Add(this.txtFname);
            this.grpCustInfo.Controls.Add(this.lblEmail);
            this.grpCustInfo.Controls.Add(this.txtEmail);
            this.grpCustInfo.Controls.Add(this.lblPhone);
            this.grpCustInfo.Controls.Add(this.lblFname);
            this.grpCustInfo.Controls.Add(this.lblCity);
            this.grpCustInfo.Controls.Add(this.txtLname);
            this.grpCustInfo.Controls.Add(this.lblZipcode);
            this.grpCustInfo.Controls.Add(this.txtPhone);
            this.grpCustInfo.Controls.Add(this.lblStreet);
            this.grpCustInfo.Controls.Add(this.txtStreet);
            this.grpCustInfo.Controls.Add(this.lblLname);
            this.grpCustInfo.Controls.Add(this.txtZipcode);
            this.grpCustInfo.Controls.Add(this.txtCity);
            this.grpCustInfo.Location = new System.Drawing.Point(12, 12);
            this.grpCustInfo.Name = "grpCustInfo";
            this.grpCustInfo.Size = new System.Drawing.Size(469, 208);
            this.grpCustInfo.TabIndex = 14;
            this.grpCustInfo.TabStop = false;
            this.grpCustInfo.Text = "Customer information";
            // 
            // lstCustomer
            // 
            this.lstCustomer.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCustomer.FormattingEnabled = true;
            this.lstCustomer.HorizontalScrollbar = true;
            this.lstCustomer.ItemHeight = 14;
            this.lstCustomer.Location = new System.Drawing.Point(12, 235);
            this.lstCustomer.Name = "lstCustomer";
            this.lstCustomer.Size = new System.Drawing.Size(780, 256);
            this.lstCustomer.TabIndex = 15;
            this.lstCustomer.SelectedIndexChanged += new System.EventHandler(this.lstCustomer_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(514, 24);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add Customer";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(514, 65);
            this.btnChange.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(130, 23);
            this.btnChange.TabIndex = 17;
            this.btnChange.Text = "Change data";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(514, 106);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete customer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(514, 147);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 23);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear data";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(514, 511);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(130, 23);
            this.btnOK.TabIndex = 20;
            this.btnOK.Text = "Select customer";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(662, 511);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 546);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstCustomer);
            this.Controls.Add(this.grpCustInfo);
            this.Name = "FormCustomer";
            this.Text = "FormCustomer";
            this.grpCustInfo.ResumeLayout(false);
            this.grpCustInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtZipcode;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblZipcode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox grpCustInfo;
        private System.Windows.Forms.ListBox lstCustomer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}