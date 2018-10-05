using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OfficeOpenXml;

namespace MoneyTrackingSpreadsheetManager {
	public class MTFileHandler {
		public MTSpreadsheetInteractor interactor { get; internal set; }
		public SpreadsheetInfoContainer infoContainer { get; internal set; }
		internal ExcelWorksheet moneySpreadsheet { get; private set; }
		internal ExcelPackage package;

		public delegate void SaveErrorEventHandler(object sender, Exception exception);
		public event SaveErrorEventHandler SaveError;

		public MTFileHandler(FileInfo fileInfo, string worksheetName) {
			//ExcelPackage ep = new ExcelPackage(new FileInfo(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "lol.xlsx"));
			//ep.Workbook.Worksheets.Add("lol");
			//ep.Workbook.Worksheets["lol"].Cells[1, 1].AddComment("Hello", "Me");
			//ep.Save();


			package = new ExcelPackage(fileInfo);
			ExcelWorkbook workbook = package.Workbook;
			if(workbook.Worksheets[worksheetName] == null) {
				TemplateHandler th = new TemplateHandler();
				moneySpreadsheet = th.CreateAWorksheetFromTemplate(workbook, worksheetName);
				//FileInfo templatesFile = new FileInfo(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar +
				//								  "Templates" + Path.DirectorySeparatorChar + "MTTemplate.xlsx");
				//ExcelPackage copyPackage = new ExcelPackage(templatesFile);

				//moneySpreadsheet = workbook.Worksheets.Add("2018xb", copyPackage.Workbook.Worksheets[1]);
				if (!Directory.Exists(package.File.Directory.FullName)) {
					Directory.CreateDirectory(package.File.Directory.FullName);
				}
				if (!File.Exists(package.File.FullName)) {
					package.SaveAs(package.File);
				}
			}
			else {
				moneySpreadsheet = workbook.Worksheets[worksheetName];
			}

			interactor = new MTSpreadsheetInteractor(moneySpreadsheet, this);
			infoContainer = new SpreadsheetInfoContainer( new FileInfo( Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "MTConfig.txt" ));

		}

		public void Save() {
			try {
				package.Save();
			}
			catch (Exception e){
				OnSaveError(e);
			}
		}

		protected virtual void OnSaveError(Exception e) {
			if(SaveError != null) {
				SaveError(this,e);
			}
		}
	}
}
