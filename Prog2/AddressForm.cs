/*Grading ID : C4811
  CIS 200-01
  Prog 2
  1/1/2016
  Address form that takes address info and validates each before sending the info 
  back to the main form
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class AddressForm : Form
    {
        //Precondtion:NONE
        //Postcondtion: Adds 5 states to the State combobx
        public AddressForm()
        {
            InitializeComponent();
            // addes 5 states options to the State Combobox
            stateBox.Items.Add("KY");
            stateBox.Items.Add("TN");
            stateBox.Items.Add("OH");
            stateBox.Items.Add("IL");
            stateBox.Items.Add("CA");
        }

        internal string NameValue // property for the Address' Name
        {
            //Precondtion:NONE
            //Postcondtion:Retuns the value inputed into the name text box
            get { return nameTxtBox.Text; }
            //Precondtion:NONE
            //Postcondtion:Sets the value of the text box to the entered info
            set { nameTxtBox.Text = value; }
        }

        internal string Address// property for the Address' Address1
        {
            //Precondtion:NONE
            //Postcondtion:Retuns the value inputed into the Address1 text box
            get { return addressTxtBox.Text; }
            //Precondtion:NONE
            //Postcondtion:Sets the value of the text box to the entered info
            set { addressTxtBox.Text = value; }
        }
        internal string Address2// property for the Address' Address 2 (optional)
        {
            //Precondtion:NONE
            //Postcondtion:Retuns the value inputed into the Address2 text box
            get { return addressTxtBox2.Text; }
            //Precondtion:NONE
            //Postcondtion:Sets the value of the text box to the entered info
            set { addressTxtBox2.Text = value; }
        }
        internal string City// property for the Address' City
        {
            //Precondtion:NONE
            //Postcondtion:Retuns the value inputed into the City text box
            get { return cityTxtBox.Text; }
            //Precondtion:NONE
            //Postcondtion:Sets the value of the text box to the entered info
            set { cityTxtBox.Text = value; }
        }
        internal string State// property for the Address' State
        {
            //Precondtion:NONE
            //Postcondtion:Retuns the value inputed into the State combobox
            get { return stateBox.Text; }
            //Precondtion:NONE
            //Postcondtion:Sets the value of the combobox to the entered info
            set { stateBox.Text = value; }
        }
        internal string Zip// property for the Address' ZipCode
        {
            //Precondtion:NONE
            //Postcondtion:Retuns the value inputed into the ZipCode text box
            get { return zipTxtBox.Text; }
            //Precondtion:NONE
            //Postcondtion:Sets the value of the text box to the entered info
            set { zipTxtBox.Text = value; }
         
        }
        //Precondtion: Must be a string, and can not be empty
        //Postcondtion:validates the input value for the Name
        private void nameTxt_Validating(object sender, CancelEventArgs e)
        {
            int number; // declares an int to hold a number use to validate whether or not an int was entered

            if (nameTxtBox.Text.Length <= 0) // if textbox is empty
            {
                e.Cancel = true;//call the error message, prevents the focus from being changed

                errorProvider1.SetError(nameTxtBox, "Please Enter a Name");// sets the error message 

                nameTxtBox.SelectAll(); // highlights the tex box if an error occurs

            }
            else
                if (int.TryParse(nameTxtBox.Text, out number)) //if an int is entered
            {
                e.Cancel = true;//call the error message, prevents the focus from being changed

                errorProvider1.SetError(nameTxtBox, "Please Enter a Name");// sets the error message 

                nameTxtBox.SelectAll();// highlights the tex box if an error occurs
            }
        }
        //Precondtion: The input must be valid
        //Postcondtion: Removes the error message and 
        //              allows the user to move on to the next text box
        private void nameTxt_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(nameTxtBox, ""); // removes error message and allows focus to change

        }
        //Precondtion: Text box can not be empty
        //Postcondtion:validates the input value for the address
        private void addressTxt_Validating(object sender, CancelEventArgs e)
        {            

            if (addressTxtBox.Text.Length <= 0)// if textbox is empty
            {
                e.Cancel = true;//call the error message, prevents the focus from being changed

                errorProvider1.SetError(addressTxtBox, "Please Enter a Address");// sets the error message 

                addressTxtBox.SelectAll();// highlights the tex box if an error occurs

            }                     
            
        }
        //Precondtion: The input must be valid
        //Postcondtion: Removes the error message and 
        //              allows the user to move on to the next text box
        private void addressTxt_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(addressTxtBox, "");// removes error message and allows focus to change
        }
        //Precondtion: Must be a string, and can not be empty
        //Postcondtion:validates the input value for the City
        private void cityTxt_Validating(object sender, CancelEventArgs e)
        {
            int number; // declares an int to hold a number use to validate whether or not an int was entered

            if (cityTxtBox.Text.Length <= 0)// if textbox is empty
            {
                e.Cancel = true;//call the error message, prevents the focus from being changed

                errorProvider1.SetError(cityTxtBox, "Please Enter a City");// sets the error message

                cityTxtBox.SelectAll();// highlights the tex box if an error occurs

            }
            else
                if (int.TryParse(cityTxtBox.Text, out number)) //if an int is entered
            {
                e.Cancel = true;//call the error message, prevents the focus from being changed

                errorProvider1.SetError(cityTxtBox, "Please Enter a City");// sets the error message 

                cityTxtBox.SelectAll();// highlights the tex box if an error occurs
            }

        }
        //Precondtion: The input must be valid
        //Postcondtion: Removes the error message and 
        //              allows the user to move on to the next text box
        private void cityTxt_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(cityTxtBox, "");// removes error message and allows focus to change

        }
        //Precondtion: The input must be valid
        //Postcondtion: Removes the error message and 
        //              allows the user to move on to the next text box
        private void stateBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(stateBox, "");// removes error message and allows focus to change
        }
        //Precondtion: An item must be selected
        //Postcondtion:makes sure an item is selected
        private void stateBox_Validating(object sender, CancelEventArgs e)
        {
            if (stateBox.SelectedIndex == -1) // if nothing has been selected in the combobox

                e.Cancel = true;//call the error message, prevents the focus from being changed

            errorProvider1.SetError(stateBox, "Please Select a State");// sets the error message 

            stateBox.SelectAll();// highlights the combo box if an error occurs
        }
        //Precondtion: Must be a non negative, 5 digit integer, and can not be empty
        //Postcondtion:validates the input value for the Zip
        private void zipTxt_Validating(object sender, CancelEventArgs e)
        {
            int zipCode; //declares an int variable to hold the zip code

            if (!int.TryParse(zipTxtBox.Text, out zipCode)) // is a non int was entered
            {
                e.Cancel = true; //call the error message, prevents the focus from being changed
                                 
                errorProvider1.SetError(zipTxtBox, "Please Enter a 5 Digit Integer Zip Code"); // sets the error message 

                zipTxtBox.SelectAll(); // highlights the tex box if an error occurs
            }
            else if
                 (zipTxtBox.Text.Length > 5 || zipTxtBox.Text.Length < 5) //if zipcode is less than or greater than 5 digits
                {
                    e.Cancel = true; //call the error message, prevents the focus from being changed
                                    

                errorProvider1.SetError(zipTxtBox, "Please Enter a 5 Digit Integer Zip Code"); // sets the error message

                zipTxtBox.SelectAll(); // highlights the tex box if an error occurs
            }
            else
                if (zipCode < 00000 && zipCode > 99999) //if zip code entered is greater than or less than 99999,00000
            {
                e.Cancel = true;//call the error message, prevents the focus from being changed

                errorProvider1.SetError(zipTxtBox, "Please Enter a Non Negative integer between 00000 and 99999");// sets the error message 

                zipTxtBox.SelectAll();// highlights the tex box if an error occurs
            }
        }
        //Precondtion: The input must be valid
        //Postcondtion: Removes the error message and 
        //              allows the user to move on to the next text box
        private void zipTxt_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(zipTxtBox, "");// removes error message and allows focus to change
        }
        //Precondtion: None
        //Postcondtion:Cancels the form
        private void cancelButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // if there was a left-click?
                this.DialogResult = DialogResult.Cancel;//cancels the form
        }
        //Precondtion: All previous text(combo) boxes must have valid data enter
        //Postcondtion:Send the validated info back to the main Form
        private void okButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren()) 
                this.DialogResult = DialogResult.OK;
        }
    }
}
