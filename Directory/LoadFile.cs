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
    /// <summary>
    /// Class file used to load a text file that the user wants.
    /// </summary>
    class LoadFile
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();

        public void LoadFileMethod(DataGridView dgvPerson)
        {
            string stringLine = String.Empty;
            int value = 0;

            if (openFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                try
                {
                    StreamReader loadFile = new StreamReader(openFileDialog.FileName);
                    dgvPerson.AllowUserToAddRows = false;
                    dgvPerson.Rows.Clear();
                    stringLine = loadFile.ReadLine();
                    string[] loadToCell = stringLine.Split(';');

                    while (stringLine != null)
                    {
                        dgvPerson.Rows.Add();

                        for (int cellCount = value; cellCount <= loadToCell.Count() - 1; cellCount++)
                        {
                            loadToCell = stringLine.Split(';');
                            dgvPerson.Rows[dgvPerson.Rows.Count - 1].Cells[cellCount].Value = loadToCell[cellCount].ToString();
                        }
                        stringLine = loadFile.ReadLine();
                    }
                    loadFile.Close();
                    MessageBox.Show("Successfully Loaded File", "Load Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvPerson.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
                catch (PathTooLongException)
                {
                    MessageBox.Show("Error: The Path to the file is too long", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(RowNotInTableException)
                {
                    MessageBox.Show("Error: Invalid Row", "Invalid Row", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Error: There seems to be a load error", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
