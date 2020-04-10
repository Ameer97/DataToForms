using IssaForms.Reports;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace IssaForms
{
    public partial class ColonDataForm : Form
    {
        public ColonDataForm()
        {
            InitializeComponent();
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            var Row = dataGridView1.SelectedCells[0].RowIndex;
            var Id = dataGridView1.Rows[Row].Cells[0].Value;
            CrystalReport1 cr = new CrystalReport1();
            cr.SetParameterValue("@Id", Id);
            var ForCr = new ReportViewerForm();
            ForCr.crystalReportViewer1.ReportSource = cr;
            ForCr.crystalReportViewer1.Refresh();
            ForCr.Show();
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
            CrystalReport3 cr = new CrystalReport3();
            cr.SetParameterValue("@Id", Id);
            var ForCr = new ReportViewerForm();
            //ForCr.crystalReportViewer1.ReportSource = cr;
            //ForCr.crystalReportViewer1.Refresh();
            var path = @"colon\" + Id + "-" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second + ".doc";
            cr.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.WordForWindows, path);
            Process.Start(path);

            //ForCr.Show();
        }
    }
}
