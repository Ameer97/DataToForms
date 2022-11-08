using IssaForms.Db;
using IssaForms.Enum;
using IssaForms.Forms;
using IssaForms.Models;
using IssaForms.Reports;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace IssaForms
{
    public partial class ColonForm : Form
    {
        public FormsDbContext _context = new FormsDbContext();

        public ColonForm()
        {
            InitializeComponent();
            TName.Focus();
            var PreparationList = new List<string>()
            {
                Preparation.Good,
                Preparation.Fair,
                Preparation.Bad
            };
            CPreparation.DataSource = PreparationList;

            var ScopeList = new List<string>()
            {
                Scope.Olympus,
                Scope.Pentax,
            };
            CScope.DataSource = ScopeList;

            var GenderList = new List<string>()
            {
                Gender.Male,
                Gender.Female,
            };
            CGender.DataSource = GenderList;
        }


        //private void ColonForm_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.A)
        //        e.SuppressKeyPress = true;
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            var Colon = new Colon
            {
                Name = TName.Text,
                Age = TAge.Text,
                Gender = CGender.Text,
                FileNo = TFileNo.Text,
                Date = dateTimePicker1.Value,
                Premedication = TPremedication.Text,
                Scope = CScope.Text,
                ReferredDoctor = TReferredDoctor.Text,
                ClinicalData = TClinicalData.Text,
                Preparation = CPreparation.Text,
                AnalInspection = TAnalInspection.Text,
                PRExam = TPRExam.Text,
                Ileum = TIleum.Text,
                ColonDetails = TColon.Text,
                Rectum = TRectum.Text,
                Conclusion = TConclusion.Text,
                Assistant = TAssistant.Text,
                Endoscopist = TEndoscopist.Text,
            };

            _context.Colons.Add(Colon);
            _context.SaveChanges();

            ColonReport cr = new ColonReport();
            cr.SetParameterValue("@Id", Colon.Id);

            CommonFucntions.Preview(Colon.Id, cr);
        }



        private void button3_Click(object sender, EventArgs e)
        {
            var ColonForm = new ColonDataForm();
            ColonForm.Show();
        }

        private void SpeedColon_Click(object sender, EventArgs e)
        {
            SpeedAll();
            TAnalInspection.Text = Interaction.InputBox("Input Anal Inspection");
            TPRExam.Text = Interaction.InputBox("Input PRExam");
            TIleum.Text = Interaction.InputBox("Input Ileum");
            TColon.Text = Interaction.InputBox("Input Colon");
            TRectum.Text = Interaction.InputBox("Input Rectum");

            TConclusion.Text = Interaction.InputBox("Input Conclusion");
            TEndoscopist.Text = Interaction.InputBox("Input Endoscopist");
            TAssistant.Text = Interaction.InputBox("Input Assistant");
        }
        void SpeedAll()
        {
            TName.Text = Interaction.InputBox("Input Name");
            TAge.Text = Interaction.InputBox("Input Age");
            TFileNo.Text = Interaction.InputBox("Input File No");
            TPremedication.Text = Interaction.InputBox("Input Premedication");
            TReferredDoctor.Text = Interaction.InputBox("Input Referred Doctor");
            TClinicalData.Text = Interaction.InputBox("Input Clinical Data");
        }

        private void ColonForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                try
                {
                    ColonKeyForm keyForm = new ColonKeyForm((TextBox)ActiveControl);
                    keyForm.Show();
                }
                catch { }
                ////var gg = TName;
                //var g = (TextBox)ActiveControl;
                //g.Paste();
            }
        }
    }
}
