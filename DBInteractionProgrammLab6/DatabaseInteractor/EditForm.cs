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
    public partial class EditForm : Form
    {
        DatabaseInteraction DI;
        public EditForm(DatabaseInteraction Form1DI)
        {
            InitializeComponent();
            DI = Form1DI;
            TableCB.Items.AddRange(DI.Tables);
            TableCB.SelectedIndex = 0;
            UpdateGrid(TableCB.SelectedItem.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string table = TableCB.SelectedItem.ToString();
            string condition = DI.Columns(table)[0] +"=" +IDElementCB.SelectedItem.ToString();
            string update="";

            string[,] elements = DI.ShowElements(table);
            string[] IDelements = new string[elements.GetLength(1)];

            for(int i=0; i<IDelements.Length;i++)
                IDelements[i] = DI.ShowElements(table)[0,i].ToString();
            
            string[] columns = DI.Columns(table);

            for (int i = 0; i < DI.Columns(table).Length; i++)
            {
                string gridcell = InputGrid.Rows[0].Cells[i].Value.ToString();
                if (gridcell == "null")
                    update +=
                        columns[i] + "`=NULL, `";
                else if (gridcell != "")
                    update +=
                        columns[i] + "`='" + InputGrid.Rows[0].Cells[i].Value.ToString() + "', `";
            }

            if (update == "")
                return;
            DI.UpdateElement(table,
                ("`"+update.Remove(update.Length-3))
                ,condition);
            UpdateGrid(table);

        }

        private void UpdateGrid(string table)
        {
            string[] columns = DI.Columns(table);
            InputGrid.ColumnCount = columns.GetLength(0);
            InputGrid.RowCount = 1;
            InputGrid.Rows[0].ReadOnly = false;

            for (int i = 0; i < columns.Length; i++)
            {
                InputGrid.Columns[i].HeaderCell.Value = columns[i];
                InputGrid.Rows[0].Cells[i].Value = "";
            }
            IDElementCB.Items.Clear();

            string[,] elements = DI.ShowElements(table);

            if (elements.GetLength(1)!=0)
            {
                string[] elementsID = new string[elements.GetLength(1)];
                for (int i = 0; i < elements.GetLength(1); i++)
                    elementsID[i] = elements[0, i];
                IDElementCB.Items.AddRange(elementsID);
                IDElementCB.SelectedIndex = 0;
                IDElementCB.Enabled = true;
            }
            else
                IDElementCB.Enabled = false;
        }

        private void TableCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string table = TableCB.SelectedItem.ToString();
            IDElementCB.Items.Clear();
            UpdateGrid(table);
        }
    }
}
