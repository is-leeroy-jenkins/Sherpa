// ******************************************************************************************
//     ASSEMBLY:                BUDGET EXECUTION
//     AUTHOR:                  TERRY D. EPPLER
//     CREATED:                 03-24-2023
// 
//     LAST MODIFIED BY:        TERRY D. EPPLER
//     LAST MODIFIED ON:        05-31-2023
// ******************************************************************************************
// <COPYRIGHT FILE="COLORCONFIG.CS" COMPANY="TERRY D. EPPLER">
//    THIS IS A FEDERAL BUDGET, FINANCE, AND ACCOUNTING APPLICATION FOR THE
//    US ENVIRONMENTAL PROTECTION AGENCY (US EPA).
//    COPYRIGHT ©  2023  TERRY EPPLER
// 
//    PERMISSION IS HEREBY GRANTED, FREE OF CHARGE, TO ANY PERSON OBTAINING A COPY
//    OF THIS SOFTWARE AND ASSOCIATED DOCUMENTATION FILES (THE “SOFTWARE”),
//    TO DEAL IN THE SOFTWARE WITHOUT RESTRICTION,
//    INCLUDING WITHOUT LIMITATION THE RIGHTS TO USE,
//    COPY, MODIFY, MERGE, PUBLISH, DISTRIBUTE, SUBLICENSE,
//    AND/OR SELL COPIES OF THE SOFTWARE,
//    AND TO PERMIT PERSONS TO WHOM THE SOFTWARE IS FURNISHED TO DO SO,
//    SUBJECT TO THE FOLLOWING CONDITIONS:
// 
//    THE ABOVE COPYRIGHT NOTICE AND THIS PERMISSION NOTICE SHALL BE INCLUDED IN ALL
//    COPIES OR SUBSTANTIAL PORTIONS OF THE SOFTWARE.
// 
//    THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//    INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//    FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT.
//    IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//    DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//    ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//    DEALINGS IN THE SOFTWARE.
// 
//    YOU CAN CONTACT ME AT:   TERRYEPPLER@GMAIL.COM OR EPPLER.TERRY@EPA.GOV
// </COPYRIGHT>
// <SUMMARY>
//   COLORCONFIG.CS
// </SUMMARY>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;

    /// <summary>
    /// 
    /// </summary>
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class ColorConfig
    {
        /// <summary>
        /// Gets the blue.
        /// </summary>
        /// <value>
        /// The blue.
        /// </value>
        public Color Blue { get; }

        /// <summary>
        /// Gets the red.
        /// </summary>
        /// <value>
        /// The red.
        /// </value>
        public Color Red { get; }

        /// <summary>
        /// Gets the gray.
        /// </summary>
        /// <value>
        /// The gray.
        /// </value>
        public Color Gray { get; }

        /// <summary>
        /// Gets the white.
        /// </summary>
        /// <value>
        /// The white.
        /// </value>
        public Color White { get; }

        /// <summary>
        /// Gets the black.
        /// </summary>
        /// <value>
        /// The black.
        /// </value>
        public Color Black { get; }

        /// <summary>
        /// Gets the transparent.
        /// </summary>
        /// <value>
        /// The transparent.
        /// </value>
        public Color Transparent { get; }

        /// <summary>
        /// Gets the hover gray.
        /// </summary>
        /// <value>
        /// The hover gray.
        /// </value>
        public Color HoverGray { get; }

        /// <summary>
        /// Gets the hover blue.
        /// </summary>
        /// <value>
        /// The hover blue.
        /// </value>
        public Color HoverBlue { get; }

        /// <summary>
        /// Gets the steel blue.
        /// </summary>
        /// <value>
        /// The steel blue.
        /// </value>
        public Color SteelBlue { get; }

        /// <summary>
        /// Gets the maroon.
        /// </summary>
        /// <value>
        /// The maroon.
        /// </value>
        public Color Maroon { get; }

        /// <summary>
        /// Gets the light steel blue.
        /// </summary>
        /// <value>
        /// The light steel blue.
        /// </value>
        public Color LightSteelBlue { get; }

        /// <summary>
        /// Gets the dark interior.
        /// </summary>
        /// <value>
        /// The dark interior.
        /// </value>
        public Color DarkInterior { get; }

        /// <summary>
        /// Gets the dark border.
        /// </summary>
        /// <value>
        /// The dark border.
        /// </value>
        public Color DarkBorder { get; }

        /// <summary>
        /// Gets the dark background.
        /// </summary>
        /// <value>
        /// The dark background.
        /// </value>
        public Color DarkBackground { get; }

        /// <summary>
        /// Gets the dark blue.
        /// </summary>
        /// <value>
        /// The dark blue.
        /// </value>
        public Color DarkBlue { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColorConfig"/> class.
        /// </summary>
        public ColorConfig( )
        {
            Blue = Color.FromArgb( 0, 120, 212 );
            HoverBlue = Color.FromArgb( 50, 93, 129 );
            Transparent = Color.Transparent;
            HoverGray = Color.FromArgb( 70, 70, 70 );
            DarkInterior = Color.FromArgb( 40, 40, 40 );
            Black = Color.Black;
            White = Color.White;
            Red = Color.FromArgb( 192, 0, 0 );
            DarkBorder = Color.FromArgb( 65, 65, 65 );
            DarkBackground = Color.FromArgb( 20, 20, 20 );
            DarkBlue = Color.FromArgb( 24, 47, 66 );
            Gray = Color.DarkGray;
            SteelBlue = Color.SteelBlue;
            Maroon = Color.Maroon;
            LightSteelBlue = Color.LightSteelBlue;
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