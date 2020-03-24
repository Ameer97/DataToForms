using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IssaForms.Models;
using IssaForms.Db;
using IssaForms.Enum;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace IssaForms
{
    public partial class Form1 : Form
    {
        public FormsDbContext _context = new FormsDbContext();

        public Form1()
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Colon = new Colon
            {
                Name = TName.Text,
                Age = TAge.Text,
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

        private void button2_Click(object sender, EventArgs e)
        {
            var Stomach = new Stomach
            {
                Name = TName.Text,
                Age = TAge.Text,
                FileNo = TFileNo.Text,
                Date = dateTimePicker1.Value,
                Premedication = TPremedication.Text,
                Scope = CScope.Text,
                ReferredDoctor = TReferredDoctor.Text,
                ClinicalData = TClinicalData.Text,
                GEJ = TGEJ.Text,
                Esophagus = TEsophagus.Text,
                StomachDetails = TStomach.Text,
                D1 = TD1.Text,
                D2 = TD2.Text,
                Conclusion = TConclusion.Text,
                Assistant = TAssistant.Text,
            };
            _context.Stomaches.Add(Stomach);
            _context.SaveChanges();

            CrystalReport2 cr = new CrystalReport2();
            cr.SetParameterValue("@Id", Stomach.Id);
            var ForCr = new ReportViewerForm();
            ForCr.crystalReportViewer1.ReportSource = cr;
            ForCr.crystalReportViewer1.Refresh();
            ForCr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ColonForm = new ColonDataForm();
            ColonForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var StomacheForm = new StomacheDataForm();
            StomacheForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void SpeedStomache_Click(object sender, EventArgs e)
        {

        }

        private void SpeedColon_Click(object sender, EventArgs e)
        {

        }
    }
}
