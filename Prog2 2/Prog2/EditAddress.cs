// Program 2
// CIS 200
// Fall 2014
// Due: 11/21/2014
// By: Javoni Faucette

// File: EditAddress.cs
// This class creates the EditAddress dialog box form GUI. It performs validation
// and provides String properties for each field. As well as updates the existing 
// address.
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
    public partial class EditAddress : Form
    {
        List<Address> tempAddressList;
        public EditAddress(List<Address> addressList)
        {
            InitializeComponent();
            tempAddressList = addressList;// tempAddressList enabling the user to edit
        }

        //Precondition: None.
        //Postcondition: Loads all the addresses in the list into the combobox.
        private void EditAddress_Load(object sender, EventArgs e)
        {
            foreach (Address address in tempAddressList)
            {
                cboSelectAddress.Items.Add(address.Name);
            }
        }


        // Precondition:  Focus is shifting from zipTxt
        // Postcondition: If text is invalid, focus remains and error provider
        //                highlights the field
        private void txtEditZip_Validating(object sender, CancelEventArgs e)
        {
            int zip;           // Zip code of address
            bool valid = true; // Is text valid?

            if (!int.TryParse(txtEditZip.Text, out zip)) // Parse failed?
                valid = false;
            else if ((zip < 0) || (zip > Address.MAX_ZIP))
                valid = false;

            if (!valid) // Invalid, so cancel and highlight field
            {
                e.Cancel = true;
                txtEditZip.SelectAll();
                errorProvider1.SetError(txtEditZip, "Invalid zip code! Enter 5 digit zip code.");
            }
        }

        // Precondition:  Validating of zipTxt not cancelled, so data OK
        // Postcondition: Error provider cleared and focus allowed to change
        private void txtEditZip_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtEditZip, "");
        }

        // Precondition:  Focus is shifting from nameTxt
        // Postcondition: If text is invalid, focus remains and error provider
        //                highlights the field
        private void txtEditName_Validating(object sender, CancelEventArgs e)
        {
            if (txtEditName.TextLength == 0) // Empty field
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEditName, "Must provide Name");
            }
        }

        // Precondition:  Validating of nameTxt not cancelled, so data OK
        // Postcondition: Error provider cleared and focus allowed to change
        private void txtEditName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtEditName, "");
        }

        // Precondition:  Focus is shifting from address1Txt
        // Postcondition: If text is invalid, focus remains and error provider
        //                highlights the field
        private void txtEditA1_Validating(object sender, CancelEventArgs e)
        {
            if (txtEditA1.TextLength == 0) // Empty field
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEditA1, "Must provide Address");
            }
        }

        // Precondition:  Validating of address1Txt not cancelled, so data OK
        // Postcondition: Error provider cleared and focus allowed to change
        private void txtEditA1_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtEditA1, "");
        }

        // Precondition:  Focus is shifting from cityTxt
        // Postcondition: If text is invalid, focus remains and error provider
        //                highlights the field
        private void txtEditCity_Validating(object sender, CancelEventArgs e)
        {
            if (txtEditCity.TextLength == 0) // Empty field
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEditCity, "Must provide City");
            }
        }

        // Precondition:  Validating of cityTxt not cancelled, so data OK
        // Postcondition: Error provider cleared and focus allowed to change
        private void txtEditCity_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtEditCity, "");
        }

        // Precondition:  User clicked on btnUpdate
        // Postcondition: If invalid field on dialog, keep form open and give first invalid
        //                field the focus. Else return OK and close form.
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Raise validating event for all enabled controls on form
            // If all pass, ValidateChildren() will be true
            if (ValidateChildren() && cboSelectAddress.SelectedIndex != -1)
            {
                Address selected = tempAddressList.ElementAt(cboSelectAddress.SelectedIndex);
                selected.Name = txtEditName.Text;
                selected.Address1 = txtEditA1.Text;
                selected.Address2 = txtEditA2.Text;
                selected.City = txtEditCity.Text;
                selected.State = cboEditState.SelectedItem.ToString();
                selected.Zip = int.Parse(txtEditZip.Text);
                this.DialogResult = DialogResult.OK;
            }// end if
        }// end click event
        
        //Precondition: Selected index is changed.
        //Postcondition: Sets the text entered in the text boxes to update the previous info.
        private void cboSelectAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            Address selected = tempAddressList.ElementAt(cboSelectAddress.SelectedIndex);
            txtEditName.Text = selected.Name;
            txtEditA1.Text = selected.Address1;
            txtEditA2.Text = selected.Address2;
            txtEditCity.Text = selected.City;
            cboEditState.SelectedItem = selected.State;
            txtEditZip.Text = selected.Zip.ToString();
        }

        //Precondition: Cancel button is moused down? 
        //Postcondition: the dialog result cancels and closes the dialog result.
        private void btnCancel_MouseDown(object sender, MouseEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }



        
    }
}
