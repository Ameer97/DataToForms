using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            // TODO: This line of code loads data into the 'stomachDataSet.Stomaches' table. You can move, or remove it, as needed.
            this.stomachesTableAdapter.Fill(this.stomachDataSet.Stomaches);
            // TODO: This line of code loads data into the 'stomacheDataSet.Stomaches' table. You can move, or remove it, as needed.
            this.stomachesTableAdapter.Fill(this.stomachDataSet.Stomaches);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            var Row = dataGridView1.SelectedCells[0].RowIndex;
            var Id = dataGridView1.Rows[Row].Cells[0].Value;
            CrystalReport2 cr = new CrystalReport2();
            cr.SetParameterValue("@Id", Id);
            var ForCr = new ReportViewerForm();
            ForCr.crystalReportViewer1.ReportSource = cr;
            ForCr.crystalReportViewer1.Refresh();
            ForCr.Show();
        }
    }
}
