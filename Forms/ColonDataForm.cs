using IssaForms.Reports;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace IssaForms
{
    public partial class ColonDataForm : Form
    {
        public ColonDataForm()
        {
            InitializeComponent();
        }

        private void ColonDataForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'colonDataSet1.Colons' table. You can move, or remove it, as needed.
            this.colonsTableAdapter1.Fill(this.colonDataSet1.Colons);
            // TODO: This line of code loads data into the 'colonDataSet1.Colons' table. You can move, or remove it, as needed.
            this.colonsTableAdapter1.Fill(this.colonDataSet1.Colons);
        }
        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            var Row = dataGridView2.SelectedCells[0].RowIndex;
            var Id = dataGridView2.Rows[Row].Cells[0].Value;
            ColonReport cr = new ColonReport();
            cr.SetParameterValue("@Id", Id);

            CommonFucntions.Preview(Id, cr);
        }
    }
}
