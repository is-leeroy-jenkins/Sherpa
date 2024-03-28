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
//   ContextMenu.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using Syncfusion.Windows.Forms.Spreadsheet;
    using Syncfusion.Windows.Forms.Tools;

    /// <inheritdoc />
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class ContextMenu : ContextBase
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ContextMenu"/> class.
        /// </summary>
        public ContextMenu( )
        {
            BackColor = Color.FromArgb( 45, 45, 45 );
            ForeColor = Color.FromArgb( 106, 189, 252 );
            Size = new Size( 199, 158 );
            ShowCheckMargin = false;
            ShowImageMargin = true;
            Font = new Font( "Roboto", 9 );
            ImageScalingSize = new Size( 16, 16 );
            ShowImageMargin = true;
            ShowCheckMargin = false;
            MetroColor = Color.FromArgb( 45, 45, 45 );
            CanApplyTheme = true;
            CanOverrideStyle = true;
            Style = ContextMenuStyle.Office2016Black;
            ThemeStyle = new ContextMenuStripExVisualStyle( );
            ThemeStyle.BackColor = Color.FromArgb( 45, 45, 45 );
            ThemeStyle.ForeColor = Color.FromArgb( 106, 189, 252 );
            ThemeStyle.DisabledForeColor = Color.FromArgb( 45, 45, 45 );
            ThemeStyle.HoverBackColor = Color.FromArgb( 50, 93, 129 );
            ThemeStyle.HoverForeColor = Color.White;
            ThemeStyle.PressedForeColor = Color.White;
            ThemeStyle.PressedBackColor = Color.FromArgb( 0, 120, 212 );
            ThemeStyle.BorderColor = Color.FromArgb( 0, 120, 212 );

            // Menu Items
            _browseFile = CreateBrowseFileItem( );
            _browseFolder = CreateBrowseFolderItem( );
            _budgetCalculator = CreateBudgetCalculatorItem( );
            _windowsCalculator = CreateWindowsCalculatorItem( );
            _budgetCalendar = CreateBudgetCalendarItem( );
            _controlPanel = CreateControlPanelItem( );
            _taskManager = CreateTaskManagerItem( );
            _budgetGuidance = CreateBudgetGuidanceItem( );
            _windowsClock = CreateWindowsClockItem( );
            _saveChanges = CreateSaveChangesItem( );
            _windowsMaps = CreateMapsItem( );
            _oneDrive = CreateOneDriveItem( );
            _windowsMediaPlayer = CreateWindowsMediaPlayerItem( );
            _exitApplication = CreateExitApplicationItem( );
        }

        /// <summary>
        /// Creates the control panel option.
        /// </summary>
        /// <returns></returns>
        private ToolStripMenuItemExt CreateControlPanelItem( )
        {
            try
            {
                var _name = MenuOption.ControlPanel.ToString( );
                var _caption = _name.SplitPascal( );
                var _item = new ToolStripMenuItemExt( );
                _item.TextAlign = ContentAlignment.MiddleCenter;
                _item.Font = new Font( "Roboto", 9 );
                _item.Name = _name;
                _item.Size = new Size( 198, 24 );
                _item.BackColor = Color.FromArgb( 45, 45, 45 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = $"{_caption}";
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
        /// Creates the task manager option.
        /// </summary>
        /// <returns>
        /// </returns>
        private ToolStripMenuItemExt CreateTaskManagerItem( )
        {
            try
            {
                var _name = MenuOption.TaskManager.ToString( );
                var _caption = _name.SplitPascal( );
                var _item = new ToolStripMenuItemExt( );
                _item.TextAlign = ContentAlignment.MiddleCenter;
                _item.Font = new Font( "Roboto", 9 );
                _item.Name = _name;
                _item.Size = new Size( 198, 24 );
                _item.BackColor = Color.FromArgb( 45, 45, 45 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = $"{_caption}";
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
        /// Creates the windows calculator option.
        /// </summary>
        /// <returns></returns>
        private ToolStripMenuItemExt CreateWindowsCalculatorItem( )
        {
            try
            {
                var _name = MenuOption.WindowsCalculator.ToString( );
                var _caption = _name.SplitPascal( );
                var _item = new ToolStripMenuItemExt( );
                _item.TextAlign = ContentAlignment.MiddleCenter;
                _item.Font = new Font( "Roboto", 9 );
                _item.Name = _name;
                _item.Size = new Size( 198, 24 );
                _item.BackColor = Color.FromArgb( 45, 45, 45 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = $"{_caption}";
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
        /// Creates the one drive option.
        /// </summary>
        /// <returns></returns>
        private ToolStripMenuItemExt CreateOneDriveItem( )
        {
            try
            {
                var _name = MenuOption.OneDrive.ToString( );
                var _caption = _name.SplitPascal( );
                var _item = new ToolStripMenuItemExt( );
                _item.TextAlign = ContentAlignment.MiddleCenter;
                _item.Font = new Font( "Roboto", 9 );
                _item.Name = _name;
                _item.Size = new Size( 198, 24 );
                _item.BackColor = Color.FromArgb( 45, 45, 45 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = $"{_caption}";
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
        /// Creates the maps option.
        /// </summary>
        /// <returns></returns>
        private ToolStripMenuItemExt CreateMapsItem( )
        {
            try
            {
                var _name = MenuOption.WindowsMaps.ToString( );
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
        /// Creates the close option.
        /// </summary>
        /// <returns>
        /// ToolStripMenuItemExt
        /// </returns>
        private ToolStripMenuItemExt CreateWindowsClockItem( )
        {
            try
            {
                var _name = MenuOption.WindowsClock.ToString( );
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
        /// Creates the windows media player option.
        /// </summary>
        /// <returns></returns>
        private protected ToolStripMenuItemExt CreateWindowsMediaPlayerItem( )
        {
            try
            {
                var _name = MenuOption.MediaPlayer.ToString( );
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
    }
}