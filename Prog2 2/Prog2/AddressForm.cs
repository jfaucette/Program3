// Program 2
// CIS 200
// Fall 2014
// Due: 11/2/2014
// By: Andrew L. Wright

// File: AddressForm.cs
// This class creates the Address dialog box form GUI. It performs validation
// and provides String properties for each field.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prog2
{
    public partial class AddressForm : Form
    {
        public const String DEFAULT_STATE = "KY"; // Default state for addresses

        // Precondition:  None
        // Postcondition: The form's GUI is prepared for display.
        public AddressForm()
        {
            InitializeComponent();

            List<string> states = new List<string> {"CA", "IN", "KY", "MD", "ME",
                                   "NC", "OH", "SC", "TN", "TX"};

            foreach (string state in states)
                stateCbo.Items.Add(state);

            State = AddressForm.DEFAULT_STATE;
        }

        public string AddressName
        {
            // Precondition:  None
            // Postcondition: The text of form's name field is returned
            get
            {
                return nameTxt.Text;
            }
            // Precondition:  None
            // Postcondition: The text of form's name field is set to specified value
            set
            {
                nameTxt.Text = value;
            }
        }

        public string Address1
        {
            // Precondition:  None
            // Postcondition: The text of form's Address1 field is returned
            get
            {
                return address1Txt.Text;
            }
            // Precondition:  None
            // Postcondition: The text of form's Address1 field is set to specified value
            set
            {
                address1Txt.Text = value;
            }
        }

        public string Address2
        {
            // Precondition:  None
            // Postcondition: The text of form's Address2 field is returned
            get
            {
                return address2Txt.Text;
            }
            // Precondition:  None
            // Postcondition: The text of form's Address2 field is set to specified value
            set
            {
                address2Txt.Text = value;
            }
        }

        public string City
        {
            // Precondition:  None
            // Postcondition: The text of form's City field is returned
            get
            {
                return cityTxt.Text;
            }
            // Precondition:  None
            // Postcondition: The text of form's City field is set to specified value
            set
            {
                cityTxt.Text = value;
            }
        }

        public string ZipText
        {
            // Precondition:  None
            // Postcondition: The text of form's Zip field is returned
            get
            {
                return zipTxt.Text;
            }
            // Precondition:  None
            // Postcondition: The text of form's Zip field is set to specified value
            set
            {
                zipTxt.Text = value;
            }
        }

        public string State
        {
            // Precondition:  None
            // Postcondition: The text of form's State field is returned
            get
            {
                if (stateCbo.SelectedIndex != -1) // -1 means no item selected
                    return stateCbo.SelectedItem.ToString();
                else
                    return "";

            }
            // Precondition:  value must be in stateCbo Items
            // Postcondition: The text of form's State field is set to specified value
            set
            {
                stateCbo.SelectedItem = value;
            }
        }

        // Precondition:  None
        // Postcondition: The State is set to the default choice and
        //                states combo box is loaded with values
        private void AddressForm_Load(object sender, EventArgs e)
        {
            List<string> states = new List<string> {"CA", "IN", "KY", "MD", "ME",
                                   "NC", "OH", "SC", "TN", "TX"};

            foreach (string state in states)
                stateCbo.Items.Add(state);

            State = AddressForm.DEFAULT_STATE;
        }

        // Precondition:  Focus is shifting from zipTxt
        // Postcondition: If text is invalid, focus remains and error provider
        //                highlights the field
        private void zipTxt_Validating(object sender, CancelEventArgs e)
        {
            int zip;           // Zip code of address
            bool valid = true; // Is text valid?

            if (!int.TryParse(zipTxt.Text, out zip)) // Parse failed?
                valid = false;
            else if ((zip < 0) || (zip > Address.MAX_ZIP))
                valid = false;

            if (!valid) // Invalid, so cancel and highlight field
            {
                e.Cancel = true;
                zipTxt.SelectAll();
                errorProvider.SetError(zipTxt, "Invalid zip code! Enter 5 digit zip code.");
            }
        }

        // Precondition:  Validating of zipTxt not cancelled, so data OK
        // Postcondition: Error provider cleared and focus allowed to change
        private void zipTxt_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(zipTxt, "");
        }

        // Precondition:  Focus is shifting from nameTxt
        // Postcondition: If text is invalid, focus remains and error provider
        //                highlights the field
        private void nameTxt_Validating(object sender, CancelEventArgs e)
        {
            if (nameTxt.TextLength == 0) // Empty field
            {
                e.Cancel = true;
                errorProvider.SetError(nameTxt, "Must provide Name");
            }
        }

        // Precondition:  Validating of nameTxt not cancelled, so data OK
        // Postcondition: Error provider cleared and focus allowed to change
        private void nameTxt_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(nameTxt, "");
        }

        // Precondition:  Focus is shifting from address1Txt
        // Postcondition: If text is invalid, focus remains and error provider
        //                highlights the field
        private void address1Txt_Validating(object sender, CancelEventArgs e)
        {
            if ( address1Txt.TextLength == 0) // Empty field
            {
                e.Cancel = true;
                errorProvider.SetError(address1Txt, "Must provide Address");
            }
        }

        // Precondition:  Validating of address1Txt not cancelled, so data OK
        // Postcondition: Error provider cleared and focus allowed to change
        private void address1Txt_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(address1Txt, "");
        }

        // Precondition:  Focus is shifting from cityTxt
        // Postcondition: If text is invalid, focus remains and error provider
        //                highlights the field
        private void cityTxt_Validating(object sender, CancelEventArgs e)
        {
            if (cityTxt.TextLength == 0) // Empty field
            {
                e.Cancel = true;
                errorProvider.SetError(cityTxt, "Must provide City");
            }
        }

        // Precondition:  Validating of cityTxt not cancelled, so data OK
        // Postcondition: Error provider cleared and focus allowed to change
        private void cityTxt_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(cityTxt, "");
        }

        // Precondition:  User pressed on cancelBtn
        // Postcondition: Form closes and sends Cancel result
        private void cancelBtn_MouseDown(object sender, MouseEventArgs e)
        {
            // This handler uses MouseDown instead of Click event because
            // Click won't be allowed if other field's validation fails

            if (e.Button == MouseButtons.Left) // Was it a left-click?
                this.DialogResult = DialogResult.Cancel;
        }

        // Precondition:  User clicked on okBtn
        // Postcondition: If invalid field on dialog, keep form open and give first invalid
        //                field the focus. Else return OK and close form.
        private void okBtn_Click(object sender, EventArgs e)
        {
            // The easy way
            // Raise validating event for all enabled controls on form
            // If all pass, ValidateChildren() will be true
            if (ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }
    }
}
