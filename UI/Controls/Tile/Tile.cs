﻿//  ******************************************************************************************
//      Assembly:                Sherpa
//      Filename:                Tile.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="Tile.cs" company="Terry D. Eppler">
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
//     You can contact me at:  terryeppler@gmail.com or eppler.terry@epa.gov
// 
//  </copyright>
//  <summary>
//    Tile.cs
//  </summary>
//  ******************************************************************************************

namespace Sherpa
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    /// <inheritdoc/>
    /// <summary> </summary>
    /// <seealso cref="T:Sherpa.TileBase"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    public class Tile : TileBase
    {
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.Tile"/>
        /// class.
        /// </summary>
        public Tile( )
        {
            BackColor = Color.FromArgb( 27, 27, 27 );
            ForeColor = Color.FromArgb( 106, 189, 252 );
            Size = new Size( 180, 80 );
            MinimumSize = new Size( 100, 50 );
            Font = new Font( "Roboto", 9 );
            Anchor = AnchorStyles.Top & AnchorStyles.Left;
            Dock = DockStyle.None;
            TileType = HubTileType.DefaultTile;
            Title.Font = new Font( "Roboto", 10, FontStyle.Regular );
            Title.TextColor = Color.FromArgb( 106, 189, 252 );
            Body.TextColor = Color.FromArgb( 106, 189, 252 );
            Body.Font = new Font( "Roboto", 9 );
            Footer.TextColor = Color.FromArgb( 106, 189, 252 );
            Footer.Font = new Font( "Roboto", 8 );
            SlideTransition = TransitionDirection.RightToLeft;
            ShowBanner = true;
            BannerColor = Color.Transparent;
            BannerHeight = 30;
            ShowBannerIcon = true;
            Banner.Font = new Font( "Roboto", 8 );
            Banner.TextColor = Color.FromArgb( 106, 189, 252 );
            HoveredBorderColor = Color.FromArgb( 17, 53, 84 );
            HoverColor = Color.FromArgb( 17, 53, 84 );
            HoverBorderLength = 1;
            EnableHoverColor = true;
            EnableSelectionMarker = false;
            Visible = true;
            Enabled = true;
            TurnLiveTileOn = true;

            // Event Wiring
            MouseEnter += OnMouseEnter;
            MouseLeave += OnMouseLeave;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.Tile"/>
        /// class.
        /// </summary>
        /// <param name="type"> The type. </param>
        public Tile( HubTileType type = HubTileType.DefaultTile )
            : this( )
        {
            TileType = type;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.Tile"/>
        /// class.
        /// </summary>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        public Tile( string name, HubTileType type = HubTileType.DefaultTile )
            : this( )
        {
            Name = name;
            TileType = type;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.Tile"/>
        /// class.
        /// </summary>
        /// <param name="location"> The location. </param>
        /// <param name="size"> The size. </param>
        /// <param name="type"> The type. </param>
        public Tile( Point location, Size size, HubTileType type = HubTileType.DefaultTile )
            : this( )
        {
            Size = size;
            Location = location;
            TileType = type;
        }

        /// <summary> Called when [mouse enter]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnMouseEnter( object sender, EventArgs e )
        {
            try
            {
                BackColor = Color.FromArgb( 17, 53, 84 );
                HoveredBorderColor = Color.FromArgb( 50, 93, 129 );
                Title.Font = new Font( "Roboto", 9, FontStyle.Bold );
                Title.TextColor = Color.White;
                Body.Font = new Font( "Roboto", 9, FontStyle.Bold );
                Body.TextColor = Color.White;
                Footer.Font = new Font( "Roboto", 8, FontStyle.Bold );
                Footer.TextColor = Color.White;
                Banner.Font = new Font( "Roboto", 8, FontStyle.Bold );
                Banner.TextColor = Color.White;
                Refresh( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Called when [mouse leave]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnMouseLeave( object sender, EventArgs e )
        {
            try
            {
                BackColor = Color.FromArgb( 40, 40, 40 );
                HoveredBorderColor = Color.FromArgb( 50, 93, 129 );
                Title.Font = new Font( "Roboto", 9, FontStyle.Regular );
                Title.TextColor = Color.FromArgb( 106, 189, 252 );
                Body.Font = new Font( "Roboto", 9, FontStyle.Regular );
                Body.TextColor = Color.FromArgb( 106, 189, 252 );
                Footer.Font = new Font( "Roboto", 8, FontStyle.Regular );
                Footer.TextColor = Color.FromArgb( 106, 189, 252 );
                Banner.Font = new Font( "Roboto", 8, FontStyle.Regular );
                Banner.TextColor = Color.FromArgb( 106, 189, 252 );
                Refresh( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
    }
}