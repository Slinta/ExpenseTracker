using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using System.IO;

namespace MoneyTrackingSpreadsheetManager {
	public enum ColumnType {
		Weekday, Date,
		Food, Shool, Country, Transport, Fun, ForSomeone, Loss,
		TAmount, TFrom, TTo,
		EMethod, EAmount,
		WWhere, WTime, WHourlyRate, WPaid,
		MFood, MSchool, MCountry, MTransport, MFun, MSomeone, MLost,
		MEarnAmount
	}


	public class SpreadsheetInfoContainer {

		static internal SpreadsheetInfoContainer instance;

		public ushort dataHeadingLine { get; private set; }
		public ushort dataStartLine { get; private set; }
		public readonly Dictionary<ColumnType, ushort> columnNumbers = new Dictionary<ColumnType, ushort>();
		public readonly Dictionary<string, string> accounts = new Dictionary<string, string>();

		public SpreadsheetInfoContainer(FileInfo configurationFile) {
			StreamReader reader = new StreamReader(configurationFile.ToString());
			ushort lineNum = 0;
			while (!reader.EndOfStream) {
				string line = reader.ReadLine();
				if (line.StartsWith("#")) {
					continue;
				}
				else {
					line = line.Trim();
					lineNum++;
					if (lineNum == 1) {
							dataHeadingLine = ushort.Parse(line);
						}
					else if (lineNum == 2) {
						dataStartLine = ushort.Parse(line);
					}
					else if(lineNum > 2 && lineNum < 29) {
						string letter = line.Split(',')[1].Trim();
						ExcelCellAddress addr = new ExcelCellAddress(letter + dataStartLine);
						ushort column = (ushort)addr.Column;
						columnNumbers.Add((ColumnType)lineNum - 3, column);
					}
					else if(lineNum >= 29) {
						if (line.Trim() == "") {
							continue;
						}
						string accName = line.Split(',')[0].Trim();
						string accIdentifier = line.Split(',')[1].Trim();
						accounts.Add(accName, accIdentifier);
					}
				}
			}
			instance = this;
		}

		public List<string> GetAccounts() {
			return accounts.Keys.ToList<string>();
		}
	}

}
