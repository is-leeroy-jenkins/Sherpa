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
    using System.Windows.Forms;
    using MetroSet_UI.Child;
    using MetroSet_UI.Enums;
    using OpenTK.Platform.Windows;
    
    /// <inheritdoc />
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "RedundantBaseConstructorCall" ) ]
    public class ContextMenu : BasicMenu
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.ContextMenu" /> class.
        /// </summary>
        public ContextMenu( ) 
            : base( )
        {
            BackColor = Color.FromArgb( 30, 30, 30 );
            BackgroundColor = Color.FromArgb( 30, 30, 30 );
            ForeColor = Color.FromArgb( 106, 189, 252 );
            ArrowColor = Color.FromArgb( 0, 120, 212 );
            SeparatorColor = Color.FromArgb( 0, 120, 212 );
            AutoSize = false;
            Size = new Size( 160, 510 );
            IsDerivedStyle = true;
            RenderMode = ToolStripRenderMode.ManagerRenderMode;
            Style = Style.Custom;
            ShowCheckMargin = false;
            ShowImageMargin = true;
            SelectedItemBackColor = Color.FromArgb( 50, 93, 129 );
            SelectedItemColor = Color.White;
            ThemeAuthor = "Terry Eppler";

            // Menu Items
            _file = CreateFileItem( );
            _save = CreateSaveItem( );
            _refresh = CreateRefreshItem( );
            _calculator = CreateCalculatorItem( );
            _calendar = CreateCalendarItem( );
            _guidance = CreateDocumentationItem( );
            _clock = CreateClockItem( );
            _maps = CreateMapsItem( );
            _controlPanel = CreateControlPanelItem( );
            _taskManager = CreateTaskManagerItem( );
            _mediaPlayer = CreateMediaPlayerItem( );
            _firefox = CreateFirefoxItem( );
            _edge = CreateEdgeItem( );
            _chrome = CreateChromeItem( );
            _exit = base.CreateExitItem( );
        }

        /// <summary>
        /// Creates the calendar item.
        /// </summary>
        /// <returns></returns>
        private protected MetroSetToolStripMenuItem CreateCalendarItem( )
        {
            try
            {
                var _name = MenuOption.Calendar.ToString( );
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.BottomCenter;
                _item.Font = new Font( "Roboto", 9 );
                _item.Name = _name;
                _item.Size = new Size( 160, 30 );
                _item.BackColor = Color.FromArgb( 30, 30, 30 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = _name.SplitPascal( );
                _item.Tag = MenuOption.Calendar.ToString( );
                _item.MouseEnter += OnMouseEnter;
                _item.MouseLeave += OnMouseLeave;
                _item.MouseDown -= null;
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
        /// Creates the documentation item.
        /// </summary>
        /// <returns></returns>
        private protected MetroSetToolStripMenuItem CreateDocumentationItem( )
        {
            try
            {
                var _name = MenuOption.Documentation.ToString( );
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.BottomCenter;
                _item.Font = new Font( "Roboto", 9 );
                _item.Name = _name;
                _item.Size = new Size( 160, 30 );
                _item.BackColor = Color.FromArgb( 30, 30, 30 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = _name.SplitPascal( );
                _item.Tag = MenuOption.Documentation.ToString( );
                _item.MouseEnter += OnMouseEnter;
                _item.MouseLeave += OnMouseLeave;
                _item.MouseDown -= null;
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
        /// Creates the control panel option.
        /// </summary>
        /// <returns></returns>
        private protected MetroSetToolStripMenuItem CreateControlPanelItem( )
        {
            try
            {
                var _name = MenuOption.ControlPanel.ToString( );
                var _caption = _name.SplitPascal( );
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.BottomCenter;
                _item.Font = new Font( "Roboto", 9 );
                _item.Name = _name;
                _item.Size = new Size( 160, 30 );
                _item.BackColor = Color.FromArgb( 30, 30, 30 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = $"{_caption}";
                _item.Tag = _name;
                _item.Checked = false;
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
        /// Creates the task manager option.
        /// </summary>
        /// <returns>
        /// </returns>
        private protected MetroSetToolStripMenuItem CreateTaskManagerItem( )
        {
            try
            {
                var _name = MenuOption.TaskManager.ToString( );
                var _caption = _name.SplitPascal( );
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.BottomCenter;
                _item.Font = new Font( "Roboto", 9 );
                _item.Name = _name;
                _item.Size = new Size( 160, 30 );
                _item.BackColor = Color.FromArgb( 30, 30, 30 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = $"{_caption}";
                _item.Tag = _name;
                _item.Checked = false;
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
        /// Creates the one drive option.
        /// </summary>
        /// <returns></returns>
        private protected MetroSetToolStripMenuItem CreateStorageItem( )
        {
            try
            {
                var _name = MenuOption.Storage.ToString( );
                var _caption = _name.SplitPascal( );
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.BottomCenter;
                _item.Font = new Font( "Roboto", 9 );
                _item.Name = _name;
                _item.Size = new Size( 160, 30 );
                _item.BackColor = Color.FromArgb( 30, 30, 30 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = $"{_caption}";
                _item.Tag = _name;
                _item.Checked = false;
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
        /// Creates the maps option.
        /// </summary>
        /// <returns></returns>
        private protected MetroSetToolStripMenuItem CreateMapsItem( )
        {
            try
            {
                var _name = MenuOption.Maps.ToString( );
                var _caption = _name.SplitPascal( );
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.BottomCenter;
                _item.Font = new Font( "Roboto", 9 );
                _item.Name = _name;
                _item.Size = new Size( 160, 30 );
                _item.BackColor = Color.FromArgb( 30, 30, 30 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = _caption;
                _item.Tag = _name;
                _item.Checked = false;
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
        /// Creates the calculator option.
        /// </summary>
        /// <returns>
        /// ToolStripMenuItemExt
        /// </returns>
        private protected MetroSetToolStripMenuItem CreateCalculatorItem( )
        {
            try
            {
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.BottomCenter;
                _item.Font = new Font( "Roboto", 9 );
                _item.Name = MenuOption.Calculator.ToString( );
                _item.Size = new Size( 160, 30 );
                _item.BackColor = Color.FromArgb( 30, 30, 30 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = $"{MenuOption.Calculator}";
                _item.Tag = MenuOption.Calculator.ToString( );
                _item.MouseEnter += OnMouseEnter;
                _item.MouseLeave += OnMouseLeave;
                _item.MouseDown -= null;
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
        /// Creates the edge option.
        /// </summary>
        /// <returns></returns>
        private protected MetroSetToolStripMenuItem CreateEdgeItem( )
        {
            try
            {
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.BottomCenter;
                _item.Font = new Font( "Roboto", 9 );
                _item.Name = MenuOption.Edge.ToString( );
                _item.Size = new Size( 160, 30 );
                _item.BackColor = Color.FromArgb( 30, 30, 30 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = $"{MenuOption.Edge}";
                _item.Tag = MenuOption.Edge.ToString( );
                _item.MouseHover += OnMouseEnter;
                _item.MouseLeave += OnMouseLeave;
                _item.MouseDown -= null;
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
        /// Creates the firefox option.
        /// </summary>
        /// <returns></returns>
        private protected MetroSetToolStripMenuItem CreateFirefoxItem( )
        {
            try
            {
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.BottomCenter;
                _item.Font = new Font( "Roboto", 9 );
                _item.Name = MenuOption.Firefox.ToString( );
                _item.Size = new Size( 160, 30 );
                _item.BackColor = Color.FromArgb( 30, 30, 30 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = $"{MenuOption.Firefox}";
                _item.Tag = MenuOption.Firefox.ToString( );
                _item.MouseHover += OnMouseEnter;
                _item.MouseLeave += OnMouseLeave;
                _item.MouseDown -= null;
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
        private protected MetroSetToolStripMenuItem CreateClockItem( )
        {
            try
            {
                var _name = MenuOption.Clock.ToString( );
                var _caption = _name.SplitPascal( );
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.BottomCenter;
                _item.Font = new Font( "Roboto", 9 );
                _item.Name = _name;
                _item.Size = new Size( 160, 30 );
                _item.BackColor = Color.FromArgb( 30, 30, 30 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = _caption;
                _item.Tag = _name;
                _item.Checked = false;
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
        /// Creates the windows media player option.
        /// </summary>
        /// <returns></returns>
        private protected MetroSetToolStripMenuItem CreateMediaPlayerItem( )
        {
            try
            {
                var _name = MenuOption.MediaPlayer.ToString( );
                var _caption = _name.SplitPascal( );
                var _item = new MetroSetToolStripMenuItem( );
                _item.TextAlign = ContentAlignment.BottomCenter;
                _item.Font = new Font( "Roboto", 9 );
                _item.Name = _name;
                _item.Size = new Size( 160, 30 );
                _item.BackColor = Color.FromArgb( 30, 30, 30 );
                _item.ForeColor = Color.FromArgb( 106, 189, 252 );
                _item.Text = _caption;
                _item.Tag = _name;
                _item.Checked = false;
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
    }
}