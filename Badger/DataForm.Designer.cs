// // <copyright file = "TestForm3.Designer.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>
//

namespace BudgetExecution
{

    partial class DataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataForm));
            this.SQLiteSelectCommand = new System.Data.SQLite.SQLiteCommand();
            this.SQLiteConnection = new System.Data.SQLite.SQLiteConnection();
            this.SQLiteAdapter = new System.Data.SQLite.SQLiteDataAdapter();
            this.ToolStrip = new BudgetExecution.BudgetToolStrip();
            this.StatusOfFunds = new System.Windows.Forms.BindingSource(this.components);
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BudgetDataSet = new BudgetExecution.Data.DataSets.StatusOfFunds();
            this.DataGrid = new BudgetExecution.BudgetDataGrid();
            this.statusOfFundsIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetLevelDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bFYDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eFYDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rpioCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rpioNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ahCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ahNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fundCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fundNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orgCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orgNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bocCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bocNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programProjectCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programProjectNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programAreaCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programAreaNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rcCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rcNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lowerNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetedDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postedDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openCommitmentsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uLODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expendituresDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obligationsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usedDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.npmCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.npmNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StatusOfFunds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BudgetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SQLiteSelectCommand
            // 
            this.SQLiteSelectCommand.CommandText = "SELECT        *\r\nFROM            StatusOfFunds";
            this.SQLiteSelectCommand.Connection = this.SQLiteConnection;
            this.SQLiteSelectCommand.UpdatedRowSource = System.Data.UpdateRowSource.Both;
            // 
            // SQLiteConnection
            // 
            this.SQLiteConnection.BusyTimeout = 0;
            this.SQLiteConnection.ConnectionString = "Foreign Keys=True;Data Source=C:\\Users\\terry\\source\\repos\\BudgetExecution\\Data\\Da" +
    "tabase\\SQLite\\DataModels\\Data.db";
            this.SQLiteConnection.DefaultDbType = System.Data.DbType.String;
            this.SQLiteConnection.DefaultTimeout = 30;
            this.SQLiteConnection.DefaultTypeName = null;
            this.SQLiteConnection.Flags = System.Data.SQLite.SQLiteConnectionFlags.None;
            this.SQLiteConnection.ParseViaFramework = false;
            this.SQLiteConnection.PrepareRetries = 3;
            this.SQLiteConnection.ProgressOps = 0;
            this.SQLiteConnection.VfsName = null;
            this.SQLiteConnection.WaitTimeout = 30000;
            // 
            // SQLiteAdapter
            // 
            this.SQLiteAdapter.SelectCommand = this.SQLiteSelectCommand;
            this.SQLiteAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Table", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("StatusOfFundsId", "StatusOfFundsId"),
                        new System.Data.Common.DataColumnMapping("BudgetLevel", "BudgetLevel"),
                        new System.Data.Common.DataColumnMapping("BFY", "BFY"),
                        new System.Data.Common.DataColumnMapping("EFY", "EFY"),
                        new System.Data.Common.DataColumnMapping("RpioCode", "RpioCode"),
                        new System.Data.Common.DataColumnMapping("RpioName", "RpioName"),
                        new System.Data.Common.DataColumnMapping("AhCode", "AhCode"),
                        new System.Data.Common.DataColumnMapping("AhName", "AhName"),
                        new System.Data.Common.DataColumnMapping("FundCode", "FundCode"),
                        new System.Data.Common.DataColumnMapping("FundName", "FundName"),
                        new System.Data.Common.DataColumnMapping("OrgCode", "OrgCode"),
                        new System.Data.Common.DataColumnMapping("OrgName", "OrgName"),
                        new System.Data.Common.DataColumnMapping("AccountCode", "AccountCode"),
                        new System.Data.Common.DataColumnMapping("BocCode", "BocCode"),
                        new System.Data.Common.DataColumnMapping("BocName", "BocName"),
                        new System.Data.Common.DataColumnMapping("ProgramProjectCode", "ProgramProjectCode"),
                        new System.Data.Common.DataColumnMapping("ProgramProjectName", "ProgramProjectName"),
                        new System.Data.Common.DataColumnMapping("ProgramAreaCode", "ProgramAreaCode"),
                        new System.Data.Common.DataColumnMapping("ProgramAreaName", "ProgramAreaName"),
                        new System.Data.Common.DataColumnMapping("RcCode", "RcCode"),
                        new System.Data.Common.DataColumnMapping("RcName", "RcName"),
                        new System.Data.Common.DataColumnMapping("LowerName", "LowerName"),
                        new System.Data.Common.DataColumnMapping("Amount", "Amount"),
                        new System.Data.Common.DataColumnMapping("Budgeted", "Budgeted"),
                        new System.Data.Common.DataColumnMapping("Posted", "Posted"),
                        new System.Data.Common.DataColumnMapping("OpenCommitments", "OpenCommitments"),
                        new System.Data.Common.DataColumnMapping("ULO", "ULO"),
                        new System.Data.Common.DataColumnMapping("Expenditures", "Expenditures"),
                        new System.Data.Common.DataColumnMapping("Obligations", "Obligations"),
                        new System.Data.Common.DataColumnMapping("Used", "Used"),
                        new System.Data.Common.DataColumnMapping("Available", "Available"),
                        new System.Data.Common.DataColumnMapping("NpmCode", "NpmCode"),
                        new System.Data.Common.DataColumnMapping("NpmName", "NpmName")})});
            // 
            // ToolStrip
            // 
            this.ToolStrip.AddButton = null;
            this.ToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ToolStrip.BindingSource = this.StatusOfFunds;
            this.ToolStrip.BorderStyle = Syncfusion.Windows.Forms.Tools.ToolStripBorderStyle.StaticEdge;
            this.ToolStrip.BrowseButton = null;
            this.ToolStrip.CalculatorButton = null;
            this.ToolStrip.CanOverrideStyle = true;
            this.ToolStrip.CaptionAlignment = Syncfusion.Windows.Forms.Tools.CaptionAlignment.Near;
            this.ToolStrip.CaptionFont = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStrip.CaptionStyle = Syncfusion.Windows.Forms.Tools.CaptionStyle.Top;
            this.ToolStrip.CaptionTextStyle = Syncfusion.Windows.Forms.Tools.CaptionTextStyle.Plain;
            this.ToolStrip.DataFilter = null;
            this.ToolStrip.DeleteButton = null;
            this.ToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStrip.EditButton = null;
            this.ToolStrip.ExcelButton = null;
            this.ToolStrip.Field = BudgetExecution.Field.RpioActivityCode;
            this.ToolStrip.FirstButton = null;
            this.ToolStrip.Font = new System.Drawing.Font("Roboto", 9F);
            this.ToolStrip.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip.Image = null;
            this.ToolStrip.ImageDirectory = null;
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStrip.ImageSize = new System.Drawing.Size(0, 0);
            this.ToolStrip.LastButton = null;
            this.ToolStrip.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office12;
            this.ToolStrip.Location = new System.Drawing.Point(1, 626);
            this.ToolStrip.Margin = new System.Windows.Forms.Padding(1);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.NextButton = null;
            this.ToolStrip.Numeric = BudgetExecution.Numeric.NS;
            this.ToolStrip.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Blue;
            this.ToolStrip.Padding = new System.Windows.Forms.Padding(1);
            this.ToolStrip.PreviousButton = null;
            this.ToolStrip.PrintButton = null;
            this.ToolStrip.ProgressBar = null;
            this.ToolStrip.RefreshButton = null;
            this.ToolStrip.SaveButton = null;
            this.ToolStrip.Separator1 = null;
            this.ToolStrip.Separator10 = null;
            this.ToolStrip.Separator11 = null;
            this.ToolStrip.Separator12 = null;
            this.ToolStrip.Separator13 = null;
            this.ToolStrip.Separator14 = null;
            this.ToolStrip.Separator15 = null;
            this.ToolStrip.Separator2 = null;
            this.ToolStrip.Separator3 = null;
            this.ToolStrip.Separator4 = null;
            this.ToolStrip.Separator5 = null;
            this.ToolStrip.Separator6 = null;
            this.ToolStrip.Separator7 = null;
            this.ToolStrip.Separator8 = null;
            this.ToolStrip.Separator9 = null;
            this.ToolStrip.ShowCaption = true;
            this.ToolStrip.ShowLauncher = true;
            this.ToolStrip.Size = new System.Drawing.Size(1186, 41);
            this.ToolStrip.TabIndex = 2;
            this.ToolStrip.Text = "budgetToolStrip1";
            this.ToolStrip.ThemeStyle.ArrowColor = System.Drawing.Color.SteelBlue;
            this.ToolStrip.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ToolStrip.ThemeStyle.BottomToolStripBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ToolStrip.ThemeStyle.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ToolStrip.ThemeStyle.CaptionForeColor = System.Drawing.Color.Black;
            this.ToolStrip.ThemeStyle.ComboBoxStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ToolStrip.ThemeStyle.ComboBoxStyle.HoverBorderColor = System.Drawing.Color.SteelBlue;
            this.ToolStrip.ThemeStyle.HoverItemBackColor = System.Drawing.Color.SteelBlue;
            this.ToolStrip.ThemeStyle.HoverItemForeColor = System.Drawing.Color.White;
            this.ToolStrip.ToolStripComboBox = null;
            this.ToolStrip.ToolStripTextBox = null;
            // 
            // StatusOfFunds
            // 
            this.StatusOfFunds.DataMember = "Table";
            this.StatusOfFunds.DataSource = this.BindingSource;
            // 
            // BindingSource
            // 
            this.BindingSource.DataSource = this.BudgetDataSet;
            this.BindingSource.Position = 0;
            // 
            // BudgetDataSet
            // 
            this.BudgetDataSet.DataSetName = "BudgetDataSet";
            this.BudgetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid.AutoGenerateColumns = false;
            this.DataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.DataGrid.BindingSource = null;
            this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.statusOfFundsIdDataGridViewTextBoxColumn1,
            this.budgetLevelDataGridViewTextBoxColumn1,
            this.bFYDataGridViewTextBoxColumn1,
            this.eFYDataGridViewTextBoxColumn1,
            this.rpioCodeDataGridViewTextBoxColumn1,
            this.rpioNameDataGridViewTextBoxColumn1,
            this.ahCodeDataGridViewTextBoxColumn1,
            this.ahNameDataGridViewTextBoxColumn1,
            this.fundCodeDataGridViewTextBoxColumn1,
            this.fundNameDataGridViewTextBoxColumn1,
            this.orgCodeDataGridViewTextBoxColumn1,
            this.orgNameDataGridViewTextBoxColumn1,
            this.accountCodeDataGridViewTextBoxColumn1,
            this.bocCodeDataGridViewTextBoxColumn1,
            this.bocNameDataGridViewTextBoxColumn1,
            this.programProjectCodeDataGridViewTextBoxColumn1,
            this.programProjectNameDataGridViewTextBoxColumn1,
            this.programAreaCodeDataGridViewTextBoxColumn1,
            this.programAreaNameDataGridViewTextBoxColumn1,
            this.rcCodeDataGridViewTextBoxColumn1,
            this.rcNameDataGridViewTextBoxColumn1,
            this.lowerNameDataGridViewTextBoxColumn1,
            this.amountDataGridViewTextBoxColumn1,
            this.budgetedDataGridViewTextBoxColumn1,
            this.postedDataGridViewTextBoxColumn1,
            this.openCommitmentsDataGridViewTextBoxColumn1,
            this.uLODataGridViewTextBoxColumn1,
            this.expendituresDataGridViewTextBoxColumn1,
            this.obligationsDataGridViewTextBoxColumn1,
            this.usedDataGridViewTextBoxColumn1,
            this.availableDataGridViewTextBoxColumn1,
            this.npmCodeDataGridViewTextBoxColumn1,
            this.npmNameDataGridViewTextBoxColumn1});
            this.DataGrid.DataFilter = null;
            this.DataGrid.DataSource = this.StatusOfFunds;
            this.DataGrid.EnableHeadersVisualStyles = false;
            this.DataGrid.Field = BudgetExecution.Field.RpioActivityCode;
            this.DataGrid.Font = new System.Drawing.Font("Roboto", 9F);
            this.DataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(139)))), ((int)(((byte)(138)))));
            this.DataGrid.HoverText = null;
            this.DataGrid.Location = new System.Drawing.Point(52, 89);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Numeric = BudgetExecution.Numeric.NS;
            this.DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid.RowHeadersWidth = 26;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.DataGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid.Size = new System.Drawing.Size(1097, 471);
            this.DataGrid.TabIndex = 4;
            this.DataGrid.ToolTip = null;
            // 
            // statusOfFundsIdDataGridViewTextBoxColumn1
            // 
            this.statusOfFundsIdDataGridViewTextBoxColumn1.DataPropertyName = "StatusOfFundsId";
            this.statusOfFundsIdDataGridViewTextBoxColumn1.HeaderText = "StatusOfFundsId";
            this.statusOfFundsIdDataGridViewTextBoxColumn1.Name = "statusOfFundsIdDataGridViewTextBoxColumn1";
            // 
            // budgetLevelDataGridViewTextBoxColumn1
            // 
            this.budgetLevelDataGridViewTextBoxColumn1.DataPropertyName = "BudgetLevel";
            this.budgetLevelDataGridViewTextBoxColumn1.HeaderText = "BudgetLevel";
            this.budgetLevelDataGridViewTextBoxColumn1.Name = "budgetLevelDataGridViewTextBoxColumn1";
            // 
            // bFYDataGridViewTextBoxColumn1
            // 
            this.bFYDataGridViewTextBoxColumn1.DataPropertyName = "BFY";
            this.bFYDataGridViewTextBoxColumn1.HeaderText = "BFY";
            this.bFYDataGridViewTextBoxColumn1.Name = "bFYDataGridViewTextBoxColumn1";
            // 
            // eFYDataGridViewTextBoxColumn1
            // 
            this.eFYDataGridViewTextBoxColumn1.DataPropertyName = "EFY";
            this.eFYDataGridViewTextBoxColumn1.HeaderText = "EFY";
            this.eFYDataGridViewTextBoxColumn1.Name = "eFYDataGridViewTextBoxColumn1";
            // 
            // rpioCodeDataGridViewTextBoxColumn1
            // 
            this.rpioCodeDataGridViewTextBoxColumn1.DataPropertyName = "RpioCode";
            this.rpioCodeDataGridViewTextBoxColumn1.HeaderText = "RpioCode";
            this.rpioCodeDataGridViewTextBoxColumn1.Name = "rpioCodeDataGridViewTextBoxColumn1";
            // 
            // rpioNameDataGridViewTextBoxColumn1
            // 
            this.rpioNameDataGridViewTextBoxColumn1.DataPropertyName = "RpioName";
            this.rpioNameDataGridViewTextBoxColumn1.HeaderText = "RpioName";
            this.rpioNameDataGridViewTextBoxColumn1.Name = "rpioNameDataGridViewTextBoxColumn1";
            // 
            // ahCodeDataGridViewTextBoxColumn1
            // 
            this.ahCodeDataGridViewTextBoxColumn1.DataPropertyName = "AhCode";
            this.ahCodeDataGridViewTextBoxColumn1.HeaderText = "AhCode";
            this.ahCodeDataGridViewTextBoxColumn1.Name = "ahCodeDataGridViewTextBoxColumn1";
            // 
            // ahNameDataGridViewTextBoxColumn1
            // 
            this.ahNameDataGridViewTextBoxColumn1.DataPropertyName = "AhName";
            this.ahNameDataGridViewTextBoxColumn1.HeaderText = "AhName";
            this.ahNameDataGridViewTextBoxColumn1.Name = "ahNameDataGridViewTextBoxColumn1";
            // 
            // fundCodeDataGridViewTextBoxColumn1
            // 
            this.fundCodeDataGridViewTextBoxColumn1.DataPropertyName = "FundCode";
            this.fundCodeDataGridViewTextBoxColumn1.HeaderText = "FundCode";
            this.fundCodeDataGridViewTextBoxColumn1.Name = "fundCodeDataGridViewTextBoxColumn1";
            // 
            // fundNameDataGridViewTextBoxColumn1
            // 
            this.fundNameDataGridViewTextBoxColumn1.DataPropertyName = "FundName";
            this.fundNameDataGridViewTextBoxColumn1.HeaderText = "FundName";
            this.fundNameDataGridViewTextBoxColumn1.Name = "fundNameDataGridViewTextBoxColumn1";
            // 
            // orgCodeDataGridViewTextBoxColumn1
            // 
            this.orgCodeDataGridViewTextBoxColumn1.DataPropertyName = "OrgCode";
            this.orgCodeDataGridViewTextBoxColumn1.HeaderText = "OrgCode";
            this.orgCodeDataGridViewTextBoxColumn1.Name = "orgCodeDataGridViewTextBoxColumn1";
            // 
            // orgNameDataGridViewTextBoxColumn1
            // 
            this.orgNameDataGridViewTextBoxColumn1.DataPropertyName = "OrgName";
            this.orgNameDataGridViewTextBoxColumn1.HeaderText = "OrgName";
            this.orgNameDataGridViewTextBoxColumn1.Name = "orgNameDataGridViewTextBoxColumn1";
            // 
            // accountCodeDataGridViewTextBoxColumn1
            // 
            this.accountCodeDataGridViewTextBoxColumn1.DataPropertyName = "AccountCode";
            this.accountCodeDataGridViewTextBoxColumn1.HeaderText = "AccountCode";
            this.accountCodeDataGridViewTextBoxColumn1.Name = "accountCodeDataGridViewTextBoxColumn1";
            // 
            // bocCodeDataGridViewTextBoxColumn1
            // 
            this.bocCodeDataGridViewTextBoxColumn1.DataPropertyName = "BocCode";
            this.bocCodeDataGridViewTextBoxColumn1.HeaderText = "BocCode";
            this.bocCodeDataGridViewTextBoxColumn1.Name = "bocCodeDataGridViewTextBoxColumn1";
            // 
            // bocNameDataGridViewTextBoxColumn1
            // 
            this.bocNameDataGridViewTextBoxColumn1.DataPropertyName = "BocName";
            this.bocNameDataGridViewTextBoxColumn1.HeaderText = "BocName";
            this.bocNameDataGridViewTextBoxColumn1.Name = "bocNameDataGridViewTextBoxColumn1";
            // 
            // programProjectCodeDataGridViewTextBoxColumn1
            // 
            this.programProjectCodeDataGridViewTextBoxColumn1.DataPropertyName = "ProgramProjectCode";
            this.programProjectCodeDataGridViewTextBoxColumn1.HeaderText = "ProgramProjectCode";
            this.programProjectCodeDataGridViewTextBoxColumn1.Name = "programProjectCodeDataGridViewTextBoxColumn1";
            // 
            // programProjectNameDataGridViewTextBoxColumn1
            // 
            this.programProjectNameDataGridViewTextBoxColumn1.DataPropertyName = "ProgramProjectName";
            this.programProjectNameDataGridViewTextBoxColumn1.HeaderText = "ProgramProjectName";
            this.programProjectNameDataGridViewTextBoxColumn1.Name = "programProjectNameDataGridViewTextBoxColumn1";
            // 
            // programAreaCodeDataGridViewTextBoxColumn1
            // 
            this.programAreaCodeDataGridViewTextBoxColumn1.DataPropertyName = "ProgramAreaCode";
            this.programAreaCodeDataGridViewTextBoxColumn1.HeaderText = "ProgramAreaCode";
            this.programAreaCodeDataGridViewTextBoxColumn1.Name = "programAreaCodeDataGridViewTextBoxColumn1";
            // 
            // programAreaNameDataGridViewTextBoxColumn1
            // 
            this.programAreaNameDataGridViewTextBoxColumn1.DataPropertyName = "ProgramAreaName";
            this.programAreaNameDataGridViewTextBoxColumn1.HeaderText = "ProgramAreaName";
            this.programAreaNameDataGridViewTextBoxColumn1.Name = "programAreaNameDataGridViewTextBoxColumn1";
            // 
            // rcCodeDataGridViewTextBoxColumn1
            // 
            this.rcCodeDataGridViewTextBoxColumn1.DataPropertyName = "RcCode";
            this.rcCodeDataGridViewTextBoxColumn1.HeaderText = "RcCode";
            this.rcCodeDataGridViewTextBoxColumn1.Name = "rcCodeDataGridViewTextBoxColumn1";
            // 
            // rcNameDataGridViewTextBoxColumn1
            // 
            this.rcNameDataGridViewTextBoxColumn1.DataPropertyName = "RcName";
            this.rcNameDataGridViewTextBoxColumn1.HeaderText = "RcName";
            this.rcNameDataGridViewTextBoxColumn1.Name = "rcNameDataGridViewTextBoxColumn1";
            // 
            // lowerNameDataGridViewTextBoxColumn1
            // 
            this.lowerNameDataGridViewTextBoxColumn1.DataPropertyName = "LowerName";
            this.lowerNameDataGridViewTextBoxColumn1.HeaderText = "LowerName";
            this.lowerNameDataGridViewTextBoxColumn1.Name = "lowerNameDataGridViewTextBoxColumn1";
            // 
            // amountDataGridViewTextBoxColumn1
            // 
            this.amountDataGridViewTextBoxColumn1.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn1.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn1.Name = "amountDataGridViewTextBoxColumn1";
            // 
            // budgetedDataGridViewTextBoxColumn1
            // 
            this.budgetedDataGridViewTextBoxColumn1.DataPropertyName = "Budgeted";
            this.budgetedDataGridViewTextBoxColumn1.HeaderText = "Budgeted";
            this.budgetedDataGridViewTextBoxColumn1.Name = "budgetedDataGridViewTextBoxColumn1";
            // 
            // postedDataGridViewTextBoxColumn1
            // 
            this.postedDataGridViewTextBoxColumn1.DataPropertyName = "Posted";
            this.postedDataGridViewTextBoxColumn1.HeaderText = "Posted";
            this.postedDataGridViewTextBoxColumn1.Name = "postedDataGridViewTextBoxColumn1";
            // 
            // openCommitmentsDataGridViewTextBoxColumn1
            // 
            this.openCommitmentsDataGridViewTextBoxColumn1.DataPropertyName = "OpenCommitments";
            this.openCommitmentsDataGridViewTextBoxColumn1.HeaderText = "OpenCommitments";
            this.openCommitmentsDataGridViewTextBoxColumn1.Name = "openCommitmentsDataGridViewTextBoxColumn1";
            // 
            // uLODataGridViewTextBoxColumn1
            // 
            this.uLODataGridViewTextBoxColumn1.DataPropertyName = "ULO";
            this.uLODataGridViewTextBoxColumn1.HeaderText = "ULO";
            this.uLODataGridViewTextBoxColumn1.Name = "uLODataGridViewTextBoxColumn1";
            // 
            // expendituresDataGridViewTextBoxColumn1
            // 
            this.expendituresDataGridViewTextBoxColumn1.DataPropertyName = "Expenditures";
            this.expendituresDataGridViewTextBoxColumn1.HeaderText = "Expenditures";
            this.expendituresDataGridViewTextBoxColumn1.Name = "expendituresDataGridViewTextBoxColumn1";
            // 
            // obligationsDataGridViewTextBoxColumn1
            // 
            this.obligationsDataGridViewTextBoxColumn1.DataPropertyName = "Obligations";
            this.obligationsDataGridViewTextBoxColumn1.HeaderText = "Obligations";
            this.obligationsDataGridViewTextBoxColumn1.Name = "obligationsDataGridViewTextBoxColumn1";
            // 
            // usedDataGridViewTextBoxColumn1
            // 
            this.usedDataGridViewTextBoxColumn1.DataPropertyName = "Used";
            this.usedDataGridViewTextBoxColumn1.HeaderText = "Used";
            this.usedDataGridViewTextBoxColumn1.Name = "usedDataGridViewTextBoxColumn1";
            // 
            // availableDataGridViewTextBoxColumn1
            // 
            this.availableDataGridViewTextBoxColumn1.DataPropertyName = "Available";
            this.availableDataGridViewTextBoxColumn1.HeaderText = "Available";
            this.availableDataGridViewTextBoxColumn1.Name = "availableDataGridViewTextBoxColumn1";
            // 
            // npmCodeDataGridViewTextBoxColumn1
            // 
            this.npmCodeDataGridViewTextBoxColumn1.DataPropertyName = "NpmCode";
            this.npmCodeDataGridViewTextBoxColumn1.HeaderText = "NpmCode";
            this.npmCodeDataGridViewTextBoxColumn1.Name = "npmCodeDataGridViewTextBoxColumn1";
            // 
            // npmNameDataGridViewTextBoxColumn1
            // 
            this.npmNameDataGridViewTextBoxColumn1.DataPropertyName = "NpmName";
            this.npmNameDataGridViewTextBoxColumn1.HeaderText = "NpmName";
            this.npmNameDataGridViewTextBoxColumn1.Name = "npmNameDataGridViewTextBoxColumn1";
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.CaptionButtonColor = System.Drawing.Color.DimGray;
            this.CaptionFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(1188, 668);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.ToolStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DataForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Budget Execution";
            ((System.ComponentModel.ISupportInitialize)(this.StatusOfFunds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BudgetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Data.SQLite.SQLiteCommand SQLiteSelectCommand;
        private BudgetToolStrip ToolStrip;
        private System.Windows.Forms.BindingSource StatusOfFunds;
        private System.Windows.Forms.BindingSource BindingSource;
        public Data.DataSets.StatusOfFunds BudgetDataSet;
        private BudgetDataGrid DataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusOfFundsIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetLevelDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bFYDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eFYDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rpioCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rpioNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ahCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ahNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fundCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fundNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orgCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orgNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bocCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bocNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn programProjectCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn programProjectNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn programAreaCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn programAreaNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rcCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rcNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lowerNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetedDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn postedDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn openCommitmentsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn uLODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn expendituresDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn obligationsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usedDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn npmCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn npmNameDataGridViewTextBoxColumn1;
        private System.Data.SQLite.SQLiteDataAdapter SQLiteAdapter;
        private System.Data.SQLite.SQLiteConnection SQLiteConnection;
    }
}