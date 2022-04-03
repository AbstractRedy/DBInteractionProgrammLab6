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
    public partial class DeleteForm : Form
    {
        DatabaseInteraction DI;
        public DeleteForm(DatabaseInteraction Form1DI)
        {
            InitializeComponent();
            DI = Form1DI;
            TableCB.Items.AddRange(DI.Tables);
            TableCB.SelectedIndex = 0;
        }

        private void DeleteElement_Click(object sender, EventArgs e)
        {
            string table = TableCB.SelectedItem.ToString();
            string condition = DI.Columns(table)[0] + "=" + IDElementCB.SelectedItem.ToString();
            DI.RemoveFromTable(table, condition);
            IDUpdate(table);
        }
        private void IDUpdate(string table)
        {
            IDElementCB.Items.Clear();
            string[,] elements = DI.ShowElements(table);
            if (elements.GetLength(1) != 0)
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
            IDUpdate(table);
        }
    }
}
