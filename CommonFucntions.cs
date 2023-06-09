using CrystalDecisions.CrystalReports.Engine;
using OfficeOpenXml;
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
            var file = id + "-" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second + ".doc";
            var filename = path + file;
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            var ggg = path + file;
            cr.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.WordForWindows, ggg);
            Process.Start(filename);
        }




        public static async Task SaveExcel<T>(List<T> dataList, string reportName = "excelFile", string exttension = ".xlsx") where T : new()
        {
            string Path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "__reports");

            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            await Task.Yield();
            if (!Directory.Exists(Path)) Directory.CreateDirectory(Path);

            string excelName = $"/{reportName}-{DateTime.Now:yyyy-MM-dd_HH-mm-ss}{exttension}";
            var filePath = Path + excelName;
            var file = new FileInfo(filePath);

            using (var package = new ExcelPackage(file))
            {
                var workSheet = package.Workbook.Worksheets.Add("Sheet1");
                workSheet.Cells.LoadFromCollection(dataList, true);
                package.Save();
                Process.Start(@"cmd.exe ", @"/c " + filePath);

            }

        }
    }
}
