// // <copyright file = "DataGridForm.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Collections.Specialized;
    using System.Configuration;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;

    public partial class DataGridForm : MetroForm
    {
        /// <summary>
        /// Gets the data grid.
        /// </summary>
        /// <value>
        /// The data grid.
        /// </value>
        public BudgetDataGrid BudgetDataGrid { get; } = new BudgetDataGrid();
        
        public DataGridForm()
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
            Icon = new Icon( BudgetDataGrid.AppSetting[ "BudgetExecutionIcon" ], 33, 32 );
            ShowIcon = false;
            ShowInTaskbar = true;
            Padding = ControlConfig.Padding;
            Text = string.Empty;
            Size = new Size( BudgetDataGrid.Size.Width - 1, BudgetDataGrid.Size.Height - 1 );
            BudgetDataGrid.Dock = DockStyle.Fill;
            Controls.Add( BudgetDataGrid );
        }
    }
}
