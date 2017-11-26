/*Grading ID : C4811
  CIS 200-01
  Prog 2
  1/1/2016
  The Main Form that takes previously validated info and creates 
  Address/Letter objects and adds them to their respective lists. 
  Also displays all the current objects of each list onto the main form
  as well as Cacluates the Total Cost of all Parcels listed
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
    public partial class Prog2Form : Form
    {
        private UserParcelView upv;

        //Precondition: None
        //Postcondition: creates Address' and Letters to their respective 
        //               list using the Add(Address/Letter) method
        public Prog2Form()
        {
            InitializeComponent();
            upv = new UserParcelView();

            upv.AddAddress("John Smith", "123 Any St.", "Apt. 45",
                "Louisville", "KY", 40202);// test address 1
            upv.AddAddress("Jane Doe", "987 Main St.", "",
                "Beverly Hills", "CA", 90210);// test address 2
            upv.AddAddress("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901);// test address 3
            upv.AddAddress("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101);// test address 4
            upv.AddAddress("Stan Marsh", "ShTapa Town", "4321 Your Street",
                "Pittsburgh", "Pennsylvania", 15201);// test address 5
            upv.AddAddress("Eric Cartman", "South Park Elementary", "Detention Room 102",
                "New York City", "New York", 10001);// test address 6
            upv.AddAddress("Kenny McCormick", "SoDoSoapa", "1111 Gheto Avenue",
                "South Park", "Colorado", 80019);// test address 7
            upv.AddAddress("Kyle Broflovski", "The Church of God", "5676 Jewish Lane",
                "Jersey City", "New Jersey", 07208);// test address 8

            upv.AddLetter(upv.AddressAt(1), upv.AddressAt(0), 2.50M);//test letter 1
            upv.AddLetter(upv.AddressAt(3), upv.AddressAt(4), 1.50M);//test letter 2
            upv.AddLetter(upv.AddressAt(2), upv.AddressAt(5), 2.00M);//test letter 3
            upv.AddLetter(upv.AddressAt(7), upv.AddressAt(6), 0.75M);//test letter 4
        }

        //Precondition: None
        //Postcondition:Displays a messagebox with my Name, Class/Section,Due Date
        //              and name of the program
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Codey Von Vreckin{Environment.NewLine}CIS 200-01{Environment.NewLine}Due: Nov 1, 2016{Environment.NewLine}Program 2");
        }
        //Precondition: None
        //Postcondition:closes the App
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close(); 
        }
        //Precondition: None
        //Postcondition:takes info added in the Address form and uses it to create a new 
        //              address object
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressForm addressForm = new AddressForm(); //adds a new address form object
            DialogResult result;
            
            result = addressForm.ShowDialog();// shows the form as a modal dialog box

            if (result == DialogResult.OK)//if all entered address info is valid
            {
                // adds the new address object to the list
                upv.AddAddress(addressForm.NameValue, addressForm.Address, addressForm.Address2,
                                addressForm.City, addressForm.State, Convert.ToInt32(addressForm.Zip));
            }                        
        }
        //Precondition: None
        //Postcondition:takes info from the Address list as wellas the fixed cost from the letter form to  
        //              create a new letter object in the parcels list
        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LettersForm letterForm = new LettersForm(upv);//adds a new letter form object
            DialogResult result;

            result = letterForm.ShowDialog();// shows the form as a modal dialog box

            if (result == DialogResult.OK)//if all entered address/ fixed cost info is valid
            {       //adds a new letter object to the parcels list
                upv.AddLetter(letterForm.Origin, letterForm.Destination, Convert.ToDecimal(letterForm.FixedCost));
            }
        }
        //Precondition: must be addresses in the address list
        //Postcondition:displays all the address info for each address
        //              object in the address list
        private void listAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {                        
            textBox1.Text = string.Join("\r\n\r\n", upv.AddressList);
        }
        //Precondition: must be letters in the parcels list
        //Postcondition:displays all the letter info(origin/destination/fixed cost) for each letter
        //              object in the parcels list. And adds the total cost of all parcels in the list
        private void listParcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Join("\r\n\r\n", upv.ParcelList);
            textBox1.AppendText("\r\n\r\n\r\n");
            textBox1.AppendText(upv.ToString());
        }
    }
}
