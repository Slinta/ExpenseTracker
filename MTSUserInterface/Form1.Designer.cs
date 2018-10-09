namespace MTSUserInterface {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.PConfirmB = new System.Windows.Forms.Button();
			this.SelectFileButton = new System.Windows.Forms.Button();
			this.openXlsxFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.panel1 = new System.Windows.Forms.Panel();
			this.PPriceNUD = new System.Windows.Forms.NumericUpDown();
			this.PDateC = new System.Windows.Forms.MonthCalendar();
			this.PCommentLabel = new System.Windows.Forms.Label();
			this.PAccountLabel = new System.Windows.Forms.Label();
			this.PAmountLabel = new System.Windows.Forms.Label();
			this.PTypeLabel = new System.Windows.Forms.Label();
			this.PAccountCB = new System.Windows.Forms.ComboBox();
			this.PTypeCB = new System.Windows.Forms.ComboBox();
			this.PCommentRTB = new System.Windows.Forms.RichTextBox();
			this.PTitleL = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.TAmountNUD = new System.Windows.Forms.NumericUpDown();
			this.TCalendar = new System.Windows.Forms.MonthCalendar();
			this.TCommentLabel = new System.Windows.Forms.Label();
			this.TToLabel = new System.Windows.Forms.Label();
			this.TAmountLabel = new System.Windows.Forms.Label();
			this.TFromLabel = new System.Windows.Forms.Label();
			this.TToCB = new System.Windows.Forms.ComboBox();
			this.TFromCB = new System.Windows.Forms.ComboBox();
			this.TCommentRTB = new System.Windows.Forms.RichTextBox();
			this.TTitleL = new System.Windows.Forms.Label();
			this.TConfirmB = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.EAmountNUD = new System.Windows.Forms.NumericUpDown();
			this.EDescriptionTB = new System.Windows.Forms.TextBox();
			this.ECalendar = new System.Windows.Forms.MonthCalendar();
			this.ECommentLabel = new System.Windows.Forms.Label();
			this.EDescriptionL = new System.Windows.Forms.Label();
			this.EAmountL = new System.Windows.Forms.Label();
			this.EAccountL = new System.Windows.Forms.Label();
			this.EAccountCB = new System.Windows.Forms.ComboBox();
			this.ECommentRTB = new System.Windows.Forms.RichTextBox();
			this.ETitleL = new System.Windows.Forms.Label();
			this.EConfirmB = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.WHourlyRateL = new System.Windows.Forms.Label();
			this.WHourlyRateNUD = new System.Windows.Forms.NumericUpDown();
			this.WHoursNUD = new System.Windows.Forms.NumericUpDown();
			this.WLabelTB = new System.Windows.Forms.TextBox();
			this.WCalendar = new System.Windows.Forms.MonthCalendar();
			this.WCommentL = new System.Windows.Forms.Label();
			this.WLabelL = new System.Windows.Forms.Label();
			this.WHoursL = new System.Windows.Forms.Label();
			this.WCommentRTB = new System.Windows.Forms.RichTextBox();
			this.WTitleL = new System.Windows.Forms.Label();
			this.WConfirmB = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PPriceNUD)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TAmountNUD)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.EAmountNUD)).BeginInit();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.WHourlyRateNUD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WHoursNUD)).BeginInit();
			this.SuspendLayout();
			// 
			// PConfirmB
			// 
			this.PConfirmB.Enabled = false;
			this.PConfirmB.Location = new System.Drawing.Point(700, 161);
			this.PConfirmB.Name = "PConfirmB";
			this.PConfirmB.Size = new System.Drawing.Size(75, 23);
			this.PConfirmB.TabIndex = 0;
			this.PConfirmB.Text = "Confirm";
			this.PConfirmB.UseVisualStyleBackColor = true;
			this.PConfirmB.Click += new System.EventHandler(this.PConfirmB_Click);
			// 
			// SelectFileButton
			// 
			this.SelectFileButton.Location = new System.Drawing.Point(12, 12);
			this.SelectFileButton.Name = "SelectFileButton";
			this.SelectFileButton.Size = new System.Drawing.Size(75, 23);
			this.SelectFileButton.TabIndex = 1;
			this.SelectFileButton.Text = "Select file";
			this.SelectFileButton.UseVisualStyleBackColor = true;
			this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
			// 
			// openXlsxFileDialog
			// 
			this.openXlsxFileDialog.DefaultExt = "xlsx";
			this.openXlsxFileDialog.FileName = "openFileDialog1";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel1.Controls.Add(this.PPriceNUD);
			this.panel1.Controls.Add(this.PDateC);
			this.panel1.Controls.Add(this.PCommentLabel);
			this.panel1.Controls.Add(this.PAccountLabel);
			this.panel1.Controls.Add(this.PAmountLabel);
			this.panel1.Controls.Add(this.PTypeLabel);
			this.panel1.Controls.Add(this.PAccountCB);
			this.panel1.Controls.Add(this.PTypeCB);
			this.panel1.Controls.Add(this.PCommentRTB);
			this.panel1.Controls.Add(this.PTitleL);
			this.panel1.Controls.Add(this.PConfirmB);
			this.panel1.Location = new System.Drawing.Point(12, 41);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(781, 190);
			this.panel1.TabIndex = 2;
			// 
			// PPriceNUD
			// 
			this.PPriceNUD.DecimalPlaces = 2;
			this.PPriceNUD.Location = new System.Drawing.Point(282, 95);
			this.PPriceNUD.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			this.PPriceNUD.Name = "PPriceNUD";
			this.PPriceNUD.Size = new System.Drawing.Size(120, 20);
			this.PPriceNUD.TabIndex = 11;
			// 
			// PDateC
			// 
			this.PDateC.Location = new System.Drawing.Point(6, 22);
			this.PDateC.MaxSelectionCount = 1;
			this.PDateC.Name = "PDateC";
			this.PDateC.TabIndex = 10;
			// 
			// PCommentLabel
			// 
			this.PCommentLabel.AutoSize = true;
			this.PCommentLabel.Location = new System.Drawing.Point(435, 22);
			this.PCommentLabel.Name = "PCommentLabel";
			this.PCommentLabel.Size = new System.Drawing.Size(51, 13);
			this.PCommentLabel.TabIndex = 9;
			this.PCommentLabel.Text = "Comment";
			// 
			// PAccountLabel
			// 
			this.PAccountLabel.AutoSize = true;
			this.PAccountLabel.Location = new System.Drawing.Point(282, 118);
			this.PAccountLabel.Name = "PAccountLabel";
			this.PAccountLabel.Size = new System.Drawing.Size(47, 13);
			this.PAccountLabel.TabIndex = 8;
			this.PAccountLabel.Text = "Account";
			// 
			// PAmountLabel
			// 
			this.PAmountLabel.AutoSize = true;
			this.PAmountLabel.Location = new System.Drawing.Point(282, 79);
			this.PAmountLabel.Name = "PAmountLabel";
			this.PAmountLabel.Size = new System.Drawing.Size(31, 13);
			this.PAmountLabel.TabIndex = 7;
			this.PAmountLabel.Text = "Price";
			// 
			// PTypeLabel
			// 
			this.PTypeLabel.AutoSize = true;
			this.PTypeLabel.Location = new System.Drawing.Point(282, 39);
			this.PTypeLabel.Name = "PTypeLabel";
			this.PTypeLabel.Size = new System.Drawing.Size(75, 13);
			this.PTypeLabel.TabIndex = 6;
			this.PTypeLabel.Text = "Purchase type";
			// 
			// PAccountCB
			// 
			this.PAccountCB.FormattingEnabled = true;
			this.PAccountCB.Location = new System.Drawing.Point(282, 134);
			this.PAccountCB.Name = "PAccountCB";
			this.PAccountCB.Size = new System.Drawing.Size(121, 21);
			this.PAccountCB.TabIndex = 4;
			// 
			// PTypeCB
			// 
			this.PTypeCB.FormattingEnabled = true;
			this.PTypeCB.Location = new System.Drawing.Point(285, 55);
			this.PTypeCB.Name = "PTypeCB";
			this.PTypeCB.Size = new System.Drawing.Size(121, 21);
			this.PTypeCB.TabIndex = 3;
			// 
			// PCommentRTB
			// 
			this.PCommentRTB.Location = new System.Drawing.Point(432, 38);
			this.PCommentRTB.Name = "PCommentRTB";
			this.PCommentRTB.Size = new System.Drawing.Size(262, 138);
			this.PCommentRTB.TabIndex = 2;
			this.PCommentRTB.Text = "";
			// 
			// PTitleL
			// 
			this.PTitleL.AutoSize = true;
			this.PTitleL.Location = new System.Drawing.Point(3, 0);
			this.PTitleL.Name = "PTitleL";
			this.PTitleL.Size = new System.Drawing.Size(160, 13);
			this.PTitleL.TabIndex = 1;
			this.PTitleL.Text = "Add a purchase with this formula";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel2.Controls.Add(this.TAmountNUD);
			this.panel2.Controls.Add(this.TCalendar);
			this.panel2.Controls.Add(this.TCommentLabel);
			this.panel2.Controls.Add(this.TToLabel);
			this.panel2.Controls.Add(this.TAmountLabel);
			this.panel2.Controls.Add(this.TFromLabel);
			this.panel2.Controls.Add(this.TToCB);
			this.panel2.Controls.Add(this.TFromCB);
			this.panel2.Controls.Add(this.TCommentRTB);
			this.panel2.Controls.Add(this.TTitleL);
			this.panel2.Controls.Add(this.TConfirmB);
			this.panel2.Location = new System.Drawing.Point(12, 237);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(781, 190);
			this.panel2.TabIndex = 11;
			// 
			// TAmountNUD
			// 
			this.TAmountNUD.DecimalPlaces = 2;
			this.TAmountNUD.Location = new System.Drawing.Point(283, 161);
			this.TAmountNUD.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			this.TAmountNUD.Name = "TAmountNUD";
			this.TAmountNUD.Size = new System.Drawing.Size(120, 20);
			this.TAmountNUD.TabIndex = 12;
			// 
			// TCalendar
			// 
			this.TCalendar.Location = new System.Drawing.Point(6, 25);
			this.TCalendar.MaxSelectionCount = 1;
			this.TCalendar.Name = "TCalendar";
			this.TCalendar.TabIndex = 10;
			// 
			// TCommentLabel
			// 
			this.TCommentLabel.AutoSize = true;
			this.TCommentLabel.Location = new System.Drawing.Point(435, 22);
			this.TCommentLabel.Name = "TCommentLabel";
			this.TCommentLabel.Size = new System.Drawing.Size(51, 13);
			this.TCommentLabel.TabIndex = 9;
			this.TCommentLabel.Text = "Comment";
			// 
			// TToLabel
			// 
			this.TToLabel.AutoSize = true;
			this.TToLabel.Location = new System.Drawing.Point(280, 67);
			this.TToLabel.Name = "TToLabel";
			this.TToLabel.Size = new System.Drawing.Size(59, 13);
			this.TToLabel.TabIndex = 8;
			this.TToLabel.Text = "Account to";
			// 
			// TAmountLabel
			// 
			this.TAmountLabel.AutoSize = true;
			this.TAmountLabel.Location = new System.Drawing.Point(280, 146);
			this.TAmountLabel.Name = "TAmountLabel";
			this.TAmountLabel.Size = new System.Drawing.Size(43, 13);
			this.TAmountLabel.TabIndex = 7;
			this.TAmountLabel.Text = "Amount";
			// 
			// TFromLabel
			// 
			this.TFromLabel.AutoSize = true;
			this.TFromLabel.Location = new System.Drawing.Point(277, 27);
			this.TFromLabel.Name = "TFromLabel";
			this.TFromLabel.Size = new System.Drawing.Size(70, 13);
			this.TFromLabel.TabIndex = 6;
			this.TFromLabel.Text = "Account from";
			// 
			// TToCB
			// 
			this.TToCB.FormattingEnabled = true;
			this.TToCB.Location = new System.Drawing.Point(280, 83);
			this.TToCB.Name = "TToCB";
			this.TToCB.Size = new System.Drawing.Size(121, 21);
			this.TToCB.TabIndex = 4;
			// 
			// TFromCB
			// 
			this.TFromCB.FormattingEnabled = true;
			this.TFromCB.Location = new System.Drawing.Point(280, 43);
			this.TFromCB.Name = "TFromCB";
			this.TFromCB.Size = new System.Drawing.Size(121, 21);
			this.TFromCB.TabIndex = 3;
			// 
			// TCommentRTB
			// 
			this.TCommentRTB.Location = new System.Drawing.Point(432, 38);
			this.TCommentRTB.Name = "TCommentRTB";
			this.TCommentRTB.Size = new System.Drawing.Size(262, 138);
			this.TCommentRTB.TabIndex = 2;
			this.TCommentRTB.Text = "";
			// 
			// TTitleL
			// 
			this.TTitleL.AutoSize = true;
			this.TTitleL.Location = new System.Drawing.Point(3, 0);
			this.TTitleL.Name = "TTitleL";
			this.TTitleL.Size = new System.Drawing.Size(151, 13);
			this.TTitleL.TabIndex = 1;
			this.TTitleL.Text = "Add a transfer with this formula";
			// 
			// TConfirmB
			// 
			this.TConfirmB.Enabled = false;
			this.TConfirmB.Location = new System.Drawing.Point(703, 161);
			this.TConfirmB.Name = "TConfirmB";
			this.TConfirmB.Size = new System.Drawing.Size(75, 23);
			this.TConfirmB.TabIndex = 0;
			this.TConfirmB.Text = "Confirm";
			this.TConfirmB.UseVisualStyleBackColor = true;
			this.TConfirmB.Click += new System.EventHandler(this.TConfirmB_Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel3.Controls.Add(this.EAmountNUD);
			this.panel3.Controls.Add(this.EDescriptionTB);
			this.panel3.Controls.Add(this.ECalendar);
			this.panel3.Controls.Add(this.ECommentLabel);
			this.panel3.Controls.Add(this.EDescriptionL);
			this.panel3.Controls.Add(this.EAmountL);
			this.panel3.Controls.Add(this.EAccountL);
			this.panel3.Controls.Add(this.EAccountCB);
			this.panel3.Controls.Add(this.ECommentRTB);
			this.panel3.Controls.Add(this.ETitleL);
			this.panel3.Controls.Add(this.EConfirmB);
			this.panel3.Location = new System.Drawing.Point(9, 433);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(784, 190);
			this.panel3.TabIndex = 12;
			// 
			// EAmountNUD
			// 
			this.EAmountNUD.DecimalPlaces = 2;
			this.EAmountNUD.Location = new System.Drawing.Point(289, 142);
			this.EAmountNUD.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			this.EAmountNUD.Name = "EAmountNUD";
			this.EAmountNUD.Size = new System.Drawing.Size(120, 20);
			this.EAmountNUD.TabIndex = 13;
			// 
			// EDescriptionTB
			// 
			this.EDescriptionTB.Location = new System.Drawing.Point(288, 103);
			this.EDescriptionTB.Name = "EDescriptionTB";
			this.EDescriptionTB.Size = new System.Drawing.Size(100, 20);
			this.EDescriptionTB.TabIndex = 11;
			// 
			// ECalendar
			// 
			this.ECalendar.Location = new System.Drawing.Point(9, 22);
			this.ECalendar.MaxSelectionCount = 1;
			this.ECalendar.Name = "ECalendar";
			this.ECalendar.TabIndex = 10;
			// 
			// ECommentLabel
			// 
			this.ECommentLabel.AutoSize = true;
			this.ECommentLabel.Location = new System.Drawing.Point(438, 22);
			this.ECommentLabel.Name = "ECommentLabel";
			this.ECommentLabel.Size = new System.Drawing.Size(51, 13);
			this.ECommentLabel.TabIndex = 9;
			this.ECommentLabel.Text = "Comment";
			// 
			// EDescriptionL
			// 
			this.EDescriptionL.AutoSize = true;
			this.EDescriptionL.Location = new System.Drawing.Point(288, 87);
			this.EDescriptionL.Name = "EDescriptionL";
			this.EDescriptionL.Size = new System.Drawing.Size(33, 13);
			this.EDescriptionL.TabIndex = 8;
			this.EDescriptionL.Text = "Label";
			// 
			// EAmountL
			// 
			this.EAmountL.AutoSize = true;
			this.EAmountL.Location = new System.Drawing.Point(291, 126);
			this.EAmountL.Name = "EAmountL";
			this.EAmountL.Size = new System.Drawing.Size(43, 13);
			this.EAmountL.TabIndex = 7;
			this.EAmountL.Text = "Amount";
			// 
			// EAccountL
			// 
			this.EAccountL.AutoSize = true;
			this.EAccountL.Location = new System.Drawing.Point(291, 47);
			this.EAccountL.Name = "EAccountL";
			this.EAccountL.Size = new System.Drawing.Size(47, 13);
			this.EAccountL.TabIndex = 6;
			this.EAccountL.Text = "Account";
			// 
			// EAccountCB
			// 
			this.EAccountCB.FormattingEnabled = true;
			this.EAccountCB.Location = new System.Drawing.Point(288, 63);
			this.EAccountCB.Name = "EAccountCB";
			this.EAccountCB.Size = new System.Drawing.Size(121, 21);
			this.EAccountCB.TabIndex = 3;
			// 
			// ECommentRTB
			// 
			this.ECommentRTB.Location = new System.Drawing.Point(435, 38);
			this.ECommentRTB.Name = "ECommentRTB";
			this.ECommentRTB.Size = new System.Drawing.Size(262, 138);
			this.ECommentRTB.TabIndex = 2;
			this.ECommentRTB.Text = "";
			// 
			// ETitleL
			// 
			this.ETitleL.AutoSize = true;
			this.ETitleL.Location = new System.Drawing.Point(3, 0);
			this.ETitleL.Name = "ETitleL";
			this.ETitleL.Size = new System.Drawing.Size(157, 13);
			this.ETitleL.TabIndex = 1;
			this.ETitleL.Text = "Add an earning with this formula";
			// 
			// EConfirmB
			// 
			this.EConfirmB.Enabled = false;
			this.EConfirmB.Location = new System.Drawing.Point(706, 161);
			this.EConfirmB.Name = "EConfirmB";
			this.EConfirmB.Size = new System.Drawing.Size(75, 23);
			this.EConfirmB.TabIndex = 0;
			this.EConfirmB.Text = "Confirm";
			this.EConfirmB.UseVisualStyleBackColor = true;
			this.EConfirmB.Click += new System.EventHandler(this.EConfirmB_Click);
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel4.Controls.Add(this.WHourlyRateL);
			this.panel4.Controls.Add(this.WHourlyRateNUD);
			this.panel4.Controls.Add(this.WHoursNUD);
			this.panel4.Controls.Add(this.WLabelTB);
			this.panel4.Controls.Add(this.WCalendar);
			this.panel4.Controls.Add(this.WCommentL);
			this.panel4.Controls.Add(this.WLabelL);
			this.panel4.Controls.Add(this.WHoursL);
			this.panel4.Controls.Add(this.WCommentRTB);
			this.panel4.Controls.Add(this.WTitleL);
			this.panel4.Controls.Add(this.WConfirmB);
			this.panel4.Location = new System.Drawing.Point(9, 629);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(784, 190);
			this.panel4.TabIndex = 13;
			// 
			// WHourlyRateL
			// 
			this.WHourlyRateL.AutoSize = true;
			this.WHourlyRateL.Location = new System.Drawing.Point(286, 86);
			this.WHourlyRateL.Name = "WHourlyRateL";
			this.WHourlyRateL.Size = new System.Drawing.Size(60, 13);
			this.WHourlyRateL.TabIndex = 16;
			this.WHourlyRateL.Text = "HourlyRate";
			// 
			// WHourlyRateNUD
			// 
			this.WHourlyRateNUD.Location = new System.Drawing.Point(288, 102);
			this.WHourlyRateNUD.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			this.WHourlyRateNUD.Name = "WHourlyRateNUD";
			this.WHourlyRateNUD.Size = new System.Drawing.Size(120, 20);
			this.WHourlyRateNUD.TabIndex = 14;
			this.WHourlyRateNUD.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// WHoursNUD
			// 
			this.WHoursNUD.DecimalPlaces = 2;
			this.WHoursNUD.Location = new System.Drawing.Point(288, 153);
			this.WHoursNUD.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
			this.WHoursNUD.Name = "WHoursNUD";
			this.WHoursNUD.Size = new System.Drawing.Size(120, 20);
			this.WHoursNUD.TabIndex = 13;
			// 
			// WLabelTB
			// 
			this.WLabelTB.Location = new System.Drawing.Point(288, 46);
			this.WLabelTB.Name = "WLabelTB";
			this.WLabelTB.Size = new System.Drawing.Size(100, 20);
			this.WLabelTB.TabIndex = 11;
			// 
			// WCalendar
			// 
			this.WCalendar.Location = new System.Drawing.Point(9, 18);
			this.WCalendar.MaxSelectionCount = 1;
			this.WCalendar.Name = "WCalendar";
			this.WCalendar.TabIndex = 10;
			// 
			// WCommentL
			// 
			this.WCommentL.AutoSize = true;
			this.WCommentL.Location = new System.Drawing.Point(438, 30);
			this.WCommentL.Name = "WCommentL";
			this.WCommentL.Size = new System.Drawing.Size(51, 13);
			this.WCommentL.TabIndex = 9;
			this.WCommentL.Text = "Comment";
			// 
			// WLabelL
			// 
			this.WLabelL.AutoSize = true;
			this.WLabelL.Location = new System.Drawing.Point(285, 30);
			this.WLabelL.Name = "WLabelL";
			this.WLabelL.Size = new System.Drawing.Size(33, 13);
			this.WLabelL.TabIndex = 8;
			this.WLabelL.Text = "Label";
			// 
			// WHoursL
			// 
			this.WHoursL.AutoSize = true;
			this.WHoursL.Location = new System.Drawing.Point(286, 137);
			this.WHoursL.Name = "WHoursL";
			this.WHoursL.Size = new System.Drawing.Size(35, 13);
			this.WHoursL.TabIndex = 7;
			this.WHoursL.Text = "Hours";
			// 
			// WCommentRTB
			// 
			this.WCommentRTB.Location = new System.Drawing.Point(435, 46);
			this.WCommentRTB.Name = "WCommentRTB";
			this.WCommentRTB.Size = new System.Drawing.Size(262, 138);
			this.WCommentRTB.TabIndex = 2;
			this.WCommentRTB.Text = "";
			// 
			// WTitleL
			// 
			this.WTitleL.AutoSize = true;
			this.WTitleL.Location = new System.Drawing.Point(3, 0);
			this.WTitleL.Name = "WTitleL";
			this.WTitleL.Size = new System.Drawing.Size(156, 13);
			this.WTitleL.TabIndex = 1;
			this.WTitleL.Text = "Add a job entry with this formula";
			// 
			// WConfirmB
			// 
			this.WConfirmB.Enabled = false;
			this.WConfirmB.Location = new System.Drawing.Point(703, 161);
			this.WConfirmB.Name = "WConfirmB";
			this.WConfirmB.Size = new System.Drawing.Size(75, 23);
			this.WConfirmB.TabIndex = 0;
			this.WConfirmB.Text = "Confirm";
			this.WConfirmB.UseVisualStyleBackColor = true;
			this.WConfirmB.Click += new System.EventHandler(this.WConfirmB_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(802, 827);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.SelectFileButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PPriceNUD)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.TAmountNUD)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.EAmountNUD)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.WHourlyRateNUD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WHoursNUD)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button PConfirmB;
		private System.Windows.Forms.Button SelectFileButton;
		private System.Windows.Forms.OpenFileDialog openXlsxFileDialog;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label PTitleL;
		private System.Windows.Forms.Label PCommentLabel;
		private System.Windows.Forms.Label PAccountLabel;
		private System.Windows.Forms.Label PAmountLabel;
		private System.Windows.Forms.Label PTypeLabel;
		private System.Windows.Forms.ComboBox PAccountCB;
		private System.Windows.Forms.ComboBox PTypeCB;
		private System.Windows.Forms.RichTextBox PCommentRTB;
		private System.Windows.Forms.MonthCalendar PDateC;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.MonthCalendar TCalendar;
		private System.Windows.Forms.Label TCommentLabel;
		private System.Windows.Forms.Label TToLabel;
		private System.Windows.Forms.Label TAmountLabel;
		private System.Windows.Forms.Label TFromLabel;
		private System.Windows.Forms.ComboBox TToCB;
		private System.Windows.Forms.ComboBox TFromCB;
		private System.Windows.Forms.RichTextBox TCommentRTB;
		private System.Windows.Forms.Label TTitleL;
		private System.Windows.Forms.Button TConfirmB;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.MonthCalendar ECalendar;
		private System.Windows.Forms.Label ECommentLabel;
		private System.Windows.Forms.Label EDescriptionL;
		private System.Windows.Forms.Label EAmountL;
		private System.Windows.Forms.Label EAccountL;
		private System.Windows.Forms.ComboBox EAccountCB;
		private System.Windows.Forms.RichTextBox ECommentRTB;
		private System.Windows.Forms.Label ETitleL;
		private System.Windows.Forms.Button EConfirmB;
		private System.Windows.Forms.TextBox EDescriptionTB;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TextBox WLabelTB;
		private System.Windows.Forms.MonthCalendar WCalendar;
		private System.Windows.Forms.Label WCommentL;
		private System.Windows.Forms.Label WLabelL;
		private System.Windows.Forms.Label WHoursL;
		private System.Windows.Forms.RichTextBox WCommentRTB;
		private System.Windows.Forms.Label WTitleL;
		private System.Windows.Forms.Button WConfirmB;
		private System.Windows.Forms.NumericUpDown PPriceNUD;
		private System.Windows.Forms.NumericUpDown TAmountNUD;
		private System.Windows.Forms.NumericUpDown EAmountNUD;
		private System.Windows.Forms.NumericUpDown WHoursNUD;
		private System.Windows.Forms.Label WHourlyRateL;
		private System.Windows.Forms.NumericUpDown WHourlyRateNUD;
	}
}

