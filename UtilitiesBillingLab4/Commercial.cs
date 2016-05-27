using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesBillingLab4
{
    public class Commercial : Customer
    {
        // Use these constants to determine cost for commercial customers
        // Might be better if these were placed in a .cfg file later on

        const int BASE_CAP = 1000;                      // First 1000 kwh pays a flat rate
        const decimal BASE_AMOUNT = 60.00m;             // First 1000 kwh for commercial KWH is $60.00
        const decimal RATE_KWH = 0.045m;                // Rate per kwh for commercial customers.

        private int kiloWattHours;                      // The amount of kwh used by the commercial customer

        /// <summary>
        /// Create a new Commercial customer object
        /// </summary>
        /// <param name="n">Name for Customer</param>
        /// <param name="k">kiloWattHours used</param>
        public Commercial(string n, int k) : base(n)
        {
            kiloWattHours = k;
        }

        /// <summary>
        /// Calculate the bill total for a Commercial customer
        /// </summary>
        public override void CalculateBill()
        {
            // Commercial customers will always pay the base amount, so we assign the base amount right away as a
            // defacto minimum value to billAmount.
            billAmount = BASE_AMOUNT;

            // if the KWH used exceed the BASE_CAP, then charge the regular rates for these.
            if (kiloWattHours > BASE_CAP)
                billAmount += (kiloWattHours - BASE_CAP) * RATE_KWH;
        }

        /// <summary>
        /// Output the Commercial customer's information into an output string of 100 characters.
        /// </summary>
        /// <returns>Customer information in 100 exact characters</returns>
        public override string ToString()
        {
            const string BLANK = "                         "; // This holds blank spacing for output

            string s = (Name + " (C) " + BLANK).Substring(0, 25)
                        + BLANK
                        + (" KWH USED: " + kiloWattHours.ToString() + BLANK).Substring(0, 25)
                        + (" BILL: " + BillAmount.ToString("c") + BLANK).Substring(0, 25);

            return s;
        }

        /// <summary>
        /// Format a string of the Commercial customer properly set to CSV format.
        /// </summary>
        /// <returns>Single line in CSV format to write to file.</returns>
        public override string SaveOutputString()
        {
            return "C," + Name + ", " + kiloWattHours.ToString();
        }

        /// <summary>
        /// Provide a description for how much Commercial customers pay.
        /// </summary>
        /// <returns></returns>
        public static string CustomerDescription()
        {
            string s = "Commercial customers are charged a flat rate of " +
                        BASE_AMOUNT.ToString("c") + " for the first " + BASE_CAP.ToString() +
                        " kWh used, and $" + RATE_KWH.ToString() + " for each additional kWh used.";
            return s;
        }
    }
}
