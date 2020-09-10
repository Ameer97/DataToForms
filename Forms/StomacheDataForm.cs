using IssaForms.Reports;
using System;
using System.Diagnostics;
using System.IO;
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
            CrystalReport4 cr = new CrystalReport4();
            cr.SetParameterValue("@Id", Id);

            var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\stomache\";
            var fileName = Id + "-" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second + ".doc";
            
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            cr.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.WordForWindows, path + fileName);
            Process.Start(path);
        }
    }
}
