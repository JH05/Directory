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
    class Delete
    {
        /// <summary>
        /// Deletes data in the selected row.
        /// </summary>
        public void deleteMethod(DataGridView dgvPerson)
        {
            dgvPerson.AllowUserToAddRows = false;
            try
            {
                foreach (DataGridViewRow row in dgvPerson.SelectedRows)
                {
                    if (!row.IsNewRow) 
                    {
                        dgvPerson.Rows.Remove(row);
                    }
                    else
                    {
                        MessageBox.Show("You are trying to delete a New Row.", "New Row Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                MessageBox.Show("Deleted Data Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvPerson.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Error: Trying to delete an empty row.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DeletedRowInaccessibleException)
            {
                MessageBox.Show("Error: Delete Row Inaccessible", "Deleted Row Inaccessible", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}