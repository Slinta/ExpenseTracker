using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using System.IO;

namespace MoneyTrackingSpreadsheetManager {
	class TemplateHandler {
		private ExcelPackage package;
		private string templateWorksheetName = "2018";

		public ExcelWorksheets LoadTemplates() {
			FileInfo templatesFile = new FileInfo(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar +
												  "Templates" + Path.DirectorySeparatorChar + "MTTemplate.xlsx");
			if (!templatesFile.Exists) {
				throw new Exception("Unable to locate 'MTTemplate.xlsx' inside Templates folder. Redownload might be necessary");
			}
			package = new ExcelPackage(templatesFile);
			return package.Workbook.Worksheets;
		}

		public ExcelWorksheet CreateAWorksheetFromTemplate(ExcelWorkbook current, string name) {
			ExcelWorksheets _sheets = LoadTemplates();
			current.Worksheets.Add(name, _sheets[templateWorksheetName]);
			_sheets.Dispose();
			return current.Worksheets[name];
		}
	}
}
