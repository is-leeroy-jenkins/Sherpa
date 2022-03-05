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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataForm));
            this.ToolStrip = new BudgetExecution.BudgetToolStrip();
            this.SQLiteSelectCommand = new System.Data.SQLite.SQLiteCommand();
            this.SQLiteConnection = new System.Data.SQLite.SQLiteConnection();
            this.SQLiteAdapter = new System.Data.SQLite.SQLiteDataAdapter();
            this.DataSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet = new BudgetExecution.StatusOfFunds();
            this.DataGrid = new BudgetExecution.BudgetDataGrid();
            this.statusOfFundsIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bFYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eFYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rpioCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rpioNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ahCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ahNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fundCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fundNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orgCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orgNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bocCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bocNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programProjectCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programProjectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programAreaCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programAreaNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rcCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rcNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lowerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openCommitmentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uLODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expendituresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obligationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.npmCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.npmNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolStrip
            // 
            this.ToolStrip.AddButton = null;
            this.ToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ToolStrip.BindingSource = null;
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
            this.ToolStrip.Location = new System.Drawing.Point(1, 589);
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
            this.ToolStrip.ShowCaption = false;
            this.ToolStrip.ShowLauncher = true;
            this.ToolStrip.Size = new System.Drawing.Size(1056, 27);
            this.ToolStrip.TabIndex = 0;
            this.ToolStrip.Text = "Budget Execution";
            this.ToolStrip.ThemeName = "Default";
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
            // DataSource
            // 
            this.DataSource.DataMember = "Table";
            this.DataSource.DataSource = this.DataSet;
            // 
            // DataSet
            // 
            this.DataSet.DataSetName = "StatusOfFunds";
            this.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToOrderColumns = true;
            this.DataGrid.AutoGenerateColumns = false;
            this.DataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.DataGrid.BindingSource = null;
            this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.statusOfFundsIdDataGridViewTextBoxColumn,
            this.budgetLevelDataGridViewTextBoxColumn,
            this.bFYDataGridViewTextBoxColumn,
            this.eFYDataGridViewTextBoxColumn,
            this.rpioCodeDataGridViewTextBoxColumn,
            this.rpioNameDataGridViewTextBoxColumn,
            this.ahCodeDataGridViewTextBoxColumn,
            this.ahNameDataGridViewTextBoxColumn,
            this.fundCodeDataGridViewTextBoxColumn,
            this.fundNameDataGridViewTextBoxColumn,
            this.orgCodeDataGridViewTextBoxColumn,
            this.orgNameDataGridViewTextBoxColumn,
            this.accountCodeDataGridViewTextBoxColumn,
            this.bocCodeDataGridViewTextBoxColumn,
            this.bocNameDataGridViewTextBoxColumn,
            this.programProjectCodeDataGridViewTextBoxColumn,
            this.programProjectNameDataGridViewTextBoxColumn,
            this.programAreaCodeDataGridViewTextBoxColumn,
            this.programAreaNameDataGridViewTextBoxColumn,
            this.rcCodeDataGridViewTextBoxColumn,
            this.rcNameDataGridViewTextBoxColumn,
            this.lowerNameDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.budgetedDataGridViewTextBoxColumn,
            this.postedDataGridViewTextBoxColumn,
            this.openCommitmentsDataGridViewTextBoxColumn,
            this.uLODataGridViewTextBoxColumn,
            this.expendituresDataGridViewTextBoxColumn,
            this.obligationsDataGridViewTextBoxColumn,
            this.usedDataGridViewTextBoxColumn,
            this.availableDataGridViewTextBoxColumn,
            this.npmCodeDataGridViewTextBoxColumn,
            this.npmNameDataGridViewTextBoxColumn});
            this.DataGrid.DataFilter = null;
            this.DataGrid.DataSource = this.DataSource;
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataGrid.EnableHeadersVisualStyles = false;
            this.DataGrid.Field = BudgetExecution.Field.RpioActivityCode;
            this.DataGrid.Font = new System.Drawing.Font("Roboto", 9F);
            this.DataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(139)))), ((int)(((byte)(138)))));
            this.DataGrid.HoverText = null;
            this.DataGrid.Location = new System.Drawing.Point(1, 33);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Numeric = BudgetExecution.Numeric.NS;
            this.DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid.RowHeadersWidth = 26;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid.Size = new System.Drawing.Size(1056, 556);
            this.DataGrid.TabIndex = 1;
            this.DataGrid.ToolTip = null;
            // 
            // statusOfFundsIdDataGridViewTextBoxColumn
            // 
            this.statusOfFundsIdDataGridViewTextBoxColumn.DataPropertyName = "StatusOfFundsId";
            this.statusOfFundsIdDataGridViewTextBoxColumn.HeaderText = "StatusOfFundsId";
            this.statusOfFundsIdDataGridViewTextBoxColumn.Name = "statusOfFundsIdDataGridViewTextBoxColumn";
            // 
            // budgetLevelDataGridViewTextBoxColumn
            // 
            this.budgetLevelDataGridViewTextBoxColumn.DataPropertyName = "BudgetLevel";
            this.budgetLevelDataGridViewTextBoxColumn.HeaderText = "BudgetLevel";
            this.budgetLevelDataGridViewTextBoxColumn.Name = "budgetLevelDataGridViewTextBoxColumn";
            // 
            // bFYDataGridViewTextBoxColumn
            // 
            this.bFYDataGridViewTextBoxColumn.DataPropertyName = "BFY";
            this.bFYDataGridViewTextBoxColumn.HeaderText = "BFY";
            this.bFYDataGridViewTextBoxColumn.Name = "bFYDataGridViewTextBoxColumn";
            // 
            // eFYDataGridViewTextBoxColumn
            // 
            this.eFYDataGridViewTextBoxColumn.DataPropertyName = "EFY";
            this.eFYDataGridViewTextBoxColumn.HeaderText = "EFY";
            this.eFYDataGridViewTextBoxColumn.Name = "eFYDataGridViewTextBoxColumn";
            // 
            // rpioCodeDataGridViewTextBoxColumn
            // 
            this.rpioCodeDataGridViewTextBoxColumn.DataPropertyName = "RpioCode";
            this.rpioCodeDataGridViewTextBoxColumn.HeaderText = "RpioCode";
            this.rpioCodeDataGridViewTextBoxColumn.Name = "rpioCodeDataGridViewTextBoxColumn";
            // 
            // rpioNameDataGridViewTextBoxColumn
            // 
            this.rpioNameDataGridViewTextBoxColumn.DataPropertyName = "RpioName";
            this.rpioNameDataGridViewTextBoxColumn.HeaderText = "RpioName";
            this.rpioNameDataGridViewTextBoxColumn.Name = "rpioNameDataGridViewTextBoxColumn";
            // 
            // ahCodeDataGridViewTextBoxColumn
            // 
            this.ahCodeDataGridViewTextBoxColumn.DataPropertyName = "AhCode";
            this.ahCodeDataGridViewTextBoxColumn.HeaderText = "AhCode";
            this.ahCodeDataGridViewTextBoxColumn.Name = "ahCodeDataGridViewTextBoxColumn";
            // 
            // ahNameDataGridViewTextBoxColumn
            // 
            this.ahNameDataGridViewTextBoxColumn.DataPropertyName = "AhName";
            this.ahNameDataGridViewTextBoxColumn.HeaderText = "AhName";
            this.ahNameDataGridViewTextBoxColumn.Name = "ahNameDataGridViewTextBoxColumn";
            // 
            // fundCodeDataGridViewTextBoxColumn
            // 
            this.fundCodeDataGridViewTextBoxColumn.DataPropertyName = "FundCode";
            this.fundCodeDataGridViewTextBoxColumn.HeaderText = "FundCode";
            this.fundCodeDataGridViewTextBoxColumn.Name = "fundCodeDataGridViewTextBoxColumn";
            // 
            // fundNameDataGridViewTextBoxColumn
            // 
            this.fundNameDataGridViewTextBoxColumn.DataPropertyName = "FundName";
            this.fundNameDataGridViewTextBoxColumn.HeaderText = "FundName";
            this.fundNameDataGridViewTextBoxColumn.Name = "fundNameDataGridViewTextBoxColumn";
            // 
            // orgCodeDataGridViewTextBoxColumn
            // 
            this.orgCodeDataGridViewTextBoxColumn.DataPropertyName = "OrgCode";
            this.orgCodeDataGridViewTextBoxColumn.HeaderText = "OrgCode";
            this.orgCodeDataGridViewTextBoxColumn.Name = "orgCodeDataGridViewTextBoxColumn";
            // 
            // orgNameDataGridViewTextBoxColumn
            // 
            this.orgNameDataGridViewTextBoxColumn.DataPropertyName = "OrgName";
            this.orgNameDataGridViewTextBoxColumn.HeaderText = "OrgName";
            this.orgNameDataGridViewTextBoxColumn.Name = "orgNameDataGridViewTextBoxColumn";
            // 
            // accountCodeDataGridViewTextBoxColumn
            // 
            this.accountCodeDataGridViewTextBoxColumn.DataPropertyName = "AccountCode";
            this.accountCodeDataGridViewTextBoxColumn.HeaderText = "AccountCode";
            this.accountCodeDataGridViewTextBoxColumn.Name = "accountCodeDataGridViewTextBoxColumn";
            // 
            // bocCodeDataGridViewTextBoxColumn
            // 
            this.bocCodeDataGridViewTextBoxColumn.DataPropertyName = "BocCode";
            this.bocCodeDataGridViewTextBoxColumn.HeaderText = "BocCode";
            this.bocCodeDataGridViewTextBoxColumn.Name = "bocCodeDataGridViewTextBoxColumn";
            // 
            // bocNameDataGridViewTextBoxColumn
            // 
            this.bocNameDataGridViewTextBoxColumn.DataPropertyName = "BocName";
            this.bocNameDataGridViewTextBoxColumn.HeaderText = "BocName";
            this.bocNameDataGridViewTextBoxColumn.Name = "bocNameDataGridViewTextBoxColumn";
            // 
            // programProjectCodeDataGridViewTextBoxColumn
            // 
            this.programProjectCodeDataGridViewTextBoxColumn.DataPropertyName = "ProgramProjectCode";
            this.programProjectCodeDataGridViewTextBoxColumn.HeaderText = "ProgramProjectCode";
            this.programProjectCodeDataGridViewTextBoxColumn.Name = "programProjectCodeDataGridViewTextBoxColumn";
            // 
            // programProjectNameDataGridViewTextBoxColumn
            // 
            this.programProjectNameDataGridViewTextBoxColumn.DataPropertyName = "ProgramProjectName";
            this.programProjectNameDataGridViewTextBoxColumn.HeaderText = "ProgramProjectName";
            this.programProjectNameDataGridViewTextBoxColumn.Name = "programProjectNameDataGridViewTextBoxColumn";
            // 
            // programAreaCodeDataGridViewTextBoxColumn
            // 
            this.programAreaCodeDataGridViewTextBoxColumn.DataPropertyName = "ProgramAreaCode";
            this.programAreaCodeDataGridViewTextBoxColumn.HeaderText = "ProgramAreaCode";
            this.programAreaCodeDataGridViewTextBoxColumn.Name = "programAreaCodeDataGridViewTextBoxColumn";
            // 
            // programAreaNameDataGridViewTextBoxColumn
            // 
            this.programAreaNameDataGridViewTextBoxColumn.DataPropertyName = "ProgramAreaName";
            this.programAreaNameDataGridViewTextBoxColumn.HeaderText = "ProgramAreaName";
            this.programAreaNameDataGridViewTextBoxColumn.Name = "programAreaNameDataGridViewTextBoxColumn";
            // 
            // rcCodeDataGridViewTextBoxColumn
            // 
            this.rcCodeDataGridViewTextBoxColumn.DataPropertyName = "RcCode";
            this.rcCodeDataGridViewTextBoxColumn.HeaderText = "RcCode";
            this.rcCodeDataGridViewTextBoxColumn.Name = "rcCodeDataGridViewTextBoxColumn";
            // 
            // rcNameDataGridViewTextBoxColumn
            // 
            this.rcNameDataGridViewTextBoxColumn.DataPropertyName = "RcName";
            this.rcNameDataGridViewTextBoxColumn.HeaderText = "RcName";
            this.rcNameDataGridViewTextBoxColumn.Name = "rcNameDataGridViewTextBoxColumn";
            // 
            // lowerNameDataGridViewTextBoxColumn
            // 
            this.lowerNameDataGridViewTextBoxColumn.DataPropertyName = "LowerName";
            this.lowerNameDataGridViewTextBoxColumn.HeaderText = "LowerName";
            this.lowerNameDataGridViewTextBoxColumn.Name = "lowerNameDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // budgetedDataGridViewTextBoxColumn
            // 
            this.budgetedDataGridViewTextBoxColumn.DataPropertyName = "Budgeted";
            this.budgetedDataGridViewTextBoxColumn.HeaderText = "Budgeted";
            this.budgetedDataGridViewTextBoxColumn.Name = "budgetedDataGridViewTextBoxColumn";
            // 
            // postedDataGridViewTextBoxColumn
            // 
            this.postedDataGridViewTextBoxColumn.DataPropertyName = "Posted";
            this.postedDataGridViewTextBoxColumn.HeaderText = "Posted";
            this.postedDataGridViewTextBoxColumn.Name = "postedDataGridViewTextBoxColumn";
            // 
            // openCommitmentsDataGridViewTextBoxColumn
            // 
            this.openCommitmentsDataGridViewTextBoxColumn.DataPropertyName = "OpenCommitments";
            this.openCommitmentsDataGridViewTextBoxColumn.HeaderText = "OpenCommitments";
            this.openCommitmentsDataGridViewTextBoxColumn.Name = "openCommitmentsDataGridViewTextBoxColumn";
            // 
            // uLODataGridViewTextBoxColumn
            // 
            this.uLODataGridViewTextBoxColumn.DataPropertyName = "ULO";
            this.uLODataGridViewTextBoxColumn.HeaderText = "ULO";
            this.uLODataGridViewTextBoxColumn.Name = "uLODataGridViewTextBoxColumn";
            // 
            // expendituresDataGridViewTextBoxColumn
            // 
            this.expendituresDataGridViewTextBoxColumn.DataPropertyName = "Expenditures";
            this.expendituresDataGridViewTextBoxColumn.HeaderText = "Expenditures";
            this.expendituresDataGridViewTextBoxColumn.Name = "expendituresDataGridViewTextBoxColumn";
            // 
            // obligationsDataGridViewTextBoxColumn
            // 
            this.obligationsDataGridViewTextBoxColumn.DataPropertyName = "Obligations";
            this.obligationsDataGridViewTextBoxColumn.HeaderText = "Obligations";
            this.obligationsDataGridViewTextBoxColumn.Name = "obligationsDataGridViewTextBoxColumn";
            // 
            // usedDataGridViewTextBoxColumn
            // 
            this.usedDataGridViewTextBoxColumn.DataPropertyName = "Used";
            this.usedDataGridViewTextBoxColumn.HeaderText = "Used";
            this.usedDataGridViewTextBoxColumn.Name = "usedDataGridViewTextBoxColumn";
            // 
            // availableDataGridViewTextBoxColumn
            // 
            this.availableDataGridViewTextBoxColumn.DataPropertyName = "Available";
            this.availableDataGridViewTextBoxColumn.HeaderText = "Available";
            this.availableDataGridViewTextBoxColumn.Name = "availableDataGridViewTextBoxColumn";
            // 
            // npmCodeDataGridViewTextBoxColumn
            // 
            this.npmCodeDataGridViewTextBoxColumn.DataPropertyName = "NpmCode";
            this.npmCodeDataGridViewTextBoxColumn.HeaderText = "NpmCode";
            this.npmCodeDataGridViewTextBoxColumn.Name = "npmCodeDataGridViewTextBoxColumn";
            // 
            // npmNameDataGridViewTextBoxColumn
            // 
            this.npmNameDataGridViewTextBoxColumn.DataPropertyName = "NpmName";
            this.npmNameDataGridViewTextBoxColumn.HeaderText = "NpmName";
            this.npmNameDataGridViewTextBoxColumn.Name = "npmNameDataGridViewTextBoxColumn";
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.CaptionButtonColor = System.Drawing.Color.DimGray;
            this.CaptionFont = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(1058, 617);
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
            ((System.ComponentModel.ISupportInitialize)(this.DataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BudgetToolStrip ToolStrip;
        private System.Data.SQLite.SQLiteCommand SQLiteSelectCommand;
        public System.Data.SQLite.SQLiteDataAdapter SQLiteAdapter;
        public System.Data.SQLite.SQLiteConnection SQLiteConnection;
        private System.Windows.Forms.BindingSource DataSource;
        private StatusOfFunds DataSet;
        private BudgetDataGrid DataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusOfFundsIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bFYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eFYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rpioCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rpioNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ahCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ahNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fundCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fundNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orgCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orgNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bocCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bocNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programProjectCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programProjectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programAreaCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programAreaNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rcCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rcNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lowerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openCommitmentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uLODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expendituresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obligationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn npmCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn npmNameDataGridViewTextBoxColumn;
    }
}