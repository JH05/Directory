#region System Namespace
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
#endregion

namespace Directory
{
    class Search
    {
        /// <summary>
        /// This is the code for searching.
        /// </summary>
        public void SearchMethod(DataGridView dgvPerson, ComboBox cmbSearch, TextBox txtSearch)
        {
            try
            {
                string search = cmbSearch.SelectedItem.ToString();
                string searchValue = txtSearch.Text;
                search = cmbSearch.Text;
                dgvPerson.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                switch (search)
                {
                    case "Name":
                        foreach (DataGridViewRow row in dgvPerson.Rows)
                        {
                            if (row.Cells[0].Value.ToString().Equals(searchValue))
                            {
                                row.Selected = true;
                                break;
                            }
                        }
                        break;

                    case "Telephone Number":
                        foreach (DataGridViewRow row in dgvPerson.Rows)
                        {
                            if (row.Cells[1].Value.ToString().Equals(searchValue))
                            {
                                row.Selected = true;
                                break;
                            }
                        }
                        break;

                    case "Email Address":
                        foreach (DataGridViewRow row in dgvPerson.Rows)
                        {
                            if (row.Cells[2].Value.ToString().Equals(searchValue))
                            {
                                row.Selected = true;
                                break;
                            }
                        }
                        break;

                    case "Postal Address":
                        foreach (DataGridViewRow row in dgvPerson.Rows)
                        {
                            if (row.Cells[3].Value.ToString().Equals(searchValue))
                            {
                                row.Selected = true;
                                break;
                            }
                        }
                        break;

                    case "Birth Date":
                        foreach (DataGridViewRow row in dgvPerson.Rows)
                        {
                            if (row.Cells[4].Value.ToString().Equals(searchValue))
                            {
                                row.Selected = true;
                                break;
                            }
                        }
                        break;                    
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Error: Invalid Search", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(SyntaxErrorException)
            {
                MessageBox.Show("Error: Wrong Syntax", "Syntax Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Error: Nothing Returned", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}