/*Grading ID : C4811
  CIS 200-01
  Prog 2
  1/1/2016
  A letter form that allows the user to select a 
  origin and destination address as well as a fixed cost
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
    public partial class LettersForm : Form
    {
        private UserParcelView userParcelView;
        //Precondtion:NONE
        //Postcondtion: Adds the Address names for the origin and destination comboboxes 
        public LettersForm(UserParcelView upv)
        {
            InitializeComponent();

            // Save reference to user parcel view
            userParcelView = upv;
          
            // Add all our names from addresses to the comboboxes
            foreach (var address in userParcelView.addresses)
            {
                originComboBox.Items.Add(address.Name);
                destinComboBox.Items.Add(address.Name);
            }
        }
        
        internal Address Origin// property for the origin Address
        {
            //Precondtion:NONE
            //Postcondtion: returns the selected origin address info 
            get { return userParcelView.AddressAt(originComboBox.SelectedIndex); }
        }

        internal Address Destination// property for the destination Address
        {
            //Precondtion:NONE
            //Postcondtion: returns the selected destination address info 
            get { return userParcelView.AddressAt(destinComboBox.SelectedIndex); }
        }

        internal string FixedCost// property for the Fixed Cost
        {
            //Precondtion:NONE
            //Postcondtion:returns the fixed cost   
            get { return fixedCostTxtBox.Text; }
        }
        //Precondtion: The input must be valid
        //Postcondtion: Removes the error message and 
        //              allows the user to move on to the next text box
        private void originComboBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(originComboBox, "");
        }
        //Precondtion: An item must be selected
        //Postcondtion:makes sure an item is selected
        private void originComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (originComboBox.SelectedIndex == -1)// if nothing has been selected in the combobox

                e.Cancel = true;//call the error message, prevents the focus from being changed

            errorProvider1.SetError(originComboBox, "Please Select an Origin");// Set error message

            originComboBox.SelectAll();// highlights the tex box if an error occurs


        }
        //Precondtion: An item must be selected
        //Postcondtion:makes sure an item is selected
        private void destinComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (destinComboBox.SelectedIndex == -1)// if nothing has been selected in the combobox
            {
                e.Cancel = true;//call the error message, prevents the focus from being changed

                errorProvider1.SetError(destinComboBox, "Please Select a Destination");// Set error message

                destinComboBox.SelectAll();// highlights the tex box if an error occurs
            }
            else
            if (destinComboBox == originComboBox) // if the same name is selected for origin and destination
                e.Cancel = true;//call the error message, prevents the focus from being changed

            errorProvider1.SetError(destinComboBox, "Origin and Destination Addresses can not be the same");// Set error message

            destinComboBox.SelectAll();// highlights the tex box if an error occurs
        }
        //Precondtion: The input must be valid
        //Postcondtion: Removes the error message and 
        //              allows the user to move on to the next text box
        private void destinComboBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(destinComboBox, "");
        }

        private void fixedCostTxtBox_Validating(object sender, CancelEventArgs e)
        {
            decimal fixedCost; // declares a decimal variable to hold the fixed cost

            if (!decimal.TryParse(fixedCostTxtBox.Text, out fixedCost))// if a non decimal value is entered
            {
                e.Cancel = true; //call the error message, prevents the focus from being changed

                errorProvider1.SetError(fixedCostTxtBox, "Please Enter a Fixed Cost"); // Set error message

                fixedCostTxtBox.SelectAll(); // highlights the tex box if an error occurs
            }
            else 

            if(fixedCostTxtBox.Text.Length < 0)// if the text box is empty
            {
                e.Cancel = true; //call the error message, prevents the focus from being changed

                errorProvider1.SetError(fixedCostTxtBox, "Please Enter a Fixed Cost"); // Set error message

                fixedCostTxtBox.SelectAll(); // highlights the tex box if an error occurs
            }
        }
        //Precondtion: The input must be valid
        //Postcondtion: Removes the error message and 
        //              allows the user to move on to the next text box
        private void fixedCostTxtBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(fixedCostTxtBox, "");
        }
        //Precondtion: None
        //Postcondtion:Cancels the form
        private void letterOKButtton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }
        //Precondtion: All previous text(combo) boxes must have valid data enter
        //Postcondtion:Send the validated info back to the main Form
        private void letterCancelButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Was it a left-click?
                this.DialogResult = DialogResult.Cancel;
        }
    }
}
