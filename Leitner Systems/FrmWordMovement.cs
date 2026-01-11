using Leitner_Systems.LeitnerSystemsDataCommon;
using Microsoft.Data.SqlClient;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leitner_Systems
{
    public partial class FrmWordMovement : Form
    {
        public FrmWordMovement()
        {
            InitializeComponent();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            TableWordMovement();
            CountRows();
        }

        private void TableWordMovement()
        {
            SqlDataAdapter da = new SqlDataAdapter($"SELECT * FROM WordMovements", DbConfig.ConnectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, $"WordMovements");
            dataGridViewWordMovement.DataSource = ds.Tables[$"WordMovements"]?.DefaultView;
        }
        private void CountRows()
        {
            int recordCount = dataGridViewWordMovement.RowCount;

            labelLine.Text = $"Lines: {recordCount - 1}"; // -1 because of the header row
        }

        private void buttonSearchWord_Click(object sender, EventArgs e)
        {
            string word = textBoxSearchWord.Text.ToUpper().Trim();

            if (word != string.Empty)
            {
                if (checkBoxEnWord.Checked)
                {
                    dataGridViewWordMovement.Sort(dataGridViewWordMovement.Columns[1], ListSortDirection.Ascending);

                    foreach (DataGridViewRow row in dataGridViewWordMovement.Rows)
                    {
                        if (row.Cells[1].Value != null &&
                            row.Cells[1].Value.ToString()!.Equals(word, StringComparison.OrdinalIgnoreCase))
                        {
                            // Избиране на реда
                            row.Selected = true;

                            // Скролиране до него
                            dataGridViewWordMovement.FirstDisplayedScrollingRowIndex = row.Index;

                            // Ако искаш и курсорът да се позиционира в реда:
                            dataGridViewWordMovement.CurrentCell = row.Cells[0];

                            break;
                        }
                    }
                }
                else if (checkBoxBgWord.Checked)
                {
                    dataGridViewWordMovement.Sort(dataGridViewWordMovement.Columns[2], ListSortDirection.Ascending);

                    foreach (DataGridViewRow row in dataGridViewWordMovement.Rows)
                    {
                        if (row.Cells[2].Value != null &&
                            row.Cells[2].Value.ToString()!.Equals(word, StringComparison.OrdinalIgnoreCase))
                        {
                            // Избиране на реда
                            row.Selected = true;

                            // Скролиране до него
                            dataGridViewWordMovement.FirstDisplayedScrollingRowIndex = row.Index;

                            // Ако искаш и курсорът да се позиционира в реда:
                            dataGridViewWordMovement.CurrentCell = row.Cells[0];

                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a language checkbox (English or Bulgarian).");
                }
            }
        }

        private void checkBoxEnWord_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxBgWord.Checked = false;
        }

        private void checkBoxBgWord_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxEnWord.Checked = false;
        }
    }
}
