//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                TextBox.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="TextBox.cs" company="Terry D. Eppler">
// 
//     This is a Federal Budget, Finance, and Accounting application for the
//     US Environmental Protection Agency (US EPA).
//     Copyright ©  2023  Terry Eppler
// 
//     Permission is hereby granted, free of charge, to any person obtaining a copy
//     of this software and associated documentation files (the “Software”),
//     to deal in the Software without restriction,
//     including without limitation the rights to use,
//     copy, modify, merge, publish, distribute, sublicense,
//     and/or sell copies of the Software,
//     and to permit persons to whom the Software is furnished to do so,
//     subject to the following conditions:
// 
//     The above copyright notice and this permission notice shall be included in all
//     copies or substantial portions of the Software.
// 
//     THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//     INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//     FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT.
//     IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//     DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//     ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//     DEALINGS IN THE SOFTWARE.
// 
//     You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// 
//  </copyright>
//  <summary>
//    TextBox.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using MetroSet_UI.Controls;
    using MetroSet_UI.Enums;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="MetroSet_UI.Controls.MetroSetTextBox" />
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "UnusedVariable" ) ]
    [ SuppressMessage( "ReSharper", "ConvertIfStatementToSwitchStatement" ) ]
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    public class TextBox : MetroSetTextBox
    {
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public SmallTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public string HoverText { get; set; }

        /// <summary>
        /// Gets or sets the length of the selection.
        /// </summary>
        /// <value>
        /// The length of the selection.
        /// </value>
        public int SelectionLength { get; set; }

        /// <summary>
        /// Gets or sets the data filter.
        /// </summary>
        /// <value>
        /// The data filter.
        /// </value>
        public IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextBox"/> class.
        /// </summary>
        public TextBox( )
        {
            // Basic Properties
            Style = Style.Custom;
            ThemeAuthor = "Terry D. Eppler";
            ThemeName = "Budget Execution";
            BackColor = Color.FromArgb( 40, 40, 40 );
            ForeColor = Color.White;
            BorderColor = Color.FromArgb( 50, 93, 129 );
            Font = new Font( "Roboto", 8 );
            HoverColor = Color.FromArgb( 0, 120, 212 );
            TextAlign = HorizontalAlignment.Left;
            SelectionLength = Text.Length;

            // Disabled Color Configuration
            DisabledBackColor = Color.Transparent;
            DisabledBorderColor = Color.Transparent;
            DisabledForeColor = Color.Transparent;

            // Wire Events
            MouseDown += OnMouseDown;
        }

        /// <summary> Called when [text box mouse enter]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public virtual void OnMouseDown( object sender, MouseEventArgs e )
        {
            if( !string.IsNullOrEmpty( Text )
               && e.Button == MouseButtons.Left )
            {
                try
                {
                    if( Text.Length >= 24 )
                    {
                        var _textDialog = new TextDialog( Text );
                        _textDialog.ShowDialog( );
                        Text = _textDialog.Editor.Text;
                    }
                    else if( Text.Length >= 6
                            && Text.Length <= 9
                            && Text.Substring( 0, 3 ) == "000" )
                    {
                        var _code = Text.Substring( 4, 2 );
                        var _dialog = new ProgramProjectDialog( _code );
                        _dialog.Location = new Point( e.X, e.Y );
                        _dialog.ShowDialog( );
                    }
                    else if( double.TryParse( Text, out var _double ) )
                    {
                        var _value = double.Parse( Text );
                        var _form = new CalculationForm( _value );
                        _form.Location = new Point( e.X, e.Y );
                        _form.ShowDialog( );
                        Text = _form.Calculator.Value.ToString( );
                    }
                    else if( decimal.TryParse( Text, out var _decimal ) )
                    {
                        var _decimalValue = double.Parse( Text );
                        var _form = new CalculationForm( _decimalValue );
                        _form.Location = new Point( e.X, e.Y );
                        _form.ShowDialog( );
                        Text = _form.Calculator.Value.ToString( );
                    }
                    else if( DateTime.TryParse( Text, out var _dateTime ) )
                    {
                        var _dateTimeValue = DateTime.Parse( Text );
                        var _form = new CalendarDialog( _dateTimeValue );
                        _form.Location = new Point( e.X, e.Y );
                        _form.ShowDialog( );
                        Text = _form.DateString;
                    }
                    else if( DateTime.TryParse( Text, out var _dateOnly ) )
                    {
                        var _dateOnlyValue = DateTime.Parse( Text );
                        var _form = new CalendarDialog( _dateOnlyValue );
                        _form.Location = new Point( e.X, e.Y );
                        _form.ShowDialog( );
                        Text = _form.DateString;
                    }
                    else
                    {
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
        /// <param name="ex">The ex.</param>
        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}