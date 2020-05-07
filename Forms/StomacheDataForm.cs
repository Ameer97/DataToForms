using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssaForms
{
    public partial class StomacheDataForm : Form
    {
        public StomacheDataForm()
        {
            InitializeComponent();
        }

        private void StomacheDataForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stomacheDataSet.Stomaches' table. You can move, or remove it, as needed.
            this.stomachesTableAdapter.Fill(this.stomachDataSet.Stomaches);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //var Row = dataGridView1.SelectedCells[0].RowIndex;
            //var Id = dataGridView1.Rows[Row].Cells[0].Value;
            //CrystalReport2 cr = new CrystalReport2();
            //cr.SetParameterValue("@Id", Id);
            //var ForCr = new ReportViewerForm();
            //ForCr.crystalReportViewer1.ReportSource = cr;
            //ForCr.crystalReportViewer1.Refresh();
            //ForCr.Show();
            var Row = dataGridView1.SelectedCells[0].RowIndex;
            var Id = dataGridView1.Rows[Row].Cells[0].Value;
            ReportDocument cr = new ReportDocument();
            cr.Load(@"C:\Users\Ameer\Desktop\github\DataToForms\CrystalReport2.rpt");
            cr.SetParameterValue("@Id", Id);
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\stomach\\" + Id + "-" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second + ".doc";
            cr.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.WordForWindows, path);
            Process.Start(path);
        }
    }
}
