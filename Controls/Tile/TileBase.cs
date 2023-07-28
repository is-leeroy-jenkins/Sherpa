//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                TileBase.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="TileBase.cs" company="Terry D. Eppler">
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
//    TileBase.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.Tools.HubTile" />
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public abstract class TileBase : HubTile
    {
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public virtual BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public virtual SmallTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public virtual string HoverText { get; set; }

        /// <summary>
        /// Gets or sets the data filter.
        /// </summary>
        /// <value>
        /// The data filter.
        /// </value>
        public virtual IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Gets/Sets HubTile Font
        /// </summary>
        public override Font Font { get; set; }

        /// <summary>
        /// Gets or sets the color of the hover.
        /// </summary>
        /// <value>
        /// The color of the hover.
        /// </value>
        public virtual Color HoverColor { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TileBase"/> class.
        /// </summary>
        protected TileBase( )
        {
        }

        /// <summary>
        /// Sets the location.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public virtual void SetLocation( int x = 1, int y = 1 )
        {
            if( x > 0
               && y > 0 )
            {
                try
                {
                    Location = new Point( x, y );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the size.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public virtual void SetSize( int width = 140, int height = 140 )
        {
            if( width > -1
               && height > -1 )
            {
                try
                {
                    Size = new Size( width, height );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the image configuration.
        /// </summary>
        /// <param name="image">The image.</param>
        /// <param name="speed">The speed.</param>
        public virtual void SetImageConfiguration( Image image, int speed = 1 )
        {
            if( speed > 0
               && image != null )
            {
                try
                {
                    ImageTransitionSpeed = speed;
                    ImageSource = image;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the type of the tile.
        /// </summary>
        /// <param name="type">The type.</param>
        public virtual void SetTileType( HubTileType type )
        {
            if( Enum.IsDefined( typeof( HubTileType ), type ) )
            {
                try
                {
                    TileType = type;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the title text.
        /// </summary>
        /// <param name="message">The message.</param>
        public virtual void SetTitleText( string message )
        {
            if( !string.IsNullOrEmpty( message )
               && Title != null )
            {
                try
                {
                    Title.Text = message;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the title configuration.
        /// </summary>
        /// <param name="font">The font.</param>
        /// <param name="color">The color.</param>
        public virtual void SetTitleConfiguration( Font font, Color color )
        {
            if( font != null
               && color != Color.Empty )
            {
                try
                {
                    Title.Font = font;
                    Title.TextColor = color;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the body text.
        /// </summary>
        /// <param name="message">The message.</param>
        public virtual void SetBodyText( string message )
        {
            if( !string.IsNullOrEmpty( message )
               && Body != null )
            {
                try
                {
                    Body.Text = message;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the body configuration.
        /// </summary>
        /// <param name="font">The font.</param>
        /// <param name="color">The color.</param>
        public virtual void SetBodyConfiguration( Font font, Color color )
        {
            if( font != null
               && color != Color.Empty )
            {
                try
                {
                    Body.Font = font;
                    Body.TextColor = color;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the banner text.
        /// </summary>
        /// <param name="message">The message.</param>
        public virtual void SetBannerText( string message )
        {
            if( !string.IsNullOrEmpty( message )
               && Banner != null
               && ShowBanner )
            {
                try
                {
                    Banner.Text = message;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the banner configuration.
        /// </summary>
        /// <param name="font">The font.</param>
        /// <param name="color">The color.</param>
        /// <param name="height">The height.</param>
        public virtual void SetBannerConfiguration( Font font, Color color, int height )
        {
            if( font != null
               && color != Color.Empty )
            {
                try
                {
                    ShowBanner = true;
                    BannerHeight = height;
                    Banner.Font = font;
                    BannerColor = color;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the banner icon.
        /// </summary>
        /// <param name="image">The image.</param>
        public virtual void SetBannerIcon( Image image )
        {
            if( image != null
               && Banner != null )
            {
                try
                {
                    ShowBannerIcon = true;
                    BannerIcon = image;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the slide transition.
        /// </summary>
        /// <param name="direction">The direction.</param>
        public virtual void SetSlideTransition(
            TransitionDirection direction = TransitionDirection.RightToLeft )
        {
            if( Enum.IsDefined( typeof( TransitionDirection ), direction ) )
            {
                try
                {
                    SlideTransition = direction;
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