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
    class SaveFile
    {
        /// <summary>
        /// Used to save the data in the DataGridView into a text file.
        /// </summary>
        public void SaveFileMethod(DataGridView dgvPerson)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            int value = 0;

            if (saveFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                StreamWriter saveFile = new StreamWriter(saveFileDialog.FileName);
                string stringLine = String.Empty;

                try
                {
                    for (int row = value; row <= dgvPerson.Rows.Count - 1; row++)
                    {
                        for (int cell = value; cell <= dgvPerson.Columns.Count - 1; cell++)
                        {
                            stringLine = stringLine + dgvPerson.Rows[row].Cells[cell].Value;

                            if (cell != dgvPerson.Columns.Count - 1)
                            {
                                stringLine = stringLine + ";";
                            }
                        }
                        saveFile.WriteLine(stringLine);
                        stringLine = String.Empty;
                    }
                    //
                    saveFile.Close();
                    MessageBox.Show("Successfully Saved File", "Save Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (DirectoryNotFoundException)
                {
                    MessageBox.Show("Error: Directory Not Found \nAre you use it is the right directory you are trying to save to?",
                                    "Directory Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (PathTooLongException)
                {
                    MessageBox.Show("Error: Path is too long to save to. Try a shorter path.",
                                    "Path Length Too Long", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Error: Save Error", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
