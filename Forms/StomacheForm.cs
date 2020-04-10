using IssaForms.Db;
using IssaForms.Enum;
using IssaForms.Models;
using IssaForms.Reports;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IssaForms.Forms
{
    public partial class StomacheForm : Form
    {
        public FormsDbContext _context = new FormsDbContext();
        public StomacheForm()
        {
            InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)
        {
            var Stomach = new Stomach
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
                GEJ = TGEJ.Text,
                Esophagus = TEsophagus.Text,
                StomachDetails = TStomach.Text,
                D1 = TD1.Text,
                D2 = TD2.Text,
                Conclusion = TConclusion.Text,
                Assistant = TAssistant.Text,
                Endoscopist = TEndoscopist.Text,
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

        private void SpeedStomache_Click(object sender, EventArgs e)
        {
            SpeedAll();
            TGEJ.Text = Interaction.InputBox("Input GEJ");
            TEsophagus.Text = Interaction.InputBox("Input Esophagus");
            TStomach.Text = Interaction.InputBox("Input Stomach");
            TD1.Text = Interaction.InputBox("Input D1");
            TD2.Text = Interaction.InputBox("Input D2");

            TConclusion.Text = Interaction.InputBox("Input Conclusion");
            TEndoscopist.Text = Interaction.InputBox("Input Endoscopist");
            TAssistant.Text = Interaction.InputBox("Input Assistant");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var StomacheDataForm = new StomacheDataForm();
            StomacheDataForm.Show();
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
