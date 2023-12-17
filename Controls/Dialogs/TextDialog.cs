//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                TextDialog.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="TextDialog.cs" company="Terry D. Eppler">
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
//    TextDialog.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Edit;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    public partial class TextDialog : MetroForm
    {
        /// <summary>
        /// The status update
        /// </summary>
        private Action _statusUpdate;

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.TextDialog" /> class.
        /// </summary>
        public TextDialog( )
        {
            InitializeComponent( );
            InitializeDelegates( );
            RegisterCallbacks();

            // General Properties
            Size = new System.Drawing.Size( 650, 250 );
            MinimumSize = new System.Drawing.Size( 650, 250 );
            MaximumSize = new System.Drawing.Size( 650, 250 );
            BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BorderThickness = 1;
            BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            StartPosition = FormStartPosition.CenterScreen;
            CaptionBarHeight = 5;
            CaptionForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionButtonColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ShowMouseOver = false;
            MinimizeBox = false;
            MaximizeBox = false;
            Enabled = true;

            // Wire Events
            Load += OnLoad;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.TextDialog" />
        /// class.
        /// </summary>
        /// <param name="text">
        /// The text displayed by the control.
        /// </param>
        public TextDialog( string text )
            : this( )
        {
            Editor.Text = text;
        }

        /// <summary>
        /// Initializes the labels.
        /// </summary>
        private void InitializeLabels( )
        {
            try
            {
                Title.Font = new System.Drawing.Font( "Roboto", 9, System.Drawing.FontStyle.Bold );
                Title.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
                Title.TextAlign = ContentAlignment.TopLeft;
                Title.Text = "Text Editor";
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the delegates.
        /// </summary>
        private void InitializeDelegates( )
        {
            try
            {
                _statusUpdate += UpdateStatusLabel;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the callback.
        /// </summary>
        private void RegisterCallbacks()
        {
            try
            {
                CloseButton.Click += OnCloseButtonClick;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the timers.
        /// </summary>
        private void InitializeTimers( )
        {
            try
            {
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the buttons.
        /// </summary>
        private void InitializeButtons( )
        {
            try
            {
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the tool strip.
        /// </summary>
        private void InitializeToolStrip( )
        {
            try
            {
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Invokes if needed.
        /// </summary>
        /// <param name="action">
        /// The action.
        /// </param>
        public void InvokeIf( Action action )
        {
            if( InvokeRequired )
            {
                BeginInvoke( action );
            }
            else
            {
                action.Invoke( );
            }
        }

        /// <summary>
        /// Sets the editor configuration.
        /// </summary>
        private void SetEditorConfiguration( )
        {
            try
            {
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the editor.
        /// </summary>
        private void InitializeEditor( )
        {
            try
            {
                Editor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                Editor.AlwaysShowScrollers = true;
                Editor.BackColor = System.Drawing.SystemColors.ControlLight;
                Editor.ForeColor = System.Drawing.Color.Black;
                Editor.BackgroundColor = new BrushInfo( System.Drawing.SystemColors.ControlLight );
                Editor.BorderStyle = BorderStyle.FixedSingle;
                Editor.CanOverrideStyle = true;
                Editor.CanApplyTheme = true;
                Editor.ColumnGuidesMeasuringFont = new System.Drawing.Font( "Roboto", 8 );
                Editor.ContextChoiceFont = new System.Drawing.Font( "Roboto", 8 );
                Editor.ContextChoiceForeColor = System.Drawing.Color.Black;
                Editor.ContextChoiceBackColor = System.Drawing.SystemColors.ControlLight;
                Editor.ContextPromptBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
                Editor.ContextPromptBackgroundBrush =
                    new BrushInfo( System.Drawing.Color.FromArgb( 233, 166, 50 ) );

                Editor.ContextTooltipBackgroundBrush =
                    new BrushInfo( System.Drawing.Color.FromArgb( 233, 166, 50 ) );

                Editor.ContextTooltipBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
                Editor.EndOfLineBackColor = System.Drawing.SystemColors.ControlLight;
                Editor.EndOfLineForeColor = System.Drawing.SystemColors.ControlLight;
                Editor.HighlightCurrentLine = true;
                Editor.IndentationBlockBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
                Editor.IndentLineColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
                Editor.IndicatorMarginBackColor = System.Drawing.SystemColors.ControlLight;
                Editor.CurrentLineHighlightColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
                Editor.Font = new System.Drawing.Font( "Roboto", 12 );
                Editor.LineNumbersColor = System.Drawing.Color.Black;
                Editor.LineNumbersFont 
                    = new System.Drawing.Font( "Roboto", 8, System.Drawing.FontStyle.Bold );
                Editor.ScrollVisualStyle = ScrollBarCustomDrawStyles.Office2016;
                Editor.ScrollColorScheme = Office2007ColorScheme.Black;
                Editor.SelectionTextColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
                Editor.ShowEndOfLine = false;
                Editor.Style = EditControlStyle.Office2016Black;
                Editor.TabSize = 4;
                Editor.TextAreaWidth = 400;
                Editor.WordWrap = true;
                Editor.WordWrapColumn = 100;
                Editor.Dock = DockStyle.None;
                Editor.Anchor = AnchorStyles.Top
                    | AnchorStyles.Bottom
                    | AnchorStyles.Left
                    | AnchorStyles.Right;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Updates the status.
        /// </summary>
        private void UpdateStatusLabel( )
        {
            try
            {
                var _dateTime = DateTime.Now;
                var _dateString = _dateTime.ToLongDateString( );
                var _timeString = _dateTime.ToLongTimeString( );
                //StatusLabel.Text = _dateString + "  " + _timeString;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Called when [load]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnLoad( object sender, EventArgs e )
        {
            try
            {
                InitializeEditor( );
                InitializeLabels( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Called when [close button clicked]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public virtual void OnCloseButtonClick( object sender, EventArgs e )
        {
            if( sender is Button _button
               && !string.IsNullOrEmpty( _button?.Name ) )
            {
                try
                {
                    Close( );
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
        private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}