// ******************************************************************************************
//     Assembly:             BudgetExecution
//     Author:                  Terry D. Eppler
//     Created:                 12-03-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        12-03-2023
// ******************************************************************************************
// <copyright file="Terry Eppler.cs" company="Terry D. Eppler">
//    BudgetExecution is a Federal Budget, Finance, and Accounting application for the
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
//    You can contact me at:  terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   ContextBase.cs.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using Syncfusion.Windows.Forms.Spreadsheet;
    using Syncfusion.Windows.Forms.Tools;
    using System.Windows.Forms;
    using System.Drawing;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:Syncfusion.Windows.Forms.Tools.ContextMenuStripEx" />
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public abstract class ContextBase : ContextMenuStripEx
    {
        /// <summary>
        /// The file option
        /// </summary>
        private protected ToolStripMenuItemExt _browseFileOption;

        /// <summary>
        /// The folder option
        /// </summary>
        private protected ToolStripMenuItemExt _browseFolderOption;

        /// <summary>
        /// The calculator option
        /// </summary>
        private protected ToolStripMenuItemExt _budgetCalculatorOption;

        /// <summary>
        /// The budget calendar option
        /// </summary>
        private protected ToolStripMenuItemExt _budgetCalendarOption;

        /// <summary>
        /// The budget guidance option
        /// </summary>
        private protected ToolStripMenuItemExt _budgetGuidanceOption;

        /// <summary>
        /// The save changes option
        /// </summary>
        private protected ToolStripMenuItemExt _saveChangesOption;

        /// <summary>
        /// The One Drive option
        /// </summary>
        private protected ToolStripMenuItemExt _oneDriveOption;

        /// <summary>
        /// The exit application option
        /// </summary>
        private protected ToolStripMenuItemExt _exitApplicationOption;

        /// <summary>
        /// The win10 calculator option
        /// </summary>
        private protected ToolStripMenuItemExt _windowsCalculatorOption;

        /// <summary>
        /// The win10 clock option
        /// </summary>
        private protected ToolStripMenuItemExt _windowsClockOption;

        /// <summary>
        /// The win10 Maps option
        /// </summary>
        private protected ToolStripMenuItemExt _windowsMapsOption;

        /// <summary>
        /// The control panel option
        /// </summary>
        private protected ToolStripMenuItemExt _controlPanelOption;

        /// <summary>
        /// The task manager option
        /// </summary>
        private protected ToolStripMenuItemExt _taskManagerOption;

        /// <summary>
        /// The task manager option
        /// </summary>
        private protected ToolStripMenuItemExt _windowsMediaPlayerOption;

        /// <summary>
        /// Creates the file option.
        /// </summary>
        /// <returns>
        /// ToolStripMenuItemExt
        /// </returns>
        private protected ToolStripMenuItemExt CreateBrowseFileOption( )
        {
            try
            {
                var _name = MenuOption.BrowseFile.ToString( );
                var _caption = _name.SplitPascal( );
                var _item = new ToolStripMenuItemExt( );
                _item.TextAlign = ContentAlignment.MiddleCenter;
                _item.Font = new Font( "Roboto", 9 );
                _item.Name = _name;
                _item.Size = new Size( 198, 24 );
                _item.BackColor = Color.FromArgb( 45, 45, 45 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = _caption;
                _item.Tag = _name;
                _item.Checked = false;
                _item.MouseDown += OnItemClicked;
                Items.Add( _item );
                return _item;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( ToolStripMenuItemExt );
            }
        }

        /// <summary>
        /// Creates the folder option.
        /// </summary>
        /// <returns>
        /// ToolStripMenuItemExt
        /// </returns>
        private protected ToolStripMenuItemExt CreateBrowseFolderOption( )
        {
            try
            {
                var _name = MenuOption.BrowseFolder.ToString( );
                var _caption = _name.SplitPascal( );
                var _item = new ToolStripMenuItemExt( );
                _item.TextAlign = ContentAlignment.MiddleCenter;
                _item.Font = new Font( "Roboto", 9 );
                _item.Name = _name;
                _item.Size = new Size( 198, 24 );
                _item.BackColor = Color.FromArgb( 45, 45, 45 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = _caption;
                _item.Tag = _name;
                _item.Checked = false;
                _item.MouseDown += OnItemClicked;
                Items.Add( _item );
                return _item;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( ToolStripMenuItemExt );
            }
        }

        /// <summary>
        /// Creates the calculator option.
        /// </summary>
        /// <returns>
        /// ToolStripMenuItemExt
        /// </returns>
        private protected ToolStripMenuItemExt CreateBudgetCalculatorOption( )
        {
            try
            {
                var _name = MenuOption.BudgetCalculator.ToString( );
                var _caption = _name.SplitPascal( );
                var _item = new ToolStripMenuItemExt( );
                _item.TextAlign = ContentAlignment.MiddleCenter;
                _item.Font = new Font( "Roboto", 9 );
                _item.Name = _name;
                _item.Size = new Size( 198, 24 );
                _item.BackColor = Color.FromArgb( 45, 45, 45 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = $"{_caption}";
                _item.Tag = MenuOption.BudgetCalculator.ToString( );
                _item.Checked = false;
                _item.MouseDown += OnItemClicked;
                Items.Add( _item );
                return _item;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( ToolStripMenuItemExt );
            }
        }

        /// <summary>
        /// Creates the calendar option.
        /// </summary>
        /// <returns>
        /// ToolStripMenuItemExt
        /// </returns>
        private protected ToolStripMenuItemExt CreateBudgetCalendarOption( )
        {
            try
            {
                var _name = MenuOption.BudgetCalendar.ToString( );
                var _caption = _name.SplitPascal( );
                var _item = new ToolStripMenuItemExt( );
                _item.TextAlign = ContentAlignment.MiddleCenter;
                _item.Font = new Font( "Roboto", 9 );
                _item.Name = _name;
                _item.Size = new Size( 198, 24 );
                _item.BackColor = Color.FromArgb( 45, 45, 45 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = _caption;
                _item.Tag = _name;
                _item.Checked = false;
                _item.MouseDown += OnItemClicked;
                Items.Add( _item );
                return _item;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( ToolStripMenuItemExt );
            }
        }

        /// <summary>
        /// Creates the guidance option.
        /// </summary>
        /// <returns>
        /// ToolStripMenuItemExt
        /// </returns>
        private protected ToolStripMenuItemExt CreateBudgetGuidanceOption( )
        {
            try
            {
                var _name = MenuOption.BudgetGuidance.ToString( );
                var _caption = _name.SplitPascal( );
                var _item = new ToolStripMenuItemExt( );
                _item.TextAlign = ContentAlignment.MiddleCenter;
                _item.Font = new Font( "Roboto", 9 );
                _item.Name = _name;
                _item.Size = new Size( 198, 24 );
                _item.BackColor = Color.FromArgb( 45, 45, 45 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = _caption;
                _item.Tag = _name;
                _item.Checked = false;
                _item.MouseDown += OnItemClicked;
                Items.Add( _item );
                return _item;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( ToolStripMenuItemExt );
            }
        }

        /// <summary>
        /// Creates the save option.
        /// </summary>
        /// <returns>
        /// ToolStripMenuItemExt
        /// </returns>
        private protected ToolStripMenuItemExt CreateSaveChangesOption( )
        {
            try
            {
                var _name = MenuOption.SaveChanges.ToString( );
                var _caption = _name.SplitPascal( );
                var _item = new ToolStripMenuItemExt( );
                _item.TextAlign = ContentAlignment.MiddleCenter;
                _item.Font = new Font( "Roboto", 9 );
                _item.Name = _name;
                _item.Size = new Size( 198, 24 );
                _item.BackColor = Color.FromArgb( 45, 45, 45 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = _caption;
                _item.Tag = _name;
                _item.Checked = false;
                _item.MouseDown += OnItemClicked;
                Items.Add( _item );
                return _item;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( ToolStripMenuItemExt );
            }
        }

        /// <summary>
        /// Creates the exit option.
        /// </summary>
        /// <returns>
        /// ToolStripMenuItemExt
        /// </returns>
        private protected ToolStripMenuItemExt CreateExitApplicationOption( )
        {
            try
            {
                var _name = MenuOption.ExitApplication.ToString( );
                var _caption = _name.SplitPascal( );
                var _item = new ToolStripMenuItemExt( );
                _item.TextAlign = ContentAlignment.MiddleCenter;
                _item.Font = new Font( "Roboto", 9 );
                _item.Name = _name;
                _item.Size = new Size( 198, 24 );
                _item.BackColor = Color.FromArgb( 45, 45, 45 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = _caption;
                _item.Tag = _name;
                _item.Checked = false;
                _item.MouseDown += OnItemClicked;
                Items.Add( _item );
                return _item;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( ToolStripMenuItemExt );
            }
        }

        /// <summary>
        /// Called when [item clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/>
        /// instance containing the event data.</param>
        private protected void OnItemClicked( object sender, MouseEventArgs e )
        {
            if( sender is ToolStripMenuItemExt _item
               && ( e?.Button == MouseButtons.Left ) )
            {
                try
                {
                    var _name = _item.Tag.ToString( );
                    if( !string.IsNullOrEmpty( _name ) )
                    {
                        var _option = Enum.Parse( typeof( MenuOption ), _name );
                        switch( _option )
                        {
                            case MenuOption.BrowseFile:
                            {
                                var _file = new FileDialog( );
                                _file.Location = e.Location;
                                _file.ShowDialog( );
                                break;
                            }
                            case MenuOption.BrowseFolder:
                            {
                                var _file = new FolderDialog( );
                                _file.Location = e.Location;
                                _file.ShowDialog( );
                                break;
                            }
                            case MenuOption.BudgetCalculator:
                            {
                                var _form = new CalculationForm( );
                                _form.Location = e.Location;
                                _form.ShowDialog( );
                                break;
                            }
                            case MenuOption.WindowsCalendar:
                            {
                                Minion.LaunchWindowsCalendar( );
                                break;
                            }
                            case MenuOption.ControlPanel:
                            {
                                Minion.LaunchControlPanel( );
                                break;
                            }
                            case MenuOption.TaskManager:
                            {
                                Minion.LaunchTaskManager( );
                                break;
                            }
                            case MenuOption.WindowsCalculator:
                            {
                                Minion.LaunchWindowsCalculator( );
                                break;
                            }
                            case MenuOption.BudgetGuidance:
                            {
                                var _guidance = new DocViewer( );
                                _guidance.ShowDialog( );
                                break;
                            }
                            case MenuOption.OneDrive:
                            {
                                Minion.LaunchOneDrive( );
                                break;
                            }
                            case MenuOption.SaveChanges:
                            {
                                var _msg = "NOT YET IMPLEMENTED!!";
                                var _notification = new Notification( _msg );
                                _notification.Show( );
                                break;
                            }
                            case MenuOption.WindowsClock:
                            {
                                Minion.LaunchWindowsClock( );
                                break;
                            }
                            case MenuOption.WindowsMaps:
                            {
                                Minion.LaunchWindowsMaps( );
                                break;
                            }
                            case MenuOption.MediaPlayer:
                            {
                                Minion.LaunchWindowsMediaPlayer( );
                                break;
                            }
                            case MenuOption.ExitApplication:
                            {
                                Application.Exit( );
                                break;
                            }
                            default:
                            {
                                var _msg = "NOT YET IMPLEMENTED!!";
                                var _notification = new Notification( _msg );
                                _notification.Show( );
                                break;
                            }
                        }

                        Close( );
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex"> The ex.
        /// </param>
        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}