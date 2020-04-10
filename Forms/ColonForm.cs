using IssaForms.Db;
using IssaForms.Enum;
using IssaForms.Models;
using IssaForms.Reports;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IssaForms
{
    public partial class ColonForm : Form
    {
        public FormsDbContext _context = new FormsDbContext();

        public ColonForm()
        {
            InitializeComponent();
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

            //ReportDocument cryRpt = new ReportDocument();
            //cryRpt.Load("CrystalReport1.rpt");

            //ParameterFieldDefinitions crParameterFieldDefinitions;
            //ParameterFieldDefinition crParameterFieldDefinition;
            //ParameterValues crParameterValues = new ParameterValues();
            //ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            //crParameterDiscreteValue.Value = Colon.Id;
            //crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            //crParameterFieldDefinition = crParameterFieldDefinitions["Id"];
            //crParameterValues = crParameterFieldDefinition.CurrentValues;

            //crParameterValues.Clear();
            //crParameterValues.Add(crParameterDiscreteValue);
            //crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            CrystalReport1 cr = new CrystalReport1();
            cr.SetParameterValue("@Id", Colon.Id);
            var ForCr = new ReportViewerForm();
            ForCr.crystalReportViewer1.ReportSource = cr;
            ForCr.crystalReportViewer1.Refresh();
            ForCr.Show();
            //ForCr.crystalReportViewer1.ReportSource = cryRpt;
            //ForCr.crystalReportViewer1.Refresh();
            //var cr = new CrystalReport1();
            //cr.Load("CrystalReport1.rpt");
            //var txt1 = cr.ReportDefinition.Sections["Section1"].ReportObjects["Text1"];
            //txt1 = TName;
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
            TAssistant.Text = Interaction.InputBox("Input Assistant");
            TEndoscopist.Text = Interaction.InputBox("Input Endoscopist");
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
    }
}
