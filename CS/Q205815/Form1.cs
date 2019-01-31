using System;
using System.Data;
using System.Windows.Forms;

namespace Q205815
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myGridControl1.DataSource = GetPersonDataTable();

        }
        DataTable GetPersonDataTable()
        {
            DataTable table = new DataTable();
            table.TableName = "Persons";
            table.Columns.Add(new DataColumn("FirstName", typeof(string)));
            table.Columns.Add(new DataColumn("SecondName", typeof(string)));
            table.Columns.Add(new DataColumn("Age", typeof(int)));
            table.Columns.Add(new DataColumn("ID", typeof(int)));
            for (int i = 0; i < 150; i++)
                table.Rows.Add("FirstName " + i, "SecondName " + i, 20 + i / 15, i);
            return table;
        }
        private void OnShowPrintPreviewSimpleButtonClick(object sender, EventArgs e)
        {
            myGridControl1.ShowPrintPreview();
        }
    }
}