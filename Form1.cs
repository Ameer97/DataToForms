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

namespace IssaForms
{
    public partial class Form1 : Form
    {
        public FormsDbContext _context = new FormsDbContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Colon = new Colon
            {
                Name = TName.Text,
                Age = TAge.Text,
                FileNo = TFileNo.Text,
                Date = Convert.ToDateTime((TDate.Text == "")? DateTime.Now.ToString() : TDate.Text),
                Premedication = TPremedication.Text,
                Scope = TScope.Text,
                Olympus = TOlympus.Text,
                ReferredDoctor = TReferredDoctor.Text,
                Medazolam = TMedazolam.Text,
                Pentax = TPentax.Text,
                Others = TOthers.Text,
                Others1 = TOthers1.Text,
                ClinicalData = TClinicalData.Text,
                Preparation = TPreparation.Text,
                AnalInspection = TAnalInspection.Text,
                PRExam = TPRExam.Text,
                Ileum = TIleum.Text,
                Cecum = TCecum.Text,
                ColonDetails = TColon.Text,
                Sigmoid = TSigmoid.Text,
                RectumRetroflexion = TRectumRetroflexion.Text,
                Conclusion = TConclusion.Text,
                Endoscopist = Convert.ToDateTime((TEndoscopist.Text == "") ? DateTime.Now.ToString() : TEndoscopist.Text),
            };

            _context.Colons.Add(Colon);
            _context.SaveChanges();
            var ForCr = new ColonForm();
            ForCr.Show();
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
                Date = Convert.ToDateTime((TDate.Text == "") ? DateTime.Now.ToString() : TDate.Text),
                Premedication = TPremedication.Text,
                Scope = TScope.Text,
                Olympus = TOlympus.Text,
                ReferredDoctor = TReferredDoctor.Text,
                Medazolam = TMedazolam.Text,
                Pentax = TPentax.Text,
                Others = TOthers.Text,
                Others1 = TOthers1.Text,
                ClinicalData = TClinicalData.Text,
                EsophagusGEJ = TEsophagusGEJ.Text,
                StomachDetails = TStomach.Text,
                DuodenumD1 = TDuodenumD1.Text,
                D2 = TD2.Text,
                Conclusion = TConclusion.Text,
                Endoscopist = Convert.ToDateTime((TEndoscopist.Text == "") ? DateTime.Now.ToString() : TEndoscopist.Text),
            };
            _context.Stomaches.Add(Stomach);
            _context.SaveChanges();
            var ForCr = new StomachForm();
            ForCr.Show();
        }


    }
}
