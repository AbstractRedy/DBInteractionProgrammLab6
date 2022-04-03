using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CFDT;
using System.Text.RegularExpressions;

namespace DatabaseInteractor
{
    public partial class AddForm : Form
    {
        DatabaseInteraction DI;
        public AddForm(DatabaseInteraction Form1DI)
        {
            InitializeComponent();
            DI = Form1DI;
            TableCB.Items.AddRange(DI.Tables);
            TableCB.SelectedIndex = 0;
            UpdateGrid(TableCB.SelectedItem.ToString());
        }

        private void AEButton_Click(object sender, EventArgs e)
        {
            string table = TableCB.SelectedItem.ToString();
            string[] elements = new string[DI.Columns(table).Length-1];
            for (int i = 0; i < elements.Length; i++)
                elements[i] = InputGrid.Rows[0].Cells[i].Value.ToString();
            
            string arguments = "'"+String.Join("', '", elements)+"'";
            Regex a = new Regex(@"''");
            DI.AddToTable(table, a.Replace(arguments, @"NULL"));
            UpdateGrid(table);
        }

        private void TableCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            InputGrid.Rows.Clear();
            UpdateGrid(TableCB.SelectedItem.ToString());
        }
        private void UpdateGrid(string table)
        {
            string[] columns = DI.Columns(table);
            InputGrid.ColumnCount = columns.GetLength(0)-1;
            InputGrid.RowCount = 1;
            InputGrid.Rows[0].ReadOnly = false;
            for (int i = 1; i < columns.Length; i++)
            { 
                InputGrid.Columns[i-1].HeaderCell.Value = columns[i];
                InputGrid.Rows[0].Cells[i-1].Value = "";
            }
        }
    }
}
