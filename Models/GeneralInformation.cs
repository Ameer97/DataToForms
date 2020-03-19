using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssaForms.Models
{
    public class GeneralInformation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string FileNo { get; set; }
        public DateTime Date { get; set; }
        public string Premedication { get; set; }
        public string Scope { get; set; }
        public string Olympus { get; set; }
        public string ReferredDoctor { get; set; }
        public string Medazolam { get; set; }
        public string Pentax { get; set; }
        public string Others { get; set; }
        public string Others1 { get; set; }
        public string ClinicalData { get; set; }
        public string Conclusion { get; set; }
        public DateTime Endoscopist { get; set; }
    }
}
