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

namespace DatabaseInteractor
{
    public partial class ElementsForm : Form
    {
        DatabaseInteraction DI;
        string[,] elements;
        public ElementsForm(DatabaseInteraction Form1DI)
        {
            InitializeComponent();
            DI= Form1DI;
            TableCB.Items.AddRange(DI.Tables);
            TableCB.SelectedIndex = 0;
        }
        private void UpdateInfoButton_Click(object sender, EventArgs e)
        {
            Output.Columns.Clear();
            Output.Rows.Clear();
        }
        public void ItemsUpdate()
        {
            string table = TableCB.SelectedItem.ToString();
            Output.Columns.Clear();
            Output.Rows.Clear();
            elements = DI.ShowElements(table);
            string[] columns = DI.Columns(table) ;
            Output.ColumnCount = elements.GetLength(0);
            Output.RowCount = elements.GetLength(1);

            for (int i=0; i<columns.Length;i++)
                Output.Columns[i].HeaderCell.Value = columns[i];
            for (int i =0; i<elements.GetLength(1);i++)
                for(int j=0; j<elements.GetLength(0);j++)
                    Output.Rows[i].Cells[j].Value = elements[j,i];
        }
    }
}
