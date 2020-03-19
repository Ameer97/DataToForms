using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssaForms.Models
{
    public class Stomach : GeneralInformation
    {
        public string EsophagusGEJ { get; set; }
        public string StomachDetails { get; set; }
        public string DuodenumD1 { get; set; }
        public string D2 { get; set; }
    }
}
