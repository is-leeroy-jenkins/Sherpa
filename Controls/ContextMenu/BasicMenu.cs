// ******************************************************************************************
//     Assembly:                Sherpa
//     Author:                  Terry D. Eppler
//     Created:                 05-12-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-12-2024
// ******************************************************************************************
// <copyright file="BasicMenu.cs" company="Terry D. Eppler">
//    Baby is a small web browser used in a Federal Budget, Finance, and Accounting application for the
//    US Environmental Protection Agency (US EPA).
//    Copyright ©  2024  Terry Eppler
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
//   BasicMenu.cs
// </summary>
// ******************************************************************************************

namespace Sherpa
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using MetroSet_UI.Child;
    using MetroSet_UI.Controls;
    using Syncfusion.Windows.Forms.Spreadsheet;
    
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="MetroSet_UI.Controls.MetroSetContextMenuStrip" />
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public abstract class BasicMenu : MetroSetContextMenuStrip
    {
        /// <summary>
        /// The file
        /// </summary>
        private protected MetroSetToolStripMenuItem _file;
        
        /// <summary>
        /// Gets or sets the refresh option.
        /// </summary>
        /// <value>
        /// The refresh option.
        /// </value>
        private protected MetroSetToolStripMenuItem _refresh;
        
        /// <summary>
        /// Gets or sets the Save As Pdf option.
        /// </summary>
        /// <value>
        /// The calculator option.
        /// </value>
        private protected MetroSetToolStripMenuItem _save;
        
        /// <summary>
        /// Gets or sets the calculator option.
        /// </summary>
        /// <value>
        /// The calculator option.
        /// </value>
        private protected MetroSetToolStripMenuItem _print;
        
        /// <summary>
        /// Gets or sets the exit option.
        /// </summary>
        /// <value>
        /// The exit option.
        /// </value>
        private protected MetroSetToolStripMenuItem _exit;
        
        /// <summary>
        /// Gets or sets the chrome option.
        /// </summary>
        /// <value>
        /// The chrome option.
        /// </value>
        private protected MetroSetToolStripMenuItem _chrome;
        
        /// <summary>
        /// Gets or sets the edge option.
        /// </summary>
        /// <value>
        /// The edge option.
        /// </value>
        private protected MetroSetToolStripMenuItem _edge;
        
        /// <summary>
        /// Gets or sets the firefox option.
        /// </summary>
        /// <value>
        /// The firefox option.
        /// </value>
        private protected MetroSetToolStripMenuItem _firefox;
        
        /// <summary>
        /// The calculator
        /// </summary>
        private protected MetroSetToolStripMenuItem _calculator;
        
        /// <summary>
        /// The calendar
        /// </summary>
        private protected MetroSetToolStripMenuItem _calendar;
        
        /// <summary>
        /// The task manager
        /// </summary>
        private protected MetroSetToolStripMenuItem _taskManager;
        
        /// <summary>
        /// The task manager
        /// </summary>
        private protected MetroSetToolStripMenuItem _controlPanel;
        
        /// <summary>
        /// The media player
        /// </summary>
        private protected MetroSetToolStripMenuItem _mediaPlayer;
        
        /// <summary>
        /// The maps
        /// </summary>
        private protected MetroSetToolStripMenuItem _maps;
        
        /// <summary>
        /// The clock
        /// </summary>
        private protected MetroSetToolStripMenuItem _clock;
        
        /// <summary>
        /// The guidance
        /// </summary>
        private protected MetroSetToolStripMenuItem _guidance;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="BasicMenu"/> class.
        /// </summary>
        protected BasicMenu( )
        {
        }
        
        /// <summary>
        /// Creates the file item.
        /// </summary>
        /// <returns></returns>
        private protected MetroSetToolStripMenuItem CreateFileItem( )
        {
            try
            {
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.MiddleCenter;
                _item.Name = MenuOption.File.ToString( );
                _item.Size = new Size( 203, 30 );
                _item.BackColor = Color.FromArgb( 10, 10, 10 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = MenuOption.File.ToString( );
                _item.Tag = MenuOption.File.ToString( );
                _item.Image = Resources.Images.MenuImages.FileItem;
                _item.MouseHover += OnMouseEnter;
                _item.MouseLeave += OnMouseLeave;
                _item.MouseDown += OnItemClicked;
                Items.Add( _item );
                return _item;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( MetroSetToolStripMenuItem );
            }
        }
        
        /// <summary>
        /// Creates the close option.
        /// </summary>
        /// <returns>
        /// MetroSetToolStripMenuItem
        /// </returns>
        private protected MetroSetToolStripMenuItem CreateExitItem( )
        {
            try
            {
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.MiddleCenter;
                _item.Name = MenuOption.Exit.ToString( );
                _item.Size = new Size( 203, 30 );
                _item.BackColor = Color.FromArgb( 10, 10, 10 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = $"{MenuOption.Exit}";
                _item.Tag = MenuOption.Exit.ToString( );
                _item.Image = Resources.Images.MenuImages.ExitItem;
                _item.MouseHover += OnMouseEnter;
                _item.MouseLeave += OnMouseLeave;
                _item.MouseDown += OnItemClicked;
                Items.Add( _item );
                return _item;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( MetroSetToolStripMenuItem );
            }
        }
        
        /// <summary>
        /// Creates the close option.
        /// </summary>
        /// <returns>
        /// MetroSetToolStripMenuItem
        /// </returns>
        private protected MetroSetToolStripMenuItem CreateRefreshItem( )
        {
            try
            {
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.MiddleCenter;
                _item.Name = MenuOption.Refresh.ToString( );
                _item.Size = new Size( 203, 30 );
                _item.BackColor = Color.FromArgb( 10, 10, 10 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = $"{MenuOption.Refresh}";
                _item.Tag = MenuOption.Refresh.ToString( );
                _item.Image = Resources.Images.MenuImages.RefreshItem;
                _item.MouseHover += OnMouseEnter;
                _item.MouseLeave += OnMouseLeave;
                _item.MouseDown += OnItemClicked;
                Items.Add( _item );
                return _item;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( MetroSetToolStripMenuItem );
            }
        }
        
        /// <summary>
        /// Creates the file option.
        /// </summary>
        /// <returns>
        /// MetroSetToolStripMenuItem
        /// </returns>
        private protected MetroSetToolStripMenuItem CreateSaveItem( )
        {
            try
            {
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.MiddleCenter;
                _item.Name = MenuOption.Save.ToString( );
                _item.Size = new Size( 203, 30 );
                _item.BackColor = Color.FromArgb( 10, 10, 10 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = $"{MenuOption.Save}".SplitPascal( );
                _item.Tag = MenuOption.Save.ToString( );
                _item.Image = Resources.Images.MenuImages.SaveItem;
                _item.ImageAlign = ContentAlignment.MiddleCenter;
                _item.MouseHover += OnMouseEnter;
                _item.MouseLeave += OnMouseLeave;
                _item.MouseDown += OnItemClicked;
                Items.Add( _item );
                return _item;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( MetroSetToolStripMenuItem );
            }
        }

        /// <summary>
        /// Creates the chrome item.
        /// </summary>
        /// <returns></returns>
        private protected MetroSetToolStripMenuItem CreateChromeItem( )
        {
            try
            {
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.MiddleCenter;
                _item.Name = MenuOption.Chrome.ToString( );
                _item.Size = new Size( 203, 30 );
                _item.BackColor = Color.FromArgb( 10, 10, 10 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = $"{MenuOption.Chrome}".SplitPascal( );
                _item.Tag = MenuOption.Chrome.ToString( );
                _item.Image = Resources.Images.MenuImages.ChromeItem;
                _item.ImageAlign = ContentAlignment.MiddleCenter;
                _item.MouseHover += OnMouseEnter;
                _item.MouseLeave += OnMouseLeave;
                _item.MouseDown += OnItemClicked;
                Items.Add( _item );
                return _item;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( MetroSetToolStripMenuItem );
            }
        }

        /// <summary>
        /// Called when [mouse enter].
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private protected void OnMouseEnter( object sender, EventArgs e )
        {
            if( sender is MetroSetToolStripMenuItem _item )
            {
                try
                {
                    _item.BackColor = Color.FromArgb( 50, 93, 129 );
                    _item.ForeColor = Color.White;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }
        
        /// <summary>
        /// Called when [mouse leave].
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private protected void OnMouseLeave( object sender, EventArgs e )
        {
            if( sender is MetroSetToolStripMenuItem _item )
            {
                try
                {
                    _item.BackColor = Color.FromArgb( 10, 10, 10 );
                    _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
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
            if( sender is MetroSetToolStripMenuItem _item
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
                                var _calendarForm = new CalendarForm( );
                                _calendarForm.Show( );
                                _calendarForm.Focus( );
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
                            case MenuOption.Firefox:
                            {
                                WebMinion.RunFirefox( );
                                break;
                            }
                            case MenuOption.Edge:
                            {
                                WebMinion.RunEdge( );
                                break;
                            }
                            case MenuOption.Chrome:
                            {
                                WebMinion.RunChrome( );
                                break;
                            }
                            case MenuOption.Documentation:
                            {
                                var _docViewer = new DocViewer( );
                                _docViewer.Show( );
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
                                var _clockForm = new ClockForm( );
                                _clockForm.Location = e.Location;
                                _clockForm.ShowDialog( );
                                break;
                            }
                            case MenuOption.Maps:
                            {
                                var _geoMapper = new GeoMapper( );
                                _geoMapper.Show( );
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
        /// <param name="ex">
        /// The ex.
        /// </param>
        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}