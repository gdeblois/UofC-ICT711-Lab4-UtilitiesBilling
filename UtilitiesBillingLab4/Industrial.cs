using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesBillingLab4
{
    public class Industrial : Customer
    {
        // Use these constants to determine cost for industrial customers
        // Might be better if these were placed in a .cfg file later on

        const int BASE_CAP = 1000;                  // First 1000 kwh pays a flat rate
        const decimal BASE_PEAK_AMOUNT = 76.00m;        // First 1000 kwh for peak hours is $76.00
        const decimal BASE_OFFPEAK_AMOUNT = 40.00m;     // First 1000 kwh for off-peak hours is $40.00
        const decimal RATE_PEAK = 0.065m;               // Rate per kwh for peak hours after the Base Cap amount
        const decimal RATE_OFFPEAK = 0.028m;            // Rate per kwh for offpeak hours after the Base Cap amount

        private int peakKWH;                            // The amount of peak KWH used
        private int offPeakKWH;                         // The amount of off-peak KWH used

        /// <summary>
        /// Create a new Industrial customer object
        /// </summary>
        /// <param name="n">Name of customer</param>
        /// <param name="p">Peak KWH Used</param>
        /// <param name="o">Off-peak KWH Used</param>
        public Industrial(string n, int p, int o) : base(n)
        {
            peakKWH = p;
            offPeakKWH = o;
        }

        /// <summary>
        /// Calculate the bill amount for an Industrial Customer
        /// </summary>
        public override void CalculateBill()
        {
            // Industrial customers will always pay the base amount, so we assign peak and off-peak billing amounts to these
            // defacto minimum values.
            decimal peakAmount = BASE_PEAK_AMOUNT;
            decimal offPeakAmount = BASE_OFFPEAK_AMOUNT;

            // if the KWH used exceed the BASE_CAP, then charge the regular rates for these.
            if (peakKWH > BASE_CAP)
                peakAmount += (peakKWH - BASE_CAP) * RATE_PEAK;

            if (offPeakKWH > BASE_CAP)
                offPeakAmount += (offPeakKWH - BASE_CAP) * RATE_OFFPEAK;

            billAmount = offPeakAmount + peakAmount;
        }

        /// <summary>
        /// Output the Industrial customer's information into an output string of 100 characters.
        /// </summary>
        /// <returns>Customer information in 100 exact characters</returns>
        public override string ToString()
        {
            const string BLANK = "                         "; // This holds blank spacing for output

            string s = (Name + " (I) " + BLANK).Substring(0, 25)
                        + (" PEAK KWH: " + peakKWH.ToString() + BLANK).Substring(0, 25)
                        + (" OFF-PEAK KWH: " + offPeakKWH.ToString() + BLANK).Substring(0, 25)
                        + (" BILL: " + BillAmount.ToString("c") + BLANK).Substring(0, 25);

            return s;
        }

        /// <summary>
        /// Format a string of the Industrial customer properly set to CSV format.
        /// </summary>
        /// <returns>Single line in CSV format to write to file.</returns>
        public override string SaveOutputString()
        {
            return "I," + Name + ", " + peakKWH.ToString() + ", " + offPeakKWH.ToString();
        }

        /// <summary>
        /// Provide a description for how much Industrial customers pay.
        /// </summary>
        /// <returns></returns>
        public static string CustomerDescription()
        {
            string s = "Industrial customers pay a flat rate of " + BASE_PEAK_AMOUNT.ToString("c") +
                        " for the first " + BASE_CAP + " kWh used during peak hours, and $" +
                        RATE_PEAK.ToString() + " for each additional kWh used during peak hours. " +

                        "There is a flat rate of " + BASE_OFFPEAK_AMOUNT.ToString("c") + " for the first " +
                        BASE_CAP + " used during off-peak hours, and $" +
                        RATE_OFFPEAK.ToString() + " for each additional kWh used during off-peak hours.";
            return s;
        }
    }
}
