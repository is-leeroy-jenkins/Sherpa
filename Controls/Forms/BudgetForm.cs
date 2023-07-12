// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="BudgetForm.cs" company="Terry D. Eppler">
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
//   BudgetForm.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Specialized;
    using System.Configuration;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class BudgetForm
    {
        /// <summary> Gets or sets the state of the minimized. </summary>
        /// <value> The state of the minimized. </value>
        public static FormWindowState MinimizedState { get; set; } = FormWindowState.Minimized;

        /// <summary> Gets or sets the state of the normal. </summary>
        /// <value> The state of the normal. </value>
        public static FormWindowState NormalState { get; set; } = FormWindowState.Normal;

        /// <summary> Gets or sets the state of the maximized. </summary>
        /// <value> The state of the maximized. </value>
        public static FormWindowState MaximizedState { get; set; } = FormWindowState.Maximized;

        /// <summary> Gets or sets the form centered. </summary>
        /// <value> The form centered. </value>
        public static FormStartPosition FormCentered { get; set; } = FormStartPosition.CenterScreen;

        /// <summary> Gets or sets the default location. </summary>
        /// <value> The default location. </value>
        public static FormStartPosition DefaultLocation { get; set; } = FormStartPosition.WindowsDefaultLocation;

        /// <summary> Gets or sets the form. </summary>
        /// <value> The form. </value>
        public MetroForm Form { get; set; }

        /// <summary> Gets or sets the tag. </summary>
        /// <value> The tag. </value>
        public object Tag { get; set; }

        /// <summary> Gets or sets the size. </summary>
        /// <value> The size. </value>
        public Size Size { get; set; }

        /// <summary> Gets or sets the field. </summary>
        /// <value> The field. </value>
        public Field Field { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is visible.
        /// </summary>
        /// <value>
        /// <c> true </c>
        /// if this instance is visible; otherwise,
        /// <c> false </c>
        /// .
        /// </value>
        public static bool IsVisible { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether this instance is enabled.
        /// </summary>
        /// <value>
        /// <c> true </c>
        /// if this instance is enabled; otherwise,
        /// <c> false </c>
        /// .
        /// </value>
        public static bool IsEnabled { get; set; } = true;

        /// <summary> Gets the budget execution icon. </summary>
        /// <value> The budget execution icon. </value>
        public static NameValueCollection AppSetting { get; set; } = ConfigurationManager.AppSettings;

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetForm"/>
        /// class.
        /// </summary>
        public BudgetForm( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetForm"/>
        /// class.
        /// </summary>
        /// <param name="form"> The form. </param>
        public BudgetForm( MetroForm form )
        {
            Form = form;
        }

        /// <summary> The caption height </summary>
        public static int CaptionHeight = 26;

        /// <summary> The start position </summary>
        public static FormStartPosition StartPosition = FormStartPosition.CenterScreen;

        /// <summary> Gets the field. </summary>
        /// <param name="field"> The field. </param>
        /// <returns> </returns>
        public static Field GetField( Field field )
        {
            if( Enum.IsDefined( typeof( Field ), field ) )
            {
                try
                {
                    return field;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( Field );
                }
            }

            return default( Field );
        }

        /// <summary> Get ErrorDialog Dialog. </summary>
        /// <param name="ex"> The ex. </param>
        private protected static void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}