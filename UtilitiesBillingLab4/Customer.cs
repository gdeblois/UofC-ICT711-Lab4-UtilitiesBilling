using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesBillingLab4
{
    public abstract class Customer
    {
        private string name;            // Name of Customer
        protected decimal billAmount;   // Bill amount.  I set this to protected because the lab required that this member was read-only from the public accessors.

        /// <summary>
        /// Constructor for base customer class.
        /// </summary>
        /// <param name="n"></param>
        public Customer(string n)
        {
            // All customer child objects have a name as a common denominator.
            name = n;
        }

        /// <summary>
        /// Name read-write accessors
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// BillAmount read-only accessor
        /// </summary>
        public decimal BillAmount
        {
            get { return billAmount; }
        }

        /// <summary>
        /// Abstract method to calculate bill for Customer objects.
        /// </summary>
        public abstract void CalculateBill();

        /// <summary>
        /// Abstract ToString method to format output into 100 exact characters
        /// </summary>
        /// <returns>Customer information in 100 exact characters</returns>
        public override string ToString()
        {
            const string BLANK = "                         "; // This holds blank spacing for output

            string s = (Name + BLANK).Substring(0, 25)
                        + BLANK
                        + BLANK
                        + ("BILL: " + BillAmount.ToString("c") + BLANK).Substring(0, 25);
            return s;
        }

        /// <summary>
        /// Child classes will have an output string that is to be saved in the .txt file
        /// </summary>
        /// <returns>Single line in CSV format to write to file.</returns>
        public abstract string SaveOutputString();

    }
}
