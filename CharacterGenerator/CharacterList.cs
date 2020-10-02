using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CharacterLib;

namespace CharacterGenerator
{
    public partial class CharacterList : Form
    {
        DataTable characterTable;
        Dbase database;
        public CharacterList(string connectionString)
        {
            InitializeComponent();
            database = new Dbase(connectionString);
            characterTable = database.Fetch();
            dataGridView1.DataSource = characterTable;
            string[] editableColumns = {"name"};
            SetEditableColumns(dataGridView1, editableColumns);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void SetEditableColumns(DataGridView dgv, string[] columnNames)
        {
            for(int i = 0; i < dgv.Columns.Count; i++)
            {
                dgv.Columns[i].ReadOnly = !columnNames.Contains(dgv.Columns[i].Name);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var plural = dataGridView1.SelectedRows.Count > 1;
            var messageBoxText = $"Delete {(plural ? "these" : "this")} character{(plural ? "s" : "")}?";
            if (MessageBox.Show(messageBoxText, "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    int characterId = (int) (dataGridView1.SelectedRows[i].Cells["id"].Value);
                    database.DeleteById((int) dataGridView1.SelectedRows[i].Cells["id"].Value);
                }
                foreach(DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(row.Index);
                }
                dataGridView1.ClearSelection();

            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        { 
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var characterId = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            var fieldName = dataGridView1.Columns[e.ColumnIndex].HeaderText;
            var fieldValue = (string)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            database.UpdateField(characterId, fieldName, fieldValue);
        }
    }
}
