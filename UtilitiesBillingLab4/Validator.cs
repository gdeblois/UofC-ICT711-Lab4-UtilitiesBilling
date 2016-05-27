using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilitiesBillingLab4
{
    public static class Validator
    {
        /// <summary>
        /// Checks if input is present
        /// </summary>
        /// <param name="textBox">Pass textBox</param>
        /// <returns></returns>
        public static bool IsPresent(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(textBox.Tag + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Checks if textbox is less than it's maximum length
        /// </summary>
        /// <param name="textBox">Pass textBox</param>
        /// <param name="length">Maximum length</param>
        /// <returns></returns>
        public static bool WithinLength(TextBox textBox, int length)
        {
            if (textBox.Text.Length >= length)
            {
                MessageBox.Show(textBox.Tag + " must not exceed " + length.ToString() + " characters.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Checks if an input represents a decimal value
        /// </summary>
        /// <param name="textBox">Pass textBox</param>
        /// <returns></returns>
        public static bool IsInteger(TextBox textBox)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be a 32 bit integer.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        /// <summary>
        /// Checks if abstract integer value is within required range
        /// </summary>
        /// <param name="textBox">Pass textBox</param>
        /// <param name="min">Minimum Value</param>
        /// <param name="max">Maximum Value</param>
        /// <returns></returns>
        public static bool IsWithinRange(TextBox textBox, int min, int max)
        {
            int number = Convert.ToInt32(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(textBox.Tag + " must be between " + min
                    + " and " + max + ".", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Checks if a number is entered that is within range
        /// </summary>
        /// <param name="textBox">Pass textBox</param>
        /// <param name="min">Minimum Value</param>
        /// <param name="max">Maximum Value</param>
        /// <returns></returns>
        public static bool IsNumberWithinRange(TextBox textBox, int min, int max)
        {
            if (IsPresent(textBox) && IsInteger(textBox) && IsWithinRange(textBox, min, max))
            {
                return true;
            }
            return false;
        }
    }
}
