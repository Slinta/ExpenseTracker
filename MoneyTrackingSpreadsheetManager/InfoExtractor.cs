using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;

namespace MoneyTrackingSpreadsheetManager {
	class InfoExtractor {
		public static ushort? GetLineFromDate(DateTime date, ExcelWorksheet sheet) {

			ushort column = SpreadsheetInfoContainer.instance.columnNumbers[ColumnType.Date];

			ushort startRow = SpreadsheetInfoContainer.instance.dataStartLine;
			DateTime beginingOfSpreadsheet = GetDate(sheet, startRow, column);
			TimeSpan daysBetween = date - beginingOfSpreadsheet;

			if (daysBetween.Days < 0) {
				return null;
			}

			ushort theoreticalRow = (ushort)(startRow + (ushort)daysBetween.Days);
			if (GetDate(sheet, theoreticalRow, column) == date) {
				return theoreticalRow;
			}

			return null;
		}

		static internal DateTime GetDate(ExcelWorksheet sheet, int row, int column) {
			if (DateTime.TryParse(sheet.GetValue(row, column).ToString(), out DateTime result)) {
				return result;
			}
			else {
				try {
					return DateTime.FromOADate(sheet.GetValue<double>(row, column));
				}
				catch {
					throw new Exception("Couldn't parse date");
				}
			}
		}
	}
}
