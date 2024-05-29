// ******************************************************************************************
//     Assembly:             Sherpa
//     Author:                  Terry D. Eppler
//     Created:                 06-19-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        11-24-2023
// ******************************************************************************************
// <copyright file="Terry Eppler.cs" company="Terry D. Eppler">
//    Sherpa is a Federal Budget, Finance, and Accounting application for the
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
//   ToolStripButton.cs.cs
// </summary>
// ******************************************************************************************

namespace Sherpa
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using static System.Configuration.ConfigurationManager;

    /// <inheritdoc/>
    /// <summary> </summary>
    [ Serializable ]
    [ SuppressMessage( "ReSharper", "MergeConditionalExpression" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeRedundantParentheses" ) ]
    public class ToolStripButton : ToolButtonBase
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ToolStripButton"/>
        /// class.
        /// </summary>
        public ToolStripButton( )
        {
            // Basic Properties
            Margin = new Padding( 3 );
            Padding = new Padding( 1 );
            DisplayStyle = ToolStripItemDisplayStyle.Image;
            BackColor = Color.FromArgb( 45, 45, 45 );
            ForeColor = Color.FromArgb( 106, 189, 252 );
            Font = new Font( "Roboto", 9 );
            AutoToolTip = false;
            Text = string.Empty;
            Size = new Size( 30, 22 );

            // Event Wiring
            MouseHover += OnMouseHover;
            MouseLeave += OnMouseLeave;
            Click += OnClick;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance Mof the
        /// <see cref="T:Sherpa.ToolStripButton" />
        /// class.
        /// </summary>
        /// <param name="toolType"> The tool. </param>
        public ToolStripButton( ToolType toolType )
            : this( )
        {
            ToolType = toolType;
            Name = toolType.ToString( );
            HoverText = GetHoverText( toolType );
            Tag = HoverText;
            Image = GetImage( toolType );
            Click += OnClick;
        }

        /// <inheritdoc/>
        /// <summary> </summary>
        /// <param name="toolType"> </param>
        /// <param name="bindingSource"> </param>
        public ToolStripButton( ToolType toolType, BindingSource bindingSource )
            : this( toolType )
        {
            BindingSource = bindingSource;
        }

        /// <inheritdoc/>
        /// <summary> Sets the button image. </summary>
        /// <returns> </returns>
        public Image GetImage( ToolType toolType )
        {
            if( Enum.IsDefined( typeof( ToolType ), toolType ) )
            {
                try
                {
                    var _path = AppSettings[ "ToolStripImages" ] + @$"\{toolType}.png";
                    if( File.Exists( _path ) )
                    {
                        using var _stream = File.Open( _path, FileMode.Open );
                        var _image = Image.FromStream( _stream );
                        return ( _image != null )
                            ? _image
                            : default( Image );
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( Image );
                }
            }

            return default( Image );
        }

        /// <inheritdoc/>
        /// <summary> Called when [mouse over]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="T:System.EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnMouseHover( object sender, EventArgs e )
        {
            try
            {
                var _button = sender as ToolStripButton;
                if( ( _button != null )
                   && !string.IsNullOrEmpty( HoverText ) )
                {
                    _button.Tag = HoverText;
                    var _tip = new SmallTip( _button );
                    ToolTip = _tip;
                }
                else
                {
                    if( !string.IsNullOrEmpty( Tag?.ToString( ) ) )
                    {
                        var _tool = new SmallTip( _button );
                        ToolTip = _tool;
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <inheritdoc/>
        /// <summary> Called when [mouse leave]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="T:System.EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnMouseLeave( object sender, EventArgs e )
        {
            try
            {
                if( ToolTip?.Active == true )
                {
                    ToolTip.RemoveAll( );
                    ToolTip = null;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <inheritdoc/>
        /// <summary> Called when [click]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="T:System.EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public virtual void OnClick( object sender, EventArgs e )
        {
            if( sender is ToolStripButton _button )
            {
                try
                {
                    switch( _button?.ToolType )
                    {
                        case ToolType.FirstButton:
                        {
                            BindingSource?.MoveFirst( );
                            break;
                        }
                        case ToolType.PreviousButton:
                        {
                            BindingSource?.MovePrevious( );
                            break;
                        }
                        case ToolType.NextButton:
                        {
                            BindingSource?.MoveNext( );
                            break;
                        }
                        case ToolType.LastButton:
                        {
                            BindingSource?.MoveLast( );
                            break;
                        }
                        case ToolType.InsertButton:
                        case ToolType.UpdateButton:
                        {
                            var _dialog = new SqlPage( );
                            _dialog?.ShowDialog( );
                            break;
                        }
                        case ToolType.CalculatorButton:
                        {
                            var _calculator = new CalculationForm( );
                            _calculator?.ShowDialog( );
                            break;
                        }
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the image.
        /// </summary>
        public void SetImage( )
        {
            if( Enum.IsDefined( typeof( ToolType ), ToolType ) )
            {
                try
                {
                    var _path = AppSettings[ nameof( ToolStrip ) ] + $"{ToolType}.png";
                    using var _stream = File.Open( _path, FileMode.Open );
                    if( _stream != null )
                    {
                        var _image = Image.FromStream( _stream );
                        Image = _image;
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }
    }
}