//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                ExcelDataGrid.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="ExcelDataGrid.cs" company="Terry D. Eppler">
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
//    ExcelDataGrid.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Spreadsheet;

    /// <inheritdoc/>
    /// <summary> </summary>
    /// <seealso cref="T:Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet"/>
    /// <seealso cref="T:BudgetExecution.ISpreadsheet"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    public class ExcelDataGrid : Spreadsheet, ISpreadsheet
    {
        /// <summary> Gets or sets the grid. </summary>
        /// <value> The grid. </value>
        public SpreadsheetGrid Grid { get; set; }

        /// <summary> Gets or sets the model. </summary>
        /// <value> The model. </value>
        public SpreadsheetGridModel Model { get; set; }

        /// <summary> Gets or sets the binding source. </summary>
        /// <value> The binding source. </value>
        public BindingSource BindingSource { get; set; }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.ExcelDataGrid"/>
        /// class.
        /// </summary>
        public ExcelDataGrid( )
        {
            // Spreadsheet Properties
            CanApplyTheme = true;
            CanOverrideStyle = true;
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.Black;
            Font = new Font( "Roboto", 8, FontStyle.Regular );
            DefaultColumnCount = 26;
            DefaultRowCount = 66;
            AllowZooming = true;
            AllowCellContextMenu = true;
            CanApplyTheme = true;
            CanOverrideStyle = true;
            Margin = new Padding( 1 );
            Padding = new Padding( 1 );
            Font = new Font( "Roboto", 8, FontStyle.Regular );
            ForeColor = Color.FromArgb( 106, 189, 252 );
            DefaultColumnCount = 40;
            DefaultRowCount = 60;
            AllowZooming = true;
            AllowFiltering = true;
        }

        /// <summary>
        /// Initializes the labels.
        /// </summary>
        private void InitLabels( )
        {
            try
            {
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the callback.
        /// </summary>
        private void InitCallbacks( )
        {
            try
            {
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the timers.
        /// </summary>
        private void InitTimers( )
        {
            try
            {
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the buttons.
        /// </summary>
        private void InitButtons( )
        {
            try
            {
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the tool strip.
        /// </summary>
        private void InitToolStrip( )
        {
            try
            {
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <inheritdoc/>
        /// <summary> Opens the file. </summary>
        /// <param name="file"> The file. </param>
        public void OpenFile( Stream file )
        {
            try
            {
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <inheritdoc/>
        /// <summary> Displays the message box. </summary>
        /// <param name="text"> The text. </param>
        /// <param name="caption"> The caption. </param>
        /// <param name="button"> The button. </param>
        /// <param name="icon"> The icon. </param>
        /// <returns> </returns>
        public virtual bool DisplayMessageBox( string text, string caption,
            MessageBoxButtons button, MessageBoxIcon icon )
        {
            return false;
        }

        /// <summary> Fails the specified ex. </summary>
        /// <param name="ex"> The ex. </param>
        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}