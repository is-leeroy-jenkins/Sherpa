//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                MinionSelector.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="MinionSelector.cs" company="Terry D. Eppler">
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
//    MinionSelector.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    [ SuppressMessage( "ReSharper", "UseObjectOrCollectionInitializer" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedVariable" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    public partial class MinionSelector : MetroForm
    {
        /// <summary>
        /// Gets or sets the image path.
        /// </summary>
        /// <value>
        /// The image path.
        /// </value>
        public string ImagePath { get; } =
            @"C:\Users\teppler\source\repos\BudgetExecution\Resources\Pictures\Carousel\Minion";

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.MinionSelector" /> class.
        /// </summary>
        public MinionSelector( )
        {
            InitializeComponent( );

            // Basic Properties
            Size = new Size( 1200, 600 );
            MaximumSize = new Size( 1200, 600 );
            MinimumSize = new Size( 1200, 600 );
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.FromArgb( 106, 189, 252 );
            Font = new Font( "Roboto", 9 );
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BorderColor = Color.FromArgb( 20, 20, 20 );
            Dock = DockStyle.None;
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            ShowIcon = false;
            ShowInTaskbar = true;
            ShowMouseOver = true;
            MetroColor = Color.FromArgb( 20, 20, 20 );
            CaptionFont = new Font( "Roboto", 11 );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            MinimizeBox = false;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterParent;

            // Panel Properties
            SelectionPanel.BorderColor = Color.Transparent;

            // Event Wiring
            Load += OnLoad;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.MinionSelector" /> class.
        /// </summary>
        /// <param name="dirPath">
        /// The directory path.
        /// </param>
        public MinionSelector( string dirPath )
            : this( )
        {
            ImagePath = dirPath;
            Load += OnLoad;
        }

        /// <summary>
        /// Initializes the labels.
        /// </summary>
        private void InitializeLabels( )
        {
            try
            {
                Header.ForeColor = Color.FromArgb( 106, 189, 252 );
                Header.TextAlign = ContentAlignment.TopLeft;
                Header.Text = string.Empty;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the Carousel.
        /// </summary>
        private void InitializeCarousel( )
        {
            try
            {
                // Basic Carousel Properties
                Carousel.BackColor = Color.FromArgb( 20, 20, 20 );
                Carousel.ForeColor = Color.FromArgb( 106, 189, 252 );
                Carousel.Font = new Font( "Roboto", 8 );
                Carousel.CarouselPath = CarouselPath.Default;
                Carousel.ImageSlides = true;
                Carousel.PadX = 0;
                Carousel.PadY = 0;
                Carousel.Perspective = 4;
                Carousel.RotateAlways = false;
                Carousel.ShowImagePreview = true;
                Carousel.ShowImageShadow = true;
                Carousel.TransitionSpeed = 2;
                Carousel.UseOriginalImageinPreview = true;
                Carousel.UseCustomBounds = false;
                Carousel.CanOverrideStyle = true;
                Carousel.VisualStyle = CarouselVisualStyle.Metro;
                Carousel.HighlightColor = Color.FromArgb( 0, 120, 212 );

                // ThemeStyle Properties
                Carousel.ThemeStyle.BackColor = Color.Transparent;
                Carousel.ThemeStyle.Font = new Font( "Roboto", 9 );
                Carousel.ThemeStyle.ForeColor = Color.FromArgb( 106, 189, 252 );
                Carousel.ThemeStyle.HoverImageBorderColor = Color.FromArgb( 0, 120, 212 );
                Carousel.ThemeStyle.HoverImageBorderThickness = 3;
                Carousel.ThemeStyle.ImageShadeColor = Color.FromArgb( 18, 18, 18 );

                // User Properties
                Carousel.ImageSize = new Size( 250, 250 );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the callbacks.
        /// </summary>
        private void RegisterCallbacks( )
        {
            try
            {
                Carousel.OnCarouselItemSelectionChanged += OnItemSelected;
                CloseButton.Click += OnCloseButtonClicked;
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
                // Timer Properties
                Timer.Enabled = true;
                Timer.Interval = 500;
                Timer.Start( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the carousel images.
        /// </summary>
        /// <param name="dirPath">
        /// The dir path.
        /// </param>
        private void SetCarouselImages( string dirPath )
        {
            try
            {
                ThrowIf.Null( dirPath, nameof( dirPath ) );
                var _files = Directory.GetFiles( dirPath );
                for( var _i = 0; _i < _files.Length; _i++ )
                {
                    var _path = _files[ _i ];
                    if( !string.IsNullOrEmpty( _files[ _i ] )
                       && File.Exists( _files[ _i ] ) )
                    {
                        var _name = Path.GetFileNameWithoutExtension( _path );
                        using var _stream = File.Open( _path, FileMode.Open );
                        var _image = new Bitmap( _stream );
                        _image.Tag = _name;
                        var _carouselImage = new CarouselImage( );
                        _carouselImage.ItemImage = _image;
                        Carousel.ImageListCollection.Add( _carouselImage );
                    }
                }

                Carousel.FilePath = ImagePath;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnLoad( object sender, EventArgs e )
        {
            try
            {
                InitializeCarousel( );
                InitializeLabels( );
                InitializeTimers( );
                SetCarouselImages( ImagePath );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [item selected].
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnItemSelected( object sender, EventArgs e )
        {
            if( sender is Carousel _carousel )
            {
                try
                {
                    var _tag = _carousel?.ActiveImage?.Tag?.ToString( );
                    var _provider = DataBuilder.GetProvider( _tag );
                    switch( _provider )
                    {
                        case Provider.SQLite:
                        {
                            DataMinion.RunSQLite( );
                            Close( );
                            break;
                        }
                        case Provider.SqlCe:
                        {
                            DataMinion.RunSqlCe( );
                            Close( );
                            break;
                        }
                        case Provider.SqlServer:
                        {
                            DataMinion.RunSqlCe( );
                            Close( );
                            break;
                        }
                        case Provider.Access:
                        {
                            DataMinion.RunAccess( );
                            Close( );
                            break;
                        }
                        case Provider.Excel:
                        {
                            DataMinion.OpenExcel( );
                            Close( );
                            break;
                        }
                        default:
                        {
                            DataMinion.RunSQLite( );
                            Close( );
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
        /// Called when [close button clicked].
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnCloseButtonClicked( object sender, EventArgs e )
        {
            if( sender is Button _button )
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
        /// Launches the ErrorDialog
        /// </summary>
        /// <param name="ex">
        /// The exception.
        /// </param>
        private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}