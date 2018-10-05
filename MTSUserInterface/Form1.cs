using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoneyTrackingSpreadsheetManager;
using System.IO;

namespace MTSUserInterface {
	public partial class Form1 : Form {
		MTFileHandler mtFileHandler = null;
		string worksheetName = "2018";
		public Form1() {
			InitializeComponent();
			if (File.Exists(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "config.cfg")) {
				StreamReader s = new StreamReader(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "config.cfg");
				string path = s.ReadLine();
				InitialiseMTFileHandler(path, worksheetName);
			}
			

			
		}

		
		private void OnSaveError(object sender, Exception exception) {
			if (MessageBox.Show("Can't save the xlsx file, perhaps it's already open? \r " + exception.Data, "Save error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Retry) {
				mtFileHandler.Save();
			}
			else {
				return;
			}
		}

		private void SelectFileButton_Click(object sender, EventArgs e) {
			openXlsxFileDialog = new OpenFileDialog();
			openXlsxFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
			if (openXlsxFileDialog.ShowDialog() == DialogResult.OK) {
				FileInfo cfgFile = new FileInfo(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "config.cfg");
				if (File.Exists(cfgFile.ToString())) {
					File.Delete(cfgFile.ToString());

				}
				FileStream stream = File.Create(cfgFile.ToString());
				StreamWriter sw = new StreamWriter(stream);
				sw.WriteLine(openXlsxFileDialog.FileName);
				sw.Dispose();


				InitialiseMTFileHandler(openXlsxFileDialog.FileName, worksheetName);

			}
		}

		private void PConfirmB_Click(object sender, EventArgs e) {
			mtFileHandler.interactor.AddPurchase((PurchaseType)Enum.Parse(typeof(PurchaseType), PTypeCB.Text), PDateC.SelectionRange.Start, PPriceNUD.Value, PAccountCB.Text, PCommentRTB.Text);
			
		}

		private void TConfirmB_Click(object sender, EventArgs e) {
			mtFileHandler.interactor.AddTransfer(TCalendar.SelectionStart, TFromCB.Text, TToCB.Text, TAmountNUD.Value, TCommentRTB.Text);
		}

		private void EConfirmB_Click(object sender, EventArgs e) {
			mtFileHandler.interactor.AddEarn(ECalendar.SelectionStart, EAccountCB.Text ,EDescriptionTB.Text, EAmountNUD.Value, ECommentRTB.Text);
		}

		private void WConfirmB_Click(object sender, EventArgs e) {
			mtFileHandler.interactor.AddJobEntry(WCalendar.SelectionStart, WLabelTB.Text, WHourlyRateNUD.Value, WHoursNUD.Value, WCommentRTB.Text);
		}

		void InitialiseMTFileHandler(string path, string worksheetName) {
			mtFileHandler = new MTFileHandler(new FileInfo(path), worksheetName);
			string[] accounts = mtFileHandler.infoContainer.accounts.Keys.ToArray<string>();
			PAccountCB.Items.AddRange(accounts);
			TToCB.Items.AddRange(accounts);
			TFromCB.Items.AddRange(accounts);
			EAccountCB.Items.AddRange(accounts);


			string[] array = Enum.GetNames(typeof(PurchaseType));
			foreach (string p in array) {
				PTypeCB.Items.Add(p);
			}

			PConfirmB.Enabled = true;
			TConfirmB.Enabled = true;
			EConfirmB.Enabled = true;
			WConfirmB.Enabled = true;

			mtFileHandler.SaveError += OnSaveError;
		}
	}
}
