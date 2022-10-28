using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssaForms
{
    public class CommonFucntions
    {
        public static void Preview(object id, ReportClass cr, bool colon = true)
        {
            var directory = colon ? "colon" : "stomache";
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + directory + "\\";
            var file = id + "-" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second + ".pdf";
            var filename = path + file;
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            var ggg = path + file;
            cr.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, ggg);
            Process.Start(filename);
        }
    }
}
