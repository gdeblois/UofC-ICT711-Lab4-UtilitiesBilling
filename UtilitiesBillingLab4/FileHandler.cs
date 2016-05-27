using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;            // needed for file processing

namespace UtilitiesBillingLab4
{
    public static class FileHandler
    {
        // I put the file handling routines into a separate static class so that the routines
        // can be placed in another file and make the main program body less cluttered.
        // This can also be used as a template for file handling for future applications as well.

        // The save file is located in bin/Debug
        const string savePath = "customers.txt";

        /// <summary>
        /// Load data from the file to the arrays; returns boolean flag that indicates success
        /// </summary>
        /// <param name="cust">The customer list is passed.</param>
        /// <returns>Whether the file was read successfully or not.</returns>
        public static bool LoadData(List<Customer> cust)
        {
            // The following code was borrowed from an example that was demonstrated in Lecture #1 of ICT-711 (with some modifications)
            FileStream fs;
            StreamReader sr;                               // for file reading
            string line;                                   // one line from the file
            string[] parts;                                // line will be split into multiple parts
            Customer c;                                    // Customer object

            try
            {
                // open the file
                fs = new FileStream(savePath, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);

            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            // file opened successfully
            // read all lines, storing data in the cust List

            try
            {
                while (!sr.EndOfStream)
                {

                    line = sr.ReadLine();           // read next line
                    parts = line.Split(',');        // split the line into parts using comma as delimiter

                    switch (parts[0])               // Verify the first item in the line, which determines the type of customer
                    {
                        // This is a Residential customer, and we read the next 2 items in the line to
                        // create the object, calculate it's bill and add it to the Customer List.
                        case "R":
                            c = new Residential(parts[1], Int32.Parse(parts[2]));
                            c.CalculateBill();
                            cust.Add(c);
                            break;

                        // This is an Industrial customer, and we read the next 3 items in the line to
                        // create the object, calculate it's bill and add it to the Customer List.
                        case "I":
                            c = new Industrial(parts[1], Int32.Parse(parts[2]), Int32.Parse(parts[3]));
                            c.CalculateBill();
                            cust.Add(c);
                            break;

                        // This is a Commercial customer, and we read the next 2 items in the line to
                        // create the object, calculate it's bill and add it to the Customer List.
                        case "C":
                            c = new Commercial(parts[1], Int32.Parse(parts[2]));
                            c.CalculateBill();
                            cust.Add(c);
                            break;

                        // If we get here, then obviously the line that was read is invalid, so we do nothing.
                        default:
                            break;
                    }
                }
                // If we get here, then the file was read successfully.
                sr.Close();
                return true;
            }

            // Catch any exceptions to the attempts at file reading above.
            catch (IOException ex)
            {
                MessageBox.Show("I/O error occurred while reading from the file: " +
                            ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unanticipated error occurred while reading from the  file: " +
                            ex.Message);
                return false;
            }
            finally
            {
                sr.Close();
            }
        }

        /// <summary>
        /// Save the Customer List to a file.
        /// </summary>
        /// <param name="cust">The Customer List is passed</param>
        public static void SaveData(List<Customer> cust)
        {
            // I used a filestream to write to the file, borrowing a little bit from LoadData() above.
            FileStream fs;
            StreamWriter sw;                               // for file writing

            try
            {
                // open the file with FileMode.Create -- basically to overwrite the existing file.
                fs = new FileStream(savePath, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);

            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            // File is successfully open, now write the output to the text file
            try
            {
                // Iterate through the customer list and send it to StreamWriter
                // Each customer object has this method to format data to output to the .txt file
                foreach (Customer c in cust)
                    sw.WriteLine(c.SaveOutputString());

                // If we get here, the file was written successfully.
                sw.Close();
                return;
            }

            // The obligatory catch statements are here.
            catch (IOException ex)
            {
                MessageBox.Show("I/O error occurred while writing to the file: " +
                            ex.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unanticipated error occurred while writing to the file: " +
                            ex.Message);
                return;
            }
            finally
            {
                sw.Close();
            }
        }
    }
}
