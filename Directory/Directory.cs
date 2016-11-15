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
    public partial class Directory : Form
    {
        /// <summary>
        /// Main Class file.
        /// </summary>
        public Directory()
        {   
            InitializeComponent();
        }

        #region Buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.PersonMethod(dgvPerson, txtName, txtTelephoneNumber, txtEmailAddress, txtPostalAddress, txtBirthDate);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {   
            Edit edit = new Edit();
            edit.EditMethod(dgvPerson);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.deleteMethod(dgvPerson);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        { 
            Search search = new Search();
            search.SearchMethod(dgvPerson, cmbSearch, txtSearch);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFile saveFile = new SaveFile();
            saveFile.SaveFileMethod(dgvPerson);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadFile loadFile = new LoadFile();
            loadFile.LoadFileMethod(dgvPerson);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {  
            this.Close();
        }
        #endregion
    }
}
