using System;
using System.Windows.Forms;

namespace IssaForms.Forms
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ColonForm = new ColonForm();
            ColonForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var StomacheForm = new StomacheForm();
            StomacheForm.Show();
        }
    }
}
