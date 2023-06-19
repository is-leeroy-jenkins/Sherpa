// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="Editor.cs" company="Terry D. Eppler">
//    This is a Federal Budget, Finance, and Accounting application for the
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
//    You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   Editor.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Edit;

    /// <summary> </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.Edit.EditControl"/>
    public class Editor : EditControl
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Editor"/>
        /// class.
        /// </summary>
        public Editor( )
        {
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Dock = DockStyle.None;
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            AlwaysShowScrollers = true;
            BackColor = SystemColors.ControlLight;
            ForeColor = Color.Black;
            BackgroundColor = new BrushInfo( SystemColors.ControlLight );
            BorderStyle = BorderStyle.FixedSingle;
            CanOverrideStyle = true;
            CanApplyTheme = true;
            ColumnGuidesMeasuringFont = new Font( "Roboto", 8 );
            ContextChoiceFont = new Font( "Roboto", 8 );
            ContextChoiceForeColor = Color.Black;
            ContextChoiceBackColor = SystemColors.ControlLight;
            ContextPromptBorderColor = Color.FromArgb( 0, 120, 212 );
            ContextPromptBackgroundBrush = new BrushInfo( Color.FromArgb( 233, 166, 50 ) );
            ContextTooltipBackgroundBrush = new BrushInfo( Color.FromArgb( 233, 166, 50 ) );
            ContextTooltipBorderColor = Color.FromArgb( 0, 120, 212 );
            EndOfLineBackColor = SystemColors.ControlLight;
            EndOfLineForeColor = SystemColors.ControlLight;
            HighlightCurrentLine = true;
            IndentationBlockBorderColor = Color.FromArgb( 0, 120, 212 );
            IndentLineColor = Color.FromArgb( 50, 93, 129 );
            IndicatorMarginBackColor = SystemColors.ActiveCaption;
            CurrentLineHighlightColor = Color.FromArgb( 0, 120, 212 );
            Font = new Font( "Roboto", 10 );
            LineNumbersColor = Color.Black;
            LineNumbersFont = new Font( "Roboto", 8, FontStyle.Bold );
            ScrollVisualStyle = ScrollBarCustomDrawStyles.Office2016;
            ScrollColorScheme = Office2007ColorScheme.Black;
            SelectionTextColor = Color.White;
            ShowEndOfLine = false;
            Style = EditControlStyle.Office2016Black;
            TabSize = 4;
            TextAreaWidth = 400;
            WordWrap = true;
            WordWrapColumn = 100;
        }
    }
}