using System;

namespace IssaForms.Models
{
    public class GeneralInformation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string FileNo { get; set; }
        public DateTime Date { get; set; }
        public string Premedication { get; set; }
        public string Scope { get; set; }
        public string ReferredDoctor { get; set; }
        public string ClinicalData { get; set; }
        public string Conclusion { get; set; }
        public string Assistant { get; set; }
        public string Endoscopist { get; set; }
    }
}
