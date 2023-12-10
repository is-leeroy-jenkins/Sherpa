// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 12-10-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        12-10-2023
// ******************************************************************************************
// <copyright file="SizeConfig.cs" company="Terry D. Eppler">
//    Budget Execution is a Federal Budget, Finance, and Accounting application
//    for the US Environmental Protection Agency (US EPA).
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
//    Contact at:   terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   SizeConfig.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Drawing;

    public class SizeConfig
    {
        /// <summary> Gets or sets the size of the client. </summary>
        /// <value> The size of the client. </value>
        public Size ClientSize { get; set; }

        /// <summary> Gets or sets the bounds. </summary>
        /// <value> The bounds. </value>
        public Size Bounds { get; set; }

        /// <summary> Gets or sets the height. </summary>
        /// <value> The height. </value>
        public int Height { get; set; }

        /// <summary> Gets or sets the width. </summary>
        /// <value> The width. </value>
        public int Width { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SizeConfig"/>
        /// class.
        /// </summary>
        public SizeConfig( )
        {
        }

        /// <summary> The form normal </summary>
        public static readonly Size FormNormal = new Size( 1200, 750 );

        /// <summary> The form maximum </summary>
        public static readonly Size FormMaximum = new Size( 1500, 820 );

        /// <summary> The form minimum </summary>
        public static readonly Size FormMinimum = new Size( 600, 400 );

        /// <summary> The dialog normal </summary>
        public static readonly Size DialogNormal = new Size( 680, 530 );

        /// <summary> The dialog minimum </summary>
        public static readonly Size DialogMinimum = new Size( 300, 300 );

        /// <summary> The dialog maximum </summary>
        public static readonly Size DialogMaximum = new Size( 800, 800 );

        /// <summary> The context menu normal </summary>
        public static readonly Size ContextMenuNormal = new Size( 250, 350 );

        /// <summary> The image small </summary>
        public static readonly Size ImageSmall = new Size( 12, 12 );

        /// <summary> The image medium </summary>
        public static readonly Size ImageMedium = new Size( 16, 16 );

        /// <summary> The image large </summary>
        public static readonly Size ImageLarge = new Size( 20, 20 );

        /// <summary> The image huge </summary>
        public static readonly Size ImageHuge = new Size( 250, 250 );

        /// <summary> Gets the size. </summary>
        /// <param name="width"> The width. </param>
        /// <param name="height"> The height. </param>
        /// <returns> </returns>
        public Size GetSize( int width = 1, int height = 1 )
        {
            try
            {
                return ( width > 0 ) && ( height > 0 )
                    ? new Size( width, height )
                    : Size.Empty;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( Size );
            }
        }

        /// <summary> Gets the size. </summary>
        /// <param name="size"> The size. </param>
        /// <returns> </returns>
        public Size GetSize( Size size )
        {
            if( ( size.Width > -1 )
               && ( size.Height > -1 ) )
            {
                try
                {
                    return size;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }

            return default( Size );
        }

        /// <summary> Called when [size changed]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnSizeChanged( object sender, EventArgs e )
        {
            if( ( sender != null )
               && ( e != null ) )
            {
                try
                {
                    var _message = new MessageDialog( "NOT YET IMPLEMENTED" );
                    _message?.ShowDialog( );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary> Fails the specified ex. </summary>
        /// <param name="ex"> The ex. </param>
        private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}