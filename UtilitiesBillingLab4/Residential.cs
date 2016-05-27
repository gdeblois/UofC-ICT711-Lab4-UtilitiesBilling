using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesBillingLab4
{
    public class Residential : Customer
    {
        // Use these constants to determine cost for residential customers
        const decimal BASE_COST = 6.00m;
        const decimal RATE_KWH = 0.052m;

        private int kiloWattHours;            // kilowatt hours used

        /// <summary>
        /// Create a Residential customer object
        /// </summary>
        /// <param name="n">Name of customer</param>
        /// <param name="k">kWh used</param>
        public Residential(string n, int k) : base(n)
        {
            kiloWattHours = k;
        }

        /// <summary>
        /// Calculate the Residential customer's bill
        /// </summary>
        public override void CalculateBill()
        {
            billAmount = BASE_COST + kiloWattHours * RATE_KWH;
        }

        /// <summary>
        /// Output the Residential customer's information into an output string of 100 characters.
        /// </summary>
        /// <returns>Customer information in 100 exact characters</returns>
        public override string ToString()
        {
            const string BLANK = "                         "; // This holds blank spacing for output

            string s =    (Name + " (R) " + BLANK).Substring(0, 25)
                        + BLANK
                        + (" KWH USED: " + kiloWattHours.ToString() + BLANK).Substring(0, 25)
                        + (" BILL: " + BillAmount.ToString("c") + BLANK).Substring(0, 25);
            return s;
        }

        /// <summary>
        /// Format a string of the Residential customer properly set to CSV format.
        /// </summary>
        /// <returns>Single line in CSV format to write to file.</returns>
        public override string SaveOutputString()
        {
            return "R," + Name + ", " + kiloWattHours.ToString();
        }

        /// <summary>
        /// Provide a description for how much Residential customers pay.
        /// </summary>
        /// <returns></returns>
        public static string CustomerDescription()
        {
            string s = "Residential customers are charged " + BASE_COST.ToString("c") + " initially plus $" + RATE_KWH + " for each kWh used.";
            return s;
        }
    }
}
