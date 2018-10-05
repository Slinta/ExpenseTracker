using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;

namespace MoneyTrackingSpreadsheetManager {
	public enum PurchaseType {
		Food, School, Country, Transport, Fun, ForSomeone, Loss


	}

	public class MTSpreadsheetInteractor {
		ColumnType GetCTFromPT(PurchaseType p) {

			return (ColumnType)((int)p + 2);

		}
		ColumnType GetMCTFromPT(PurchaseType p) {

			return (ColumnType)((int)p + 18);

		}

		MTFileHandler fileHandler;
		ExcelWorksheet worksheet;
		public MTSpreadsheetInteractor(ExcelWorksheet worksheet, MTFileHandler fileHandler) {
			this.worksheet = worksheet;
			this.fileHandler = fileHandler;

		}

		public void AddJobEntry(DateTime date, string where, decimal hourlyRate, decimal time, string comment = "") {
			int row = InfoExtractor.GetLineFromDate(date, worksheet).Value;
			worksheet.Cells[row, SpreadsheetInfoContainer.instance.columnNumbers[ColumnType.WWhere]].Value = where;
			worksheet.Cells[row, SpreadsheetInfoContainer.instance.columnNumbers[ColumnType.WTime]].Value = time;
			worksheet.Cells[row, SpreadsheetInfoContainer.instance.columnNumbers[ColumnType.WHourlyRate]].Value = hourlyRate;
			CommentHandling(comment, new ExcelCellAddress(row, SpreadsheetInfoContainer.instance.columnNumbers[ColumnType.WWhere]));
			fileHandler.Save();
		}
		public void AddPurchase(PurchaseType pType, DateTime date,  decimal value, string account, string comment = "") {
			int row = InfoExtractor.GetLineFromDate(date, worksheet).Value;

			ExcelCellAddress address = new ExcelCellAddress(row, SpreadsheetInfoContainer.instance.columnNumbers[GetCTFromPT(pType)]);
			worksheet.Cells[address.Row, address.Column].Value = value;

			CommentHandling(comment,  address);

			ExcelCellAddress mngmntAddress = new ExcelCellAddress(row, SpreadsheetInfoContainer.instance.columnNumbers[GetMCTFromPT(pType)]);
			worksheet.Cells[mngmntAddress.Row, mngmntAddress.Column].Value = SpreadsheetInfoContainer.instance.accounts[account];

			fileHandler.Save();

		}
		public void AddTransfer(DateTime date, string accountFrom, string accountTo, decimal value, string comment = "") {
			int row = InfoExtractor.GetLineFromDate(date, worksheet).Value;
			CommentHandling(comment, new ExcelCellAddress(row, SpreadsheetInfoContainer.instance.columnNumbers[ColumnType.TAmount]));

			worksheet.Cells[row, SpreadsheetInfoContainer.instance.columnNumbers[ColumnType.TAmount]].Value = value;
			worksheet.Cells[row, SpreadsheetInfoContainer.instance.columnNumbers[ColumnType.TFrom]].Value = SpreadsheetInfoContainer.instance.accounts[accountFrom];
			worksheet.Cells[row, SpreadsheetInfoContainer.instance.columnNumbers[ColumnType.TTo]].Value = SpreadsheetInfoContainer.instance.accounts[accountTo];

			fileHandler.Save();
		}
		public void AddEarn(DateTime date, string account, string method, decimal amount, string comment = "") {
			int row = InfoExtractor.GetLineFromDate(date, worksheet).Value;
			CommentHandling(comment, new ExcelCellAddress(row, SpreadsheetInfoContainer.instance.columnNumbers[ColumnType.EMethod]));
			worksheet.Cells[row, SpreadsheetInfoContainer.instance.columnNumbers[ColumnType.EAmount]].Value = amount;
			worksheet.Cells[row, SpreadsheetInfoContainer.instance.columnNumbers[ColumnType.EMethod]].Value = method;
			ExcelCellAddress mngmntAddress = new ExcelCellAddress(row, SpreadsheetInfoContainer.instance.columnNumbers[ColumnType.MEarnAmount]);
			worksheet.Cells[mngmntAddress.Row, mngmntAddress.Column].Value = SpreadsheetInfoContainer.instance.accounts[account];


			fileHandler.Save();
		}

		void CommentHandling(string commentText, ExcelCellAddress address) {
			if (commentText != "") {
				if (worksheet.Cells[address.Row, address.Column].Comment == null) {
					worksheet.Cells[address.Row, address.Column].AddComment(commentText, "MTSM");
				}
				else {
					ExcelComment comment = worksheet.Cells[address.Row, address.Column].Comment;
					worksheet.Comments.Remove(comment);
					worksheet.Cells[address.Row, address.Column].AddComment(commentText, "MTSM");
				}
			}

		}
	}
}
