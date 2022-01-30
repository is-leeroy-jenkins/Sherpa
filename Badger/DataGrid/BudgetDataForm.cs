// // <copyright file = "BudgetDataForm.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;

    public partial class BudgetDataForm : MetroForm
    {
        /// <summary>
        /// Gets the data grid.
        /// </summary>
        /// <value>
        /// The data grid.
        /// </value>
        public DataGridPanel DataGrid { get; } = new DataGridPanel();

        public BudgetDataForm()
        {
            InitializeComponent();
            BackColor = ColorConfig.FormBackColorDark;
            BorderThickness = BorderConfig.Thin;
            BorderColor = ColorConfig.BorderColorBlue;
            Font = FontConfig.FontSizeSmall;
            CaptionBarColor = ColorConfig.FormBackColorDark;
            CaptionBarHeight = SizeConfig.CaptionSizeNormal;
            CaptionButtonColor = ColorConfig.CaptionButtonDefaultColor;
            CaptionButtonHoverColor = ColorConfig.CaptionButtonHoverColor;
            CaptionAlign = AlignConfig.HorizontalLeft;
            CaptionFont = FontConfig.FontSizeMedium;
            MetroColor = ColorConfig.FormBackColorDark;
            FormBorderStyle = BorderConfig.Sizeable;
            Icon = new Icon( @"C:\Users\terry\source\repos\BudgetExecution\Etc\epa.ico", 33, 32 );
            ShowIcon = false;
            ShowInTaskbar = true;
            Padding = ControlConfig.Padding;
            Text = string.Empty;
            Size = new Size( DataGrid.Size.Width, DataGrid.Size.Height);
            DataGrid.Dock = DockStyle.Fill;
            Controls.Add( DataGrid );
        }
    }
}
