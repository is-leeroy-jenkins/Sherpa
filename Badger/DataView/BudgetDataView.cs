// <copyright file = "BudgetDataGridView.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using Syncfusion.WinForms.DataGrid.Enums;
    using Syncfusion.WinForms.GridCommon;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="DataViewBase" />
    public class BudgetDataView : DataViewBase
    {
        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="BudgetDataView"/> class.
        /// </summary>
        public BudgetDataView()
        {
            BackColor = BudgetColor.FormDark;
            ShowBusyIndicator = true;
            ShowErrorIcon = true;
            ShowGroupDropArea = true;
            ShowHeaderToolTip = true;
            ShowRowHeader = true;
            ShowPreviewRow = true;
            ShowToolTip = true;
            AllowDraggingColumns = true;
            AllowDeleting = true;
            AllowFiltering = true;
            AllowGrouping = true;
            FilterPopupMode = FilterPopupMode.AdvancedFilter;
            EditMode = EditMode.DoubleClick;
            CopyOption = CopyOptions.IncludeHeaders;
        }
    }
}
