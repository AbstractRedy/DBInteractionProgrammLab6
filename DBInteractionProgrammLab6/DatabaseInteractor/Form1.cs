using MySql.Data.MySqlClient;
using CFDT;
using System.Text.RegularExpressions;
namespace DatabaseInteractor
{
    public partial class Form1 : Form
    {
        DatabaseInteraction DI;
        string[,] elements;
        public Form1()
        {
            InitializeComponent();
            DI = new DatabaseInteraction("инфосистемабиблгорода", Password);
            TableCB.Items.AddRange(DI.Tables);
            TableCB.SelectedIndex = 0;
        }
        private string Password
        {
            get {return "Zr.200603"; }    //Ваш пароль
        }

        private void ActCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(ActCB.SelectedIndex)
            {
                case 0:
                    Output.Show();
                    ElementLabel.Hide();
                    IDElementCB.Hide();
                    InputGrid.Hide();
                    ItemsUpdate();
                    break;
                case 1:
                    Output.Hide();
                    InputGrid.Show();
                    IDElementCB.Show();
                    ElementLabel.Show();
                    break;
                case 2:
                    Output.Hide();
                    InputGrid.Show();
                    IDElementCB.Show();
                    ElementLabel.Show();
                    break;
                case 3:
                    Output.Hide();
                    InputGrid.Hide();
                    IDElementCB.Show();
                    ElementLabel.Show();
                    break;
            }
        }

        public void ItemsUpdate()
        {
            Output.Columns.Clear();
            Output.Rows.Clear();
            elements = DI.ShowElements(table);
            string[] columns = DI.Columns(table);
            Output.ColumnCount = elements.GetLength(0);
            Output.RowCount = elements.GetLength(1);

            for (int i = 0; i < columns.Length; i++)
                Output.Columns[i].HeaderCell.Value = columns[i];
            for (int i = 0; i < elements.GetLength(1); i++)
                for (int j = 0; j < elements.GetLength(0); j++)
                    Output.Rows[i].Cells[j].Value = elements[j, i];
        }
        private void TableCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string table = TableCB.SelectedItem.ToString();
            IDElementCB.Items.Clear();
            UpdateGrid();
        }
        private void UpdateGrid()
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
        string table { get { return TableCB.SelectedItem.ToString(); ; } }
        private void EditElement()
        {
            string condition = DI.Columns(table)[0] + "=" + IDElementCB.SelectedItem.ToString();
            string update = "";

            string[,] elements = DI.ShowElements(table);
            string[] IDelements = new string[elements.GetLength(1)];

            for (int i = 0; i < IDelements.Length; i++)
                IDelements[i] = DI.ShowElements(table)[0, i].ToString();

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
                ("`" + update.Remove(update.Length - 3))
                , condition);
            UpdateGrid();

        }
        private void AddElement()
        {
            string[] elements = new string[DI.Columns(table).Length - 1];
            for (int i = 0; i < elements.Length; i++)
                elements[i] = InputGrid.Rows[0].Cells[i].Value.ToString();

            string arguments = "'" + String.Join("', '", elements) + "'";
            Regex a = new Regex(@"''");
            DI.AddToTable(table, a.Replace(arguments, @"NULL"));
            UpdateGrid();
        }
        private void DeleteElement()
        {
            string condition = DI.Columns(table)[0] + "=" + IDElementCB.SelectedItem.ToString();
            DI.RemoveFromTable(table, condition);
            IDUpdate();
        }
        private void IDUpdate()
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
        private void button1_Click(object sender, EventArgs e)
        {
            switch (ActCB.SelectedIndex)
            {
                case 0:
                    ItemsUpdate();
                    break;
                case 1:
                    AddElement();
                    break;
                case 2:
                    EditElement();
                    break;
                case 3:
                    DeleteElement();
                    break;
            }
        }
    }
}