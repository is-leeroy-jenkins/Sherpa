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
    public abstract class ContextBase : ContextMenuStripEx
    {
        /// <summary>
        /// The file option
        /// </summary>
        private protected ToolStripMenuItemExt _fileOption;

        /// <summary>
        /// The folder option
        /// </summary>
        private protected ToolStripMenuItemExt _folderOption;

        /// <summary>
        /// The calculator option
        /// </summary>
        private protected ToolStripMenuItemExt _calculatorOption;

        /// <summary>
        /// The calendar option
        /// </summary>
        private protected ToolStripMenuItemExt _calendarOption;

        /// <summary>
        /// The guidance option
        /// </summary>
        private protected ToolStripMenuItemExt _guidanceOption;

        /// <summary>
        /// The save option
        /// </summary>
        private protected ToolStripMenuItemExt _saveOption;

        /// <summary>
        /// The close option
        /// </summary>
        private protected ToolStripMenuItemExt _closeOption;

        /// <summary>
        /// The exit option
        /// </summary>
        private protected ToolStripMenuItemExt _exitOption;

        /// <summary>
        /// Creates the file option.
        /// </summary>
        /// <returns>
        /// ToolStripMenuItemExt
        /// </returns>
        private protected ToolStripMenuItemExt CreateFileOption( )
        {
            try
            {
                var _item = new ToolStripMenuItemExt( );
                _item.TextAlign = ContentAlignment.MiddleCenter;
                _item.Font = new Font( "Roboto", 8 );
                _item.Name = MenuOption.File.ToString( );
                _item.Size = new Size( 198, 22 );
                _item.BackColor = Color.FromArgb( 45, 45, 45 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = $"{MenuOption.File}";
                _item.Tag = MenuOption.File.ToString( );
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
        private protected ToolStripMenuItemExt CreateFolderOption( )
        {
            try
            {
                var _item = new ToolStripMenuItemExt( );
                _item.TextAlign = ContentAlignment.MiddleCenter;
                _item.Font = new Font( "Roboto", 8 );
                _item.Name = MenuOption.Folder.ToString( );
                _item.Size = new Size( 198, 22 );
                _item.BackColor = Color.FromArgb( 45, 45, 45 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = $"{MenuOption.Folder}";
                _item.Tag = MenuOption.Folder.ToString( );
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
        private protected ToolStripMenuItemExt CreateCalculatorOption( )
        {
            try
            {
                var _item = new ToolStripMenuItemExt( );
                _item.TextAlign = ContentAlignment.MiddleCenter;
                _item.Font = new Font( "Roboto", 8 );
                _item.Name = MenuOption.Calculator.ToString( );
                _item.Size = new Size( 198, 22 );
                _item.BackColor = Color.FromArgb( 45, 45, 45 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = $"{MenuOption.Calculator}";
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
        private protected ToolStripMenuItemExt CreateCalendarOption( )
        {
            try
            {
                var _item = new ToolStripMenuItemExt( );
                _item.TextAlign = ContentAlignment.MiddleCenter;
                _item.Font = new Font( "Roboto", 8 );
                _item.Name = MenuOption.Calendar.ToString( );
                _item.Size = new Size( 198, 22 );
                _item.BackColor = Color.FromArgb( 45, 45, 45 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = $"{MenuOption.Calendar}";
                _item.Tag = MenuOption.Calendar.ToString( );
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
        private protected ToolStripMenuItemExt CreateGuidanceOption( )
        {
            try
            {
                var _item = new ToolStripMenuItemExt( );
                _item.TextAlign = ContentAlignment.MiddleCenter;
                _item.Font = new Font( "Roboto", 8 );
                _item.Name = MenuOption.Guidance.ToString( );
                _item.Size = new Size( 198, 22 );
                _item.BackColor = Color.FromArgb( 45, 45, 45 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = $"{MenuOption.Guidance}";
                _item.Tag = MenuOption.Guidance.ToString( );
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
        private protected ToolStripMenuItemExt CreateSaveOption( )
        {
            try
            {
                var _item = new ToolStripMenuItemExt( );
                _item.TextAlign = ContentAlignment.MiddleCenter;
                _item.Font = new Font( "Roboto", 8 );
                _item.Name = MenuOption.Save.ToString( );
                _item.Size = new Size( 198, 22 );
                _item.BackColor = Color.FromArgb( 45, 45, 45 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = $"{MenuOption.Save}";
                _item.Tag = MenuOption.Save.ToString( );
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
        /// Creates the close option.
        /// </summary>
        /// <returns>
        /// ToolStripMenuItemExt
        /// </returns>
        private protected ToolStripMenuItemExt CreateCloseOption( )
        {
            try
            {
                var _item = new ToolStripMenuItemExt( );
                _item.TextAlign = ContentAlignment.MiddleCenter;
                _item.Font = new Font( "Roboto", 8 );
                _item.Name = MenuOption.Close.ToString( );
                _item.Size = new Size( 198, 22 );
                _item.BackColor = Color.FromArgb( 45, 45, 45 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = $"{MenuOption.Close}";
                _item.Tag = MenuOption.Close.ToString( );
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
        private protected ToolStripMenuItemExt CreateExitOption( )
        {
            try
            {
                var _item = new ToolStripMenuItemExt( );
                _item.TextAlign = ContentAlignment.MiddleCenter;
                _item.Font = new Font( "Roboto", 8 );
                _item.Name = MenuOption.Exit.ToString( );
                _item.Size = new Size( 198, 22 );
                _item.BackColor = Color.FromArgb( 45, 45, 45 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = $"{MenuOption.Exit}";
                _item.Tag = MenuOption.Exit.ToString( );
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
                                var _file = new FileBrowser( );
                                _file.Location = e.Location;
                                _file.Show( );
                                break;
                            }
                            case MenuOption.Folder:
                            {
                                var _file = new FolderBrowser( );
                                _file.Location = e.Location;
                                _file.Show( );
                                break;
                            }
                            case MenuOption.Calculator:
                            {
                                var _form = new CalculationForm( );
                                _form.Location = e.Location;
                                _form.ShowDialog( );
                                break;
                            }
                            case MenuOption.Calendar:
                            {
                                var _form = new CalendarDialog( );
                                _form.Location = e.Location;
                                _form.ShowDialog( );
                                break;
                            }
                            case MenuOption.Guidance:
                            {
                                var _guidance = new GuidanceDialog( );
                                _guidance.Location = e.Location;
                                _guidance.ShowDialog( );
                                break;
                            }
                            case MenuOption.Save:
                            {
                                var _msg = "NOT YET IMPLEMENTED!!";
                                var _notification = new Notification( _msg );
                                _notification.Show( );
                                break;
                            }
                            case MenuOption.Close:
                            {
                                var _msg = "NOT YET IMPLEMENTED!!";
                                var _notification = new Notification( _msg );
                                _notification.Show( );
                                break;
                            }
                            case MenuOption.Exit:
                            {
                                var _msg = "NOT YET IMPLEMENTED!!";
                                var _notification = new Notification( _msg );
                                _notification.Show( );
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