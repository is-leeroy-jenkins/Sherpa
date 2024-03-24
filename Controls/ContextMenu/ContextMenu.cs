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

    /// <inheritdoc />
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class ContextMenu : ContextBase
    {
        /// <summary>
        /// Gets or sets the file option.
        /// </summary>
        /// <value>
        /// The file option.
        /// </value>
        public ToolStripMenuItemExt FileOption
        {
            get
            {
                return _fileOption;
            }
            private protected set
            {
                _fileOption = value;
            }
        }

        /// <summary>
        /// Gets or sets the folder option.
        /// </summary>
        /// <value>
        /// The folder option.
        /// </value>
        public ToolStripMenuItemExt FolderOption
        {
            get
            {
                return _folderOption;
            }
            private protected set
            {
                _folderOption = value;
            }
        }

        /// <summary>
        /// Gets or sets the calculator option.
        /// </summary>
        /// <value>
        /// The calculator option.
        /// </value>
        public ToolStripMenuItemExt BudgetCalculatorOption
        {
            get
            {
                return _budgetCalculatorOption;
            }
            private protected set
            {
                _budgetCalculatorOption = value;
            }
        }

        /// <summary>
        /// Gets or sets the Calendar option.
        /// </summary>
        /// <value>
        /// The file option.
        /// </value>
        public ToolStripMenuItemExt CalendarOption
        {
            get
            {
                return _calendarOption;
            }
            private protected set
            {
                _calendarOption = value;
            }
        }

        /// <summary>
        /// Gets the task manager option.
        /// </summary>
        /// <value>
        /// The task manager option.
        /// </value>
        public ToolStripMenuItemExt TaskManagerOption
        {
            get
            {
                return _taskManagerOption;
            }
            private protected set
            {
                _taskManagerOption = value;
            }
        }

        /// <summary>
        /// Gets the control panel option.
        /// </summary>
        /// <value>
        /// The control panel option.
        /// </value>
        public ToolStripMenuItemExt ControlPanelOption
        {
            get
            {
                return _controlPanelOption;
            }
            private protected set
            {
                _controlPanelOption = value;
            }
        }

        /// <summary>
        /// Gets the windows calculator option.
        /// </summary>
        /// <value>
        /// The windows calculator option.
        /// </value>
        public ToolStripMenuItemExt WindowsCalculatorOption
        {
            get
            {
                return _windowsCalculatorOption;
            }
            private protected set
            {
                _windowsCalculatorOption = value;
            }
        }

        /// <summary>
        /// Gets or sets the Guidance option.
        /// </summary>
        /// <value>
        /// The file option.
        /// </value>
        public ToolStripMenuItemExt GuidanceOption
        {
            get
            {
                return _guidanceOption;
            }
            private protected set
            {
                _guidanceOption = value;
            }
        }

        /// <summary>
        /// Gets or sets the save option.
        /// </summary>
        /// <value>
        /// The save option.
        /// </value>
        public ToolStripMenuItemExt SaveOption
        {
            get
            {
                return _saveOption;
            }
            private protected set
            {
                _saveOption = value;
            }
        }

        /// <summary>
        /// Gets or sets the close option.
        /// </summary>
        /// <value>
        /// The close option.
        /// </value>
        public ToolStripMenuItemExt CloseOption
        {
            get
            {
                return _closeOption;
            }
            private protected set
            {
                _closeOption = value;
            }
        }

        /// <summary>
        /// Gets or sets the exit option.
        /// </summary>
        /// <value>
        /// The exit option.
        /// </value>
        public ToolStripMenuItemExt ExitOption
        {
            get
            {
                return _exitOption;
            }
            private protected set
            {
                _exitOption = value;
            }
        }

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
            Style = ContextMenuStyle.Office2016Black;
            ThemeStyle.BackColor = Color.FromArgb( 45, 45, 45 );
            ThemeStyle.ForeColor = Color.FromArgb( 106, 189, 252 );
            ThemeStyle.DisabledForeColor = Color.FromArgb( 45, 45, 45 );
            ThemeStyle.HoverBackColor = Color.FromArgb( 0, 120, 212 );
            ThemeStyle.HoverForeColor = Color.White;
            ThemeStyle.PressedForeColor = Color.Black;
            ThemeStyle.PressedBackColor = Color.FromArgb( 204, 204, 204 );
            ThemeStyle.BorderColor = Color.FromArgb( 77, 77, 77 );

            // Menu Items
            _fileOption = CreateFileOption( );
            _folderOption = CreateFolderOption( );
            _budgetCalculatorOption = CreateBudgetCalculatorOption( );
            _calendarOption = CreateCalendarOption( );
            _controlPanelOption = CreateControlPanelOption( );
            _taskManagerOption = CreateTaskManagerOption( );
            _guidanceOption = CreateGuidanceOption( );
            _saveOption = CreateSaveOption( );
            _closeOption = CreateCloseOption( );
            _exitOption = CreateExitOption( );
        }
    }
}