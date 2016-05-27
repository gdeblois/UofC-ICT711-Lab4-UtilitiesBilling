using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
ICT711 Final Assessment
=======================

Submitted by: Ghislain de Blois

This is the final assessment in ICT711. Consider it being Lab 4, only bigger, and comprehensive. You will need to apply most of the concepts that you’ve learned in this course.
Like in Lab 3, you have an option of working alone, or in groups of 2-3 people. Again, the scope depends on the size of your group:

Step 1 is mandatory if you work alone.
Steps 1 and 2 are mandatory if you work in a group of two. 
Steps 1, 2, and 3 are mandatory if you work in a group of three.

It is up to your group how you divide the work between the group members. You are encouraged to collaborate tightly in the design phase, and then you may assign code modules 
(classes, methods) to individual people to code. Alternatively, you may choose to practice “extreme programming” and do peer-coding – it is all up to you. However, keep in
mind to divide the work in equitable manner, so that each person gets a good practice from working on this lab. Make sure to include comments in each piece of code that 
indicate who is responsible for developing it. The grades will be assigned on individual basis, based on contribution of each person (scope), achieved functionality and 
quality of the code.

You will develop a Windows Application that processes payments from various types of customers of the city power company. Customers are billed based on the number of kWh 
of electricity used, and the bill amount calculation rules depend on the type of the customer

Details
=======
Step 1 
------
Create an abstract class Customer that represents a generic customer of the city power company. Being abstract, this class will never be used to create objects, and will 
serve as a base class to derive various customer types. Here are detailed requirements for the Customer class

Customer is an abstract class.
It has private data: name (a  string), and billAmount (decimal or double)
Constructor takes one parameter of type string and initializes name. (There is no need to initialize billAmount as it will automatically be initialized to zero.
There is a  read-write public property for name and read-only public property for billAmount
There is an abstract method CalculateBill() that takes no parameters  and has void return type
Customer also has overridden method ToString() that returns  a string containing both name and pay amount information in reasonable format
Create class Residential that inherits from Customer:
In addition to the inherited data, it has private int data kwh storing the number of kWH used  by the customer
The constructor takes two parameters: a string for the name and an int for the kwh; it calls the base class constructor to set the name, sets kwh to the value of the 
parameter and calls CalculateBill method to set the billAmount
Override method CalculateBill calculates the bill amount, charging initial $6.00 plus $0.052 for each kWhused by the customer
Override method ToString displays all data of the residential customer
The main form class collects data of multiple customers and stores them in a list. Here are the details:
Main form contains a list customers defined for type Customer (the base class)
When user enters name and kWh used, an object of Residential is created and added to the list
A list box on the form displays data of all customers entered so far
Add file processing:
Before the application closes, data of the customers is written into a text file. For each customer, there is an indication the customer type, name, and kwh, for example:
R, Bob Smith, 1000
Since the billAmount can be recalculated, it does not need to be stored
As the form loads, and the text file exists, read data from the file and create initial contents of the list.
Tip: Write data to the file in plain form (no string formatting) as indicated above. Otherwise it will be hard to restore the data.

Step 2
------
Add class Industrial that inherits from Customer.
For an Industrial customer, two kWh values need to be collected: for kWh use during peak hours, and for kWh used during off-peak hours (you will need two kWh text boxes, not one).
The bill amount is calculated as follows:
Flat rate of $76.00 for the first 1000 kWh used during peak hours, and $0.065 for each additional kWh used during peak hours
Flat rate of $40.00 for the first 1000 kWh used during off-peak hours, and $0.028 for each additional kWh used during off-peak hours
The total bill amount is the sum of the bill amount for the peak hours plus that for the off-peak hours
Make sure to provide on the form an option to select customer type, and display appropriate number of input text boxes based on the user’s selection.
Also, when writing to the file, write all relevant data, for example:
R, Bob Smith, 1000
I, ACME Corp, 10000, 15000

Step 3
------
Add class Commercial that inherits from Customer.
For a Customer, similar to Residential, there is no distinction between kWh use during peak hours and off-peak hours (you will need only one kWh text box).
The bill amount is calculated as follows:
Flat rate of $60.00 for the first 1000 kWh used, and $0.045 for each additional kWh used 
Again, make sure display appropriate number of input text boxes based on the user’s selection of customer type.
Also, when writing to the file, write all relevant data, for example:
R, Bob Smith, 1000
I, ACME Corp, 10000, 15000
C, ABC Shop, 7500

Good luck!!

*/


namespace UtilitiesBillingLab4
{
    public partial class Form1 : Form
    {
        // We use a list collection of customer objects.
        // I deliberate name it simply as 'cust' because it is short and easier to type out.
        public List<Customer> cust;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // When the program starts, we initialize a fresh new list for the customers
            cust = new List<Customer>();

            // Load the data into the List, but if there were any errors, clear everything
            if (FileHandler.LoadData(cust) == false)
                cust = new List<Customer>();

            // Display all of the customers into the listbox
            lstCustomers.Items.Clear();
            foreach (Customer c in cust)
                lstCustomers.Items.Add(c.ToString());

            // For user friendliness, we select the Residential radio button as well as place a cursor on the name textbox
            rbResidential.Select();
            txtName.Select();
        }

        private void rbResidential_CheckedChanged(object sender, EventArgs e)
        {
            // When Residential radio button is checked
            // We disable the second KWH entry box and ask the user to enter regular KWH

            // Change the labels
            lblKWH1.Text = "Enter kWh Used:";
            lblKWH2.Text = "";

            // Clear the two KWH entry boxes
            txtKWH1.Text = "";
            txtKWH2.Text = "";

            // Set the tags for the KWH entry boxes
            txtKWH1.Tag = "Enter kWh Used";
            txtKWH2.Tag = "";

            // Enable the first entry box, but disable the second one
            txtKWH1.ReadOnly = false;
            txtKWH2.ReadOnly = true;

            // Provide the Residential description in the rich text box
            rtbCustDesc.Text = Residential.CustomerDescription();
        }

        private void rbIndustrial_CheckedChanged(object sender, EventArgs e)
        {
            // When Industrial radio button is checked
            // We ask that the user enter peak and off-peak hours

            // Change the labels
            lblKWH1.Text = "Peak kWh Used:";
            lblKWH2.Text = "Off-Peak kWh Used:";

            // Clear the two KWH entry boxes
            txtKWH1.Text = "";
            txtKWH2.Text = "";

            // Set the tags for the KWH entry boxes
            txtKWH1.Tag = "Peak kWh Used";
            txtKWH2.Tag = "Off-Peak kWh Used";

            // Enable _BOTH_ entry boxes here
            txtKWH1.ReadOnly = false;
            txtKWH2.ReadOnly = false;

            // Provide the Industrial description in the rich text box
            rtbCustDesc.Text = Industrial.CustomerDescription();
        }

        private void rbCommercial_CheckedChanged(object sender, EventArgs e)
        {
            // When Commercial radio button is checked
            // We disable the second KWH entry box and ask the user to enter regular KWH

            // Change the labels
            lblKWH1.Text = "Enter kWh Used:";
            lblKWH2.Text = "";

            // Clear the two KWH entry boxes
            txtKWH1.Text = "";
            txtKWH2.Text = "";

            // Set the tags for the KWH entry boxes
            txtKWH1.Tag = "Enter kWh Used";
            txtKWH2.Tag = "";

            // Enable the first entry box, but disable the second one
            txtKWH1.ReadOnly = false;
            txtKWH2.ReadOnly = true;

            // Provide the Customer description in the rich text box
            rtbCustDesc.Text = Commercial.CustomerDescription();
        }

        /// <summary>
        /// Method to add or insert customers to the list.
        /// </summary>
        /// <param name="pos">Index position for Customer List</param>
        private void InsertCustomer(int pos)
        {
            int k;              // Basic KWH used
            int o;              // Offpeak KWH used (in case of Industrial customer)
            string n;           // To hold customer name;
            Customer c;         // For new customer to be stored into

            // First, let us validate the data that is supposed to be entered
            if ((Validator.IsPresent(txtName) && Validator.WithinLength(txtName, 20) &&
                 Validator.IsNumberWithinRange(txtKWH1, 0, 999999)) == false)
            {
                // if the data entered cannot be validated, then exit here.
                return;
            }

            // Grab the Customer name and KWH from the form.
            n = txtName.Text;
            k = Int32.Parse(txtKWH1.Text);

            // Check which radio button is selected and create new Customer object accordingly
            if (rbResidential.Checked == true)
                c = new Residential(n, k);

            else if (rbIndustrial.Checked == true)
            {
                // Let's validate the second KWH text box here because we need to grab the second KWH value.
                if (Validator.IsNumberWithinRange(txtKWH2, 0, 999999) == false)
                {
                    // if the data entered cannot be validated, then exit here.
                    return;
                }
                o = Int32.Parse(txtKWH2.Text);
                c = new Industrial(n, k, o);
            }

            else  // Obviously, this is a Commercial customer if neither of the first two radio buttons are clicked
                c = new Commercial(n, k);

            // Calculate the bill for the new customer, then insert customer to List
            c.CalculateBill();
            cust.Insert(pos, c);

            // Display all of the customers into the listbox
            lstCustomers.Items.Clear();
            foreach (Customer d in cust)
                lstCustomers.Items.Add(d.ToString());

            // Clear the Name and the KWH entry boxes and select the Name text box (for convenience)
            txtName.Text = "";
            txtKWH1.Text = "";
            txtKWH2.Text = "";
            txtName.Select();
        }

        private void bthAdd_Click(object sender, EventArgs e)
        {
            // When "Add Customer" button is clicked
            // ...add it to the end of the list

            InsertCustomer(lstCustomers.Items.Count);
        }

        private void btnInsertCustomer_Click(object sender, EventArgs e)
        {
            // When "Insert Customer" button is clicked
            // ... insert it to the position selected in the list

            int i = lstCustomers.SelectedIndex;

            // Only insert a customer if an index is selected, otherwise display an error message
            if(i >= 0)
                InsertCustomer(i);
            else
                MessageBox.Show("Please select a position in the Customer List so you can insert", "Error");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // When "Delete Customer" is clicked
            // ... remove the selected index from the list
            int i = lstCustomers.SelectedIndex;

            // Only delete a customer if an index is selected, otherwise display an error message
            if (i >= 0)
            {
                // Delete the customer at the selected position.
                cust.RemoveAt(i);

                // Display all of the remaining customers in the list box
                lstCustomers.Items.Clear();
                foreach (Customer d in cust)
                    lstCustomers.Items.Add(d.ToString());
            }
            else
                MessageBox.Show("Please select a position in the Customer List so you can delete", "Error");
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            // When the Clear Form button is clicked...
            // Clear the Name and the KWH entry boxes and select the Name text box (for convenience)
            txtName.Text = "";
            txtKWH1.Text = "";
            txtKWH2.Text = "";
            txtName.Select();
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            // When the Clear List button is clicked
            // Clear the cust List and the lstCustomers list box
            cust = new List<Customer>();
            lstCustomers.Items.Clear();
        }

        private void btnExitAndSave_Click(object sender, EventArgs e)
        {
            // When Exit button is pressed, save the data and then close the program.
            // I tried to find sample C# code to detect the form closing via the X button, but it was a bit verbose.
            FileHandler.SaveData(cust);
            this.Close();
        }
    }
}
