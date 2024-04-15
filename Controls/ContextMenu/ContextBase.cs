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
        private protected ToolStripMenuItemExt _file;

        /// <summary>
        /// The folder option
        /// </summary>
        private protected ToolStripMenuItemExt _folder;

        /// <summary>
        /// The calculator option
        /// </summary>
        private protected ToolStripMenuItemExt _calculator;

        /// <summary>
        /// The budget calendar option
        /// </summary>
        private protected ToolStripMenuItemExt _calendar;

        /// <summary>
        /// The budget guidance option
        /// </summary>
        private protected ToolStripMenuItemExt _guidance;

        /// <summary>
        /// The save changes option
        /// </summary>
        private protected ToolStripMenuItemExt _save;

        /// <summary>
        /// The One Drive option
        /// </summary>
        private protected ToolStripMenuItemExt _storage;

        /// <summary>
        /// The exit application option
        /// </summary>
        private protected ToolStripMenuItemExt _exit;

        /// <summary>
        /// The win10 calculator option
        /// </summary>
        private protected ToolStripMenuItemExt _windowsCalculator;

        /// <summary>
        /// The win10 clock option
        /// </summary>
        private protected ToolStripMenuItemExt _clock;

        /// <summary>
        /// The win10 Maps option
        /// </summary>
        private protected ToolStripMenuItemExt _maps;

        /// <summary>
        /// The control panel option
        /// </summary>
        private protected ToolStripMenuItemExt _controlPanel;

        /// <summary>
        /// The task manager option
        /// </summary>
        private protected ToolStripMenuItemExt _taskManager;

        /// <summary>
        /// The task manager option
        /// </summary>
        private protected ToolStripMenuItemExt _mediaPlayer;

        /// <summary>
        /// Creates the file option.
        /// </summary>
        /// <returns>
        /// ToolStripMenuItemExt
        /// </returns>
        private protected ToolStripMenuItemExt CreateFileItem( )
        {
            try
            {
                var _name = MenuOption.File.ToString( );
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
        private protected ToolStripMenuItemExt CreateFolderItem( )
        {
            try
            {
                var _name = MenuOption.Folder.ToString( );
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
        private protected ToolStripMenuItemExt CreateCalculatorItem( )
        {
            try
            {
                var _name = MenuOption.Calculator.ToString( );
                var _caption = _name.SplitPascal( );
                var _item = new ToolStripMenuItemExt( );
                _item.TextAlign = ContentAlignment.MiddleCenter;
                _item.Font = new Font( "Roboto", 9 );
                _item.Name = _name;
                _item.Size = new Size( 198, 24 );
                _item.BackColor = Color.FromArgb( 45, 45, 45 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = $"{_caption}";
                _item.Tag = MenuOption.Calculator.ToString( );
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
        private protected ToolStripMenuItemExt CreateCalendarItem( )
        {
            try
            {
                var _name = MenuOption.Calendar.ToString( );
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
        private protected ToolStripMenuItemExt CreateDocumentationItem( )
        {
            try
            {
                var _name = MenuOption.Documentation.ToString( );
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
        private protected ToolStripMenuItemExt CreateSaveItem( )
        {
            try
            {
                var _name = MenuOption.Save.ToString( );
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
        private protected ToolStripMenuItemExt CreateExitItem( )
        {
            try
            {
                var _name = MenuOption.Exit.ToString( );
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
                            case MenuOption.File:
                            {
                                var _fileDialog = new FileDialog( );
                                _fileDialog.Location = e.Location;
                                _fileDialog.ShowDialog( this );
                                break;
                            }
                            case MenuOption.Folder:
                            {
                                var _folderDialog = new FolderDialog( );
                                _folderDialog.Location = e.Location;
                                _folderDialog.ShowDialog( this );
                                break;
                            }
                            case MenuOption.Calculator:
                            {
                                var _calculationForm = new CalculationForm( );
                                _calculationForm.Location = e.Location;
                                _calculationForm.ShowDialog( );
                                break;
                            }
                            case MenuOption.Calendar:
                            {
                                WinMinion.LaunchCalendar( );
                                break;
                            }
                            case MenuOption.ControlPanel:
                            {
                                WinMinion.LaunchControlPanel( );
                                break;
                            }
                            case MenuOption.TaskManager:
                            {
                                WinMinion.LaunchTaskManager( );
                                break;
                            }
                            case MenuOption.Documentation:
                            {
                                var _docViewer = new DocViewer( );
                                _docViewer.ShowDialog( );
                                break;
                            }
                            case MenuOption.Storage:
                            {
                                WinMinion.LaunchOneDrive( );
                                break;
                            }
                            case MenuOption.Save:
                            {
                                var _msg = "NOT YET IMPLEMENTED!!";
                                var _notification = new Notification( _msg );
                                _notification.Show( );
                                break;
                            }
                            case MenuOption.Clock:
                            {
                                WinMinion.LaunchClock( );
                                break;
                            }
                            case MenuOption.Maps:
                            {
                                WinMinion.LaunchMaps( );
                                break;
                            }
                            case MenuOption.MediaPlayer:
                            {
                                WinMinion.LaunchMediaPlayer( );
                                break;
                            }
                            case MenuOption.Exit:
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