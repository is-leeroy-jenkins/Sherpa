namespace BudgetExecution
{
    using System;
    using System.Collections.Specialized;
    using System.Configuration;
    using System.Drawing;

    /// <summary>
    /// 
    /// </summary>
    public static class ToolFactory
    {
        /// <summary>
        /// Gets or sets the image directory.
        /// </summary>
        /// <value>
        /// The image directory.
        /// </value>
        public static NameValueCollection ImageDirectory { get; } = ConfigurationManager.AppSettings;

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="ToolFactory"/> class.
        /// </summary>
        static ToolFactory()
        {
        }

        /// <summary>
        /// Creates the first record button.
        /// </summary>
        /// <returns></returns>
        public static BudgetToolStripButton CreateFirstButton()
        {
            try
            {
                var _filename = ImageDirectory + "FirstButton.png";
                var _firstButton = new BudgetToolStripButton();
                _firstButton.Image = Image.FromFile( _filename );
                _firstButton.HoverText = "First Record";
                return _firstButton;
            }
            catch ( Exception ex )
            {
                Fail( ex );
                return default( BudgetToolStripButton );
            }
        }

        /// <summary>
        /// Creates the previous record button.
        /// </summary>
        /// <returns></returns>
        public static BudgetToolStripButton CreatePreviousButton()
        {
            try
            {
                var _filename = ImageDirectory + "PreviousButton.png";
                var _previousButton = new BudgetToolStripButton();
                _previousButton.Image = Image.FromFile( _filename );
                _previousButton.HoverText = "Previous Record";
                return _previousButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( BudgetToolStripButton );
            }
        }

        /// <summary>
        /// Creates the next record button.
        /// </summary>
        /// <returns></returns>
        public static BudgetToolStripButton CreateNextButton()
        {
            try
            {
                var _filename = ImageDirectory + "NextButton.png";
                var _nextButton = new BudgetToolStripButton();
                _nextButton.Image = Image.FromFile( _filename );
                _nextButton.HoverText = "Next Record";
                return _nextButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( BudgetToolStripButton );
            }
        }

        /// <summary>
        /// Creates the last record button.
        /// </summary>
        /// <returns></returns>
        public static BudgetToolStripButton CreateLastButton()
        {
            try
            {
                var _filename = ImageDirectory + "LastButton.png";
                var _lastButton = new BudgetToolStripButton();
                _lastButton.Image = Image.FromFile( _filename );
                _lastButton.HoverText = "Last Record";
                return _lastButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( BudgetToolStripButton );
            }
        }

        /// <summary>
        /// Creates the edit record button.
        /// </summary>
        /// <returns></returns>
        public static BudgetToolStripButton CreateEditButton()
        {
            try
            {
                var _filename = ImageDirectory + "EditButton.png";
                var _editButton = new BudgetToolStripButton();
                _editButton.Image = Image.FromFile( _filename );
                _editButton.HoverText = "Edit Record";
                return _editButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( BudgetToolStripButton );
            }
        }

        /// <summary>
        /// Creates the add record button.
        /// </summary>
        /// <returns></returns>
        public static BudgetToolStripButton CreateAddButton()
        {
            try
            {
                var _filename = ImageDirectory + "AddButton.png";
                var _addButton = new BudgetToolStripButton();
                _addButton.Image = Image.FromFile( _filename );
                _addButton.HoverText = "Add Record";
                return _addButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( BudgetToolStripButton );
            }
        }

        /// <summary>
        /// Creates the delete record button.
        /// </summary>
        /// <returns></returns>
        public static BudgetToolStripButton CreateDeleteButton()
        {
            try
            {
                var _filename = ImageDirectory + "DeleteButton.png";
                var _deleteButton = new BudgetToolStripButton();
                _deleteButton.Image = Image.FromFile( _filename );
                _deleteButton.HoverText = "Delete Record";
                return _deleteButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( BudgetToolStripButton );
            }
        }

        /// <summary>
        /// Creates the refresh data button.
        /// </summary>
        /// <returns></returns>
        public static BudgetToolStripButton CreateRefreshButton()
        {
            try
            {
                var _filename = ImageDirectory + "RefreshButton.png";
                var _refreshButton = new BudgetToolStripButton();
                _refreshButton.Image = Image.FromFile( _filename );
                _refreshButton.HoverText = "Refresh Data";
                return _refreshButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( BudgetToolStripButton );
            }
        }

        /// <summary>
        /// Creates the save changes button.
        /// </summary>
        /// <returns></returns>
        public static BudgetToolStripButton CreateSaveButton()
        {
            try
            {
                var _filename = ImageDirectory + "SaveButton.png";
                var _saveButton = new BudgetToolStripButton();
                _saveButton.Image = Image.FromFile( _filename );
                _saveButton.HoverText = "Save Changes";
                return _saveButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( BudgetToolStripButton );
            }
        }

        /// <summary>
        /// Creates the print data button.
        /// </summary>
        /// <returns></returns>
        public static BudgetToolStripButton CreatePrintButton()
        {
            try
            {
                var _filename = ImageDirectory + "PrintButton.png";
                var _printButton = new BudgetToolStripButton();
                _printButton.Image = Image.FromFile( _filename );
                _printButton.HoverText = "Print Data";
                return _printButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( BudgetToolStripButton );
            }
        }

        /// <summary>
        /// Creates the excel export button.
        /// </summary>
        /// <returns></returns>
        public static BudgetToolStripButton CreateExcelButton()
        {
            try
            {
                var _filename = ImageDirectory + "ExcelButton.png";
                var _excelButton = new BudgetToolStripButton();
                _excelButton.Image = Image.FromFile( _filename );
                _excelButton.HoverText = "Export to Excel";
                return _excelButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( BudgetToolStripButton );
            }
        }

        /// <summary>
        /// Creates the calculator button.
        /// </summary>
        /// <returns></returns>
        public static BudgetToolStripButton CreateCalculatorButton()
        {
            try
            {
                var _filename = ImageDirectory + "CalculatorButton.png";
                var _calculatorButton = new BudgetToolStripButton();
                _calculatorButton.Image = Image.FromFile( _filename );
                _calculatorButton.HoverText = "Launch Calculator";
                return _calculatorButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( BudgetToolStripButton );
            }
        }

        /// <summary>
        /// Creates the label.
        /// </summary>
        /// <returns>
        /// </returns>
        public static BudgetToolStripLabel CreateLabel()
        {
            try
            {
                var _label = new BudgetToolStripLabel();
                return _label;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( BudgetToolStripLabel );
            }
        }

        /// <summary>
        /// Creates the ComboBox.
        /// </summary>
        /// <returns>
        /// </returns>
        public static BudgetToolStripComboBox CreateComboBox()
        {
            try
            {
                var _comboBox = new BudgetToolStripComboBox();
                return _comboBox;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( BudgetToolStripComboBox );
            }
        }

        /// <summary>
        /// Creates the text box.
        /// </summary>
        /// <returns>
        /// </returns>
        public static BudgetToolStripTextBox CreateTextBox()
        {
            try
            {
                var _textBox = new BudgetToolStripTextBox();
                return _textBox;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( BudgetToolStripTextBox );
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText();
            _error?.ShowDialog();
        }
    }
}
