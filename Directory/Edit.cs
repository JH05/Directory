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
    class Edit
    {
        /// <summary>
        /// Where all the editing happens.
        /// </summary>
        public void EditMethod(DataGridView dgvPerson)
        {
            MessageBox.Show("Successfully Entered Edit Mode.\n You can now edit the data in the fields.", "Edit Mode", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvPerson.ReadOnly = false;
            dgvPerson.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
