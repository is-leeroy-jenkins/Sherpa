//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                DataView.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="DataView.cs" company="Terry D. Eppler">
// 
//     This is a Federal Budget, Finance, and Accounting application for the
//     US Environmental Protection Agency (US EPA).
//     Copyright ©  2023  Terry Eppler
// 
//     Permission is hereby granted, free of charge, to any person obtaining a copy
//     of this software and associated documentation files (the “Software”),
//     to deal in the Software without restriction,
//     including without limitation the rights to use,
//     copy, modify, merge, publish, distribute, sublicense,
//     and/or sell copies of the Software,
//     and to permit persons to whom the Software is furnished to do so,
//     subject to the following conditions:
// 
//     The above copyright notice and this permission notice shall be included in all
//     copies or substantial portions of the Software.
// 
//     THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//     INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//     FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT.
//     IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//     DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//     ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//     DEALINGS IN THE SOFTWARE.
// 
//     You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// 
//  </copyright>
//  <summary>
//    DataView.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Threading;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Gauge;
    using Syncfusion.Windows.Forms.Grid;

    /// <summary> </summary>
    /// <seealso cref="DataViewBase"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class DataView : DataViewBase
    {
        /// <summary> Gets or sets the data table. </summary>
        /// <value> The data table. </value>
        public DataTable DataTable { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataView"/>
        /// class.
        /// </summary>
        public DataView( )
        {
            // Control Properties
            ThemesEnabled = true;
            ApplyVisualStyles = true;
            TransparentBackground = false;
            EnableAddNew = true;
            EnableEdit = true;
            CanOverrideStyle = true;
            EnableRemove = true;
            AllowResizeToFit = true;
            ExcelLikeSelectionFrame = true;
            ExcelLikeAlignment = true;
            BackColor = Color.FromArgb( 78, 78, 79 );
            ForeColor = Color.Black;
            Font = new Font( "Roboto", 8, FontStyle.Regular );
            GridOfficeScrollBars = OfficeScrollBars.Office2010;
            Office2010ScrollBarsColorScheme = Office2010ColorScheme.Black;
            ColorStyles = ColorStyles.Office2016DarkGray;
            GridVisualStyles = GridVisualStyles.Metro;
            GridLineColor = Color.Black;
            HorizontalScrollTips = true;
            HorizontalThumbTrack = true;
            VerticalScrollTips = true;
            VerticalThumbTrack = true;
            DefaultGridBorderStyle = GridBorderStyle.Dotted;
            AlphaBlendSelectionColor = Color.FromArgb( 0, 120, 212 );

            // ThemStyle Properties
            ThemeStyle.CellStyle.Font = new Font( "Roboto", 8, FontStyle.Regular );
            ThemeStyle.CellStyle.BackColor = Color.FromArgb( 78, 78, 79 );
            ThemeStyle.CellStyle.TextColor = Color.Black;
            ThemeStyle.CellStyle.BackColor = Color.FromArgb( 78, 78, 79 );
            ThemeStyle.CellStyle.TextColor = Color.LightSteelBlue;
            ThemeStyle.HeaderStyle.HoverTextColor = Color.White;
            ThemeStyle.HeaderStyle.HoverBackColor = Color.FromArgb( 0, 120, 212 );

            // Model Properties
            Model.Rows.DefaultSize = 22;
            Model.ActiveGridView.PdfExport = true;
            Model.Properties.ThemedHeader = false;

            // Style Properties
            Properties.ThemedHeader = true;
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
            TableStyle.Font.FontStyle = FontStyle.Regular;
            TableStyle.BackColor = Color.FromArgb( 78, 78, 79 );
            TableStyle.TextColor = Color.LightSteelBlue;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataView"/>
        /// class.
        /// </summary>
        /// <param name="dataTable"> The data table. </param>
        public DataView( DataTable dataTable )
            : this( )
        {
            DataTable = dataTable;
        }
    }
}