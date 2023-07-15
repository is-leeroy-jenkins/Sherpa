// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="DataGridBase.cs" company="Terry D. Eppler">
//    This is a Federal Budget, Finance, and Accounting application for the
//    US Environmental Protection Agency (US EPA).
//    Copyright ©  2023  Terry Eppler
// 
//    Permission is hereby granted, free of charge, to any person obtaining a copy
//    of this software and associated documentation files (the “Software”),
//    to deal in the Software without restriction,
//    including without limitation the rights to use,
//    copy, modify, merge, publish, distribute, sublicense,
//    and/or sell copies of the Software,
//    and to permit persons to whom the Software is furnished to do so,
//    subject to the following conditions:
// 
//    The above copyright notice and this permission notice shall be included in all
//    copies or substantial portions of the Software.
// 
//    THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//    INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//    FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT.
//    IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//    DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//    ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//    DEALINGS IN THE SOFTWARE.
// 
//    You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   DataGridBase.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Grid;

    /// <inheritdoc />
    /// <summary> </summary>
    /// <seealso cref="T:Syncfusion.Windows.Forms.Grid.GridDataBoundGrid" />
    [ SuppressMessage( "ReSharper", "PublicConstructorInAbstractClass" ) ]
    public abstract class DataGridBase : GridDataBoundGrid
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.DataGridBase" />
        /// class.
        /// </summary>
        /// <overload>
        /// Initializes a new instance of
        /// <see cref="T:Syncfusion.Windows.Forms.Grid.GridDataBoundGrid" />
        /// .
        /// </overload>
        public DataGridBase( )
        {
            // Basic Properties
            ForeColor = Color.LightGray;
            BackColor = Color.FromArgb( 45, 45, 45 );
            Font = new Font( "Roboto", 8 );
            Margin = new Padding( 0 );
            Padding = new Padding( 0 );
            Size = new Size( 700, 400 );
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Dock = DockStyle.None;
            Visible = true;
            Enabled = true;

            // Model Properties
            Model.Rows.DefaultSize = 22;
            Model.ActiveGridView.PdfExport = true;
            Model.Properties.ThemedHeader = false;
            Model.Properties.GridLineColor = Color.FromArgb( 141, 139, 138 );

            // Style Properties
            ThemesEnabled = true;
            ApplyVisualStyles = true;
            EnableAddNew = true;
            EnableEdit = true;
            EnableRemove = true;
            AllowResizeToFit = true;
            ExcelLikeSelectionFrame = true;
            ExcelLikeAlignment = true;
            AlphaBlendSelectionColor = Color.FromArgb( 0, 120, 212 );
            Properties.BackgroundColor = Color.FromArgb( 45, 45, 45 );
            Properties.CenterHorizontal = true;
            Properties.CenterVertical = true;
            Properties.ColHeaders = true;
            Properties.RowHeaders = true;
            Properties.Buttons3D = true;

            // Table Style Properties
            TableStyle.Themed = true;
            TableStyle.WrapText = false;
            TableStyle.HorizontalAlignment = GridHorizontalAlignment.Center;
            TableStyle.AutoFit = AutoFitOptions.Both;
            TableStyle.Font.Facename = "Roboto";
            TableStyle.Font.Size = 8;
        }
    }
}