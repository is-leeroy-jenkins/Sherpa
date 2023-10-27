//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                ToolFactory.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="ToolFactory.cs" company="Terry D. Eppler">
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
//    ToolFactory.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Configuration;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Threading;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class ToolFactory
    {
        /// <summary> Gets the image directory. </summary>
        /// <value> The image directory. </value>
        public static string ImageDirectory { get; } =
            ConfigurationManager.AppSettings[ "ToolStrip" ];

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ToolFactory"/>
        /// class.
        /// </summary>
        public ToolFactory( )
        {
        }

        /// <summary> Creates the separator. </summary>
        /// <returns> </returns>
        public static ToolSeparator CreateSeparator( )
        {
            try
            {
                var _separator = new ToolSeparator( );
                return _separator;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( ToolSeparator );
            }
        }

        /// <summary> Creates the first button. </summary>
        /// <returns> </returns>
        public static ToolStripButton CreateFirstButton( )
        {
            try
            {
                var _filename = ImageDirectory + "FirstButton.png";
                var _firstButton = new ToolStripButton( );
                _firstButton.Image = Image.FromFile( _filename );
                _firstButton.HoverText = "First Record";
                _firstButton.ToolType = ToolType.FirstButton;
                return _firstButton;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( ToolStripButton );
            }
        }

        /// <summary> Creates the previous button. </summary>
        /// <returns> </returns>
        public static ToolStripButton CreatePreviousButton( )
        {
            try
            {
                var _filename = ImageDirectory + "PreviousButton.png";
                var _previousButton = new ToolStripButton( );
                _previousButton.Image = Image.FromFile( _filename );
                _previousButton.HoverText = "Previous Record";
                _previousButton.ToolType = ToolType.PreviousButton;
                return _previousButton;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( ToolStripButton );
            }
        }

        /// <summary> Creates the next button. </summary>
        /// <returns> </returns>
        public static ToolStripButton CreateNextButton( )
        {
            try
            {
                var _filename = ImageDirectory + "NextButton.png";
                var _nextButton = new ToolStripButton( );
                _nextButton.Image = Image.FromFile( _filename );
                _nextButton.HoverText = "Next Record";
                _nextButton.ToolType = ToolType.NextButton;
                return _nextButton;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( ToolStripButton );
            }
        }

        /// <summary> Creates the last button. </summary>
        /// <returns> </returns>
        public static ToolStripButton CreateLastButton( )
        {
            try
            {
                var _filename = ImageDirectory + "LastButton.png";
                var _lastButton = new ToolStripButton( );
                _lastButton.Image = Image.FromFile( _filename );
                _lastButton.HoverText = "Last Record";
                _lastButton.ToolType = ToolType.LastButton;
                return _lastButton;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( ToolStripButton );
            }
        }

        /// <summary> Creates the edit button. </summary>
        /// <returns> </returns>
        public static ToolStripButton CreateEditButton( )
        {
            try
            {
                var _filename = ImageDirectory + "EditButton.png";
                var _editButton = new ToolStripButton( );
                _editButton.Image = Image.FromFile( _filename );
                _editButton.HoverText = "Edit Record";
                _editButton.ToolType = ToolType.EditButton;
                return _editButton;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( ToolStripButton );
            }
        }

        /// <summary> Creates the add button. </summary>
        /// <returns> </returns>
        public static ToolStripButton CreateAddButton( )
        {
            try
            {
                var _filename = ImageDirectory + "AddButton.png";
                var _addButton = new ToolStripButton( );
                _addButton.Image = Image.FromFile( _filename );
                _addButton.HoverText = "Add Record";
                _addButton.ToolType = ToolType.AddButton;
                return _addButton;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( ToolStripButton );
            }
        }

        /// <summary> Creates the delete button. </summary>
        /// <returns> </returns>
        public static ToolStripButton CreateDeleteButton( )
        {
            try
            {
                var _filename = ImageDirectory + "DeleteButton.png";
                var _deleteButton = new ToolStripButton( );
                _deleteButton.Image = Image.FromFile( _filename );
                _deleteButton.HoverText = "Delete Record";
                _deleteButton.ToolType = ToolType.DeleteButton;
                return _deleteButton;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( ToolStripButton );
            }
        }

        /// <summary> Creates the refresh button. </summary>
        /// <returns> </returns>
        public static ToolStripButton CreateRefreshButton( )
        {
            try
            {
                var _filename = ImageDirectory + "RefreshButton.png";
                var _refreshButton = new ToolStripButton( );
                _refreshButton.Image = Image.FromFile( _filename );
                _refreshButton.HoverText = "Refresh Data";
                _refreshButton.ToolType = ToolType.RefreshButton;
                return _refreshButton;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( ToolStripButton );
            }
        }

        /// <summary> Creates the save button. </summary>
        /// <returns> </returns>
        public static ToolStripButton CreateSaveButton( )
        {
            try
            {
                var _filename = ImageDirectory + "SaveButton.png";
                var _saveButton = new ToolStripButton( );
                _saveButton.Image = Image.FromFile( _filename );
                _saveButton.HoverText = "Save Changes";
                _saveButton.ToolType = ToolType.SaveButton;
                return _saveButton;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( ToolStripButton );
            }
        }

        /// <summary> Creates the print button. </summary>
        /// <returns> </returns>
        public static ToolStripButton CreatePrintButton( )
        {
            try
            {
                var _filename = ImageDirectory + "PrintButton.png";
                var _printButton = new ToolStripButton( );
                _printButton.Image = Image.FromFile( _filename );
                _printButton.HoverText = "Print Data";
                _printButton.ToolType = ToolType.PrintButton;
                return _printButton;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( ToolStripButton );
            }
        }

        /// <summary> Creates the excel button. </summary>
        /// <returns> </returns>
        public static ToolStripButton CreateExcelButton( )
        {
            try
            {
                var _filename = ImageDirectory + "ExcelButton.png";
                var _excelButton = new ToolStripButton( );
                _excelButton.Image = Image.FromFile( _filename );
                _excelButton.HoverText = "Export to Excel";
                _excelButton.ToolType = ToolType.ExcelButton;
                return _excelButton;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( ToolStripButton );
            }
        }

        /// <summary> Creates the calculator button. </summary>
        /// <returns> </returns>
        public static ToolStripButton CreateCalculatorButton( )
        {
            try
            {
                var _filename = ImageDirectory + "CalculatorButton.png";
                var _calculatorButton = new ToolStripButton( );
                _calculatorButton.Image = Image.FromFile( _filename );
                _calculatorButton.HoverText = "Launch Calculator";
                _calculatorButton.ToolType = ToolType.CalculatorButton;
                return _calculatorButton;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( ToolStripButton );
            }
        }

        /// <summary> Creates the home button. </summary>
        /// <returns> </returns>
        public static ToolStripButton CreateHomeButton( )
        {
            try
            {
                var _filename = ImageDirectory + "HomeButton.png";
                var _homeButton = new ToolStripButton( );
                _homeButton.Image = Image.FromFile( _filename );
                _homeButton.HoverText = "Main Menu";
                _homeButton.ToolType = ToolType.HomeButton;
                return _homeButton;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( ToolStripButton );
            }
        }

        /// <summary> Creates the label. </summary>
        /// <returns> </returns>
        public static ToolStripLabel CreateLabel( )
        {
            try
            {
                var _label = new ToolStripLabel( );
                return _label;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( ToolStripLabel );
            }
        }

        /// <summary> Creates the ComboBox. </summary>
        /// <returns> </returns>
        public static ToolStripComboBoxEx CreateComboBox( )
        {
            try
            {
                var _comboBox = new ToolStripComboBoxEx( );
                return _comboBox;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( ToolStripComboBoxEx );
            }
        }

        /// <summary> Creates the progress bar. </summary>
        /// <returns> </returns>
        public static ToolStripProgressBar CreateProgressBar( )
        {
            try
            {
                var _progress = new ToolStripProgressBar( );
                return _progress;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( ToolStripProgressBar );
            }
        }

        /// <summary> Creates the text box. </summary>
        /// <returns> </returns>
        public static ToolStripTextBox CreateTextBox( )
        {
            try
            {
                var _textBox = new ToolStripTextBox( );
                return _textBox;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( ToolStripTextBox );
            }
        }

        /// <summary> Fails the specified ex. </summary>
        /// <param name="ex"> The ex. </param>
        private static void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}