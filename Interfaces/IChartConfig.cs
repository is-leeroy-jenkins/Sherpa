// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="IChartConfig.cs" company="Terry D. Eppler">
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
//   IChartConfig.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System.Drawing;
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms.Chart;

    /// <summary> </summary>
    public interface IChartConfig
    {
        /// <summary> Gets or sets the color of the text. </summary>
        /// <value> The color of the text. </value>
        Color TextColor { get; set; }

        /// <summary> Gets or sets the font. </summary>
        /// <value> The font. </value>
        ChartFontInfo Font { get; set; }

        /// <summary> Gets or sets the border. </summary>
        /// <value> The border. </value>
        ChartLineInfo Border { get; set; }

        /// <summary> Gets or sets the interior. </summary>
        /// <value> The interior. </value>
        BrushInfo Interior { get; set; }

        /// <summary> Gets or sets the text. </summary>
        /// <value> The text. </value>
        string Text { get; set; }

        /// <summary> Gets or sets the tool tip. </summary>
        /// <value> The tool tip. </value>
        string ToolTip { get; set; }

        /// <summary> Gets or sets the tool tip format. </summary>
        /// <value> The tool tip format. </value>
        string ToolTipFormat { get; set; }

        /// <summary> Gets or sets the text orientation. </summary>
        /// <value> The text orientation. </value>
        ChartTextOrientation TextOrientation { get; set; }

        /// <summary> Gets or sets the shadow interior. </summary>
        /// <value> The shadow interior. </value>
        BrushInfo ShadowInterior { get; set; }

        /// <summary> Gets or sets a value indicating whether [highlight on mouse over]. </summary>
        /// <value>
        /// <c> true </c>
        /// if [highlight on mouse over]; otherwise,
        /// <c> false </c>
        /// .
        /// </value>
        bool HighlightOnMouseOver { get; set; }

        /// <summary> Gets or sets the highlight interior. </summary>
        /// <value> The highlight interior. </value>
        BrushInfo HighlightInterior { get; set; }

        /// <summary> Gets or sets the label. </summary>
        /// <value> The label. </value>
        string Label { get; set; }

        /// <summary> Gets or sets the text format. </summary>
        /// <value> The text format. </value>
        string TextFormat { get; set; }

        /// <summary> Gets or sets a value indicating whether [display text]. </summary>
        /// <value>
        /// <c> true </c>
        /// if [display text]; otherwise,
        /// <c> false </c>
        /// .
        /// </value>
        bool DisplayText { get; set; }

        /// <summary> Resets the color of the text. </summary>
        void ResetTextColor( );

        /// <summary> Resets the font. </summary>
        void ResetFont( );

        /// <summary> Resets the border. </summary>
        void ResetBorder( );

        /// <summary> Resets the interior. </summary>
        void ResetInterior( );

        /// <summary> Resets the text. </summary>
        void ResetText( );

        /// <summary> Resets the tool tip. </summary>
        void ResetToolTip( );

        /// <summary> Resets the tool tip format. </summary>
        void ResetToolTipFormat( );

        /// <summary> Resets the images. </summary>
        void ResetImages( );

        /// <summary> Resets the call-out. </summary>
        void ResetCallout( );

        /// <summary> Resets the text orientation. </summary>
        void ResetTextOrientation( );

        /// <summary> Resets the highlight interior. </summary>
        void ResetHighlightInterior( );

        /// <summary> Resets the label. </summary>
        void ResetLabel( );

        /// <summary> Resets the text format. </summary>
        void ResetTextFormat( );

        /// <summary> Resets the display text. </summary>
        void ResetDisplayText( );
    }
}