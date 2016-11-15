#region System Namespace
using System;
using System.Net.Mail;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
#endregion

namespace Directory
{
    class Person
    {
        /// <summary>
        /// Used to send the data to the DataGridView from the text boxes.
        /// </summary>
        public void PersonMethod(DataGridView dgvPerson, TextBox txtName, MaskedTextBox txtTelephoneNumber,
                                 TextBox txtPostalAddress, TextBox txtEmailAddress, MaskedTextBox txtBirthDate)
        {
            string Name;
            string TelephoneNumber;
            string PostalAddress;
            string EmailAddress;
            string BirthDate;

            if (txtName.Text != "" && txtTelephoneNumber.Text != "" && txtPostalAddress.Text != ""
                && txtEmailAddress.Text != "" && txtBirthDate.Text != "")
            {
                try
                {
                    Name = txtName.Text;
                    TelephoneNumber = txtTelephoneNumber.Text;
                    PostalAddress = txtPostalAddress.Text;
                    EmailAddress = txtEmailAddress.Text;
                    BirthDate = txtBirthDate.Text;

                    string[] row = { Name, TelephoneNumber, PostalAddress, EmailAddress, BirthDate };
                    dgvPerson.Rows.Add(row);
                    dgvPerson.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Error: Empty Textbox", "Information Added Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (DeletedRowInaccessibleException)
                {
                    MessageBox.Show("Error: Delete Row Inaccessible", "Deleted Row Inaccessible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(DuplicateNameException)
                {
                    MessageBox.Show("Error: Duplicate Name", "Duplicate Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtName.Clear();
                txtTelephoneNumber.Clear();
                txtPostalAddress.Clear();
                txtEmailAddress.Clear();
                txtBirthDate.Clear();
            }
            else
            {
                MessageBox.Show("Please enter data into all text boxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}