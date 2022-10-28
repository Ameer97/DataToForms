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
    public partial class KeyForm : Form
    {
        private TextBox _colonForm;
        private string data = "33 ";

        public KeyForm(TextBox colonForm)
        {
            _colonForm = colonForm;
            InitializeComponent();

            foreach (var item in Controls.OfType<Button>())
            {
                item.Click += CloseForm;
            }
        }

        private void CloseForm(object sender, EventArgs e)
        {
            _colonForm.Text += data;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data = "Hi a";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
