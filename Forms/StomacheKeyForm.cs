using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssaForms.Forms
{
    public partial class StomacheKeyForm : Form
    {
        private TextBox _selectedTextBox;

        private List<string> ColonsShoutCuts = new List<string>
        {
            "lower esophageal erosions (GERD LA class A)",
            "normal",
            "Patent lumen",
            "Lax cardia (Hill grade 1)",
            "Erythematous antral mucosa",
            "Nodular antral mucosa",
            "Anterior wall ucler",
            "Posterior wall ucler",
            "Granular erythematous antral mucosa",
            "Prolapse pastropathy",
            "normal gastric folds",
            "Dyspepsia",
            "Reflux symptoms",
            "Anemia",
            "Weight loss",
            "H.pylori gastritis ?",
            "multiple biopsies taken.",
        };

        public StomacheKeyForm(TextBox colonForm)
        {
            _selectedTextBox = colonForm;
            InitializeComponent();
        }

        void b_Click(object sender, EventArgs e)
        {
            var b = sender as Button;
            if (b != null)
            {
                _selectedTextBox.Text += b.Text;
                _selectedTextBox.Select(_selectedTextBox.Text.Length, 0);
                Close();
            }
        }

        private void StomacheKeyForm_Load(object sender, EventArgs e)
        {
            var rowCount = ColonsShoutCuts.Count;

            this.tableLayoutPanel1.RowCount = rowCount;
            this.tableLayoutPanel1.ColumnCount = 0;

            this.tableLayoutPanel1.ColumnStyles.Clear();
            this.tableLayoutPanel1.RowStyles.Clear();

            for (int i = 0; i < rowCount; i++)
            {
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100 / rowCount));
            }

            for (int i = 0; i < rowCount; i++)
            {
                var b = new Button();
                b.Text = ColonsShoutCuts[i];
                b.Name = string.Format("b_{0}", i + 1);
                b.Click += b_Click;
                b.Dock = DockStyle.Fill;
                this.tableLayoutPanel1.Controls.Add(b);
            }
        }
    }
}
